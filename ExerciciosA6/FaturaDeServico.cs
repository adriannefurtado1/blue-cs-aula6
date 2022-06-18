using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosA6
{
    public class FaturaDeServico
    {
        private double numero;
        private string descricaoDoProduto;
        private double quantidadeComprada;
        private float precoUnitario;

        public FaturaDeServico(double Numero, string DescricaoDoProduto, double Quantidade, float PrecoUnit)
        {
            this.numero = Numero;
            this.descricaoDoProduto = DescricaoDoProduto;
            this.quantidadeComprada = Quantidade;   
            this.precoUnitario = PrecoUnit;
        }

        public double Numero
        {
            get { return this.numero; }
            set { numero = value;     }

        }

        public string DescricaoDoProduto
        {
            get { return this.descricaoDoProduto; }
            set { descricaoDoProduto = value; }
        }
       
        public double QuantidadeComprada
        {
            get { return this.quantidadeComprada; }
            set
            {
                quantidadeComprada = value;
            }
        }

        public float PrecoUnitario
        {
            get { return this.precoUnitario; }
            set
            {
                precoUnitario = value;
            }
        }

        public void CalculaValorFatura()
        {
            Console.WriteLine($"[ CALCULO DO VALOR DA FATURA ] ");
            Console.WriteLine($"Numero da Fatura: {this.numero}");
            Console.WriteLine($"Produto: {this.descricaoDoProduto}");
            Console.WriteLine($"Valor Unitário: {this.precoUnitario}");
            Console.WriteLine($"Quantidade Comprada: {this.quantidadeComprada}");
            Console.WriteLine($"====================================================");
            Console.WriteLine($"VALOR TOTAL: {this.precoUnitario * this.quantidadeComprada}");
            Console.WriteLine($"====================================================");
        }
    }
}
