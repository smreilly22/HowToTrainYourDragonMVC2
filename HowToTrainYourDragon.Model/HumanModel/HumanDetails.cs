using HowToTrainYourDragon.Data;
using HowToTrainYourDragon.Model.DragonModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model.HumanModel
{
    public class HumanDetails
    {
        [Display(Name = "Human Id")]
        public int HumanId { get; set; }

        public string Name { get; set; }

        public string Occupation { get; set; } 

        
        public int CurrentLocationId { get; set; }

        public int? DragonCompanionId { get; set; }

        public  DragonDetails Dragon { get; set; }

        [Display(Name = "Dragon Companion")]
        public string DragonCompanion { get; set; }

        [Display(Name = "Current Location")]
        public string CurrentLocation { get; set; }

        [Display(Name = "Hero or Villian")]
        public bool IsEvil { get; set; }

        public byte[] Image { get; set; }

        [Display(Name = "Has Dragon")]
        public bool HasDragon { get; set; }

        public string Gender { get; set; }

        [Display(Name = "Hair Color")]
        public string HairColor { get; set; }

        [Display(Name = "Eye Color")]
        public string EyeColor { get; set; }
    }
}
