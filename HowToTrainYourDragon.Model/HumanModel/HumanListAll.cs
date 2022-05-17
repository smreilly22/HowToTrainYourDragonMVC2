using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model.HumanModel
{
    public class HumanListAll
    {
        [Display(Name = "Human Id")]
        public int HumanId { get; set; }

        public string Name { get; set; }

        [Display(Name = "Has Dragon")]
        public bool HasDragon { get; set; }
    }
}
