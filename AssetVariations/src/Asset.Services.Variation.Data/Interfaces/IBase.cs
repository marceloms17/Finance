using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset.Variations.Data.Interfaces
{
    public interface IBase<T> where T : class
    {
        Task<IEnumerable<T>> Get();

    }
}
