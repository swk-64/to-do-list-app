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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            tableLayoutPanel1.Controls.Add(button1, 3, 1);
            tableLayoutPanel1.Controls.Add(button2, 2, 1);
            tableLayoutPanel1.Controls.Add(button3, 1, 1);
            tableLayoutPanel1.Controls.Add(button4, 0, 1);
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
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(582, 482);
            button1.Name = "button1";
            button1.Size = new Size(189, 44);
            button1.TabIndex = 1;
            button1.Text = "remove";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(389, 482);
            button2.Name = "button2";
            button2.Size = new Size(187, 44);
            button2.TabIndex = 2;
            button2.Text = "add new";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(196, 482);
            button3.Name = "button3";
            button3.Size = new Size(187, 44);
            button3.TabIndex = 3;
            button3.Text = "open";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(3, 482);
            button4.Name = "button4";
            button4.Size = new Size(187, 44);
            button4.TabIndex = 4;
            button4.Text = "edit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btn_edit;
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
            dgv_items.CellContentClick += dataGridView1_CellContentClick;
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dgv_items;
        private DataGridViewCheckBoxColumn col_completed;
        private DataGridViewTextBoxColumn col_name;
        private DataGridViewTextBoxColumn col_priority;
        private DataGridViewTextBoxColumn col_category;
        private DataGridViewTextBoxColumn col_deadline;
    }
}
