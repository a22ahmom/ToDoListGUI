namespace ToDoListGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clbTasks = new CheckedListBox();
            lblTitle = new Label();
            flpElements = new FlowLayoutPanel();
            txtTaskInput = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnChange = new Button();
            flpElements.SuspendLayout();
            SuspendLayout();
            // 
            // clbTasks
            // 
            clbTasks.FormattingEnabled = true;
            clbTasks.Location = new Point(21, 222);
            clbTasks.Name = "clbTasks";
            clbTasks.Size = new Size(753, 202);
            clbTasks.TabIndex = 7;
            clbTasks.CheckOnClick = false;
            clbTasks.SelectedIndexChanged += lstDisplayTasks_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(255, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(217, 41);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "My To-Do List";
            // 
            // flpElements
            // 
            flpElements.Controls.Add(txtTaskInput);
            flpElements.Controls.Add(btnAdd);
            flpElements.Controls.Add(btnRemove);
            flpElements.Controls.Add(btnChange);
            flpElements.Location = new Point(21, 77);
            flpElements.Name = "flpElements";
            flpElements.Size = new Size(753, 88);
            flpElements.TabIndex = 9;
            // 
            // txtTaskInput
            // 
            txtTaskInput.Location = new Point(3, 3);
            txtTaskInput.Name = "txtTaskInput";
            txtTaskInput.Size = new Size(325, 27);
            txtTaskInput.Margin = new Padding(50, 30, 3, 3);
            txtTaskInput.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(141, 3);
            btnAdd.Margin = new Padding(10, 30, 3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(241, 3);
            btnRemove.Margin = new Padding(10, 30, 3, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(341, 3);
            btnChange.Margin = new Padding(10, 30, 3, 3);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(94, 29);
            btnChange.TabIndex = 3;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpElements);
            Controls.Add(lblTitle);
            Controls.Add(clbTasks);
            Name = "Form1";
            Text = "Form1";
            flpElements.ResumeLayout(false);
            flpElements.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckedListBox clbTasks;
        private Label lblTitle;
        private FlowLayoutPanel flpElements;
        private TextBox txtTaskInput;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnChange;
    }
}
