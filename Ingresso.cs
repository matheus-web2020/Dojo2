using System;
namespace Dojo2
{
    public class Ingresso
    {
        public float IngressoPreco {get; set;}

        public float ValDes;

        public void ImprimirValor(){
            
            Console.WriteLine("O valor do ingresso tradicional é $" + IngressoPreco);
        }


        public float Desconto = 15; 

        public void GerarDesconto(){
            Console.WriteLine( $"Pagando a vista, você terá {Desconto}% de desconto.");
        }

        public void ValorDoDesconto(){
                float ValDes = IngressoPreco -( IngressoPreco*15/100);

                System.Console.WriteLine("Caso você pague o ingresso a vista, o valor pago ficará R$" + ValDes);
        
        }
        
        
        
    }
}