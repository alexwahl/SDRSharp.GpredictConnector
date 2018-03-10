using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDRSharp.GpredictConnector
{
    enum Errcode
    {
        RIG_OK = 0,     /*!< No error, operation completed successfully */
        RIG_EINVAL,     /*!< invalid parameter */
        RIG_ECONF,      /*!< invalid configuration (serial,..) */
        RIG_ENOMEM,     /*!< memory shortage */
        RIG_ENIMPL,     /*!< function not implemented, but will be */
        RIG_ETIMEOUT,   /*!< communication timed out */
        RIG_EIO,        /*!< IO error, including open failed */
        RIG_EINTERNAL,  /*!< Internal Hamlib error, huh! */
        RIG_EPROTO,     /*!< Protocol error */
        RIG_ERJCTED,    /*!< Command rejected by the rig */
        RIG_ETRUNC,     /*!< Command performed, but arg truncated */
        RIG_ENAVAIL,    /*!< function not available */
        RIG_ENTARGET,   /*!< VFO not targetable */
        RIG_BUSERROR,   /*!< Error talking on the bus */
        RIG_BUSBUSY,    /*!< Collision on the bus */
        RIG_EARG,       /*!< NULL RIG handle or any invalid pointer parameter in get arg */
        RIG_EVFO,       /*!< Invalid VFO */
        RIG_EDOM        /*!< Argument out of domain of func */
    };

    class Rigctrld
    {
        
        private string GenAnswer(Errcode code)
        {
            return "RPRT " + ((int)code).ToString() + "\n";
        }

        public string ExecCommand(string command)
        {
            var answer = GenAnswer(Errcode.RIG_OK);
            if (command.StartsWith("F"))
            {
                answer = SetFrequency(command);
            }
            return answer;
        }

        private string SetFrequency(string command)
        {
            var f_string = command.Substring(3, 9);
            frequency_set_thread_ = new Thread(() => FrequencyInHzString = f_string);
            frequency_set_thread_.Start();          
            return GenAnswer(Errcode.RIG_OK); 
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
