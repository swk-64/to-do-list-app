namespace to_do_list_app
{
    partial class ShowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            cb_iscompleted = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            txbox_category = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txbox_name = new TextBox();
            nud_priority = new NumericUpDown();
            dtp_deadline = new DateTimePicker();
            tableLayoutPanel3 = new TableLayoutPanel();
            dgv_items = new DataGridView();
            col_completed = new DataGridViewCheckBoxColumn();
            col_name = new DataGridViewTextBoxColumn();
            col_priority = new DataGridViewTextBoxColumn();
            col_category = new DataGridViewTextBoxColumn();
            col_deadline = new DataGridViewTextBoxColumn();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_priority).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_items).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(886, 710);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(cb_iscompleted);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 662);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(880, 45);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(727, 3);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_cancel_Click;
            // 
            // button2
            // 
            button2.Location = new Point(571, 3);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 1;
            button2.Text = "Ok";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_ok_Click;
            // 
            // cb_iscompleted
            // 
            cb_iscompleted.AutoSize = true;
            cb_iscompleted.Location = new Point(382, 3);
            cb_iscompleted.Name = "cb_iscompleted";
            cb_iscompleted.Size = new Size(183, 36);
            cb_iscompleted.TabIndex = 3;
            cb_iscompleted.Text = "Is completed";
            cb_iscompleted.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(txbox_category, 1, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(txbox_name, 1, 0);
            tableLayoutPanel2.Controls.Add(nud_priority, 1, 1);
            tableLayoutPanel2.Controls.Add(dtp_deadline, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(880, 172);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 129);
            label3.Name = "label3";
            label3.Size = new Size(144, 43);
            label3.TabIndex = 10;
            label3.Text = "Deadline";
            // 
            // txbox_category
            // 
            txbox_category.Dock = DockStyle.Fill;
            txbox_category.Enabled = false;
            txbox_category.Location = new Point(153, 89);
            txbox_category.Name = "txbox_category";
            txbox_category.ReadOnly = true;
            txbox_category.Size = new Size(724, 39);
            txbox_category.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 86);
            label4.Name = "label4";
            label4.Size = new Size(144, 43);
            label4.TabIndex = 5;
            label4.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 43);
            label2.Name = "label2";
            label2.Size = new Size(144, 43);
            label2.TabIndex = 3;
            label2.Text = "Priority";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 43);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txbox_name
            // 
            txbox_name.Dock = DockStyle.Fill;
            txbox_name.Enabled = false;
            txbox_name.Location = new Point(153, 3);
            txbox_name.Name = "txbox_name";
            txbox_name.ReadOnly = true;
            txbox_name.Size = new Size(724, 39);
            txbox_name.TabIndex = 2;
            // 
            // nud_priority
            // 
            nud_priority.Dock = DockStyle.Fill;
            nud_priority.Enabled = false;
            nud_priority.Location = new Point(153, 46);
            nud_priority.Name = "nud_priority";
            nud_priority.ReadOnly = true;
            nud_priority.Size = new Size(724, 39);
            nud_priority.TabIndex = 11;
            // 
            // dtp_deadline
            // 
            dtp_deadline.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtp_deadline.Dock = DockStyle.Fill;
            dtp_deadline.Enabled = false;
            dtp_deadline.Format = DateTimePickerFormat.Custom;
            dtp_deadline.Location = new Point(153, 132);
            dtp_deadline.Name = "dtp_deadline";
            dtp_deadline.Size = new Size(724, 39);
            dtp_deadline.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(dgv_items, 0, 1);
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 181);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.Size = new Size(880, 475);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // dgv_items
            // 
            dgv_items.AllowUserToAddRows = false;
            dgv_items.AllowUserToDeleteRows = false;
            dgv_items.AllowUserToOrderColumns = true;
            dgv_items.AllowUserToResizeRows = false;
            dgv_items.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_items.Columns.AddRange(new DataGridViewColumn[] { col_completed, col_name, col_priority, col_category, col_deadline });
            tableLayoutPanel3.SetColumnSpan(dgv_items, 4);
            dgv_items.Dock = DockStyle.Fill;
            dgv_items.ImeMode = ImeMode.NoControl;
            dgv_items.Location = new Point(3, 43);
            dgv_items.MultiSelect = false;
            dgv_items.Name = "dgv_items";
            dgv_items.ReadOnly = true;
            dgv_items.RowHeadersVisible = false;
            dgv_items.RowHeadersWidth = 82;
            dgv_items.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_items.ScrollBars = ScrollBars.Vertical;
            dgv_items.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_items.Size = new Size(874, 429);
            dgv_items.TabIndex = 6;
            // 
            // col_completed
            // 
            col_completed.HeaderText = "Completed";
            col_completed.MinimumWidth = 10;
            col_completed.Name = "col_completed";
            col_completed.ReadOnly = true;
            // 
            // col_name
            // 
            col_name.HeaderText = "Name";
            col_name.MinimumWidth = 10;
            col_name.Name = "col_name";
            col_name.ReadOnly = true;
            // 
            // col_priority
            // 
            col_priority.HeaderText = "Priority";
            col_priority.MinimumWidth = 10;
            col_priority.Name = "col_priority";
            col_priority.ReadOnly = true;
            // 
            // col_category
            // 
            col_category.HeaderText = "Category";
            col_category.MinimumWidth = 10;
            col_category.Name = "col_category";
            col_category.ReadOnly = true;
            // 
            // col_deadline
            // 
            col_deadline.HeaderText = "DeadLine";
            col_deadline.MinimumWidth = 10;
            col_deadline.Name = "col_deadline";
            col_deadline.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 32);
            label5.TabIndex = 0;
            label5.Text = "Subtasks";
            // 
            // ShowForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 710);
            Controls.Add(tableLayoutPanel1);
            Name = "ShowForm";
            Text = "To Do List App - Task View";
            Load += ShowForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_priority).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_items).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private TextBox txbox_category;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txbox_name;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Label label5;
        private DataGridView dgv_items;
        private DataGridViewCheckBoxColumn col_completed;
        private DataGridViewTextBoxColumn col_name;
        private DataGridViewTextBoxColumn col_priority;
        private DataGridViewTextBoxColumn col_category;
        private DataGridViewTextBoxColumn col_deadline;
        private NumericUpDown nud_priority;
        private DateTimePicker dtp_deadline;
        private CheckBox cb_iscompleted;
    }
}