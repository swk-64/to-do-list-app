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

        private void inititalizeTask(TaskItem item)
        {
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

        public addNewForm()
        {
            InitializeComponent();
        }

        public addNewForm(TaskItem item)
        {
            InitializeComponent();



            inititalizeTask(item);
        }

        private void AddNewForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            taskName = txbox_name.Text;
            taskPriority = (int)nud_priority.Value;
            taskCategory = txbox_category.Text;
            taskDeadLine = dtp_deadline.Value;
            isCompleted = cb_iscompleted.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addNewSubForm add_new_sub_dial = new addNewSubForm(dtp_deadline.Value);

            add_new_sub_dial.ShowDialog();

            if (add_new_sub_dial.DialogResult == DialogResult.OK)
            {
                TaskItem newTask = new TaskItem(add_new_sub_dial.isCompleted, add_new_sub_dial.taskName, add_new_sub_dial.taskPriority,
                    add_new_sub_dial.taskCategory, add_new_sub_dial.taskDeadLine, tasks);
                tasks.Add(newTask);
                newTask.makeRow(dgv_items);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_items.CurrentRow != null)
            {
                TaskItem selectedTask = (TaskItem)dgv_items.CurrentRow.Tag;


                addNewSubForm add_new_dial_sub = new addNewSubForm(dtp_deadline.Value, selectedTask);

                add_new_dial_sub.ShowDialog();
                if (add_new_dial_sub.DialogResult == DialogResult.OK)
                {
                    selectedTask.Name = add_new_dial_sub.taskName;
                    selectedTask.Priority = add_new_dial_sub.taskPriority;
                    selectedTask.Category = add_new_dial_sub.taskCategory;
                    selectedTask.DeadLine = add_new_dial_sub.taskDeadLine;
                    selectedTask.IsCompleted = add_new_dial_sub.isCompleted;

                    dgv_items.CurrentRow.SetValues(add_new_dial_sub.isCompleted, add_new_dial_sub.taskName, add_new_dial_sub.taskPriority,
                        add_new_dial_sub.taskCategory, add_new_dial_sub.taskDeadLine);
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dgv_items.CurrentRow != null)
            {
                TaskItem selectedTask = (TaskItem)dgv_items.CurrentRow.Tag;
                dgv_items.Rows.Remove(dgv_items.CurrentRow);
                tasks.Remove(selectedTask);
            }
        }

        private void dgv_items_Check(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_items.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && dgv_items.Rows.Count != 0)
            {
                TaskItem selectedTask = (TaskItem)dgv_items.CurrentRow.Tag;
                selectedTask.IsCompleted = Convert.ToBoolean(dgv_items.Rows[e.RowIndex].Cells[0].Value);

            }
        }
    }
}
