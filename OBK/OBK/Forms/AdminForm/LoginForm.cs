﻿using OBK.Views.AdminView;
using ObkLibrary;
using System.Windows.Forms;

namespace OBK.Forms.AdminForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            AdminLoad load = new AdminLoad(this);
            Load += (a,b) => { new LoginView(load.GetHandler("login")); };
        }
    }
}
