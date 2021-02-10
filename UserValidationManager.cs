
using OyunProjesi.Entities;
using OyunProjesi.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace OyunProjesi.Manager 
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1993 && gamer.FirstName == "Erva" &&   gamer.IdentityNumber == 123456)
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
