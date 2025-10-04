namespace to_do_list_app
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }

    public class TaskItem(bool IsCompleted, string name, int priority, string category, DateTime deadLine, List<TaskItem> tasks)
    {
        // fields and constructor
        public string Name { get; set; } = name;
        public int Priority { get; set; } = priority;
        public string Category { get; set; } = category;
        public DateTime DeadLine { get; set; } = deadLine;
        public bool IsCompleted { get; set; } = IsCompleted;

        public List<TaskItem> subTasks = tasks;

        // methods
        public void makeRow(DataGridView table)
        {
            DataGridViewRow row = new DataGridViewRow();
            table.Rows.Add(IsCompleted, Name, Priority.ToString(), Category, DeadLine);
            table.Rows[table.Rows.Count - 1].Tag = this;
        }
    }
}