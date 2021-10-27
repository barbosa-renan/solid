namespace Vendas.Domain.Infrastructure
{
    public class FaturaPessoaFisica : FaturaBase
    {

        public FaturaPessoaFisica(Pedido pedido) : base(pedido)
        {
        }

        public override string Sign()
        {
        }
    }
}