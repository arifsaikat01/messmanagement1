﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messmanagement
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDefaultPanels();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ShowDefaultPanels();
        }
        private void ShowDefaultPanels()
        {
            leftpnl.Visible = true;
            centerpnl.Visible = true;
            //panelAlt.Visible = false;
        }

        private void ShowAltPanel()
        {
            leftpnl.Visible = false;
            centerpnl.Visible = false;
            //panelAlt.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowDefaultPanels();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
