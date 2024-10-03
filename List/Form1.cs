using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("Ali");
            list.Add("Ayşe");
            list.Add("Ahmet");
            list.Add("Mehmet");
            list.Add("Veysi");
            list.Add("Nazlı");
            list.Add("Suzan");
            list.Add("Semih");
            list.Add("Sinan");
            foreach (string item in list)
            {
                listBox1.Items.Add(item);
            }

            List<int> list2 = new List<int>();
            list2.Add(345);
            list2.Add(435);
            list2.Add(42);
            list2.Add(45);
            list2.Add(78);
            list2.Add(67);
            list2.Add(34);
            list2.Add(98);
            list2.Add(23);
            foreach (int item in list2)
            {
                listBox2.Items.Add(item);
            }

            if (list2.Contains(2354))
            {
                MessageBox.Show("List provide the value");
            }
            else
            {
                MessageBox.Show("List not provide the value");
            }

            List<Person> per = new List<Person>();

            per.Add(new Person()
            {
                Name = "Ali",
                Surname = "Çınar",
                Job = "Teacher"
            });
            foreach (Person person in per)
            {
                listBox3.Items.Add(person.Name + " " + person.Surname + " " + person.Job);
            }
        }
    }
}
