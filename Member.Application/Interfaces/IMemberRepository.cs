
namespace Member.Application.Interfaces
{
    public interface IMemberRepository
    {
        List<Domain.Domain.Member> GetAllMembers();
    }
}
