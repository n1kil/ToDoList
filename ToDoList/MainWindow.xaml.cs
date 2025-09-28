using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList
{
    public partial class MainWindow : Window
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\todoDataList.json";

        private ObservableCollection<ToDoModel> _toDoDataList;
        private FileIOServices _fileIOServices;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _fileIOServices = new FileIOServices(PATH);

            try
            {
                var loadedData = _fileIOServices.LoadData();
                _toDoDataList = new ObservableCollection<ToDoModel>(loadedData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                return;
            }

            dgToDoApp.ItemsSource = _toDoDataList;

            // подписка на изменения (добавление, удаление)
            _toDoDataList.CollectionChanged += _toDoDataList_CollectionChanged;
        }

        // сохранение изменений на диск
        private void _toDoDataList_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            try
            {
                _fileIOServices.SaveData(sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
    }
}
