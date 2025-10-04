namespace to_do_list_app
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_remove = new Button();
            btn_add = new Button();
            btn_show = new Button();
            btn_edit = new Button();
            dgv_items = new DataGridView();
            col_completed = new DataGridViewCheckBoxColumn();
            col_name = new DataGridViewTextBoxColumn();
            col_priority = new DataGridViewTextBoxColumn();
            col_category = new DataGridViewTextBoxColumn();
            col_deadline = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_items).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btn_remove, 3, 1);
            tableLayoutPanel1.Controls.Add(btn_add, 2, 1);
            tableLayoutPanel1.Controls.Add(btn_show, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_edit, 0, 1);
            tableLayoutPanel1.Controls.Add(dgv_items, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(774, 529);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_remove
            // 
            btn_remove.Dock = DockStyle.Fill;
            btn_remove.Location = new Point(582, 482);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(189, 44);
            btn_remove.TabIndex = 1;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_add
            // 
            btn_add.Dock = DockStyle.Fill;
            btn_add.Location = new Point(389, 482);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(187, 44);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add new";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_show
            // 
            btn_show.Dock = DockStyle.Fill;
            btn_show.Location = new Point(196, 482);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(187, 44);
            btn_show.TabIndex = 3;
            btn_show.Text = "Show";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // btn_edit
            // 
            btn_edit.Dock = DockStyle.Fill;
            btn_edit.Location = new Point(3, 482);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(187, 44);
            btn_edit.TabIndex = 4;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
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
            tableLayoutPanel1.SetColumnSpan(dgv_items, 4);
            dgv_items.Dock = DockStyle.Fill;
            dgv_items.ImeMode = ImeMode.NoControl;
            dgv_items.Location = new Point(3, 3);
            dgv_items.MultiSelect = false;
            dgv_items.Name = "dgv_items";
            dgv_items.ReadOnly = true;
            dgv_items.RowHeadersVisible = false;
            dgv_items.RowHeadersWidth = 82;
            dgv_items.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_items.ScrollBars = ScrollBars.Vertical;
            dgv_items.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_items.Size = new Size(768, 473);
            dgv_items.TabIndex = 5;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 529);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_items).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_remove;
        private Button btn_add;
        private Button btn_show;
        private Button btn_edit;
        private DataGridView dgv_items;
        private DataGridViewCheckBoxColumn col_completed;
        private DataGridViewTextBoxColumn col_name;
        private DataGridViewTextBoxColumn col_priority;
        private DataGridViewTextBoxColumn col_category;
        private DataGridViewTextBoxColumn col_deadline;
    }
}
