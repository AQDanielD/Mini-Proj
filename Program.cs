using Npgsql;
namespace Mini_Proj
{
    internal static class Program
    {
        public static string cs = "Host=ragged-mummy-11407.8nj.cockroachlabs.cloud;Port=26257;Database=HomeWorkBud;Username=aq232596_aquinas_ac_;Password=72eg0Wd7zpeV1TLCwAqr2A;SSL Mode=Prefer;Trust Server Certificate=true";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        

        




        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var cs = "Host=ragged-mummy-11407.8nj.cockroachlabs.cloud;Port=26257;Database=HomeWorkBud;Username=aq232596_aquinas_ac_;Password=72eg0Wd7zpeV1TLCwAqr2A;SSL Mode=Prefer;Trust Server Certificate=true";
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}