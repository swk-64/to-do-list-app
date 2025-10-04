namespace to_do_list_app
{
    partial class addNewSubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addNewSubForm));
            tableLayoutPanel1_new = new TableLayoutPanel();
            tableLayoutPanel2_new = new TableLayoutPanel();
            lbl_deadline_new = new Label();
            txbox_category = new TextBox();
            lbl_category_new = new Label();
            lbl_priority_new = new Label();
            lbl_name_new = new Label();
            txbox_name = new TextBox();
            dtp_deadline = new DateTimePicker();
            nud_priority = new NumericUpDown();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_close = new Button();
            btn_ok = new Button();
            cb_iscompleted = new CheckBox();
            tableLayoutPanel1_new.SuspendLayout();
            tableLayoutPanel2_new.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_priority).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1_new
            // 
            tableLayoutPanel1_new.ColumnCount = 1;
            tableLayoutPanel1_new.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1_new.Controls.Add(tableLayoutPanel2_new, 0, 0);
            tableLayoutPanel1_new.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1_new.Dock = DockStyle.Fill;
            tableLayoutPanel1_new.Location = new Point(0, 0);
            tableLayoutPanel1_new.Name = "tableLayoutPanel1_new";
            tableLayoutPanel1_new.RowCount = 2;
            tableLayoutPanel1_new.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1_new.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1_new.Size = new Size(886, 472);
            tableLayoutPanel1_new.TabIndex = 0;
            // 
            // tableLayoutPanel2_new
            // 
            tableLayoutPanel2_new.ColumnCount = 2;
            tableLayoutPanel2_new.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2_new.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2_new.Controls.Add(lbl_deadline_new, 0, 3);
            tableLayoutPanel2_new.Controls.Add(txbox_category, 1, 2);
            tableLayoutPanel2_new.Controls.Add(lbl_category_new, 0, 2);
            tableLayoutPanel2_new.Controls.Add(lbl_priority_new, 0, 1);
            tableLayoutPanel2_new.Controls.Add(lbl_name_new, 0, 0);
            tableLayoutPanel2_new.Controls.Add(txbox_name, 1, 0);
            tableLayoutPanel2_new.Controls.Add(dtp_deadline, 1, 3);
            tableLayoutPanel2_new.Controls.Add(nud_priority, 1, 1);
            tableLayoutPanel2_new.Dock = DockStyle.Fill;
            tableLayoutPanel2_new.Location = new Point(3, 3);
            tableLayoutPanel2_new.Name = "tableLayoutPanel2_new";
            tableLayoutPanel2_new.RowCount = 4;
            tableLayoutPanel2_new.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2_new.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2_new.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2_new.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2_new.Size = new Size(880, 416);
            tableLayoutPanel2_new.TabIndex = 0;
            // 
            // lbl_deadline_new
            // 
            lbl_deadline_new.AutoSize = true;
            lbl_deadline_new.Dock = DockStyle.Fill;
            lbl_deadline_new.Location = new Point(3, 312);
            lbl_deadline_new.Name = "lbl_deadline_new";
            lbl_deadline_new.Size = new Size(144, 104);
            lbl_deadline_new.TabIndex = 10;
            lbl_deadline_new.Text = "Deadline";
            // 
            // txbox_category
            // 
            txbox_category.Dock = DockStyle.Fill;
            txbox_category.Location = new Point(153, 211);
            txbox_category.Name = "txbox_category";
            txbox_category.Size = new Size(724, 39);
            txbox_category.TabIndex = 7;
            // 
            // lbl_category_new
            // 
            lbl_category_new.AutoSize = true;
            lbl_category_new.Dock = DockStyle.Fill;
            lbl_category_new.Location = new Point(3, 208);
            lbl_category_new.Name = "lbl_category_new";
            lbl_category_new.Size = new Size(144, 104);
            lbl_category_new.TabIndex = 5;
            lbl_category_new.Text = "Category";
            // 
            // lbl_priority_new
            // 
            lbl_priority_new.AutoSize = true;
            lbl_priority_new.Dock = DockStyle.Fill;
            lbl_priority_new.Location = new Point(3, 104);
            lbl_priority_new.Name = "lbl_priority_new";
            lbl_priority_new.Size = new Size(144, 104);
            lbl_priority_new.TabIndex = 3;
            lbl_priority_new.Text = "Priority";
            // 
            // lbl_name_new
            // 
            lbl_name_new.AutoSize = true;
            lbl_name_new.Dock = DockStyle.Fill;
            lbl_name_new.Location = new Point(3, 0);
            lbl_name_new.Name = "lbl_name_new";
            lbl_name_new.Size = new Size(144, 104);
            lbl_name_new.TabIndex = 1;
            lbl_name_new.Text = "Name";
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
            dtp_deadline.AllowDrop = true;
            dtp_deadline.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtp_deadline.Dock = DockStyle.Fill;
            dtp_deadline.Format = DateTimePickerFormat.Custom;
            dtp_deadline.Location = new Point(153, 315);
            dtp_deadline.Name = "dtp_deadline";
            dtp_deadline.Size = new Size(724, 39);
            dtp_deadline.TabIndex = 11;
            // 
            // nud_priority
            // 
            nud_priority.Dock = DockStyle.Fill;
            nud_priority.Location = new Point(153, 107);
            nud_priority.Name = "nud_priority";
            nud_priority.Size = new Size(724, 39);
            nud_priority.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_close);
            flowLayoutPanel1.Controls.Add(btn_ok);
            flowLayoutPanel1.Controls.Add(cb_iscompleted);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 425);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(880, 44);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(727, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(150, 46);
            btn_close.TabIndex = 0;
            btn_close.Text = "Close";
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
            // cb_iscompleted
            // 
            cb_iscompleted.AutoSize = true;
            cb_iscompleted.Location = new Point(382, 3);
            cb_iscompleted.Name = "cb_iscompleted";
            cb_iscompleted.Size = new Size(183, 36);
            cb_iscompleted.TabIndex = 2;
            cb_iscompleted.Text = "Is completed";
            cb_iscompleted.UseVisualStyleBackColor = true;
            // 
            // addNewSubForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 472);
            Controls.Add(tableLayoutPanel1_new);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "addNewSubForm";
            Text = "To Do List App - Add New SubTask";
            tableLayoutPanel1_new.ResumeLayout(false);
            tableLayoutPanel2_new.ResumeLayout(false);
            tableLayoutPanel2_new.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_priority).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1_new;
        private TableLayoutPanel tableLayoutPanel2_new;
        private Label lbl_deadline_new;
        private TextBox txbox_category;
        private Label lbl_category_new;
        private Label lbl_priority_new;
        private Label lbl_name_new;
        private TextBox txbox_name;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_close;
        private Button btn_ok;
        private DateTimePicker dtp_deadline;
        private NumericUpDown nud_priority;
        private CheckBox cb_iscompleted;
    }
}