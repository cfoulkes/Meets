using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetsApi.Data;
public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext context;
    public UnitOfWork(AppDbContext context)
    {
        this.context = context;
    }

    public Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return context.SaveChangesAsync(cancellationToken);
    }
    
}
