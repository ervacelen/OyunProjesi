using OyunProjesi.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjesi.Entities
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
