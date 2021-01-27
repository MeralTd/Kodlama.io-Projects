using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
