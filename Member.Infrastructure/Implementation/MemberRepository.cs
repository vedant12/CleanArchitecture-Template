using Member.Application.Interfaces;

namespace Member.Infrastructure.Implementation
{
    public class MemberRepository : IMemberRepository
    {
        public MemberRepository()
        {
            
        }

        public static List<Domain.Domain.Member> lstMembers = new List<Domain.Domain.Member>()
        {
           new Domain.Domain.Member{  Id =1 ,Name= "Kirtesh Shah", Type ="G" , Address="Vadodara"},
           new Domain.Domain.Member{  Id =2 ,Name= "Mahesh Shah", Type ="S" , Address="Dabhoi"},
           new Domain.Domain.Member{  Id =3 ,Name= "Nitya Shah", Type ="G" , Address="Mumbai"},
           new Domain.Domain.Member{  Id =4 ,Name= "Dilip Shah", Type ="S" , Address="Dabhoi"},
           new Domain.Domain.Member{  Id =5 ,Name= "Hansa Shah", Type ="S" , Address="Dabhoi"},
           new Domain.Domain.Member{  Id =6 ,Name= "Mita Shah", Type ="G" , Address="Surat"}
        };

        public List<Domain.Domain.Member> GetAllMembers()
        {
            return lstMembers;
        }
    }
}
