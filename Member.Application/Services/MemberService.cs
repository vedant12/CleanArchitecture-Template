using Member.Application.Interfaces;

namespace Member.Application.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;
        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public List<Domain.Domain.Member> GetAllMembers()
        {
            return _memberRepository.GetAllMembers();
        }
    }
}
