using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Reflection;


namespace IntroductionToPlugins
{
    public interface IFood
    {
        IFood Clone();
    }

    public partial class Form1 : Form
    {
        Assembly newLib = Assembly.LoadFrom("UnknownMeat.dll");
        List<Food> Foods = new List<Food>();
        public Form1()
        {
            InitializeComponent();
            comboBox1.ValueMember = "Name";
            comboBox2.ValueMember = "name";
            Assembly a = AppDomain.CurrentDomain.GetAssemblies().SingleOrDefault(assembly => assembly.GetName().Name == "IntroductionToPatterns");
            foreach (Type type in a.GetTypes())
            {
                if (type.IsSubclassOf(typeof(Food)) && !type.IsAbstract)
                {
                    comboBox1.Items.Add(type);
                }
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int caloriesCount = Convert.ToInt32(textBox1.Text);
            string taste = textBox2.Text;
            string name = textBox3.Text;
            Type selectedFood = (Type)comboBox1.SelectedItem;
            Food newObj = (Food)Activator.CreateInstance(selectedFood, taste, caloriesCount, name);
            comboBox2.Items.Add(newObj);
            comboBox2.SelectedIndex = comboBox2.Items.Count - 1;
            Foods.Add(newObj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Food[]));
            using (FileStream fs = new FileStream("foodList.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Foods.ToArray());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food selectedObj = (Food)comboBox2.SelectedItem;
            textBox4.Text = selectedObj.calories.ToString();
            textBox5.Text = selectedObj.taste;
            textBox6.Text = selectedObj.name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Food selectedObj = (Food)comboBox2.SelectedItem;
            (selectedObj as berrie).Clone();
            selectedObj.calories = Convert.ToInt32(textBox4.Text);
            selectedObj.taste = textBox5.Text;
            selectedObj.name = textBox6.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Food[]));
            using (FileStream fs = new FileStream("foodList.xml", FileMode.OpenOrCreate))
            {
                Food[] foodArr = (Food[])formatter.Deserialize(fs);
                foreach(Food food in foodArr)
                {
                    comboBox2.Items.Add(food);
                }
            }
            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
