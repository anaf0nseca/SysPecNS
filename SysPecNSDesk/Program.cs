using SysPecNSLib;

namespace SysPecNSDesk
{
    //Classe Program é a classe base do sistema, chama o método main que é o principal método do sistema
    //É a primeira classe a ser executada no sistema
 
    internal static class Program
    {
        //Atributo publico inicializado
        public static Usuario UsuarioLogado = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmPrincipal());
            //Application.Run(new FrmLogin());


        }
    }
}