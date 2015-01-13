using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.CrossCutting.Adapter
{
    /// <summary>
    /// Base contract for map dto to aggregate or aggregate to dto.
    /// <remarks>
    public interface ITypeAdapter
    {
        TTarget Adapt<TSource, TTarget>(TSource source) 
            where TTarget : class,new() 
            where TSource : class;

        TTarget Adapt<TTarget>(object source)
            where TTarget : class,new();
    }
}
