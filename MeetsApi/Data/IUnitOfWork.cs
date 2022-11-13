using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetsApi.Data;
public interface IUnitOfWork
{
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
