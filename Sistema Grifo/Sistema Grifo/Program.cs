using Sistema_Grifo.controle;

namespace Sistema_Grifo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ConexaoGeral.Conexao();
            Application.Run(new Form1());
            
        }
    }
}