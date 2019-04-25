using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.DTO.DTO
{
   public class RoleDTO
    {
        public int RoleId { get; set; }

        [Column("Role")]
        [StringLength(50)]
        public string Role1 { get; set; }
    }
}
