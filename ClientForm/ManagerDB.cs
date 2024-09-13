using ClientForm.Classes;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class ManagerDB : Form
    {
        private ConnectionDB connectionDB;
        private CommandDB commandDB;
        public ManagerDB(ConnectionDB connection)
        {
            InitializeComponent();

            connectionDB = connection;
            commandDB = new CommandDB(connectionDB.fbconnection);

            UpdateData();
        }

        private void InfoDBBtn_Click(object sender, EventArgs e)
        {
            string infoMessage = connectionDB.InfoDataBase();

            MessageBox.Show(infoMessage);
        }

        private void ManagerDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(connectionDB, this);
            addUser.ShowDialog();
        }

        public void UpdateData()
        {
            dataUser.DataSource = commandDB.LoadUser();
        }
    }
}
