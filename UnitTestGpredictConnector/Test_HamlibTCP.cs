using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDRSharp.GpredictConnector;
using SDRSharp.Common;
using SDRSharp.PanView;
using SDRSharp.Radio;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace UnitTestHamlibTCP
{
    /// <summary>
    /// Zusammenfassungsbeschreibung für Test_HamlibTCP
    /// </summary>
    [TestClass]
    public class Test_HamlibTCP
    {
        class Mock_ISharpControl : ISharpControl
        {
            public DetectorType DetectorType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public WindowType FilterType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int AudioGain { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public long CenterFrequency { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int CWShift { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool FilterAudio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool UnityGain { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int FilterBandwidth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int FilterOrder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool FmStereo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public long Frequency { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public long FrequencyShift { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool FrequencyShiftEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool MarkPeaks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool SnapToGrid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool SquelchEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int SquelchThreshold { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public bool IsSquelchOpen => throw new NotImplementedException();

            public bool SwapIq { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool UseAgc { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool AgcHang { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int AgcThreshold { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int AgcDecay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int AgcSlope { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int FFTResolution => throw new NotImplementedException();

            public float FFTRange => throw new NotImplementedException();

            public float FFTOffset => throw new NotImplementedException();

            public int FFTContrast => throw new NotImplementedException();

            public float VisualSNR => throw new NotImplementedException();

            public int IFOffset => throw new NotImplementedException();

            public System.Drawing.Drawing2D.ColorBlend Gradient => throw new NotImplementedException();

            public SpectrumStyle FFTSpectrumStyle => throw new NotImplementedException();

            public int StepSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int Zoom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public bool IsPlaying => throw new NotImplementedException();

            public float SAttack { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public float SDecay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public float WAttack { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public float WDecay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool UseTimeMarkers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public string RdsProgramService => throw new NotImplementedException();

            public string RdsRadioText => throw new NotImplementedException();

            public bool RdsUseFEC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int RFBandwidth => throw new NotImplementedException();

            public int RFDisplayBandwidth => throw new NotImplementedException();

            public int TunableBandwidth => throw new NotImplementedException();

            public float TuningLimit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public TuningStyle TuningStyle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool TuningStyleFreezed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public bool SourceIsSoundCard => throw new NotImplementedException();

            public bool SourceIsWaveFile => throw new NotImplementedException();

            public bool SourceIsTunable => throw new NotImplementedException();

            public object Source => throw new NotImplementedException();

            public bool AudioIsMuted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool BypassDemodulation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public Type SourceType => throw new NotImplementedException();

            public string SourceName => throw new NotImplementedException();

            public double AudioSampleRate => throw new NotImplementedException();

            public Color FilterColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int MaximumFilterBandwidth => throw new NotImplementedException();

            public bool FmPilotIsDetected => throw new NotImplementedException();

            public bool ThemeIsDark => throw new NotImplementedException();

            public ushort RdsPICode => throw new NotImplementedException();

            public double InputSampleRate => throw new NotImplementedException();

            public bool SourceIsComplex => throw new NotImplementedException();

            public float AudioPanning { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public event PropertyChangedEventHandler PropertyChanged;
            public event CustomPaintEventHandler WaterfallCustomPaint;
            public event CustomPaintEventHandler SpectrumAnalyzerCustomPaint;
            public event CustomPaintEventHandler SpectrumAnalyzerBackgroundCustomPaint;

            public void GetSpectrumSnapshot(byte[] destArray)
            {
                throw new NotImplementedException();
            }

            public void GetSpectrumSnapshot(float[] destArray, float scale = 1, float offset = 0)
            {
                throw new NotImplementedException();
            }

            public void InvalidateSpectrumGraphics()
            {
                throw new NotImplementedException();
            }

            public void Perform()
            {
                throw new NotImplementedException();
            }

            public void RefreshSource(bool reload)
            {
                throw new NotImplementedException();
            }

            public void RegisterFrontControl(System.Windows.Forms.UserControl control, PluginPosition preferredPosition)
            {
                throw new NotImplementedException();
            }

            public void RegisterFrontControl(Control control, PluginPosition preferredPosition)
            {
                throw new NotImplementedException();
            }

            public void RegisterStreamHook(object streamHook, ProcessorType processorType)
            {
                throw new NotImplementedException();
            }

            public void ResetFrequency(long frequency)
            {
                throw new NotImplementedException();
            }

            public void ResetFrequency(long frequency, long centerFrequency)
            {
                throw new NotImplementedException();
            }

            public void ResetRDS()
            {
                throw new NotImplementedException();
            }

            public void SetFrequency(long frequency, bool onlyMoveCenterFrequency)
            {
                throw new NotImplementedException();
            }

            public void StartRadio()
            {
                throw new NotImplementedException();
            }

            public void StopRadio()
            {
                throw new NotImplementedException();
            }

            public void UnregisterStreamHook(object streamHook)
            {
                throw new NotImplementedException();
            }
        }
        
        [TestMethod]
        public void JustInstanciate()
        {
            try
            {
                GpredictConnectorPlugin hamlibTCPPlugin = new GpredictConnectorPlugin();
            }
            catch
            {
                Assert.Fail("con should never fail..");
            }
        }

        [TestMethod]
        public void CloseWithoutInitialize()
        {
            GpredictConnectorPlugin cut = new GpredictConnectorPlugin();
            cut.Close();

        }

        [TestMethod]
        public void CloseWithInitialize()
        {
            Mock_ISharpControl isc = new Mock_ISharpControl();
            GpredictConnectorPlugin cut = new GpredictConnectorPlugin();
            cut.Initialize(isc);
            cut.Close();

        }
    }
}
