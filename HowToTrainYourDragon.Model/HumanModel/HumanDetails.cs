using HowToTrainYourDragon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model.HumanModel
{
    public class HumanDetails
    {
        public int HumanId { get; set; }

        public string Name { get; set; }

        public string Occupation { get; set; } 

        

        public int CurrentLocationId { get; set; }

        public int? DragonCompanionId { get; set; }

        public virtual Dragon Dragon { get; set; }

        public string DragonCompanion { get; set; }

        public string CurrentLocation { get; set; }

        public bool IsEvil { get; set; }

        public byte[] Image { get; set; }
    }
}
