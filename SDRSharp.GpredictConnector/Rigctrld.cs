using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace SDRSharp.GpredictConnector
{
    class Rigctrld
    {
        public string ExecCommand(string command)
        {
            if (command.StartsWith("F"))
            {
                Regex regex = new Regex("^F[ ]*([0-9]{1,})$");
                var matches = regex.Matches(command);
                if (matches.Count > 0)
                {
                    if (matches[0].Groups.Count == 2)
                    {
                        var f_string = matches[0].Groups[1].Value;
                        frequency_set_thread_ = new Thread(() => FrequencyInHzString = f_string);
                        frequency_set_thread_.Start();
                    }
                    return "RPRT 0\\n";
                }
                return "RPRT -8\\n"; //wrong or unknown F command
            }
            else if (command.StartsWith("f"))
            {
                return FrequencyInHzString + "\\n"; //return current freq.
            }
            return "RPRT -4\\n"; //recieved unsupported command
        }

        public long FrequencyInHz
        {
            get
            {
                return frequency_;
            }
            private set
            {
                if (frequency_ != value)
                {
                    frequency_ = value;
                    FrequencyInHzChanged?.Invoke(frequency_);
                }
                
            }
        }

        public string FrequencyInHzString
        {
            get
            {
                return FrequencyInHz.ToString();
            }
            private set
            {
                try
                {
                    FrequencyInHz = long.Parse(value);
                }
                catch { }
            }
        }

        public event Action<long> FrequencyInHzChanged;

        private long frequency_ = 0;
        private Thread frequency_set_thread_ = null;
        public Thread FrequencySetThread
        {
            get
            {
                return frequency_set_thread_;
            }
        }
    }
}
