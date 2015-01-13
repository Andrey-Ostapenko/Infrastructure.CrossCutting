using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.CrossCutting.Validator
{
    public interface IEntityValidatorFactory
    {
        IEntityValidator Create();
    }
}
