using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cadastro_medico medico = new cadastro_medico();
            medico.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            cadastro_paciente paciente = new cadastro_paciente();
            paciente.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            cadastro_consulta consulta = new cadastro_consulta();
            consulta.ShowDialog();
        }
    }
}
