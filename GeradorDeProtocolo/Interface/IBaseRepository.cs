using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeProtocolo.Interface
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> ListarTodos();
        void Cadastrar(T Entity);
        void Atualizar(T Entity);
        void Excluir(T Entity);

    }
}
