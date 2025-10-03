using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace to_do_list_app
{
    public partial class addNewForm : Form
    {
        public string taskName { get; private set; }
        public int taskPriority { get; private set; }
        public string taskCategory { get; private set; }
        public DateTime taskDeadLine { get; private set; }
        public bool isCompleted { get; private set; }

        public List<TaskItem> tasks = new List<TaskItem>();

        public addNewForm()
        {
            InitializeComponent();
        }

        public addNewForm(TaskItem item)
        {
            InitializeComponent();
            txbox_name.Text = item.Name;
            txbox_priority.Text = item.Priority.ToString();
            txbox_category.Text = item.Category;
            dtp_deadline.Value = item.DeadLine;

            foreach (var subtask in item.subTasks)
            {
                subtask.makeRow(dgv_items);
            }
        }

        private void AddNewForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            taskName = txbox_name.Text;
            taskPriority = int.Parse(txbox_priority.Text);
            taskCategory = txbox_category.Text;
            taskDeadLine = dtp_deadline.Value;
            isCompleted = false;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addNewSubForm add_new_sub_dial = new addNewSubForm();

            add_new_sub_dial.ShowDialog();

            if (add_new_sub_dial.DialogResult == DialogResult.OK)
            {
                TaskItem newTask = new TaskItem(add_new_sub_dial.taskName, add_new_sub_dial.taskPriority,
                    add_new_sub_dial.taskCategory, add_new_sub_dial.taskDeadLine, tasks);
                tasks.Add(newTask);
                newTask.makeRow(dgv_items);
            }
        }
    }
}
