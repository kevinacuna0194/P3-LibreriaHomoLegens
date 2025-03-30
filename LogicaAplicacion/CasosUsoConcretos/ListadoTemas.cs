using CasosUso.DTOs;
using CasosUso.InterfacesCasosUso;
using LogicaAplicacion.Mapeadores;
using LogicaNegocio.EntidadesDominio;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUsoConcretos
{
    public class ListadoTemas : IListadoTemas
    {
        public IRepositorioTemas RepoTemas { get; set; }

        public ListadoTemas(IRepositorioTemas repo)
        {
            RepoTemas = repo;
        }

        public List<TemaDTO> ObtenerListado()
        {
            List<Tema> temas = RepoTemas.FindAll();

            List<TemaDTO> temasDTO = MappersTema.ToListaTemaDTO(temas);

            return temasDTO;
        }
    }
}
