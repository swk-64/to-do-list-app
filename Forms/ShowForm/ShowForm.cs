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

            foreach (var subtask in item.subTasks)
            {
                subtask.makeRow(dgv_items);
            }
        }

        private void ShowForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
