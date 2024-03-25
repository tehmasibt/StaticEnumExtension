using StaticEnumExtension.Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticEnumExtension.Service.Interface
{
    public interface IAccount
    {
        void AccessApp(string email, string password, Roles role);
        bool CheckRole(Roles role);
    }
}
