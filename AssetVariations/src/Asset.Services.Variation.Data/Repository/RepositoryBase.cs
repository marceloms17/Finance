using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Asset.Variations.Data.Context;
using Asset.Variations.Data.Interfaces;

namespace Asset.Variations.Data.Repository
{
    public class RepositoryBase<T> : IBase<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<AssetVariationDbContext> _optionsBuilder;
        public RepositoryBase() 
        {
            _optionsBuilder = new DbContextOptions<AssetVariationDbContext>();
        }
        public async Task<IEnumerable<T>> Get()
        {
            using (var data = new AssetVariationDbContext(_optionsBuilder)) 
            {
                return await data.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        #region Disposed - https://learn.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose  
        // To detect redundant calls
        private bool _disposedValue;

        // Instantiate a SafeHandle instance.
        private SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose() => Dispose(true);

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _safeHandle.Dispose();
                }

                _disposedValue = true;
            }
        }
    }
}
#endregion - Disposed - https://learn.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose  