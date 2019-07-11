using System.Collections.Generic;
using System.Linq;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        protected readonly QuickBuyContexto QuickBuyContexto;

        public BaseRepositorio(QuickBuyContexto quickBuyContexto)
        {
            QuickBuyContexto = quickBuyContexto;
        }


        public void Adicionar(TEntity entity)
        {
            QuickBuyContexto.Set<TEntity>().Add(entity);
        }

        public void Atualizar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return QuickBuyContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            QuickBuyContexto.Dispose();
        }
    }
}
