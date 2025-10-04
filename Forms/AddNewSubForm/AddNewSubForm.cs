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

        public addNewSubForm()
        {
            InitializeComponent();
        }

        public addNewSubForm(TaskItem item)
        {
            InitializeComponent();
            txbox_name.Text = item.Name;
            txbox_category.Text = item.Category;
            nud_priority.Text = item.Priority.ToString();
            dtp_deadline.Value = item.DeadLine;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            taskName = txbox_name.Text;
            taskPriority = (int)nud_priority.Value;
            taskCategory = txbox_category.Text;
            taskDeadLine = dtp_deadline.Value;
            isCompleted = false;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
