using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chain
{
    public class Train
    {
        private TrainWagon firstWagon;
        private TrainWagon lastWagon;

        private class TrainWagon
        {
            public int Number { get; set; }
            public string Type { get; set; }
            public TrainWagon PrevWagon { get; set; }
            public TrainWagon NextWagon { get; set; }
        }

        public void AddWagon(int wagonCount, string wagonType)
        {
            for (int i = 0; i < wagonCount; i++)
            {
                var wagon = new TrainWagon()
                {
                    Number = GetWagonCount() + 1,
                    Type = wagonType
                };
                if (lastWagon == null)
                {
                    firstWagon = wagon;
                    lastWagon = wagon;
                }
                else
                {
                    lastWagon.NextWagon = wagon;
                    wagon.PrevWagon = lastWagon;
                    lastWagon = wagon;
                }
            }
        }

        public int GetWagonCount()
        {
            int count = 0;
            var wagon = firstWagon;
            while (wagon != null)
            {
                count++;
                wagon = wagon.NextWagon;
                //lastWagon.NextWagon = wagon;
            }
            return count;
        }

        public string GetAllWagons()
        {
            var s = new StringBuilder();
            var wagon = firstWagon;
            while (wagon != null)
            {
                s.AppendLine($"Вагон {wagon.Number} ({wagon.Type})");
                wagon = wagon.NextWagon;
            }
            return s.ToString();
        }
    }



}
