using QuickBuy.Dominio.ObjetoDeValor;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidade
{
    public abstract class Entidade
    {

        public List<string> _MensagensDeValidacao { get; set; }
        private List<string> MensagemValidacao
        {
            get { return _MensagensDeValidacao ?? (_MensagensDeValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();
        protected bool EhValido
        {

        get { return !MensagemValidacao.Any(); }
        }
    }
}
