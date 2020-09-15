using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Superheros.Models
{
    public class SuperHeroModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AlterEgoName { get; set; }
        public string PrimaryAbility { get; set; }
        public string SecondAbility { get; set; }
        public string CatchPhrase { get; set; }

    }
}
