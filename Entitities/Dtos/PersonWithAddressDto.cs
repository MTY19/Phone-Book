using Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitities.Dtos
{
    public class PersonWithAddressDto
    {
        public Person person { get; set; }
        public List<PersonAddress> adress { get; set; }
    }
}
