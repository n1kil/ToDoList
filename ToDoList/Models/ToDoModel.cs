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

            }
        }

    }

}
