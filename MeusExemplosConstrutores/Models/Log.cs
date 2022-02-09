namespace MeusExemplosConstrutores.Models
{
    public class Log
    {
        private static Log _log;

        //Criando uma propriedade de exemplo (((((prop + Tab)))))
        public string PropriedadeLog { get; set; }
        //Exemplo Construtor Privado
        private Log()
        {
            
        }
        //Para poder acessar o Construtor privado
        public static Log GetInstance()
        {
            if (_log == null){
                _log = new Log();
            }
            return _log;
        }
    }
}