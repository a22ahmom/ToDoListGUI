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
            checkedListBox1 = new CheckedListBox();
            lblTitle = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtTaskInput = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnChange = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(21, 222);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(753, 202);
            checkedListBox1.TabIndex = 7;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(txtTaskInput);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnRemove);
            flowLayoutPanel1.Controls.Add(btnChange);
            flowLayoutPanel1.Location = new Point(21, 77);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(753, 88);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // txtTaskInput
            // 
            txtTaskInput.Location = new Point(3, 3);
            txtTaskInput.Name = "txtTaskInput";
            txtTaskInput.Size = new Size(125, 27);
            txtTaskInput.TabIndex = 0;
            // 
            // button1
            // 
            btnAdd.Location = new Point(134, 3);
            btnAdd.Name = "button1";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(234, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(334, 3);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(94, 29);
            btnChange.TabIndex = 3;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblTitle);
            Controls.Add(checkedListBox1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckedListBox checkedListBox1;
        private Label lblTitle;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtTaskInput;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnChange;
    }
}
