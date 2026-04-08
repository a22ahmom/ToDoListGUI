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

        private Task ReadTaskInfo()
        {
            Task task = new Task();

            task.Description = txtTaskInput.Text;
            //task.IsCompleted = chkIsCompleted.Checked;
            //task.IsCompleted = clbTasks.GetItemChecked(clbTasks.SelectedIndex);

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
