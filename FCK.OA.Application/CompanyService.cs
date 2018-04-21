using FCK.OA.EntityFramework.Model;
using FCK.OA.Repositories;

namespace FCK.OA.Application
{
    public class CompanyService: RossOAppBase
    {
        public readonly IRepository<Company, int> Reposity;
        public CompanyService()
        {
            Reposity = new Repository<Company, int>(dbContext);
        }
    }
}
