using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.entity
{
    class Pessoa
    {
        public string nome { get; set; }
        public string idade { get; set; }
        public string cnh { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string carro { get; set; }

        public string getCSV()
        {
            return $"{nome};{idade};{cnh};{cpf};{email};{carro}";
        }

        public void setCSV(string csv)
        {
            string[] allFilds = csv.Split(';');
            nome = allFilds[0];
            idade = allFilds[1];
            cnh = allFilds[2];
            cpf = allFilds[3];
            email = allFilds[4];
            carro = allFilds[5];
        }

        public bool pesquisa(string pesquisa)
        {
            if(nome == pesquisa || idade == pesquisa || cnh == pesquisa || cpf == pesquisa || email == pesquisa || carro == pesquisa)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Nome: {nome} Idade: {idade} CNH: {cnh} CPF: {cpf} E-mail: {email} Carro: {carro}";
        }
    }
}
