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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            this.Visible = false;
            Form3.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.Color.Black;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usercerto = "admin";
            var senhacerta = "admin";
            var usuario = txtUser.Text;
            var senha = txtPass.Text;
            if (usuario == usercerto && senha == senhacerta)
            {
                var Form1 = new Form1();
                this.Visible = false;
                Form1.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Usuário ou senha errados!");
            }
        }
    }
}
