using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5HT1_Networking.Models
{
   public class UserJob
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Job { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
