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
            Repositorio repositorio = new Repositorio();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal(repositorio));
        }
    }
}