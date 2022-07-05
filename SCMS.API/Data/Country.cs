using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCMS.API.Data
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ShortName { get; set; }
        [Required]
        [MaxLength(64)]
        public string Name { get; set; }
        [Required]
        public int PhoneCode { get; set; }

        public ICollection<State> States { get; set; }
    }
}
