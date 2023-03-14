using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S3_SisteminhaBancario
{
    /*Isso é a classe*/
    public class Transaçao
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public Transaçao (DateTime data, double valor){
            Data = data;
            Valor = valor;
        }
    }
}