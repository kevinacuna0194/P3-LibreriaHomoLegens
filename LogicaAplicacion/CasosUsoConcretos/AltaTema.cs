using CasosUso.DTOs;
using CasosUso.InterfacesCasosUso;
using LogicaAplicacion.Mapeadores;
using LogicaNegocio.EntidadesDominio;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUsoConcretos
{
    public class AltaTema : IAltaTema
    {
        public IRepositorioTemas RepoTemas { get; set; }

        public AltaTema(IRepositorioTemas repo)
        {
            RepoTemas = repo; 
        }

        public void EjecutarAltaTema(TemaDTO dto)
        {
            RepoTemas.Add(MappersTema.ToTema(dto));
        }
    }
}
