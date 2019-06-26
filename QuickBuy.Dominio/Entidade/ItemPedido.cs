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
            if (ProdutoID == 0)
                AdicionarCritica("Não foi identificado qual a refêrencia do produto");
            if (Quantidade == 0)
                AdicionarCritica("Quantidade não foi informado");

        }

    }
}