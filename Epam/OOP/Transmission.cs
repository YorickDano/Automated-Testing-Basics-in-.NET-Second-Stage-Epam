using System;

namespace Epam.OOP
{
    public class Transmission
    {
        Random random = new Random();

        public string type;
        public int count;
        public string creator;

        string[] randTransmissionType = { "Mechanical", "Automatic", "Robotic", "Variable" };
        string[] randTransmissionCreator = { "BMW", "Bonfiglioli", "HydroTechService", "OMSI Trasmissioni S.p.A.", "FPT Industrial S.p.A.", "Shenzhen ZhaoWei Machinery & Electronics Co., Lt" };

        public Transmission()
        {
            type = randTransmissionType[random.Next(randTransmissionType.Length)];
            count = random.Next(2, 9);
            creator = randTransmissionCreator[random.Next(randTransmissionCreator.Length)];
        }

        public Transmission(string type, int count, string creator)
        {
            this.type = type;
            this.count = count;
            this.creator = creator;
        }
    }
}
