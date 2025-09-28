using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    class ToDoModel
    {

        private bool _isDone;

        private string _text;

        private int _priority;

        private string _category;

        private string _deadline;

        public int Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                _priority = value;
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
                _category = value;
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
                _deadline = value;
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
                _isDone = value;
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
                _text = value;
            }
        }

        public ToDoModel()
        {
            _text = "новая задача";
            _isDone = false;
        }


    }

}
