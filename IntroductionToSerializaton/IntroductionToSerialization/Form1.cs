using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroductionToSerialization
{
    public partial class Form1 : Form
    {
        List<Food> Foods = new List<Food>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int caloriesCount = Convert.ToInt32(textBox1.Text);
            string taste = textBox2.Text;
            string name = textBox3.Text;
            int activeButton= groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).TabIndex;
            switch(activeButton){
                case 0: {
                        Foods.Add(new inorganicFood(taste, caloriesCount, name));
                        break;
                    }
                case 1:
                    {
                        Foods.Add(new mushroom(taste, caloriesCount, name));
                        break;
                    }
                case 2:
                    {
                        Foods.Add(new seaweed(taste, caloriesCount, name));
                        break;
                    }
                case 3:
                    {
                        Foods.Add(new fruit(taste, caloriesCount, name));
                        break;
                    }
                case 4:
                    {
                        Foods.Add(new vegetable(taste, caloriesCount, name));
                        break;
                    }
                case 5:
                    {
                        Foods.Add(new cereal(taste, caloriesCount, name));
                        break;
                    }
                case 6:
                    {
                        Foods.Add(new berrie(taste, caloriesCount, name));
                        break;
                    }
                case 7:
                    {
                        Foods.Add(new nut(taste, caloriesCount, name));
                        break;
                    }
                case 8:
                    {
                        Foods.Add(new meat(taste, caloriesCount, name));
                        break;
                    }
                case 9:
                    {
                        Foods.Add(new poultry(taste, caloriesCount, name));
                        break;
                    }
                case 10:
                    {
                        Foods.Add(new fish(taste, caloriesCount, name));
                        break;
                    }
                case 11:
                    {
                        Foods.Add(new dairy(taste, caloriesCount, name));
                        break;
                    }
            }
            Food lastElement = Foods.Last();
            textBox4.Text += $"Name: {lastElement.name} Taste: {lastElement.taste} Calories: {lastElement.calories} {Environment.NewLine}";
            textBox4.Text += lastElement.printType()+Environment.NewLine;
            textBox4.Text += "==========================="+Environment.NewLine;

        }
    }
}
