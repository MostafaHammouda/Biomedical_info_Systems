﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBD
{
    
    public partial class Doc_Login : Form
    {
        public Doc_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor_View.Return_Home  aa = new Doctor_View.Return_Home ();

            aa.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doctor_View.New_Acc ab = new Doctor_View.New_Acc();

            ab.Show();
        }
    }
}
