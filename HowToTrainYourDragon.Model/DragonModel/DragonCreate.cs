using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model.DragonModel
{
    public class DragonCreate
    {
        public string DragonType { get; set; }

        public string Description { get; set; }

       

        public int LocationId { get; set; }

        public byte[] Image { get; set; }


    }
}
