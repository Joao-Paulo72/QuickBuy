using System;

namespace QuickBuy.Dominio.Entidade
{

    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoID { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException ();
        }

    }
}