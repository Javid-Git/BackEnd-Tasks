using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_To_Back_practice.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string FullName { get; set; }
        public string Describtion { get; set; }
        public Nullable<int> PositionId { get; set; }
        public Position Position { get; set; }
    }
}
