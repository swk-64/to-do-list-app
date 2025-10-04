using System.Windows.Forms;

namespace to_do_list_app
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private List<TaskItem> tasks = new List<TaskItem>();


        // Actions

        private void btn_add_Click(object sender, EventArgs e)
        {
            addNewForm add_new_dial = new addNewForm();

            add_new_dial.ShowDialog();

            if (add_new_dial.DialogResult == DialogResult.OK)
            {
                TaskItem newTask = new TaskItem(add_new_dial.isCompleted, add_new_dial.taskName, add_new_dial.taskPriority,
                    add_new_dial.taskCategory, add_new_dial.taskDeadLine, add_new_dial.tasks);
                tasks.Add(newTask);
                newTask.makeRow(dgv_items);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_items.CurrentRow != null)
            {
                TaskItem selectedTask = (TaskItem)dgv_items.CurrentRow.Tag;


                addNewForm add_new_dial = new addNewForm(selectedTask);

                add_new_dial.ShowDialog();
                if (add_new_dial.DialogResult == DialogResult.OK)
                {
                    selectedTask.Name = add_new_dial.taskName;
                    selectedTask.Priority = add_new_dial.taskPriority;
                    selectedTask.Category = add_new_dial.taskCategory;
                    selectedTask.DeadLine = add_new_dial.taskDeadLine;
                    selectedTask.IsCompleted = add_new_dial.isCompleted;

                    dgv_items.CurrentRow.SetValues(add_new_dial.isCompleted, add_new_dial.taskName, add_new_dial.taskPriority,
                        add_new_dial.taskCategory, add_new_dial.taskDeadLine, add_new_dial.tasks);
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

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (dgv_items.CurrentRow != null)
            {
                TaskItem selectedTask = (TaskItem)dgv_items.CurrentRow.Tag;
                ShowForm show_dial = new ShowForm(selectedTask);
                show_dial.ShowDialog();
                if (show_dial.DialogResult == DialogResult.OK)
                {
                    selectedTask.IsCompleted = show_dial.isCompleted;
                    dgv_items.CurrentRow.Cells[0].Value = show_dial.isCompleted;
                }
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
