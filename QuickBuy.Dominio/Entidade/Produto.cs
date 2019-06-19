namespace QuickBuy.Dominio.Entidade
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public decimal Preço { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
