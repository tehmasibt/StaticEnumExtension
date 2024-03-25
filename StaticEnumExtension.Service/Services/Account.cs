using StaticEnumExtension.Service.ConstantAccount;
using StaticEnumExtension.Service.Enums;
using StaticEnumExtension.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticEnumExtension.Service.Services
{
    public class Account : IAccount
    {
        public void AccessApp(string email, string password, Roles role)
        {
            if (email == Constants.Email && password == Constants.Password)
            {
                if(CheckRole(role))
                {
                    Console.WriteLine(Constants.SuccessMessage);
                }
                else
                {
                    Console.WriteLine(Constants.NoPermission);
                }
            }            
            else
            {
                Console.WriteLine(Constants.FailMessage);
            }
        }

        public bool CheckRole(Roles role)
        {
            if (role==Roles.SuperAdmin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }       
    }
}
