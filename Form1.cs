using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone2Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int currentStock_Small = 8, currentStock_medium = 12, currentStock_large = 18, currentStock_x_large = 20;
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CurrentInventory(checkBox1, currentStock_Small);
        }
        void CurrentInventory(CheckBox c, int c_Stock)
        {
            listBox1.Items.Clear();
            if (c.Checked == true)
                listBox1.Items.Add("Current Inventory of " + c.Text + "Stock " + c_Stock.ToString() + "/20");
            else
                listBox1.Items.Clear();
        }

        private void restockbtn_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                currentStock_Small = 20;
                CurrentInventory(checkBox1, currentStock_Small);
            }
            else if (checkBox2.Checked == true)
            {
                currentStock_medium = 20;
                CurrentInventory(checkBox2, currentStock_medium);
            }
            else if (checkBox3.Checked == true)
            {
                currentStock_large = 20;
                CurrentInventory(checkBox3, currentStock_large);
            }
            else if (checkBox4.Checked == true)
            {
                currentStock_x_large = 20;
                CurrentInventory(checkBox4, currentStock_x_large);
            }
            else
            {
                MessageBox.Show("Nothing is selected for Restocking");
            }

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CurrentInventory(checkBox2, currentStock_medium);
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CurrentInventory(checkBox3, currentStock_large);
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CurrentInventory(checkBox4, currentStock_x_large);
        }
    }
}

