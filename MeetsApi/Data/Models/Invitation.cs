using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetsApi.Data.Models
{
    public class Invitation
    {
        public int Id { get; set; }
        public InvitationStatus Status { get; set; } = null!;

        //Forign keys
        public int MemberId { get; set; }
        public int MeetingId { get; set; }
        public virtual Member Member { get; set; } = null!;
        public virtual Meeting Meeting { get; set; } = null!;

    }
}