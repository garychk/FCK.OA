using FCK.OA.EntityFramework.Model;
using FCK.OA.Repositories;

namespace FCK.OA.Application
{
    public class CategoryService: RossOAppBase
    {
        public readonly IRepository<Categories, int> Reposity;
        public CategoryService()
        {
            Reposity = new Repository<Categories, int>(dbContext);
        }
    }
}
