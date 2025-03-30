using CasosUso.DTOs;
using LogicaNegocio.EntidadesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Mapeadores
{
    public class MappersTema
    {
        public static Tema ToTema(TemaDTO dto)
        {
            Tema tema = new Tema()
            {
                Id = dto.Id,
                Nombre = dto.Nombre
            };

            return tema;
        }

        TemaDTO ToTemaDTO(Tema tema)
        {
            TemaDTO dto = new TemaDTO()
            {
                Id = tema.Id,
                Nombre = tema.Nombre
            };

            return dto;
        }
    }
}
