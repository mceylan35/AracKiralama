using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Dal.Abstract;
using AracKiralama.Dal.Concrete.EntityFramework.Context;
using AracKiralama.Entities;

namespace AracKiralama.Dal.Concrete.EntityFramework.Repository
{
    public class EfRoleRepository:EfGenericRepository<Role>,IRoleRepository
    {
        public EfRoleRepository()
        {
            context=new AracKiralamaContext();
        }
     
    }
}
