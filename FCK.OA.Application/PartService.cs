using FCK.OA.EntityFramework.Model;
using FCK.OA.Repositories;


namespace FCK.OA.Application
{
    public class PartService: RossOAppBase
    {
        public readonly IRepository<Part, long> Reposity;
        public PartService()
        {
            Reposity = new Repository<Part, long>(dbContext);
        }
    }
}
