using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetsApi.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly IMemberRepository memberRepository;
        private readonly IUnitOfWork unitOfWork;
        public MemberController(IMemberRepository memberRepository, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.memberRepository = memberRepository;
        }
        
        [HttpPost]
        public async Task<ActionResult> RegisterMember(string firstName, string lastNam, string email, CancellationToken cancellationToken)
        {
            var member = Member.Create(firstName, lastNam, email);
            memberRepository.Add(member);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            return Ok();
        }
    }
}