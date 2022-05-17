using HowToTrainYourDragon.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model.DragonModel
{
    public class DragonDetails
    {
        [Key]
        public int DragonId { get; set; }

        [Display(Name = "Dragon Species")]
        public string DragonType { get; set; }

        public string Color { get; set; }

        public int CurrentLocationId { get; set; }

        [Display(Name = "Current Location")]
        public string LocationName { get; set; }

        public byte[] Image { get; set; }

        [Display(Name = "Length(in meters)")]
        public double SizeLength { get; set; }

        [Display(Name ="Height(in meters)")]
        public double SizeHeight { get; set; }

        [Display(Name ="Weigth(in kiloggrams)")]
        public double Weight { get; set; }
        
        [Display(Name = "Wingspan(in meters)")]
        public double WingSpan { get; set; }

        [Display(Name = "Fire Type")]
        public string FireType { get; set; }

        [Display(Name = "Dragon Class")]
        public ClassType DragonClass { get; set; }

        //Stats
        public int Attack { get; set; }

        public int Speed { get; set; }

        public int Armor { get; set; }

        [Display(Name = "Fire Power")]
        public int FirePower { get; set; }

        [Display(Name = "Shot Limit")]
        public int ShotLimit { get; set; }

        public int Venom { get; set; }

        [Display(Name = "Jaw Strength")]
        public int JawStrength { get; set; }

        public int Stealth { get; set; }

    }
}
