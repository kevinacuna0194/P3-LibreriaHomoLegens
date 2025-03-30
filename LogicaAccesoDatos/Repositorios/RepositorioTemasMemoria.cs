using ExcepcionesPropias;
using LogicaNegocio.EntidadesDominio;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioTemasMemoria : IRepositorioTemas
    {
        private static List<Tema> temas = new List<Tema>() { new Tema { Id = 1, Nombre = 'Nombre de Prueba' } };

        private static int ultimoId = 2;

        public void Add(Tema tema)
        {
            if (tema is null)
            {
                throw new DatosInvalidosException("El Tema es nulo");
            }

            // Validar que el Tema cumpla con la lógica de negocio
            tema.Validar();

            // Buscar si el Tema ya existe
            Tema tema1 = BuscarTemaPorNombre(tema.Nombre);

            if (tema1 is not null)
            {
                throw new DatosInvalidosException("El Tema ya existe");
            }

            // Asignar un Id al Tema
            tema.Id = ultimoId++;

            temas.Add(tema);

        }

        public void Delete(int id)
        {
            Tema tema = FindById(id);

            if (tema is null) throw new DatosInvalidosException("No se encontró el tema a borrar en los registros. Verifica los datos e inténtalo otra vez.");

            temas.Remove(tema);
        }

        public List<Tema> FindAll()
        {
            return temas;
        }

        public Tema FindById(int id)
        {
            Tema tema1 = null;

            foreach (Tema tema in temas)
            {
                if (tema.Id == id)
                {
                    tema1 = tema;
                    break;
                }
            }

            return tema1;
        }

        public List<Tema> TemasComienzanConInicial(char inicial)
        {
            List<Tema> temas = new List<Tema>();

            foreach (Tema tema in temas)
            {
                if (tema.Nombre.StartsWith(inicial))
                {
                    temas.Add(tema);
                }
            }

            return temas;
        }

        public List<Tema> TemasContienenTexto(string texto)
        {
            List<Tema> temas = new List<Tema>();

            foreach (Tema tema in temas)
            {
                if (tema.Nombre.Contains(texto))
                {
                    temas.Add(tema);
                }
            }

            return temas;
        }

        public void Update(Tema objeto)
        {
            Tema tema = FindById(objeto.Id);

            if (tema is null) throw new DatosInvalidosException("No se encontró el tema a actualizar en los registros. Verifica los datos e inténtalo otra vez.");

            // Validar que el Tema cumpla con la lógica de negocio
            objeto.Validar();

            objeto = tema;
        }

        // Método auxiliar. Busca si el Tema existe en la lista de temas.
        private Tema BuscarTemaPorNombre(string nombre)
        {
            Tema tema1 = null;

            foreach (Tema tema in temas)
            {
                if (tema.Nombre == nombre)
                {
                    tema1 = tema;
                    break;
                }
            }

            return tema1;
        }
    }
}
