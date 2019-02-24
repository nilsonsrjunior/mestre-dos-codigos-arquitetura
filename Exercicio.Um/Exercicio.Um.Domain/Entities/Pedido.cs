using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio.Um.Domain.Entities
{
    internal sealed class Pedido : EntidadeBase
    {
        public Pedido(string cliente, IReadOnlyCollection<PedidoItem> itens)
        {
            Cliente = cliente;
            _itens = new List<PedidoItem>();
        }

        public string Cliente { get; private set; }
        public IReadOnlyCollection<PedidoItem> Itens => _itens.ToList();
        private ICollection<PedidoItem> _itens;

        public void AdicionarItem(PedidoItem item)
        {
            if (item.IsValid())
            {
                _itens.Add(item);
            }
            else
                base.Errors.AddRange(item.Errors);
        }

        public override bool IsValid()
        {
            if (string.IsNullOrEmpty(Cliente))
            {
                base.Errors.Add("Campo descrição é obrigatório");
            }

            if (Itens.Count == 0)
            {
                base.Errors.Add("Um pedido deve conter, ao menos, um item");
            }

            return base.Errors.Count == 0;
        }
    }
}
