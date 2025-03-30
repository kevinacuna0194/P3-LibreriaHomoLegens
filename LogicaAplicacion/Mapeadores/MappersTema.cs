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
        // Método auxiliar. Convierte un TemaDTO en un Tema
        public static Tema ToTema(TemaDTO dto)
        {
            Tema tema = new Tema()
            {
                Id = dto.Id,
                Nombre = dto.Nombre
            };

            return tema;
        }

        // Método auxiliar. Convierte un Tema en un TemaDTO
        public static TemaDTO ToTemaDTO(Tema tema)
        {
            TemaDTO dto = new TemaDTO()
            {
                Id = tema.Id,
                Nombre = tema.Nombre
            };

            return dto;
        }

        // Método auxiliar. Convierte una lista de Temas en una lista de TemaDTOs
        public static List<TemaDTO> ToListaTemaDTO(List<Tema> temas)
        {
            List<TemaDTO> temasDTO = new List<TemaDTO>();

            foreach (Tema tema in temas)
            {
                TemaDTO dto = ToTemaDTO(tema);

                temasDTO.Add(dto);
            }

            return temasDTO;
        }
    }
}
