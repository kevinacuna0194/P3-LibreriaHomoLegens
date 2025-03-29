using ExcepcionesPropias;
using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    internal class Tema : IValidable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(this.Nombre))
            {
                throw new DatosInvalidosException("El Nombre del tema es Obligatorio");
            }

            if (this.Nombre.Length < 3 || this.Nombre.Length > 128)
            {
                throw new DatosInvalidosException("El Nombre del tema debe tener entre 3 y 128 caracteres");
            }
        }
    }
}
