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
    public partial class StoreListForm : Form
    {
        public StoreListForm()
        {
            InitializeComponent();
            AdminLoad load = new AdminLoad(this);
            Load += load.GetHandler("storelist");
                
        }
    }
}
