using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    class ToDoModel : INotifyPropertyChanged
    {

        private bool _isDone;

        private string _text;

        private int _priority;

        private string _category;

        private string _deadline;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                if (_priority == value) return;
                _priority = value;
                // строчка ниже в свойствах нужна при изменении полей задач в самом приложении
                OnPropertyChanged("Priority");
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                if (_category == value) return;
                _category = value;
                OnPropertyChanged("Category");
            }
        }

        public string Deadline
        {
            get
            {
                return _deadline;
            }
            set
            {
                if (_deadline == value) return;
                _deadline = value;
                OnPropertyChanged("Deadline");
            }
        }


        public bool IsDone
        {
            get
            {
                return _isDone;
            }
            set
            {
                if(_isDone == value) return;
                _isDone = value;
                OnPropertyChanged("IsDone");
            }
        }

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (_text == value) return;
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        public ToDoModel()
        {
            _text = "новая задача";
            _isDone = false;
            _priority = 0;
        }

        protected virtual void OnPropertyChanged(string propertyName="")
        {
            // проверка на null
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }

}
