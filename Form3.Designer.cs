namespace Consultorio
{
    partial class cadastro_paciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro_paciente));
            System.Windows.Forms.Label iDPACIENTELabel;
            System.Windows.Forms.Label pACIENTELabel;
            System.Windows.Forms.Label tELEFONELabel;
            this.consultorioDataSet = new Consultorio.consultorioDataSet();
            this.cadastro_pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastro_pacienteTableAdapter = new Consultorio.consultorioDataSetTableAdapters.cadastro_pacienteTableAdapter();
            this.tableAdapterManager = new Consultorio.consultorioDataSetTableAdapters.TableAdapterManager();
            this.cadastro_pacienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cadastro_pacienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDPACIENTELabel1 = new System.Windows.Forms.Label();
            this.pACIENTETextBox = new System.Windows.Forms.TextBox();
            this.tELEFONETextBox = new System.Windows.Forms.TextBox();
            iDPACIENTELabel = new System.Windows.Forms.Label();
            pACIENTELabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_pacienteBindingNavigator)).BeginInit();
            this.cadastro_pacienteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultorioDataSet
            // 
            this.consultorioDataSet.DataSetName = "consultorioDataSet";
            this.consultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastro_pacienteBindingSource
            // 
            this.cadastro_pacienteBindingSource.DataMember = "cadastro_paciente";
            this.cadastro_pacienteBindingSource.DataSource = this.consultorioDataSet;
            // 
            // cadastro_pacienteTableAdapter
            // 
            this.cadastro_pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cadastro_medicoTableAdapter = null;
            this.tableAdapterManager.cadastro_pacienteTableAdapter = this.cadastro_pacienteTableAdapter;
            this.tableAdapterManager.consultaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Consultorio.consultorioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadastro_pacienteBindingNavigator
            // 
            this.cadastro_pacienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadastro_pacienteBindingNavigator.BindingSource = this.cadastro_pacienteBindingSource;
            this.cadastro_pacienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadastro_pacienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cadastro_pacienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cadastro_pacienteBindingNavigatorSaveItem});
            this.cadastro_pacienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadastro_pacienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadastro_pacienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadastro_pacienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadastro_pacienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadastro_pacienteBindingNavigator.Name = "cadastro_pacienteBindingNavigator";
            this.cadastro_pacienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cadastro_pacienteBindingNavigator.Size = new System.Drawing.Size(625, 25);
            this.cadastro_pacienteBindingNavigator.TabIndex = 0;
            this.cadastro_pacienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // cadastro_pacienteBindingNavigatorSaveItem
            // 
            this.cadastro_pacienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadastro_pacienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastro_pacienteBindingNavigatorSaveItem.Image")));
            this.cadastro_pacienteBindingNavigatorSaveItem.Name = "cadastro_pacienteBindingNavigatorSaveItem";
            this.cadastro_pacienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cadastro_pacienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cadastro_pacienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadastro_pacienteBindingNavigatorSaveItem_Click);
            // 
            // iDPACIENTELabel
            // 
            iDPACIENTELabel.AutoSize = true;
            iDPACIENTELabel.Location = new System.Drawing.Point(82, 134);
            iDPACIENTELabel.Name = "iDPACIENTELabel";
            iDPACIENTELabel.Size = new System.Drawing.Size(124, 13);
            iDPACIENTELabel.TabIndex = 1;
            iDPACIENTELabel.Text = "CÓDIGO DO PACIENTE";
            // 
            // iDPACIENTELabel1
            // 
            this.iDPACIENTELabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastro_pacienteBindingSource, "IDPACIENTE", true));
            this.iDPACIENTELabel1.Location = new System.Drawing.Point(210, 124);
            this.iDPACIENTELabel1.Name = "iDPACIENTELabel1";
            this.iDPACIENTELabel1.Size = new System.Drawing.Size(100, 23);
            this.iDPACIENTELabel1.TabIndex = 2;
            // 
            // pACIENTELabel
            // 
            pACIENTELabel.AutoSize = true;
            pACIENTELabel.Location = new System.Drawing.Point(82, 202);
            pACIENTELabel.Name = "pACIENTELabel";
            pACIENTELabel.Size = new System.Drawing.Size(63, 13);
            pACIENTELabel.TabIndex = 3;
            pACIENTELabel.Text = "PACIENTE:";
            // 
            // pACIENTETextBox
            // 
            this.pACIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastro_pacienteBindingSource, "PACIENTE", true));
            this.pACIENTETextBox.Location = new System.Drawing.Point(213, 202);
            this.pACIENTETextBox.Name = "pACIENTETextBox";
            this.pACIENTETextBox.Size = new System.Drawing.Size(100, 20);
            this.pACIENTETextBox.TabIndex = 4;
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Location = new System.Drawing.Point(82, 266);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(66, 13);
            tELEFONELabel.TabIndex = 5;
            tELEFONELabel.Text = "TELEFONE:";
            // 
            // tELEFONETextBox
            // 
            this.tELEFONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastro_pacienteBindingSource, "TELEFONE", true));
            this.tELEFONETextBox.Location = new System.Drawing.Point(213, 259);
            this.tELEFONETextBox.Name = "tELEFONETextBox";
            this.tELEFONETextBox.Size = new System.Drawing.Size(100, 20);
            this.tELEFONETextBox.TabIndex = 6;
            // 
            // cadastro_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(tELEFONELabel);
            this.Controls.Add(this.tELEFONETextBox);
            this.Controls.Add(pACIENTELabel);
            this.Controls.Add(this.pACIENTETextBox);
            this.Controls.Add(iDPACIENTELabel);
            this.Controls.Add(this.iDPACIENTELabel1);
            this.Controls.Add(this.cadastro_pacienteBindingNavigator);
            this.Name = "cadastro_paciente";
            this.Text = "Cadastro do Paciente";
            this.Load += new System.EventHandler(this.cadastro_paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_pacienteBindingNavigator)).EndInit();
            this.cadastro_pacienteBindingNavigator.ResumeLayout(false);
            this.cadastro_pacienteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private consultorioDataSet consultorioDataSet;
        private System.Windows.Forms.BindingSource cadastro_pacienteBindingSource;
        private consultorioDataSetTableAdapters.cadastro_pacienteTableAdapter cadastro_pacienteTableAdapter;
        private consultorioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadastro_pacienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cadastro_pacienteBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iDPACIENTELabel1;
        private System.Windows.Forms.TextBox pACIENTETextBox;
        private System.Windows.Forms.TextBox tELEFONETextBox;
    }
}