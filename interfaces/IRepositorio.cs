using System.Collections.Generic;
namespace DIO.Series.interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();

         T RetornarId(int id);

         void Insere(T entidade);

         void Excluir(int id);

         void Atualizar(int id, T entidade);

         int ProximoId();

    }
}