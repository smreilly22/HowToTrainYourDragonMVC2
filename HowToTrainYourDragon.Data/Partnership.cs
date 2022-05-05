using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Data
{
    public class Partnership
    {
        [Key]
        public int PartnershipId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        
        [ForeignKey(nameof(Human))]
        public int? HumanId { get; set; }

        public virtual Human Human { get; set; }

        
        [ForeignKey(nameof(Dragon))]
        public int? DragonId { get; set; }

        public virtual Dragon Dragon { get; set; }

        public string DragonNickName { get; set; }


    }
}
