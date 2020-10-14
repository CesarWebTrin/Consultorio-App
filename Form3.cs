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
    public partial class cadastro_paciente : Form
    {
        public cadastro_paciente()
        {
            InitializeComponent();
        }

        private void cadastro_pacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastro_pacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

        }

        private void cadastro_paciente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultorioDataSet.cadastro_paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_pacienteTableAdapter.Fill(this.consultorioDataSet.cadastro_paciente);

        }
    }
}
