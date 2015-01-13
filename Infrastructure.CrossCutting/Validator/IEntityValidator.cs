using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.CrossCutting.Validator
{
    public interface IEntityValidator
    {
        bool IsValid<TEntity>(TEntity item) where TEntity : class;

        IEnumerable<String> GetInvalidMessages<TEntity>(TEntity item) where TEntity : class;
    }
}
