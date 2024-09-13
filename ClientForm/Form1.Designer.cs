namespace ClientForm
{
    partial class Form1
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
            IPTextBox = new TextBox();
            PortTB = new TextBox();
            userTB = new TextBox();
            PassTB = new TextBox();
            openFile = new OpenFileDialog();
            openFileBtn = new Button();
            DBSourceLab = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            LocalNetworkRB = new RadioButton();
            LocalRB = new RadioButton();
            panel7 = new Panel();
            PathToDBTB = new TextBox();
            ConnectBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // IPTextBox
            // 
            IPTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IPTextBox.Location = new Point(124, 12);
            IPTextBox.MaxLength = 16;
            IPTextBox.Name = "IPTextBox";
            IPTextBox.Size = new Size(426, 43);
            IPTextBox.TabIndex = 0;
            IPTextBox.Text = "IP";
            IPTextBox.TextAlign = HorizontalAlignment.Center;
            IPTextBox.Enter += IPTextBox_Enter;
            IPTextBox.Leave += IPTextBox_Leave;
            // 
            // PortTB
            // 
            PortTB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PortTB.Location = new Point(124, 15);
            PortTB.MaxLength = 10;
            PortTB.Name = "PortTB";
            PortTB.Size = new Size(426, 43);
            PortTB.TabIndex = 1;
            PortTB.Text = "Port";
            PortTB.TextAlign = HorizontalAlignment.Center;
            PortTB.Enter += PortTB_Enter;
            PortTB.Leave += PortTB_Leave;
            // 
            // userTB
            // 
            userTB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            userTB.Location = new Point(124, 17);
            userTB.MaxLength = 25;
            userTB.Name = "userTB";
            userTB.Size = new Size(426, 43);
            userTB.TabIndex = 2;
            userTB.Text = "User";
            userTB.TextAlign = HorizontalAlignment.Center;
            userTB.Enter += userTB_Enter;
            userTB.Leave += userTB_Leave;
            // 
            // PassTB
            // 
            PassTB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PassTB.Location = new Point(124, 16);
            PassTB.MaxLength = 25;
            PassTB.Name = "PassTB";
            PassTB.Size = new Size(426, 43);
            PassTB.TabIndex = 3;
            PassTB.Text = "Password";
            PassTB.TextAlign = HorizontalAlignment.Center;
            PassTB.Enter += PassTB_Enter;
            PassTB.Leave += PassTB_Leave;
            // 
            // openFile
            // 
            openFile.FileName = "openFileDialog1";
            // 
            // openFileBtn
            // 
            openFileBtn.BackColor = Color.FromArgb(255, 128, 0);
            openFileBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            openFileBtn.Location = new Point(158, 13);
            openFileBtn.Name = "openFileBtn";
            openFileBtn.Size = new Size(146, 60);
            openFileBtn.TabIndex = 5;
            openFileBtn.Text = "Open file";
            openFileBtn.UseVisualStyleBackColor = false;
            openFileBtn.Visible = false;
            openFileBtn.Click += openFileBtn_Click;
            // 
            // DBSourceLab
            // 
            DBSourceLab.AutoSize = true;
            DBSourceLab.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DBSourceLab.Location = new Point(18, 90);
            DBSourceLab.Name = "DBSourceLab";
            DBSourceLab.Size = new Size(0, 37);
            DBSourceLab.TabIndex = 6;
            DBSourceLab.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 0, 3);
            tableLayoutPanel1.Controls.Add(panel5, 0, 4);
            tableLayoutPanel1.Controls.Add(panel6, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 5);
            tableLayoutPanel1.Controls.Add(ConnectBtn, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3456745F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.34568F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.34568F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.34568F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3456831F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.9259243F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3456783F));
            tableLayoutPanel1.Size = new Size(671, 670);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(IPTextBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(665, 76);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(PortTB);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 167);
            panel3.Name = "panel3";
            panel3.Size = new Size(665, 76);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.Controls.Add(userTB);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 249);
            panel4.Name = "panel4";
            panel4.Size = new Size(665, 76);
            panel4.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.Controls.Add(PassTB);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 331);
            panel5.Name = "panel5";
            panel5.Size = new Size(665, 76);
            panel5.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.Controls.Add(label1);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(665, 76);
            panel6.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(150, 6);
            label1.Name = "label1";
            label1.Size = new Size(366, 54);
            label1.TabIndex = 0;
            label1.Text = "Authorize database";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.5659752F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.43402F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel7, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 413);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(665, 167);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(LocalNetworkRB);
            panel1.Controls.Add(LocalRB);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 161);
            panel1.TabIndex = 0;
            // 
            // LocalNetworkRB
            // 
            LocalNetworkRB.AutoSize = true;
            LocalNetworkRB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LocalNetworkRB.Location = new Point(6, 101);
            LocalNetworkRB.Name = "LocalNetworkRB";
            LocalNetworkRB.Size = new Size(213, 41);
            LocalNetworkRB.TabIndex = 5;
            LocalNetworkRB.TabStop = true;
            LocalNetworkRB.Text = "Local network";
            LocalNetworkRB.UseVisualStyleBackColor = true;
            LocalNetworkRB.CheckedChanged += LocalNetworkRB_CheckedChanged;
            // 
            // LocalRB
            // 
            LocalRB.AutoSize = true;
            LocalRB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LocalRB.Location = new Point(6, 13);
            LocalRB.Name = "LocalRB";
            LocalRB.Size = new Size(110, 41);
            LocalRB.TabIndex = 4;
            LocalRB.TabStop = true;
            LocalRB.Text = "Local";
            LocalRB.UseVisualStyleBackColor = true;
            LocalRB.CheckedChanged += LocalTB_CheckedChanged;
            // 
            // panel7
            // 
            panel7.Controls.Add(PathToDBTB);
            panel7.Controls.Add(DBSourceLab);
            panel7.Controls.Add(openFileBtn);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(246, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(416, 161);
            panel7.TabIndex = 1;
            // 
            // PathToDBTB
            // 
            PathToDBTB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PathToDBTB.Location = new Point(12, 63);
            PathToDBTB.MaxLength = 100;
            PathToDBTB.Name = "PathToDBTB";
            PathToDBTB.Size = new Size(398, 43);
            PathToDBTB.TabIndex = 6;
            PathToDBTB.Text = "Path";
            PathToDBTB.Visible = false;
            PathToDBTB.Enter += PathToDBTB_Enter;
            PathToDBTB.Leave += PathToDBTB_Leave;
            // 
            // ConnectBtn
            // 
            ConnectBtn.BackColor = Color.FromArgb(0, 192, 0);
            ConnectBtn.FlatAppearance.BorderColor = Color.LawnGreen;
            ConnectBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ConnectBtn.Location = new Point(3, 586);
            ConnectBtn.Name = "ConnectBtn";
            ConnectBtn.Size = new Size(180, 63);
            ConnectBtn.TabIndex = 7;
            ConnectBtn.Text = "Connect";
            ConnectBtn.UseVisualStyleBackColor = false;
            ConnectBtn.Click += ConnectBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 670);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox IPTextBox;
        private TextBox PortTB;
        private TextBox userTB;
        private TextBox PassTB;
        private OpenFileDialog openFile;
        private Button openFileBtn;
        private Label DBSourceLab;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton LocalRB;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private RadioButton LocalNetworkRB;
        private Panel panel7;
        private TextBox PathToDBTB;
        private Button ConnectBtn;
        private RadioButton radioButton2;
    }
}