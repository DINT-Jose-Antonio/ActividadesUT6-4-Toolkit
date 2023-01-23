using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_UT6__1____Comandos
{
    public class ListadoPersonasUserControlVM : ObservableObject
    {
        private PersonasService servicioPersonas;
        private ObservableCollection<Personas> listaPersonas;

        public ObservableCollection<Personas> ListaPersonas
        {
            get => listaPersonas;
            set => listaPersonas = value;
        }

        public ListadoPersonasUserControlVM()
        {
            servicioPersonas = new PersonasService();
            ListaPersonas = servicioPersonas.ObtenerPersonas();
        }
    }
}
