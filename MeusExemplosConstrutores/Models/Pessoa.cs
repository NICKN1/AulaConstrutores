using static System.Console;
namespace MeusExemplosConstrutores.Models

{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;

        //Exempldo de Construtor vazio (((((Usando o comando ctor + Tab para criar)))))
        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }
        //Exemplo de Contrutor com parametros para receber Nome e Sobrenome
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Apresentar()
        {
            WriteLine($"Os nomes e sobrenomes: {nome} {sobrenome}.");
        }

    }
}