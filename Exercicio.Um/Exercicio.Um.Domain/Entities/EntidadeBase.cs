using System;
using System.Collections.Generic;

namespace Exercicio.Um.Domain.Entities
{
    public abstract class EntidadeBase
    {
        public EntidadeBase()
        {
            Id = Guid.NewGuid();
            Errors = new List<string>();
        }

        public Guid Id { get; private set; }
        public List<string> Errors;

        public abstract bool IsValid();
    }
}
