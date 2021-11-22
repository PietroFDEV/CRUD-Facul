using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Alugar1_Click(object sender, EventArgs e)
        {
            var Form4 = new Form4();
            this.Visible = false;
            Form4.Show();
        }

        private void FAQ1_Click(object sender, EventArgs e)
        {
            var Form5 = new Form5();
            this.Visible = false;
            Form5.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var Form8 = new Form8();
            this.Visible = false;
            Form8.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Home1_MouseEnter(object sender, EventArgs e)
        {
            Home1.ForeColor = System.Drawing.Color.Black;
        }

        private void Home1_MouseLeave(object sender, EventArgs e)
        {
            Home1.ForeColor = System.Drawing.Color.White;
        }

        private void Alugar1_MouseEnter(object sender, EventArgs e)
        {
            Alugar1.ForeColor = System.Drawing.Color.Black;
        }

        private void Alugar1_MouseLeave(object sender, EventArgs e)
        {
            Alugar1.ForeColor = System.Drawing.Color.White;
        }

        private void FAQ1_MouseEnter(object sender, EventArgs e)
        {
            FAQ1.ForeColor = System.Drawing.Color.Black;
        }

        private void FAQ1_MouseLeave(object sender, EventArgs e)
        {
            FAQ1.ForeColor = System.Drawing.Color.White;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = CRUD.Properties.Resources.profileblack;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = CRUD.Properties.Resources.perfil;
        }
    }
}
