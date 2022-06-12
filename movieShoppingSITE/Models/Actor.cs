using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movieShoppingSITE.Models
{
    public class Actor
    {
        [Key]
        public int  Id { get; set; }
        [Display(Name ="Profile Picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full name")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }
        //relationships
        public List<Actors_Movies> Actors_Movies { get; set; }
    }
}
