using System;

namespace Exercicio.Um.Domain.Entities
{
    public class PedidoItem : EntidadeBase
    {
        public PedidoItem(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }

        public override bool IsValid()
        {
            if (string.IsNullOrEmpty(Descricao))
            {
                base.Errors.Add("Campo descrição é obrigatório");
            }

            if (Valor == 0)
            {
                base.Errors.Add("Campo valor é obrigatório");
            }

            return base.Errors.Count == 0;
        }
    }
}