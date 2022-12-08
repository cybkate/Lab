using System;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Xml.Linq;
using static OOPLAB.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOPLAB
{
    public partial class Form1 : Form
    {
        public static List<Students> studentsList = new List<Students>();

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var AddStudent = new AddAStudent();
            if (AddStudent.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(studentsList[studentsList.Count - 1].name, studentsList[studentsList.Count - 1].room, studentsList[studentsList.Count - 1].age);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentsList.Add(new Students("Shevchenko Oleeksandr", 3, 18));
            studentsList.Add(new Students("Ivanov Misha", 2, 19));
            dataGridView1.Rows.Add(studentsList[0].name, studentsList[0].room, studentsList[0].age);
            dataGridView1.Rows.Add(studentsList[1].name, studentsList[1].room, studentsList[1].age);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);
                dataGridView1.Rows.RemoveAt(n - 1);
            }
            catch
            {
                MessageBox.Show("Incorrect input");
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AboutProgramm aboutProgramm = new AboutProgramm();
            aboutProgramm.Show();
        }
        public class Students
        {
            public int room;
            public string name;
            public int age;
            public Students(string name, int room, int age)
            {
                this.name = name;
                this.room = room;
                this.age = age;               
            }


        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\OOPDZ\\OOPLAB\\OOPLAB\\List.txt");
            for (int i = 0; i < studentsList.Count; i++)
            {
                sw.WriteLine(studentsList);
            }
            sw.Close();
        }
           
        }
    }
    
   

