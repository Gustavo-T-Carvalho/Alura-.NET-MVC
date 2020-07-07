using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public interface IPedidoRepository
    {
        Pedido GetPedido();
        UpdateQuantidadeResponse UpdateQuantidade(ItemPedido itemPedido);
        void AddItem(string codigo);
        Pedido UpdateCadastro(Cadastro cadastro);
    }
}



