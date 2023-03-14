using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Isso é a classe*/
namespace M1S3_SisteminhaBancario
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereço { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int NumeroConta { get; set; }
        public double saldo { get; set; }
        public string TipoBancario { get; set; }
        public int Idade { get {return (int)(Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.25)); } set{} }
        public List<Transaçao> Extrato { get; set; }


        public Cliente(){
        Extrato = new List<Transaçao>();
    }

        public string ResumoCliente(){
        return $"| {NumeroConta} | {Nome} | {CPF}";
    }
        public bool EhMaior(){
        var idade = (DateTime.Now - DataNascimento).TotalDays / 365.25;
        return idade > 18;
        }
        public Cliente(string nome, string cpf, string email, string telefone,
        string endereço, DateTime dataNascimento, int numeroConta){
            
            Nome = nome;
            CPF = cpf;
            Endereço = endereço;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
            NumeroConta = numeroConta;
            Extrato = new List<Transaçao>();
        }
    }
}