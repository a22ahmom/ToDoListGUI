using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListGUI
{
    class TaskManager
    {
        private Task[] tasks = new Task[10];
        private int numOfTasks = 0;

        public TaskManager() { }

        public int GetNumTasks() 
        { 
            return numOfTasks; 
        }

        public Task GetTask(int index) 
        { 
            return tasks[index];
        }

        public void AddTask(Task task)
        {
            bool canAddTask = task != null && numOfTasks < tasks.Length;

            if (canAddTask)
            {
                tasks[numOfTasks] = task;
                numOfTasks++;
            }
        }

        public bool CheckTask(int index)
        {
            bool validIndex = index >= 0 && index < numOfTasks;
            if (validIndex)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
