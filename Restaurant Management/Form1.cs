using proiect1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Restaurant_Management
{
    public partial class Form1 : Form
    {

        DataBase dataBase = new DataBase();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passwordUser = textBox_password.Text;


            SqlDataAdapter ADAPTER = new SqlDataAdapter();
            DataTable table = new DataTable();


            string queryString = $"Select id_user, login, password, is_admin  from register where login = '{loginUser}' and password = '{passwordUser}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            ADAPTER.SelectCommand = command;

            ADAPTER.Fill(table);

            if (table.Rows.Count == 1)
            {
                var user = new checkuser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));
                MessageBox.Show("entered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 frm1 = new Form2(user);
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No existing account", "No account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup_frm = new SignUp();
            signup_frm.Show();
            this.Hide(); 
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

