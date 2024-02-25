using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore_myapi.Service.Dtos
{
    public class CardSearchInfo
    {
        public string Name { get; set; }
        public int? MinAttack { get; set; }
        public int? MaxAttack { get; set; }
        public int? MinHealth { get; set; }
        public int? MaxHealth { get; set; }
        public int? MinCost { get; set; }
        public int? MaxCost { get; set; }
    }
}