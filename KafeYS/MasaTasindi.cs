using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYS
{
    public class MasaTasindi:EventArgs
    {
        public MasaTasindi(int eskiMasaNo, int yeniMasaNo)
        {
            EskiMasaNo = eskiMasaNo;
            YeniMasaNo = yeniMasaNo;
        }

        public int EskiMasaNo { get; private set; }
        public int YeniMasaNo { get; private set; }
    }
}
