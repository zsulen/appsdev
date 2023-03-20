using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void wishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = wishList.Text;
        }

        private void fillB_Click(object sender, EventArgs e)
        {
            wishList.Items.Add("Taylor Swift concert ticket");
            wishList.Items.Add("Blackpink concert ticket");
            wishList.Items.Add("iPhone XR");
        }

        private void sortB_Click(object sender, EventArgs e)
        {
            wishList.Sorted = true;
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            wishList.Items.Clear();
        }

        private void countB_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(wishList.Items.Count);
        }

        private void closeB_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
