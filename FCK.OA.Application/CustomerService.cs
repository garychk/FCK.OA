using FCK.OA.EntityFramework.Model;
using FCK.OA.Repositories;

namespace FCK.OA.Application
{
    public class CustomerService : RossOAppBase
    {
        public readonly IRepository<Customer, int> Reposity;
        public CustomerService()
        {
            Reposity = new Repository<Customer, int>(dbContext);
        }
    }
}
