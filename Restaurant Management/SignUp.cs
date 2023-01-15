using proiect1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant_Management
{
    public partial class SignUp : Form
    {
            DataBase dataBase = new DataBase();
        public SignUp()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
         

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
         
        }

        private void button2_Click(object sender, EventArgs e)
        {


            var login = textBox_login.Text;
            var password = textBox_password.Text;

            string querystring = $"Insert into register(login,password,is_admin) values('{login}','{password}',0)";

            SqlCommand command = new SqlCommand(querystring,dataBase.GetConnection());
            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("account created succesfully", "Success");
                Form1 form = new Form1();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("account not  created ");

            }
            dataBase.closeConnection();

        }
        private Boolean checkuser()
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user,login,password,is_admin from register where login='{loginUser}and password='{passUser}' ";
            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count>0)
            {
                MessageBox.Show("user exists allready");
                    return true;

            }
            else
            {
                return false;
            }
        }
    }
}
