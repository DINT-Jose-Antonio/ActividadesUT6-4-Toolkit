using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Actividades_UT6__1____Comandos
{
    public class NavigationService
    {
        private NuevaPersonaUserControl lista;
        public NavigationService()
        {
            ObtenerListadoPersonas = new ListadoPersonasUserControl();
            lista = new NuevaPersonaUserControl();
        }

        public UserControl ObtenerNuevaPersona()
        {
            return lista;
        }

        public UserControl ObtenerListadoPersonas { get; }

        public bool? AbrirDialogoNacionalidad()
        {
            return new AñadirNacionalidad().ShowDialog();
        }
    }
}
