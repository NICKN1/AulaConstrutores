using System;
using MeusExemplosConstrutores.Models;
using static System.Console;

namespace MeusExemplosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para o programa conseguir acessar o Construtor privado através do método
            Log ExemploDeLog = Log.GetInstance();
            ExemploDeLog.PropriedadeLog = "Teste de Instancia";
            //Log é um exemplo Para retornar a mesma instancia, os mesmos valores
    /*Exemplode de Padrão de projeto SINGLETON >>Uma única Instancia da 
    sua classe reaproveitando-a durante o ciclo de vida da aplicação*/
            Log ExemploDeLog2 = Log.GetInstance();
            WriteLine(ExemploDeLog2.PropriedadeLog);
            //Não importando o lugar do codigo, essa instancia de Log terá sempre o mesmo valor


            /*Instancio a Classe Pessoa, e dentro de "new Pessoa()" escolho qual 
            construtor que será chamado dentro dos dois criados*/
            Pessoa pessoa1 = new Pessoa("Jose", "Iranildo");
            pessoa1.Apresentar();
            //Toda Classe Possui um construtor padrão, com parâmetros vazios
        }
    }
}
