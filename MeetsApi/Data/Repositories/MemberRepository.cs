using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetsApi.Data.Models;

namespace MeetsApi.Data.Repositories;

public class MemberRepository : IMemberRepository
{
    private readonly AppDbContext context;
    public MemberRepository(AppDbContext context)
    {
        this.context = context;
        
    }

    public void Add(Member member)
    {
        context.Members.Add(member);
    }

}
