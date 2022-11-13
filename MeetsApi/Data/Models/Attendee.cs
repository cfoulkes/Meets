using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MeetsApi.Data.Models;
public class Attendee
{
    public int MemberId { get; set; }
    public int MeetingId { get; set; }
    public virtual Member Member { get; set; } = null!;
    public virtual Meeting Meeting { get; set; } = null!;

}
