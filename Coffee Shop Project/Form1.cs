using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Coffee_Shop_Project
{
    

    public partial class Form1 : Form
    {
        private class Price
        {
            public float total_price=0;
            
            public void add_price(float new_price)
            {
                total_price += new_price;
            }
            

        }

        public class Order
        {
            Price orders_price=new Price();
            public string orders;
            public Order()
            {
                orders = "";
                
            }
          public  float get_total_price()
            {
                return orders_price.total_price;
            }
            
           public void add_order(float p, string names)
            {
                orders_price.add_price(p);
                orders += "\n" + names;
            }

        }

        public class Menu_coffee
        {

            public string[] foods_name = { "1-پیتزا سبزیجات", "2-پیتزا قارچ و گوشت", "3-پیتزا پپرونی", "4-چیزبرگر", "5-دوبل برگر" };
            public double[] foods_prices = { 100000, 130000, 127000, 125000, 95000 };
            public string[] hot_drinks_name = { "1-چایی", "2-کاپوچینو", "3-قهوه ترک", "4-شکلات داغ" };
            public float[] hot_drinks_prices = { 20000, 35000, 30000, 27000 };
            public string[] cold_drinks_name = { "5-میلک شیک نوتلا", "6-میلک شیک توت فرنگی", "7-اب پرتقال", "8-اب هویج" };
            public float[] cold_drinks_price = { 30000, 35000, 20000, 15000 };
            public string[] salad_name = { "1-سالاد سزار", "2-سالاد فصل", "3-سالاد فتوش", "4-سالاد تبوله" };
            public float[] salads_price = { 110000, 95000, 120000, 95000 };
            public string[] desert_names = { "1-برونی", "2-کنافه با بستنی", "3-کنافه", "4-وافل" };
            public float[] deserts_prices = { 50000, 80000, 65000, 45000 };
            //public string[] foods_name = { "پیتزا سبزیجات", "پیتزا قارچ و گوشت", "پیتزا پپرونی", "چیزبرگر", "دوبل برگر" };
            //public float[] foods_prices = { 100000, 130000, 127000, 125000, 95000, 100000 };
            //public string[] hot_drinks_name = { "چایی", "کاپوچینو", "قهوه ترک", "شکلات داغ" };
            //public float[] hot_drinks_prices = { 20000, 35000, 30000, 27000 };
            //public string[] cold_drinks_name = { "میلک شیک نوتلا", "میلک شیک توت فرنگی", "اب پرتقال", "اب هویج" };
            //public float[] cold_drinks_price = { 30000, 35000, 20000, 15000 };
            //public string[] salad_name = { "سالاد سزار", "سالاد فصل", "سالاد فتوش", "سالاد تبوله" };
            //public float[] salads_price = { 110000, 95000, 120000, 95000 };
            //public string[] desert_names = { "برونی", "کنافه با بستنی", "کنافه", "وافل" };
            //public float[] deserts_prices = { 50000, 80000, 65000, 45000 };




        }
        
        private class Number
        {
            int table_number;
            int[] used_numbers = {0};
            Random rnd = new Random();
            bool is_used_number(int number, int[] used)
            {
                for (int i = 0; i < used.Length; i++)
                {
                    if (number == used[i])
                    {
                        return true;
                    }
                }
                return false;
            }
                

            public int get_number()
            {
                table_number = rnd.Next(50);
                while(is_used_number(table_number,used_numbers))
                {
                    table_number = rnd.Next(50);
                }
                used_numbers.Append(table_number);
                return table_number;
            }

        }

        food_form food_f = new food_form();
        Form2 drink_f=new Form2();
        desert_form desert_f=new desert_form(); 
        Order main_order = new Order();
        salad_form salad_f = new salad_form();  
        Menu_coffee mymenu = new Menu_coffee();
        Number my_number = new Number();

        float choice = 0;
        float price = 0;
        string order_name;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("به کافه ما خوش امدید", "Welcome");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            Food_chechBox.Visible = true;
            desert_checkBox.Visible = true;
            salad_checkBox.Visible = true;  
            Drink_checkBox.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Food_chechBox.Visible = false;
            Drink_checkBox.Visible = false;
            desert_checkBox.Visible = false;
            salad_checkBox.Visible = false;
            button3.Visible = false;
            
            if (Food_chechBox.Checked)
            {
                food_f.ShowDialog();

                choice = float.Parse(textBox1.Text);
                order_name = mymenu.foods_name[(int)choice - 1];
                price =(float)mymenu.foods_prices[(int)choice - 1];
                
                Food_chechBox.Checked = false;
                main_order.add_order(price, order_name);


            }

            if(Drink_checkBox.Checked)
            {
                drink_f.ShowDialog();
                choice = float.Parse(textBox1.Text);
                if(choice>4)
                {
                    order_name = mymenu.cold_drinks_name[(int)choice - 5];
                    price = (float)mymenu.cold_drinks_price[(int)choice - 5];
                    main_order.add_order(price, order_name);
                }
                if(choice<=4)
                {
                    order_name = mymenu.hot_drinks_name[(int)choice - 1];
                    price = (float)mymenu.hot_drinks_prices[(int)choice - 1];
                    main_order.add_order(price, order_name);
                }
                

            }

            if(desert_checkBox.Checked)
            {
                desert_f.ShowDialog();
                choice = float.Parse(textBox1.Text);
                order_name = mymenu.desert_names[(int)choice - 1];
                price = (float)mymenu.deserts_prices[(int)choice - 1];
                main_order.add_order(price, order_name);

            }

            if(salad_checkBox.Checked)
            {
                salad_f.ShowDialog();
                choice = float.Parse(textBox1.Text);
                order_name = mymenu.salad_name[(int)choice - 1];
                price = (float)mymenu.salads_price[(int)choice - 1];
                main_order.add_order(price, order_name);
            }

            label1.Visible = true;
            label2.Visible = true;
            label1.Text = "شماره میز شما=" + my_number.get_number().ToString();
            label2.Text = main_order.orders;
            label3.Visible = true;
            label3.Text = "صورتحساب شما "+main_order.get_total_price().ToString();

        }
    }
}
