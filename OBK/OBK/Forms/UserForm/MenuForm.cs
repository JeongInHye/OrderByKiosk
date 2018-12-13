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

namespace OBK.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm(int mNo)
        {
            InitializeComponent();
            Load load = new Load(this,mNo);
            Load += load.GetHandler("menu");
        }
    }
}