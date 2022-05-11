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

        public string Description { get; set; }

       

        public int CurrentLocatonId { get; set; }

        public byte[] Image { get; set; }
    }
}
