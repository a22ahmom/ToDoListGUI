namespace ToDoListGUI
{
    public partial class Form1 : Form
    {
        TaskManager taskManager = new TaskManager();

        public Form1()
        {
            InitializeComponent();
            InitializeGUI();
        }

        public void InitializeGUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Task task = ReadTaskInfo();

            if (task != null)
            {
                bool success = taskManager.AddTask(task);
                
                if (success)
                {
                    UpdateGUI();
                    clbTasks.SelectedIndex = taskManager.NumOfTasks - 1;
                }
            }            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = clbTasks.SelectedIndex;
            if (selectedIndex != -1)
            {
                taskManager.RemoveTask(selectedIndex);
                UpdateGUI();

                if ((selectedIndex - 1) >= 0)
                    clbTasks.SelectedIndex = Math.Max(0, selectedIndex - 1);
            }
            else
            {
                MessageBox.Show("Please select a task to remove.");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int selectedIndex = clbTasks.SelectedIndex;

            if (selectedIndex != -1)
            {
                Task task = ReadTaskInfo();

                if (task != null)
                {
                    bool success = taskManager.ChangeTask(selectedIndex, task);
                    if (success)
                    {
                        UpdateGUI();
                        clbTasks.SelectedIndex = selectedIndex;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a task to change.");
            }
        }

        private void lstDisplayTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = clbTasks.SelectedIndex;

            if (selectedIndex != -1)
            {
                Task selectedTask = taskManager.GetTask(selectedIndex);

                if (selectedTask != null)
                    txtTaskInput.Text = selectedTask.Description;
            }
        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            
        }

        private Task ReadTaskInfo()
        {
            Task task = new Task();

            task.Description = txtTaskInput.Text;

            return task;
        }

        private void UpdateGUI()
        {
            clbTasks.Items.Clear();

            string[] infoStrings = taskManager.GetInfoStrings();

            if (infoStrings != null)
            {
                clbTasks.Items.AddRange(infoStrings);
            }            
        }
    }
}
