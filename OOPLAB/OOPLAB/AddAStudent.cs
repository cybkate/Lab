using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOPLAB.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOPLAB
{
    public partial class AddAStudent : Form
    {
        public AddAStudent()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Form1.studentsList.Add(new Students(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text)));
            }

            catch
            {
                MessageBox.Show("Incorrect input");
            }
        }
    }
}
