﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Choice_Creator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var HSForm = new HomeScreen();
            HSForm.Show();
            //var HSForm1 = new NewHomeScreen_Popis_();
            //HSForm1.Show();
        }

        
    }
}
