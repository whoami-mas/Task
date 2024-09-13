namespace ClientForm
{
    partial class ManagerDB
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
            components = new System.ComponentModel.Container();
            dataUser = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usersBindingSource1 = new BindingSource(components);
            InfoDBBtn = new Button();
            usersBindingSource = new BindingSource(components);
            AddBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataUser
            // 
            dataUser.AutoGenerateColumns = false;
            dataUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUser.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn });
            dataUser.DataSource = usersBindingSource1;
            dataUser.Dock = DockStyle.Fill;
            dataUser.Location = new Point(10, 10);
            dataUser.Margin = new Padding(10);
            dataUser.Name = "dataUser";
            dataUser.ReadOnly = true;
            dataUser.RowHeadersWidth = 82;
            dataUser.RowTemplate.Height = 41;
            dataUser.Size = new Size(943, 795);
            dataUser.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            ageDataGridViewTextBoxColumn.HeaderText = "Возраст";
            ageDataGridViewTextBoxColumn.MinimumWidth = 10;
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            dateDataGridViewTextBoxColumn.HeaderText = "Дата добавления";
            dateDataGridViewTextBoxColumn.MinimumWidth = 10;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersBindingSource1
            // 
            usersBindingSource1.DataSource = typeof(Classes.Users);
            // 
            // InfoDBBtn
            // 
            InfoDBBtn.BackColor = Color.FromArgb(255, 128, 0);
            InfoDBBtn.Dock = DockStyle.Top;
            InfoDBBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            InfoDBBtn.Location = new Point(0, 0);
            InfoDBBtn.Margin = new Padding(10);
            InfoDBBtn.Name = "InfoDBBtn";
            InfoDBBtn.Size = new Size(296, 60);
            InfoDBBtn.TabIndex = 2;
            InfoDBBtn.Text = "Info database";
            InfoDBBtn.UseVisualStyleBackColor = false;
            InfoDBBtn.Click += InfoDBBtn_Click;
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Classes.Users);
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(255, 128, 0);
            AddBtn.Dock = DockStyle.Top;
            AddBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.Location = new Point(0, 60);
            AddBtn.Margin = new Padding(10);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(296, 60);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.1450348F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.8549633F));
            tableLayoutPanel1.Controls.Add(dataUser, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1265, 815);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(InfoDBBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(966, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 809);
            panel1.TabIndex = 3;
            // 
            // ManagerDB
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 815);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1291, 886);
            Name = "ManagerDB";
            Text = "Manager data base";
            FormClosing += ManagerDB_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataUser;
        private Button InfoDBBtn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private BindingSource usersBindingSource1;
        private BindingSource usersBindingSource;
        private Button AddBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}