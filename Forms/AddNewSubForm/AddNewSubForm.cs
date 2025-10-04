using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace to_do_list_app
{

    public partial class addNewSubForm : Form
    {
        public string taskName { get; private set; }
        public int taskPriority { get; private set; }
        public string taskCategory { get; private set; }
        public DateTime taskDeadLine { get; private set; }
        public bool isCompleted { get; private set; }
        public DateTime ParentDeadLine { get; private set; }
        public addNewSubForm(DateTime mainDeadLine)
        {
            InitializeComponent();
            ParentDeadLine = mainDeadLine;
        }

        public addNewSubForm(DateTime mainDeadLine, TaskItem item)
        {
            InitializeComponent();
            txbox_name.Text = item.Name;
            txbox_category.Text = item.Category;
            nud_priority.Value = item.Priority;
            dtp_deadline.Value = item.DeadLine;
            cb_iscompleted.Checked = item.IsCompleted;
            ParentDeadLine = mainDeadLine;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (dtp_deadline.Value > ParentDeadLine)
            {
                MessageBox.Show("The subtask deadline must not exceed the main task deadline.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                taskName = txbox_name.Text;
                taskPriority = (int)nud_priority.Value;
                taskCategory = txbox_category.Text;
                taskDeadLine = dtp_deadline.Value;
                isCompleted = cb_iscompleted.Checked;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
