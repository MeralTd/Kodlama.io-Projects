using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int Price { get; set; }
    }
}
