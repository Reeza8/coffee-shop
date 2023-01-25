using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Coffee_Shop_Project.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coffee_Shop_Project
{
    public partial class desert_form : Form
    {
        Menu_coffee myMenu = new Menu_coffee();
        public desert_form()
        {
            InitializeComponent();
            label1.Text = myMenu.desert_names[0];
            label2.Text = myMenu.desert_names[1];
            label3.Text = myMenu.desert_names[2];
            label4.Text = myMenu.desert_names[3];

            label7.Text = myMenu.deserts_prices[0].ToString();
            label8.Text = myMenu.deserts_prices[1].ToString();
            label9.Text = myMenu.deserts_prices[2].ToString();
            label10.Text = myMenu.deserts_prices[3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Controls["textBox1"].Text = textBox1.Text;

            this.Close();
        }
    }
}
