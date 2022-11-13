
using MeetsApi.Data.Models;

namespace MeetsApi.Data.Repositories
{
    public interface IMeetingRepository
    {
        Task<Meeting?> GetByIdWithCreatorAsync(int id, CancellationToken cancellationToken = default);
        Task<Meeting?> GetByIdWithInvitationsAsync(int id, CancellationToken cancellationToken = default);

        void Add(Meeting meeting);
        void Remove(Meeting meeting);


    }
}