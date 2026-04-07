using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListGUI
{
    class Task
    {
        private bool isCompleted;
        private string description;

        public Task()
        {
            this.isCompleted = false;
            this.description = string.Empty;
        }

        public bool IsCompleted
        {
            get
            {
                return isCompleted;
            }
            set
            {
                isCompleted = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
    }
}
