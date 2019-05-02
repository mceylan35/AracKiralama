using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Dal.Abstract;
using AracKiralama.Entities;
using AracKiralama.Interfaces;

namespace AracKiralama.Bll
{
    public class RoleManager:GenericManager<Role>,IRoleService
    {
        private IRoleRepository roleRepository;

        public RoleManager(IRoleRepository _roleRepository) : base(_roleRepository)
        {
            roleRepository = _roleRepository;
        }

        
        }
}
