namespace lab4_task1
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
            MessageBox.Show("Привет, мир!\nПривет, мир!\nПривет, мир!", "Привет всем");
            ApplicationConfiguration.Initialize();
            Application.Run(new FirstForm());
        }
    }
}