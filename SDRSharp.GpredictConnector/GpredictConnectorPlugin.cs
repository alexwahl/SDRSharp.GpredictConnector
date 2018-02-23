using SDRSharp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDRSharp.GpredictConnector
{
    public class GpredictConnectorPlugin : ISharpPlugin
    {
        private const string _displayName = "GpredictConnector";
        private Controlpanel _controlpanel;
        private ISharpControl control_;
        private TcpServer tcpServer_;

        public UserControl Gui
        {
            get
            {
                return _controlpanel;
            }
        }

        public string DisplayName
        {
            get
            {
                return _displayName;
            }
        }

        public void Close()
        {
            tcpServer_?.Stop();
        }

        public void Initialize(ISharpControl control)
        {
            control_ = control;

            //Instanciate all needed objects
            _controlpanel = new Controlpanel();          
            Rigctrld rigctrl = new Rigctrld();
            TcpServer tcpServer = new TcpServer(rigctrl);
            tcpServer_ = tcpServer;
            //Link the objects together
            _controlpanel.ServerStart += tcpServer.Start;
            _controlpanel.ServerStop += tcpServer.Stop;
            tcpServer.Connected += _controlpanel.TcpServer_Connected_Changed;
            tcpServer.Enabled += _controlpanel.TcpServer_Enabled_Changed;
            rigctrl.FrequencyInHzChanged += _controlpanel.ReceivedFrequencyInHzChanged;
            rigctrl.FrequencyInHzChanged += Rigctrl_FrequencyInHzChanged;
            
        }

        private void Rigctrl_FrequencyInHzChanged(long frequency)
        {
            control_.Frequency = frequency;
        }
    }
}
