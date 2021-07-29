using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkboxandRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            string selectedMovies = "";

            if (checkBox1.Checked)
            {
                selectedMovies = selectedMovies + checkBox1.Text + "\n";
            }
            if (checkBox2.Checked)
            {
                selectedMovies = selectedMovies + checkBox2.Text + "\n";
            }
            if (checkBox3.Checked)
            {
                selectedMovies = selectedMovies + checkBox3.Text + "\n";
            }

            MessageBox.Show(selectedMovies);
        }

        private void btnselectedcourse_Click(object sender, EventArgs e)
        {
            string course = "";
            if (radioButton1.Checked)
            {
                course = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                course = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                course = radioButton3.Text;
            }
            else
            {
                course = "Invalid Option";
            }
            MessageBox.Show(course);
        }
    }
}
