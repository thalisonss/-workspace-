using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workspace__
{
    public partial class frmConfiguracoes : Form
    {
        SpeechSynthesizer sintetizador = new SpeechSynthesizer();
        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        private void frmConfiguracoes_Load(object sender, EventArgs e)
        {
            cboVozes.Text = Properties.Settings.Default.Voz;

            foreach(InstalledVoice voz in sintetizador.GetInstalledVoices())
            {
                VoiceInfo info = voz.VoiceInfo;
                string nomeVoz = info.Name;
                cboVozes.Items.Add(nomeVoz);
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Voz = cboVozes.Text;
        }
    }
}
