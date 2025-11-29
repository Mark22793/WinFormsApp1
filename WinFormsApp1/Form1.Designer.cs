using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtTask;
        private Button btnAddTask;
        private ListBox lstTasks;
        private Button btnRemoveSelected;
        private Button btnClearAll;
        private CheckBox chkConfirmDelete;
        private Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtTask = new TextBox();
            btnAddTask = new Button();
            lstTasks = new ListBox();
            btnRemoveSelected = new Button();
            btnClearAll = new Button();
            chkConfirmDelete = new CheckBox();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.Location = new Point(20, 20);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(250, 23);
            txtTask.TabIndex = 0;
            txtTask.TextChanged += txtTask_TextChanged;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(290, 18);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(120, 30);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // lstTasks
            // 
            lstTasks.BackColor = SystemColors.Info;
            lstTasks.ForeColor = SystemColors.InactiveCaptionText;
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 15;
            lstTasks.Location = new Point(20, 70);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(390, 214);
            lstTasks.TabIndex = 2;
            lstTasks.SelectedIndexChanged += lstTasks_SelectedIndexChanged;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Location = new Point(20, 300);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(140, 30);
            btnRemoveSelected.TabIndex = 3;
            btnRemoveSelected.Text = "Remove Selected";
            btnRemoveSelected.UseVisualStyleBackColor = true;
            btnRemoveSelected.Click += btnRemoveSelected_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(180, 300);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(100, 30);
            btnClearAll.TabIndex = 4;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // chkConfirmDelete
            // 
            chkConfirmDelete.AutoSize = true;
            chkConfirmDelete.Location = new Point(300, 305);
            chkConfirmDelete.Name = "chkConfirmDelete";
            chkConfirmDelete.Size = new Size(142, 19);
            chkConfirmDelete.TabIndex = 5;
            chkConfirmDelete.Text = "Confirm before delete";
            chkConfirmDelete.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(20, 350);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
            // 
            // Form1
            // 
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(440, 400);
            Controls.Add(lblStatus);
            Controls.Add(chkConfirmDelete);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemoveSelected);
            Controls.Add(lstTasks);
            Controls.Add(btnAddTask);
            Controls.Add(txtTask);
            Name = "Form1";
            Text = "Task Manager";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
