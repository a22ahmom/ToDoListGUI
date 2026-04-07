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
            button2 = new Button();
            button3 = new Button();
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
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
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
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(234, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(334, 3);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
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
        private Button button2;
        private Button button3;
    }
}
