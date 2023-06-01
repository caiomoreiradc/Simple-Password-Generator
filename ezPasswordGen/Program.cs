namespace ezPasswordGen
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Funcao funcao = new Funcao();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal(funcao));
        }
    }
}