using System;
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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
            // make sure your defaults actually run
            this.Load += Form4_Load;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ShowDefaultPanels();
        }

        private void ShowDefaultPanels() // Add Member
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;     // container stays visible
            panelc2.Visible = false;    // hide deposit container
            panelc3.Visible = false;    // irrelevant when c2 is hidden
            panelc4.Visible = false;
            panelc5.Visible = false;
            panelc6.Visible = false;
            panelc7.Visible = false;
            panel4addmember.Visible = false;
            panel4createaddmem.Visible = false;
            panelc1.BringToFront();
        }

        private void ShowDeposit() // Deposit screen
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;     // keep parent visible
            panelc2.Visible = true;     // show deposit container
            panelc3.Visible = false;    // ensure change-manager overlay is hidden
            panelc4.Visible = false;
            panelc5.Visible = false;
            panelc6.Visible = false;
            panelc7.Visible = false;
            panelc2.BringToFront();
        }

        private void ShowChangeManager() // Change Manager screen
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;     // keep parent visible
            panelc2.Visible = true;     // parent of panelc3 must be visible
            panelc3.Visible = true;     // show overlay
            panelc4.Visible = false;
            panelc5.Visible = false;
            panelc6.Visible = false;
            panelc7.Visible = false;
            panelc3.BringToFront();
        }
        private void Showstartnewmonth() 
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;     
            panelc2.Visible = true;     
            panelc3.Visible = true; 
            panelc4.Visible = true;
            panelc5.Visible = false;
            panelc6.Visible = false;
            panelc7.Visible = false;
            panelc4.BringToFront();
        }
        private void Deletemonth()
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;
            panelc2.Visible = true;
            panelc3.Visible = true;
            panelc4.Visible = true;
            panelc5.Visible = true;
            panelc6.Visible = false;
            panelc7.Visible = false;
            panelc5.BringToFront();
        }
        private void Addmeal()
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;
            panelc2.Visible = true;
            panelc3.Visible = true;
            panelc4.Visible = true;
            panelc5.Visible = true;
            panelc6.Visible = true;
            panelc7.Visible = false;
            panelc6.BringToFront();
        }
        private void Addcost()
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;
            panelc2.Visible = true;
            panelc3.Visible = true;
            panelc4.Visible = true;
            panelc5.Visible = true;
            panelc6.Visible = true;
            panelc7.Visible = true;
            panelc7.BringToFront();
        }

        // wire buttons
        private void addmember_Click(object sender, EventArgs e) { 
            ShowDefaultPanels(); 
        }
        private void adddeposit_Click(object sender, EventArgs e) { 
            ShowDeposit(); 
        }
        private void changemanager_Click(object sender, EventArgs e) {
            ShowChangeManager(); 
        }
        private void newmonth_Click(object sender, EventArgs e)
        {
            Showstartnewmonth();
        }
        private void deletebutton_Click(object sender, EventArgs e)
        {
            Deletemonth();
        }
        private void addmeal_Click(object sender, EventArgs e)
        {
            Addmeal();
        }
        private void addcost_Click(object sender, EventArgs e)
        {
            Addcost();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
       
        
        
        private void buttonaddmem_Click(object sender, EventArgs e)
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;     // container stays visible
            panelc2.Visible = true;
            panelc3.Visible = true;
            panelc4.Visible = true;
            panelc5.Visible = true;
            panelc6.Visible = true;
            panelc7.Visible = true;
            panel4addmember.Visible = true;
            
            panel4addmember.BringToFront();
        }
        private void back4addmem_Click(object sender, EventArgs e)
        {
            ShowDefaultPanels();
        }
        private void buttoncreateadd_Click(object sender, EventArgs e)
        {
            leftpnl.Visible = true;
            toppnl.Visible = true;

            panelc1.Visible = true;     // container stays visible
            panelc2.Visible = true;
            panelc3.Visible = true;
            panelc4.Visible = true;
            panelc5.Visible = true;
            panelc6.Visible = true;
            panelc7.Visible = true;
            panel4addmember.Visible = true;
            panel4createaddmem.Visible = true;  
            panel4createaddmem.BringToFront();
        }
        private void back4createadd_Click(object sender, EventArgs e)
        {
            ShowDefaultPanels();
        }

        private void dateTimePicker4diposit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4diposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4mem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butsubmit_Click(object sender, EventArgs e)
        {

        }

        private void textBox4newmonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void sub4newmonth_Click(object sender, EventArgs e)
        {

        }

        private void submitdelete_Click(object sender, EventArgs e)
        {

        }

        private void textBox4breakfastdef_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4lunchdef_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4dinnerdef_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitdefaultmeal_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4meal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void breakfastmeal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lunchmeal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dinnermeal_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4mealmem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submitmeal_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4mealcost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4mealcost_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4selectshoper_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4mealcost_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submit4mealcost_Click(object sender, EventArgs e)
        {

        }

        private void textBox4addmem_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4addman_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4addmem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submit4addmem_Click(object sender, EventArgs e)
        {

        }
        private void textBox4createadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void email4createadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4createadd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4createaddmem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submit4createadd_Click(object sender, EventArgs e)
        {

        }
    }
}

