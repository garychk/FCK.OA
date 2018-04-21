using FCK.OA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCK.OA.EntityFramework.Model
{
    [Table("Part")]
    public class Part : Entity<long>, ISoftDelete, IMustHaveCompany
    {
        [Required, MaxLength(8)]
        public string Company { get; set; }
        [Required, MaxLength(20)]
        public string PartNum  { get; set; }
        [Required]
        public string PartDesc { get; set; }
        [Required, MaxLength(6)]
        public string IUM { get; set; }
        public bool IsDeleted { get; set; }        
    }
}
