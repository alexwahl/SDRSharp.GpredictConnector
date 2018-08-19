using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace SDRSharp.GpredictConnector
{
    class Rigctrld
    {
        public string ExecCommand(string command)
        {
            command = command.Replace("\n", String.Empty); // remove line feed from command
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
                    return GenerateReturn(HamlibErrorcode.RIG_OK);
                }
                return GenerateReturn(HamlibErrorcode.RIG_EPROTO); ; //wrong or unknown F command
            }
            else if (command.Equals("f"))
            {
                return FrequencyInHzString + "\n"; //return current freq.
            }
            return GenerateReturn(HamlibErrorcode.RIG_ENIMPL); //recieved unsupported command
        }

        private string GenerateReturn(HamlibErrorcode errorcode)
        {
            return "RPRT " + ((int)errorcode).ToString() + "\n";
        }
        public long FrequencyInHz
        {
            get
            {
                return frequency_;
            }
            set
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


        enum HamlibErrorcode
        {
            RIG_OK = 0,     /*!< No error, operation completed successfully */
            RIG_EINVAL = -1,     /*!< invalid parameter */
            RIG_ECONF = -2,      /*!< invalid configuration (serial,..) */
            RIG_ENOMEM= -3,     /*!< memory shortage */
            RIG_ENIMPL = -4,     /*!< function not implemented, but will be */
            RIG_ETIMEOUT = -5,   /*!< communication timed out */
            RIG_EIO = -6,        /*!< IO error, including open failed */
            RIG_EINTERNAL = -7,  /*!< Internal Hamlib error, huh! */
            RIG_EPROTO = -8,     /*!< Protocol error */
            RIG_ERJCTED = -9,    /*!< Command rejected by the rig */
            RIG_ETRUNC = -10,     /*!< Command performed, but arg truncated */
            RIG_ENAVAIL = -11,    /*!< function not available */
            RIG_ENTARGET = -12,   /*!< VFO not targetable */
            RIG_BUSERROR = -13,   /*!< Error talking on the bus */
            RIG_BUSBUSY = -14,    /*!< Collision on the bus */
            RIG_EARG = -15,       /*!< NULL RIG handle or any invalid pointer parameter in get arg */
            RIG_EVFO = -16,       /*!< Invalid VFO */
            RIG_EDOM = -17       /*!< Argument out of domain of func */
        };
    }
}
