using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetsApi.Data.Models;

namespace MeetsApi.Data.Repositories
{
    public class MeetingRepository : IMeetingRepository
    {
        private readonly AppDbContext context;

        public MeetingRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Meeting meeting)
        {
            context.Meetings.Add(meeting);
        }

        public async Task<Meeting?> GetByIdWithCreatorAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.Meetings
                .Include(m => m.Creator)
                .FirstOrDefaultAsync(m => m.Id == id, cancellationToken);
        }

        public async Task<Meeting?> GetByIdWithInvitationsAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.Meetings
                .Include(m => m.Invitations)
                .FirstOrDefaultAsync(m => m.Id == id, cancellationToken);
        }

        public void Remove(Meeting meeting)
        {
            context.Meetings.Remove(meeting);
        }
    }
}