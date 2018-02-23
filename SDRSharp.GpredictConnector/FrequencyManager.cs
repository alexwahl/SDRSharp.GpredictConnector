using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDRSharp.GpredictConnector
{
    class FrequencyManager
    {
        public void SetFreqFromOutside(long freq)
        {
            RxFreqChanged?.Invoke(freq);
            
        }

        public event Action<long> RxFreqChanged;

    }
}
