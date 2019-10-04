using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Dsp;

namespace MicMuter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        BufferedWaveProvider BufferedWave;

        WaveIn WaveIn = null;
        WaveOut WaveOut;

        private void Btn_startmuter_Click(object sender, EventArgs e)
        {
            if (WaveIn != null)
            {
                MessageBox.Show("Muter Already started.");
                return;
            }

            if (cbox_mic.SelectedItem == null)
            {
                MessageBox.Show("Mic not selected");
                return;
            }
            else if (cbox_out.SelectedItem == null)
            {
                MessageBox.Show("Output not selected");
                return;
            }

            WaveIn = new WaveIn();
            WaveIn.DeviceNumber = cbox_mic.SelectedIndex;
            WaveOut = new WaveOut();
            WaveOut.DeviceNumber = cbox_out.SelectedIndex;

            BufferedWave = new BufferedWaveProvider(WaveIn.WaveFormat);
            BufferedWave.DiscardOnBufferOverflow = true;

            WaveIn.DataAvailable += WaveIn_DataAvailable;

            WaveOut.Init(BufferedWave);
            WaveIn.StartRecording();
            WaveOut.Play();

            lbl_muterenb.Text = "Muter Started";
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            // Original Code: https://github.com/naudio/NAudio/blob/792d3cc0ea51cac8d5b8510b3b68268a8a697ae8/Docs/RecordingLevelMeter.md
            float max = 0;
            // interpret as 16 bit audio
            for (int index = 0; index < e.BytesRecorded; index += 2)
            {
                short sample = (short)((e.Buffer[index + 1] << 8) |
                                        e.Buffer[index + 0]);
                // to floating point
                var sample32 = Math.Abs(sample / 32768f);
                // is this the max value?
                if (sample32 > max) max = sample32;
            }

            int lvl = (int)(max * 100);
            lmt_mic.Value = (int)(max * 100);

            if (lvl > sbar_micminlvl.Value)
            {
                BufferedWave.AddSamples(e.Buffer, 0, e.BytesRecorded);
            }
            else
            {
                BufferedWave.AddSamples(new byte[e.BytesRecorded], 0, e.BytesRecorded);
            }
        }

        private void Btn_stopmuter_Click(object sender, EventArgs e)
        {
            if (WaveIn == null)
            {
                MessageBox.Show("Muter not started.");
                return;
            }

            WaveIn.StopRecording();
            WaveIn.Dispose();
            WaveOut.Stop();
            WaveOut.Dispose();
            BufferedWave.ClearBuffer();

            WaveIn = null;
            lbl_muterenb.Text = "Muter Stopped";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Btn_updatedev_Click(null, null);
        }

        private void Btn_updatedev_Click(object sender, EventArgs e)
        {
            cbox_mic.Items.Clear();
            cbox_out.Items.Clear();

            int ids = WaveIn.DeviceCount;
            for (int id = 0; id < ids; id++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(id);
                cbox_mic.Items.Add(deviceInfo.ProductName);
            }

            int ods = WaveOut.DeviceCount;
            for (int od = 0; od < ods; od++)
            {
                WaveOutCapabilities deviceInfo = WaveOut.GetCapabilities(od);
                cbox_out.Items.Add(deviceInfo.ProductName);
            }
        }
    }
}
