using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorio<T>
    {
        void Add(T objeto);

        void Delete(int id);

        void Update(T objeto);

        T FindById(int id);

        List<T> FindAll();
    }
}
