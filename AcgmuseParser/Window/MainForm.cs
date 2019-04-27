using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcgmuseParser.Windows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnBrowser_Click(object sender, EventArgs e)
        {
            var result = openMidiDialog.ShowDialog();
            if (result != DialogResult.Cancel
                && System.IO.File.Exists(openMidiDialog.FileName))
            {
                tbFileName.Text = openMidiDialog.FileName;
            }
        }

        private void TrackBarFirst_Scroll(object sender, EventArgs e)
        {
            trackBarSecond.Minimum = trackBarFirst.Value+1;
            _updateTextSpan();
        }


        private void TrackBarSecond_Scroll(object sender, EventArgs e)
        {
            trackBarThird.Minimum = trackBarSecond.Value+1;
            trackBarFirst.Maximum = trackBarSecond.Value-1;
            _updateTextSpan();
        }

        private void TrackBarThird_Scroll(object sender, EventArgs e)
        {
            trackBarSecond.Maximum = trackBarThird.Value-1;
            _updateTextSpan();
        }
        private void _updateTextSpan()
        {
            lblFirstClass.Text = _generateClassValue(trackBarFirst.Value, trackBarFirst.Maximum);
            lblSecondClass.Text = _generateClassValue(trackBarSecond.Value, trackBarSecond.Maximum);
            lblThirdClass.Text = _generateClassValue(trackBarThird.Value, trackBarThird.Maximum);


        }
        private string _generateClassValue(int cur, int max)
        {
            return cur + " / " + max;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            TrackBarFirst_Scroll(null, null);
            TrackBarSecond_Scroll(null, null);
            TrackBarThird_Scroll(null, null);
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(openMidiDialog.FileName))
            {
                MessageBox.Show("没有输入有效文件。");
                return;
            }
            
                tbOut.BeginInvoke((Action)(()=>{
                    tbOut.Text = Util.MidiConverter.ToJe(openMidiDialog.FileName,
                    trackBarFirst.Value, trackBarSecond.Value, trackBarThird.Value, trackBarOct.Value);
                    btnGo.Enabled = true;
                }));
                btnGo.Enabled = false;
            
            
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbOut.Text);
        }
    }
}
