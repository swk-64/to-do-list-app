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

        private void button2_Click(object sender, EventArgs e)
        {
            addNewForm add_new_dial = new addNewForm();

            add_new_dial.ShowDialog();

            if (add_new_dial.DialogResult == DialogResult.OK)
            {
                TaskItem newTask = new TaskItem(add_new_dial.taskName, add_new_dial.taskPriority,
                    add_new_dial.taskCategory, add_new_dial.taskDeadLine, add_new_dial.tasks);
                tasks.Add(newTask);
                newTask.makeRow(dgv_items);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_edit(object sender, EventArgs e)
        {
            if (dgv_items.CurrentRow == null && (bool)dgv_items.CurrentRow.Cells[0].Value) return;

            TaskItem selectedTask = (TaskItem)dgv_items.CurrentRow.Tag;


            addNewForm add_new_dial = new addNewForm(selectedTask);

            add_new_dial.ShowDialog();
            if (add_new_dial.DialogResult == DialogResult.OK)
            {
                selectedTask.Name = add_new_dial.taskName;
                selectedTask.Priority = add_new_dial.taskPriority;
                selectedTask.Category = add_new_dial.taskCategory;
                selectedTask.DeadLine = add_new_dial.taskDeadLine;
                selectedTask.IsCompleted = false;
                selectedTask.subTasks = add_new_dial.tasks;

                dgv_items.CurrentRow.SetValues(false, add_new_dial.taskName, add_new_dial.taskPriority,
                    add_new_dial.taskCategory, add_new_dial.taskDeadLine, add_new_dial.tasks);
            }
        }
    }
}
