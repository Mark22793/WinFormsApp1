using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Add Task
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                lstTasks.Items.Add(txtTask.Text);
                lblStatus.Text = $"Task added at {DateTime.Now:HH:mm:ss}";
                txtTask.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task first.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblStatus.Text = "No task entered.";
            }
        }

        // Remove Selected
        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
            {
                lblStatus.Text = "No task selected to remove.";
                return;
            }

            if (chkConfirmDelete.Checked)
            {
                var result = MessageBox.Show("Are you sure you want to delete this task?",
                                             "Confirm Delete",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;
            }

            lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);
            lblStatus.Text = "Task removed.";
        }

        // Clear All Tasks
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (lstTasks.Items.Count > 0)
            {
                lstTasks.Items.Clear();
                lblStatus.Text = "All tasks cleared.";
            }
            else
            {
                lblStatus.Text = "Task list is already empty.";
            }
        }

        // When user types
        private void txtTask_TextChanged(object sender, EventArgs e)
        {
            btnAddTask.Enabled = !string.IsNullOrWhiteSpace(txtTask.Text);
        }

        // When user selects a task
        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                lblStatus.Text = $"Selected: {lstTasks.SelectedItem}";
            }
        }
    }
}
