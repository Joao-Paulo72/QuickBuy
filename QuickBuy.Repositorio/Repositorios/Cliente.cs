using QuickBuy.Dominio.Entidade;

namespace QuickBuy.Repositorio.Repositorios
{
    public class Cliente
    {
        public Cliente()
        {
            var UsuarioRepositorio = new UsuarioRepositorio();
            var produto = new Produto();
            var usuario = new Usuario();

            UsuarioRepositorio.Adicionar(usuario);
        }
    }
}
