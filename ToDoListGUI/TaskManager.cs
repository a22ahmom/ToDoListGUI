using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListGUI
{
    class TaskManager
    {
        private Task[] listOfTasks = new Task[10];
        private int numOfTasks = 0;

        public TaskManager() { }

        public int NumOfTasks
        {
            get 
            { 
                return numOfTasks; 
            }
        }

        public Task GetTask(int index) 
        { 
            return listOfTasks[index];
        }

        public bool AddTask(Task task)
        {
            bool checkTask = (task != null) && (numOfTasks < listOfTasks.Length);

            if (checkTask)
            {
                listOfTasks[numOfTasks] = task;
                numOfTasks++;
                return true;
            }
            else
            {
                MessageBox.Show("Cannot add task. Task is null or task list is full.");
                return false;
            }
        }

        public bool CheckTaskIndex(int index)
        {
            bool validIndex = index >= 0 && index < listOfTasks.Length;
            return validIndex;
        }

        public string[] GetInfoStrings()
        {
            string[] infoStrings = new string[numOfTasks];
            for (int i = 0; i < numOfTasks; i++)
            {
                infoStrings[i] = listOfTasks[i].ToString();
            }
            return infoStrings;
        }
    }
}
