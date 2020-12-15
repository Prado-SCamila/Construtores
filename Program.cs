using System;
using  Construtores.classes;
namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            produto1.Codigo = 1;
            produto1.Nome = "Coca-Cola";
            produto1.Descricao = "Refrigerante de Cola";
            produto1.Estoque = 30;

            Console.WriteLine($"Produto 1 Código: {produto1.Codigo}, Nome: {produto1.Nome}, Descrição: {produto1.Descricao}, Estoque:{produto1.Estoque}");
        }
    }
}
