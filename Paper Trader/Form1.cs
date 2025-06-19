using ScottPlot;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Paper_Trader
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPasword.Text;

            // Simple authentication
            if (username == "admin" && password == "123")
            {
                this.Hide();
                Trader traderForm = new Trader();
                traderForm.FormClosed += (s, args) => this.Close();
                traderForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}