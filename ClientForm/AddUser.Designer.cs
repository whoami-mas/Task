namespace ClientForm
{
    partial class AddUser
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
            NameTB = new TextBox();
            AgeTB = new TextBox();
            SaveBtn = new Button();
            label1 = new Label();
            CloseBtn = new Button();
            SuspendLayout();
            // 
            // NameTB
            // 
            NameTB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            NameTB.Location = new Point(47, 217);
            NameTB.MaxLength = 50;
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(579, 43);
            NameTB.TabIndex = 0;
            NameTB.Text = "Name";
            NameTB.TextAlign = HorizontalAlignment.Center;
            NameTB.Enter += NameTB_Enter;
            NameTB.KeyPress += NameTB_KeyPress;
            NameTB.Leave += NameTB_Leave;
            // 
            // AgeTB
            // 
            AgeTB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AgeTB.Location = new Point(47, 292);
            AgeTB.MaxLength = 2;
            AgeTB.Name = "AgeTB";
            AgeTB.Size = new Size(579, 43);
            AgeTB.TabIndex = 1;
            AgeTB.Text = "Age";
            AgeTB.TextAlign = HorizontalAlignment.Center;
            AgeTB.Enter += AgeTB_Enter;
            AgeTB.KeyPress += AgeTB_KeyPress;
            AgeTB.Leave += AgeTB_Leave;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(0, 192, 0);
            SaveBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SaveBtn.Location = new Point(476, 577);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(150, 60);
            SaveBtn.TabIndex = 3;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(225, 77);
            label1.Name = "label1";
            label1.Size = new Size(183, 54);
            label1.TabIndex = 4;
            label1.Text = "Add user";
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.FromArgb(255, 128, 0);
            CloseBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CloseBtn.Location = new Point(47, 577);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(150, 60);
            CloseBtn.TabIndex = 3;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 673);
            Controls.Add(label1);
            Controls.Add(CloseBtn);
            Controls.Add(SaveBtn);
            Controls.Add(AgeTB);
            Controls.Add(NameTB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddUser";
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTB;
        private TextBox AgeTB;
        private Button SaveBtn;
        private Label label1;
        private Button CloseBtn;
    }
}