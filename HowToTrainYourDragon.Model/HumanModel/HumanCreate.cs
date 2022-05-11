using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model.HumanModel
{
    public class HumanCreate
    {
        public string Name { get; set; }

        public string Occupation { get; set; }

       

        public int CurrentLocationId { get; set; }

        public int? DragonCompanionId { get; set; }

        public bool IsEvil { get; set; }

        public byte[] Image { get; set; }
    }
}
