using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitities.Concrete
{
    public class PersonAddress : IEntity
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
    }
}
