using HowToTrainYourDragon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model.DragonModel
{
    public class DragonEdit
    {
        public int DragonId { get; set; }

        public string DragonType { get; set; }

        public string Color { get; set; }

        public int CurrentLocatonId { get; set; }

        public byte[] Image { get; set; }

        public double SizeLength { get; set; }

        public double SizeHeight { get; set; }

        public double Weight { get; set; }

        public double WingSpan { get; set; }

        public string FireType { get; set; }

        public ClassType DragonClass { get; set; }

        //Stats
        public int Attack { get; set; }

        public int Speed { get; set; }

        public int Armor { get; set; }

        public int FirePower { get; set; }

        public int ShotLimit { get; set; }

        public int Venom { get; set; }

        public int JawStrength { get; set; }

        public int Stealth { get; set; }
    }
}
