using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LinkTree.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        
        public string Nickname { get; set; }


        public string AvatarUrl { get; set; }

        public DateTime RegDate { get; set; }
    }
}
