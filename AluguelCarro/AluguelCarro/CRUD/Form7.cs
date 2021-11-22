﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.entity;

namespace CRUD
{
    public partial class Form7 : Form
    {
 
        public Form7()
        {
            InitializeComponent();

        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = System.Drawing.Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = System.Drawing.Color.DimGray;
        }

        private void Form7_Load(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void Home1_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            this.Visible = false;
            Form3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var Form8 = new Form8();
            this.Visible = false;
            Form8.Show();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = CRUD.Properties.Resources.profileblack;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = CRUD.Properties.Resources.perfil;
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void savePessoa(string csvPessoa)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("pessoa.txt", true, System.Text.Encoding.UTF8);
                sw.WriteLine(csvPessoa);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
                sw.Close();
            }
            sw.Close();
        }
        private Pessoa fetchDadosPessoa()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = textBox2.Text;
            pessoa.idade = textBox3.Text;
            pessoa.cnh = textBox4.Text;
            pessoa.cpf = textBox5.Text;
            pessoa.email = textBox6.Text;
            pessoa.carro = txtSandero.Text;

            return pessoa;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox3.Value >= 18)
            {
                Pessoa umaPessoa = fetchDadosPessoa();
                string csvPessoa = umaPessoa.getCSV();

                savePessoa(csvPessoa);
                limpaCampos();

                System.Windows.Forms.MessageBox.Show("Obrigado por alugar com a LJP Veículos!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Para alugar um carro é necessário ser maior de 18 anos!");
            }
        }

        private void limpaCampos()
        {
            textBox2.Clear();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Clear();
            textBox2.Focus();
        }

        private void txtSandero_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
