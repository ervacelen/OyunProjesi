using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjesi.Concrete
{
    class Gamer
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public int BirthYear { get; set; }
        public long IdentityNumber { get; set; }
        public string FirstName { get; internal set; }
    }
}
