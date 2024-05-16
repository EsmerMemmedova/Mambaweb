using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Core.Models
{
    public class Team:BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(70)]
        public string Profession { get; set; }
       public string? ImgUrl { get; set; }
        [NotMapped]
        public IFormFile ImgFile { get; set; }


    }
}
