using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syllabus_Editing
{
    public partial class Syllabus : Form
    {
        public Syllabus()
        {
            InitializeComponent();
        }

        private void Homebutton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.Create aa = new WindowsFormsApplication2.Create();
            this.Hide();
            aa.ShowDialog();
            this.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deneme.Editor ab = new deneme.Editor();
            this.Hide();
            ab.ShowDialog();
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication3.Form1 ae = new WindowsFormsApplication3.Form1();
            this.Hide();
            ae.ShowDialog();
            this.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            converter.Form1 cv = new converter.Form1();
            this.Hide();
            cv.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contact c3 = new Contact();
            this.Hide();
            c3.ShowDialog();
        }
    }
}
