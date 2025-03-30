using LogicaNegocio.EntidadesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioTemas : IRepositorio<Tema>
    {
        List<Tema> TemasContienenTexto(string texto);

        List<Tema> TemasComienzanConInicial(char inicial);
    }
}
