using System.Collections.Generic;
namespace DIO.Series
{
    public interface IReposotorio<T>
    {
         List<T> Lista();

         T RetornarId(int id);

         void Insere(T entidade);

         void Exclui(int id);

         void Atualizar(int id, T entidade);

         int ProximoId();

    }
}