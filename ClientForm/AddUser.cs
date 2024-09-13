using ClientForm.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientForm
{
    public partial class AddUser : Form
    {
        private ConnectionDB connection;
        private updateDelegate update;
        public AddUser(ConnectionDB connection, ManagerDB window)
        {
            InitializeComponent();

            this.connection = connection;
            update = window.UpdateData;
        }

        private void NameTB_Enter(object sender, EventArgs e)
        {
            NameTB.Text = "";
        }

        private void AgeTB_Enter(object sender, EventArgs e)
        {
            AgeTB.Text = "";
        }

        private void AgeTB_Leave(object sender, EventArgs e)
        {
            if (AgeTB.Text == "") AgeTB.Text = "Age";
        }

        private void NameTB_Leave(object sender, EventArgs e)
        {
            if (NameTB.Text == "") NameTB.Text = "Name";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            CommandDB commandDB = new CommandDB(connection.fbconnection);

            string result = commandDB.AddUser(NameTB.Text, Convert.ToInt32(AgeTB.Text));

            update();
            MessageBox.Show(result);
        }
        delegate void updateDelegate();

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AgeTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void NameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letters = e.KeyChar;
            if (!Char.IsLetter(letters) && letters != 32
                && letters != 8 && letters != 3 && letters != 22)
            {
                e.Handled = true;
            }
        }
    }
}
