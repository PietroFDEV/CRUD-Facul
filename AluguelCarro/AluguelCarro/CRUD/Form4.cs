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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Home1_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            this.Visible = false;
            Form3.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Alugar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var Form8 = new Form8();
            this.Visible = false;
            Form8.Show();
        }

        private void FAQ1_Click(object sender, EventArgs e)
        {
            var Form5 = new Form5();
            this.Visible = false;
            Form5.Show();
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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = System.Drawing.Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = System.Drawing.Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form6 = new Form6();
            this.Visible = false;
            Form6.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = System.Drawing.Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = System.Drawing.Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form7 = new Form7();
            this.Visible = false;
            Form7.Show();
        }
    }
}
