using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.classes
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Logadouro { get; set; }
        public long Telefone { get; set; }
        public DateTime DataNacimento { get; set; }
        public static Cliente CreateCliente(string nome, string endereco, long telefone, string cpf, DateTime dataNascimento)
        {
            return new Cliente()
            {
                Nome = nome,
                Logadouro = endereco,
                Telefone = telefone,
                CPF = cpf,
                DataNacimento = dataNascimento
            };
        }

        public override string ToString()
        {
            return $"Nome:{ Nome} \nEndereco:{Logadouro} \nTelefone:{Telefone} \nCPF:{CPF} \nDataNascimento:{DataNacimento} ()";
        }       
        public bool ValidarIdade()
        {
            if(DateTime.Today.Year - DataNacimento.Year >=18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
