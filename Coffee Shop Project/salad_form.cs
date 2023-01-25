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
    public partial class salad_form : Form
    {
        Menu_coffee myMenu = new Menu_coffee();
        public salad_form()
        {
            InitializeComponent();
            label1.Text = myMenu.salad_name[0];
            label2.Text = myMenu.salad_name[1];
            label3.Text = myMenu.salad_name[2];
            label4.Text = myMenu.salad_name[3];

            label7.Text = myMenu.salads_price[0].ToString();
            label8.Text = myMenu.salads_price[1].ToString();
            label9.Text = myMenu.salads_price[2].ToString();
            label10.Text = myMenu.salads_price[3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Controls["textBox1"].Text = textBox1.Text;

            this.Close();
        }
    }
}
