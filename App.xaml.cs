
using System.Windows;

namespace Actividades_UT6__1____Comandos
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Actividades_UT6__1____Comandos.Properties.Settings.Default.Licencia);
        }
    }
}
