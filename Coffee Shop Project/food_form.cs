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

namespace Coffee_Shop_Project
{
    public partial class food_form : Form
    {
       
        Menu_coffee myMenu = new Menu_coffee();
        
       
        public food_form()
        {
            
            InitializeComponent();
            label1.Text = myMenu.foods_name[0];
            label2.Text = myMenu.foods_name[1];
            label3.Text = myMenu.foods_name[2];
            label4.Text = myMenu.foods_name[3];
            label5.Text = myMenu.foods_name[4];
            label6.Text = myMenu.foods_prices[0].ToString();
            label7.Text = myMenu.foods_prices[1].ToString();
            label8.Text = myMenu.foods_prices[2].ToString();
            label9.Text = myMenu.foods_prices[3].ToString();
            label10.Text =myMenu.foods_prices[4].ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Controls["textBox1"].Text = textBox1.Text;
            
            this.Close();
        }

        private void food_form_Load(object sender, EventArgs e)
        {

        }
    }
}
