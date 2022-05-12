using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model.HumanModel
{
    public class HumanEdit
    {
        public int HumanId { get; set; }

        public string Name { get; set; }

        public string Occupation { get; set; }


        public int CurrentLocationId { get; set; }

        public int? DragonCompanionId { get; set; }

        public bool IsEvil { get; set; }

        public byte[] Image { get; set; }

        public bool HasDragon { get; set; }

        public string Gender { get; set; }

        public string HairColor { get; set; }

        public string EyeColor { get; set; }






    }
}

