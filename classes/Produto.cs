using System;
namespace Construtores.classes
{
    public class Produto
    {
        public int Codigo{ get;set;}
        public string Nome{get;set;}

        public string Descricao{get;set;}

        public int Estoque {get;set;}


        public Produto(){
            Console.WriteLine("Método Construtor foi executado");

        }

        public Produto(int valor){
            Codigo = valor;
            Console.WriteLine($"Codigo Inserido foi {Codigo}");

        }
    }
}