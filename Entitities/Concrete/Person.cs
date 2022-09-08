using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitities.Concrete
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public int Tckno { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
    }
}
