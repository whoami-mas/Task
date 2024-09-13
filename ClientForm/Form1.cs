using ClientForm.Classes;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace ClientForm
{
    public partial class Form1 : Form
    {
        ConnectionDB connectDB;
        public Form1()
        {
            InitializeComponent();

            connectDB = new ConnectionDB();
        }

        private void IPTextBox_Enter(object sender, EventArgs e)
        {
            IPTextBox.Text = "";
        }

        private void IPTextBox_Leave(object sender, EventArgs e)
        {
            if (IPTextBox.Text == "") IPTextBox.Text = "IP";
        }

        private void PortTB_Leave(object sender, EventArgs e)
        {
            if (PortTB.Text == "") PortTB.Text = "Port";
        }

        private void PortTB_Enter(object sender, EventArgs e)
        {
            PortTB.Text = "";
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (IPTextBox.Text == "" || PortTB.Text == "" || userTB.Text == "" ||
                PassTB.Text == "")
            {
                MessageBox.Show("Введите данные");
                return;
            }
            if (LocalRB.Checked && file == "")
            {
                MessageBox.Show("Выберите базу данных");
                return;
            }
            if (LocalNetworkRB.Checked && PathToDBTB.Text == "")
            {
                MessageBox.Show("введите путь до БД");
                return;
            }
            if (LocalNetworkRB.Checked && !Path.IsPathRooted(PathToDBTB.Text))
            {
                MessageBox.Show("Введенный путь не корректен");
                return;
            }
            if (LocalNetworkRB.Checked && Path.GetExtension(PathToDBTB.Text) != ".FDB")
            {
                MessageBox.Show("Это не тот формат файла");
                return;
            }

            string pathToData = "";
            if (LocalRB.Checked) pathToData = file;
            if (LocalNetworkRB.Checked) pathToData = PathToDBTB.Text;

            string result = connectDB.Connect(IPTextBox.Text, PortTB.Text,
                userTB.Text, PassTB.Text, pathToData);

            MessageBox.Show(result);
            if (!connectDB.statusOpen()) return;

            ManagerDB managerDBForm = new ManagerDB(connectDB);
            managerDBForm.Show();
            this.Hide();
        }

        private void userTB_Enter(object sender, EventArgs e)
        {
            userTB.Text = "";
        }

        private void PassTB_Enter(object sender, EventArgs e)
        {
            PassTB.Text = "";
            PassTB.PasswordChar = '*';
        }

        private void userTB_Leave(object sender, EventArgs e)
        {
            if (userTB.Text == "") userTB.Text = "User";
        }

        private void PassTB_Leave(object sender, EventArgs e)
        {
            if (PassTB.Text == "")
            {
                PassTB.PasswordChar = '\0';
                PassTB.Text = "Password";
            }
            else
            {
                PassTB.PasswordChar = '*';
            }
        }

        private string file = "";
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            using (var openFile = new OpenFileDialog())
            {
                openFile.Filter = "file (*.fdb)|*.fdb";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    DBSourceLab.Text = openFile.FileName;
                    file = openFile.FileName;
                }

            }
        }

        private void LocalTB_CheckedChanged(object sender, EventArgs e)
        {
            if (LocalRB.Checked)
            {
                PathToDBTB.Visible = false;
                openFileBtn.Visible = true;
                DBSourceLab.Visible = true;
            }
        }

        private void LocalNetworkRB_CheckedChanged(object sender, EventArgs e)
        {
            if (LocalNetworkRB.Checked)
            {
                openFileBtn.Visible = false;
                DBSourceLab.Visible = false;
                PathToDBTB.Visible = true;
            }
        }

        private void PathToDBTB_Enter(object sender, EventArgs e)
        {
            PathToDBTB.Text = "";
        }

        private void PathToDBTB_Leave(object sender, EventArgs e)
        {
            if (PathToDBTB.Text == "") PathToDBTB.Text = "Path";
        }
    }
}