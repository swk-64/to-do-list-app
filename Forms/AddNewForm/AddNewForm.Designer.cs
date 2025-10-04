namespace to_do_list_app
{
    partial class addNewForm
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
            btn_close = new Button();
            btn_ok = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            lbl_deadline = new Label();
            txbox_category = new TextBox();
            lbl_category = new Label();
            lbl_priority = new Label();
            lbl_name = new Label();
            txbox_name = new TextBox();
            dtp_deadline = new DateTimePicker();
            nud_priority = new NumericUpDown();
            tableLayoutPanel3 = new TableLayoutPanel();
            dgv_items = new DataGridView();
            col_completed = new DataGridViewCheckBoxColumn();
            col_name = new DataGridViewTextBoxColumn();
            col_priority = new DataGridViewTextBoxColumn();
            col_category = new DataGridViewTextBoxColumn();
            col_deadline = new DataGridViewTextBoxColumn();
            flowLayoutPanel3 = new FlowLayoutPanel();
            btn_remove = new Button();
            btn = new Button();
            btn_edit = new Button();
            lbl_subtasks = new Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_priority).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_items).BeginInit();
            flowLayoutPanel3.SuspendLayout();
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
            flowLayoutPanel1.Controls.Add(btn_close);
            flowLayoutPanel1.Controls.Add(btn_ok);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 662);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(880, 45);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(727, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(150, 46);
            btn_close.TabIndex = 0;
            btn_close.Text = "Cancel";
            btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(571, 3);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(150, 46);
            btn_ok.TabIndex = 1;
            btn_ok.Text = "Ok";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(lbl_deadline, 0, 3);
            tableLayoutPanel2.Controls.Add(txbox_category, 1, 2);
            tableLayoutPanel2.Controls.Add(lbl_category, 0, 2);
            tableLayoutPanel2.Controls.Add(lbl_priority, 0, 1);
            tableLayoutPanel2.Controls.Add(lbl_name, 0, 0);
            tableLayoutPanel2.Controls.Add(txbox_name, 1, 0);
            tableLayoutPanel2.Controls.Add(dtp_deadline, 1, 3);
            tableLayoutPanel2.Controls.Add(nud_priority, 1, 1);
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
            // lbl_deadline
            // 
            lbl_deadline.AutoSize = true;
            lbl_deadline.Dock = DockStyle.Fill;
            lbl_deadline.Location = new Point(3, 129);
            lbl_deadline.Name = "lbl_deadline";
            lbl_deadline.Size = new Size(144, 43);
            lbl_deadline.TabIndex = 10;
            lbl_deadline.Text = "Deadline";
            // 
            // txbox_category
            // 
            txbox_category.Dock = DockStyle.Fill;
            txbox_category.Location = new Point(153, 89);
            txbox_category.Name = "txbox_category";
            txbox_category.Size = new Size(724, 39);
            txbox_category.TabIndex = 7;
            // 
            // lbl_category
            // 
            lbl_category.AutoSize = true;
            lbl_category.Dock = DockStyle.Fill;
            lbl_category.Location = new Point(3, 86);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(144, 43);
            lbl_category.TabIndex = 5;
            lbl_category.Text = "Category";
            // 
            // lbl_priority
            // 
            lbl_priority.AutoSize = true;
            lbl_priority.Dock = DockStyle.Fill;
            lbl_priority.Location = new Point(3, 43);
            lbl_priority.Name = "lbl_priority";
            lbl_priority.Size = new Size(144, 43);
            lbl_priority.TabIndex = 3;
            lbl_priority.Text = "Priority";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Dock = DockStyle.Fill;
            lbl_name.Location = new Point(3, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(144, 43);
            lbl_name.TabIndex = 1;
            lbl_name.Text = "Name";
            // 
            // txbox_name
            // 
            txbox_name.Dock = DockStyle.Fill;
            txbox_name.Location = new Point(153, 3);
            txbox_name.Name = "txbox_name";
            txbox_name.Size = new Size(724, 39);
            txbox_name.TabIndex = 2;
            // 
            // dtp_deadline
            // 
            dtp_deadline.Dock = DockStyle.Fill;
            dtp_deadline.Location = new Point(153, 132);
            dtp_deadline.Name = "dtp_deadline";
            dtp_deadline.Size = new Size(724, 39);
            dtp_deadline.TabIndex = 11;
            // 
            // nud_priority
            // 
            nud_priority.Dock = DockStyle.Fill;
            nud_priority.Location = new Point(153, 46);
            nud_priority.Name = "nud_priority";
            nud_priority.Size = new Size(724, 39);
            nud_priority.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(dgv_items, 0, 1);
            tableLayoutPanel3.Controls.Add(flowLayoutPanel3, 0, 2);
            tableLayoutPanel3.Controls.Add(lbl_subtasks, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 181);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
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
            dgv_items.Size = new Size(874, 369);
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
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(btn_remove);
            flowLayoutPanel3.Controls.Add(btn);
            flowLayoutPanel3.Controls.Add(btn_edit);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 418);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(874, 54);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // btn_remove
            // 
            btn_remove.Location = new Point(3, 3);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(150, 46);
            btn_remove.TabIndex = 0;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn
            // 
            btn.Location = new Point(159, 3);
            btn.Name = "btn";
            btn.Size = new Size(150, 46);
            btn.TabIndex = 1;
            btn.Text = "Add new";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(315, 3);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(150, 46);
            btn_edit.TabIndex = 2;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // lbl_subtasks
            // 
            lbl_subtasks.AutoSize = true;
            lbl_subtasks.Location = new Point(3, 0);
            lbl_subtasks.Name = "lbl_subtasks";
            lbl_subtasks.Size = new Size(107, 32);
            lbl_subtasks.TabIndex = 0;
            lbl_subtasks.Text = "Subtasks";
            // 
            // addNewForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 710);
            Controls.Add(tableLayoutPanel1);
            Name = "addNewForm";
            Text = "Form2";
            Load += AddNewForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_priority).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_items).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lbl_deadline;
        private TextBox txbox_category;
        private Label lbl_category;
        private Label lbl_priority;
        private Label lbl_name;
        private TextBox txbox_name;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_close;
        private Button btn_ok;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btn_remove;
        private Button btn;
        private Button btn_edit;
        private Label lbl_subtasks;
        private DateTimePicker dtp_deadline;
        private DataGridView dgv_items;
        private DataGridViewCheckBoxColumn col_completed;
        private DataGridViewTextBoxColumn col_name;
        private DataGridViewTextBoxColumn col_priority;
        private DataGridViewTextBoxColumn col_category;
        private DataGridViewTextBoxColumn col_deadline;
        private NumericUpDown nud_priority;
    }
}