using XIRPL1_20_TICKETING.MasterForm;
using XIRPL1_20_TICKETING.TransactionForm;

namespace XIRPL1_20_TICKETING
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
            //MasterBandara bandara = new MasterBandara();
            //bandara.Show();

            //FrmRegister register = new FrmRegister();
            //register.Show();

            //Dashboard dashboard = new Dashboard();
            //dashboard.Show();

            //MasterKodePromo kodepromo = new MasterKodePromo();
            //kodepromo.Show();

            //Login login = new Login();
            //login.Show();

            //MasterMaskapai Maskapai = new MasterMaskapai();
            //Maskapai.Show();

            //MasterJadwalPenerbangan jadwalpenerbangan = new MasterJadwalPenerbangan();
            //jadwalpenerbangan.Show();

            UbahStatusPenerbangan statuspenerbangan = new UbahStatusPenerbangan();
            statuspenerbangan.Show();

            Application.Run(statuspenerbangan);
        }
    }
}