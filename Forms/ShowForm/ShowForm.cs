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
    public partial class ShowForm : Form
    {
        public bool isCompleted { get; private set; }

        public ShowForm()
        {
            InitializeComponent();
        }

        public ShowForm(TaskItem item)
        {
            InitializeComponent();

            txbox_name.Text = item.Name;
            nud_priority.Value = item.Priority;
            txbox_category.Text = item.Category;
            dtp_deadline.Value = item.DeadLine;
            cb_iscompleted.Checked = item.IsCompleted;

            foreach (var subtask in item.subTasks)
            {
                subtask.makeRow(dgv_items);
            }
        }

        private void ShowForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            isCompleted = cb_iscompleted.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
