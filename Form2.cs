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
    public partial class cadastro_medico : Form
    {
        public cadastro_medico()
        {
            InitializeComponent();
        }

        private void cadastro_medicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastro_medicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

        }

        private void cadastro_medico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultorioDataSet.cadastro_medico'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_medicoTableAdapter.Fill(this.consultorioDataSet.cadastro_medico);

        }
    }
}
