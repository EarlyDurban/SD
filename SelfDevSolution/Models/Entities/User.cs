using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [MaxLength(128)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Password { get; set; }

        public DateTime? AddedDate { get; set; }

        public DateTime? ActivatedDate { get; set; }

        [MaxLength(128)]
        public string ActivatedLink { get; set; }

        public DateTime? LastVisiteDate { get; set; }

        [MaxLength(128)]
        public string AvatarPAth { get; set; }

        public ICollection<Role> Roles { get; set; }

        public User()
        {
            Roles = new List<Role>();
        }
    }
}
