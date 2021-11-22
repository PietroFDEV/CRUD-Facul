using System;
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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            Pessoa umaPessoa = fetchDadosPessoa();
            string csvPessoa = umaPessoa.getCSV();
            savePessoa(csvPessoa);
            dgvDados.Rows.Add(umaPessoa.nome, umaPessoa.idade, umaPessoa.cnh, umaPessoa.cpf, umaPessoa.email, umaPessoa.carro); ;
            limpaCampos();
        }
        private void limpaCampos()
        {
            txtCarros.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtCPF.Clear();
            txtCNH.Clear();
            txtNome.Focus();
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

        private Pessoa fetchDadosPessoa ()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = txtNome.Text;
            pessoa.idade = txtNumero.Text;
            pessoa.cnh = txtCNH.Text;
            pessoa.cpf = txtCPF.Text;
            pessoa.email = txtEmail.Text;
            pessoa.carro = txtCarros.Text;

            return pessoa;
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            dgvDados.Rows.Clear();
            List<Pessoa> listaPessoas = CarregaPessoas();
            listaPessoas.ForEach(pessoa =>
            {
                dgvDados.Rows.Add(pessoa.nome, pessoa.idade, pessoa.cnh, pessoa.cpf, pessoa.email, pessoa.carro);
            });
        }

        private List<Pessoa> CarregaPessoas()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            StreamReader sr = new StreamReader("pessoa.txt", System.Text.Encoding.UTF8);
            string line = sr.ReadLine();
            while (line != null)
            {
                Pessoa pessoa = new Pessoa();
                pessoa.setCSV(line);
                listaPessoas.Add(pessoa);
                line = sr.ReadLine();
            }
            sr.Close();
            return listaPessoas;

        }



        private void Home1_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            this.Visible = false;
            Form3.Show();
        }

        private void Alugar1_Click(object sender, EventArgs e)
        {
            var Form4 = new Form4();
            this.Visible = false;
            Form4.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = System.Drawing.Color.Black;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = System.Drawing.Color.White;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            this.Visible = false;
            Form3.Show();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            dgvDados.Rows.Clear();
            string pesquisa = txtP.Text;
            List<Pessoa> listaPessoas = CarregaPessoas();
            bool encontrou = false;
            listaPessoas.ForEach(pessoa =>
            {
                if (pessoa.pesquisa(pesquisa))
                {
                    dgvDados.Rows.Add(pessoa.nome, pessoa.idade, pessoa.cnh, pessoa.cpf, pessoa.email, pessoa.carro);
                    encontrou = true;
                }
            });
            if (!encontrou)
            {
                MessageBox.Show("Valor não encontrado");

            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            dgvDados.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

                string tempFile = Path.GetTempFileName();
                string fileName = @"C:\Users\Gamer\Desktop\AluguelCarro\AluguelCarro\CRUD\bin\Debug\pessoa.txt";
                using (var sr = new StreamReader(fileName))
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!line.Contains(this.txtP.Text))
                            sw.WriteLine(line);
                        else
                            sw.WriteLine(line.Replace(this.txtP.Text, ";;;;;"));
                    }
                }

                File.Delete(fileName);
                File.Move(tempFile, fileName);
            
        }

        private void btn_Click(object sender, EventArgs e)
        {

            string tempFile = Path.GetTempFileName();
            string fileName = @"C:\Users\Gamer\Desktop\AluguelCarro\AluguelCarro\CRUD\bin\Debug\pessoa.txt";
            using (var sr = new StreamReader(fileName))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (!line.Contains(this.txtP.Text))
                        sw.WriteLine(line);
                    else
                        sw.WriteLine(line.Replace(this.txtP.Text, txtR.Text));
                }
            }

            File.Delete(fileName);
            File.Move(tempFile, fileName);
        }
    }
}
