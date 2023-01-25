using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Coffee_Shop_Project.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coffee_Shop_Project
{
    public partial class Form2 : Form
    {
        Menu_coffee myMenu = new Menu_coffee();
        public Form2()
        {
            InitializeComponent();
            label1.Text = myMenu.hot_drinks_name[0];
            label2.Text = myMenu.hot_drinks_name[1];
            label3.Text = myMenu.hot_drinks_name[2];
            label4.Text = myMenu.hot_drinks_name[3];
            
            label5.Text = myMenu.hot_drinks_prices[0].ToString();
            label6.Text = myMenu.hot_drinks_prices[1].ToString();
            label7.Text = myMenu.hot_drinks_prices[2].ToString();
            label8.Text = myMenu.hot_drinks_prices[3].ToString();

            label9.Text = myMenu.cold_drinks_name[0];
            label10.Text = myMenu.cold_drinks_name[1];
            label12.Text = myMenu.cold_drinks_name[2];
            label13.Text = myMenu.cold_drinks_name[3];

            label14.Text = myMenu.hot_drinks_prices[0].ToString();
            label15.Text = myMenu.hot_drinks_prices[1].ToString();
            label16.Text = myMenu.hot_drinks_prices[2].ToString();
            label17.Text = myMenu.hot_drinks_prices[3].ToString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Controls["textBox1"].Text = textBox1.Text;
            this.Close();   
        }
    }
}
