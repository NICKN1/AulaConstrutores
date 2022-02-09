using System;
using MeusExemplosConstrutores.Models;

namespace MeusExemplosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Instancio a Classe Pessoa, e dentro de "new Pessoa()" escolho qual 
            construtor que será chamado dentro dos dois criados*/
            Pessoa pessoa1 = new Pessoa("Jose", "Iranildo");
            pessoa1.Apresentar();
        }
    }
}
