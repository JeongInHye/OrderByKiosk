﻿using OBK.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK.Forms.AdminForm
{
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
            AdminLoad load = new AdminLoad(this);
            Load += load.GetHandler("store");
        }
    }
}
