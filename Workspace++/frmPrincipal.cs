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
    public partial class frmPrincipal : Form
    {
        SpeechSynthesizer sintetizador = new SpeechSynthesizer();
        string horaAtual = DateTime.Now.ToLongTimeString();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            sintetizador.Speak($"Boa tarde, agora é exatamente {horaAtual}");
        }

        private void timerHorario_Tick(object sender, EventArgs e)
        {
            horaAtual = DateTime.Now.ToLongTimeString();
            lblHorario.Text = horaAtual;
        }
    }
}
