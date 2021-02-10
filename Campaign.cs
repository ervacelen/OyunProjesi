using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjesi.Concrete 
{
    class Campaign : ICampaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }

    }
}
