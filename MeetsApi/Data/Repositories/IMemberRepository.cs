using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetsApi.Data.Models;

namespace MeetsApi.Data.Repositories;

public interface IMemberRepository
{
    void Add(Member member);
}
