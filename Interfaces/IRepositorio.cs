using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);        
        void Insere(T entidade);        
        void Exclui(int id);        
        void Atualiza(int id, T entidade);
        int ProximoId();
    }

    public interface IRepositorioFilme<T>
    {
        List<T> ListaFilme();
        T RetornaPorIdFilme(int id);        
        void InsereFilme(T entidade);        
        void ExcluiFilme(int id);        
        void AtualizaFilme(int id, T entidade);
        int ProximoIdFilme();
    }
}