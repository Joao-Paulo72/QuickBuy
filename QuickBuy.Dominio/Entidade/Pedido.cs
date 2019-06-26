using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidade
{
    public class Pedido : Entidade
    {
        private FormaPagamento formaPagamento;

        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string NumeroEndereco { get; set; }
        public int Complemento { get; set; }


        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }



        /// <summary>
        /// Pedido deve ter pelo menos um item de pedido
        /// ou muitos itens de pedidos
        /// </summary>

        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Critica - Pedido não pode ficar sem item de pedido");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Critica - CEP deve estar preenchido");

        }
    }
}
