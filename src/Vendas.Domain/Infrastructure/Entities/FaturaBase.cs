namespace Vendas.Domain.Infrastructure
{
    public abstract class FaturaBase : EntityBase
    {
        public Pedido Pedido { get; private set; }
        public abstract string Sign();

        protected FaturaBase(Pedido pedido)
        {
            Pedido = pedido;
        }
    }
}