using System;
using System.Collections.Generic;

namespace Epam.OOP
{
    public class Transmission
    {
        Random random = new Random();

        public string type;
        public int count;
        public string creator;

        List<string> randTransmissionType = new List<string>() { "Mechanical", "Automatic", "Robotic", "Variable" };
        List<string> randTransmissionCreator = new List<string>() { "BMW", "Bonfiglioli", "HydroTechService", "OMSI Trasmissioni S.p.A.", "FPT Industrial S.p.A.", "Shenzhen ZhaoWei Machinery & Electronics Co., Lt" };

        public Transmission()
        {
            type = randTransmissionType[random.Next(randTransmissionType.Count)];
            count = random.Next(2, 9);
            creator = randTransmissionCreator[random.Next(randTransmissionCreator.Count)];
        }

        public Transmission(string type, int count, string creator)
        {
            this.type = type;
            this.count = count;
            this.creator = creator;
        }
    }
}
