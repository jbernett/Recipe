using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeDomain.Converters
{
    public interface IConvertModel<TSource, TTarget>
    {
        TTarget Convert();
    }
}
