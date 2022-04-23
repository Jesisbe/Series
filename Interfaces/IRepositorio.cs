using System.Collections.Generic;

namespace Series.Interfaces
{
    //A classe implementa o repositorio de a otra classe . Va sustituir T por Serie de SerieRepositorio
    public interface IRepositorio<T>
    {
        //método que se chama lista que retorna uma lista
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();
    }
}