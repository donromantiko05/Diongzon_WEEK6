using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiongzonWeek6
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "admin" && textBox2.Text == "1234")
            {
                MessageBox.Show("Login successful!");

                Inventory inventoryForm = new Inventory();
                inventoryForm.FormClosed += (s, args) => this.Close();
                inventoryForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Login_Click(sender, EventArgs.Empty);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
