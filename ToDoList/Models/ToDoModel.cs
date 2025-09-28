using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    class ToDoModel
    {
        public string Name;

        private bool _isDone;

        private string _text;



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
