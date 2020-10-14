namespace Consultorio
{
    partial class cadastro_consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro_consulta));
            System.Windows.Forms.Label iDCONSULTALabel;
            System.Windows.Forms.Label cONSULTALabel;
            System.Windows.Forms.Label mEDICOLabel;
            System.Windows.Forms.Label pACIENTELabel;
            System.Windows.Forms.Label dATA_CONSULTALabel;
            this.consultorioDataSet = new Consultorio.consultorioDataSet();
            this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaTableAdapter = new Consultorio.consultorioDataSetTableAdapters.consultaTableAdapter();
            this.tableAdapterManager = new Consultorio.consultorioDataSetTableAdapters.TableAdapterManager();
            this.consultaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.consultaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDCONSULTALabel1 = new System.Windows.Forms.Label();
            this.cONSULTATextBox = new System.Windows.Forms.TextBox();
            this.mEDICOTextBox = new System.Windows.Forms.TextBox();
            this.pACIENTETextBox = new System.Windows.Forms.TextBox();
            this.dATA_CONSULTADateTimePicker = new System.Windows.Forms.DateTimePicker();
            iDCONSULTALabel = new System.Windows.Forms.Label();
            cONSULTALabel = new System.Windows.Forms.Label();
            mEDICOLabel = new System.Windows.Forms.Label();
            pACIENTELabel = new System.Windows.Forms.Label();
            dATA_CONSULTALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).BeginInit();
            this.consultaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultorioDataSet
            // 
            this.consultorioDataSet.DataSetName = "consultorioDataSet";
            this.consultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultaBindingSource
            // 
            this.consultaBindingSource.DataMember = "consulta";
            this.consultaBindingSource.DataSource = this.consultorioDataSet;
            // 
            // consultaTableAdapter
            // 
            this.consultaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cadastro_medicoTableAdapter = null;
            this.tableAdapterManager.cadastro_pacienteTableAdapter = null;
            this.tableAdapterManager.consultaTableAdapter = this.consultaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Consultorio.consultorioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // consultaBindingNavigator
            // 
            this.consultaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultaBindingNavigator.BindingSource = this.consultaBindingSource;
            this.consultaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consultaBindingNavigatorSaveItem});
            this.consultaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultaBindingNavigator.Name = "consultaBindingNavigator";
            this.consultaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.consultaBindingNavigator.TabIndex = 0;
            this.consultaBindingNavigator.Text = "bindingNavigator1";
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
            // consultaBindingNavigatorSaveItem
            // 
            this.consultaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaBindingNavigatorSaveItem.Image")));
            this.consultaBindingNavigatorSaveItem.Name = "consultaBindingNavigatorSaveItem";
            this.consultaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.consultaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.consultaBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultaBindingNavigatorSaveItem_Click);
            // 
            // iDCONSULTALabel
            // 
            iDCONSULTALabel.AutoSize = true;
            iDCONSULTALabel.Location = new System.Drawing.Point(75, 111);
            iDCONSULTALabel.Name = "iDCONSULTALabel";
            iDCONSULTALabel.Size = new System.Drawing.Size(79, 13);
            iDCONSULTALabel.TabIndex = 1;
            iDCONSULTALabel.Text = "IDCONSULTA:";
            // 
            // iDCONSULTALabel1
            // 
            this.iDCONSULTALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "IDCONSULTA", true));
            this.iDCONSULTALabel1.Location = new System.Drawing.Point(226, 111);
            this.iDCONSULTALabel1.Name = "iDCONSULTALabel1";
            this.iDCONSULTALabel1.Size = new System.Drawing.Size(100, 23);
            this.iDCONSULTALabel1.TabIndex = 2;
            // 
            // cONSULTALabel
            // 
            cONSULTALabel.AutoSize = true;
            cONSULTALabel.Location = new System.Drawing.Point(75, 164);
            cONSULTALabel.Name = "cONSULTALabel";
            cONSULTALabel.Size = new System.Drawing.Size(68, 13);
            cONSULTALabel.TabIndex = 3;
            cONSULTALabel.Text = "CONSULTA:";
            // 
            // cONSULTATextBox
            // 
            this.cONSULTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "CONSULTA", true));
            this.cONSULTATextBox.Location = new System.Drawing.Point(226, 161);
            this.cONSULTATextBox.Name = "cONSULTATextBox";
            this.cONSULTATextBox.Size = new System.Drawing.Size(100, 20);
            this.cONSULTATextBox.TabIndex = 4;
            // 
            // mEDICOLabel
            // 
            mEDICOLabel.AutoSize = true;
            mEDICOLabel.Location = new System.Drawing.Point(75, 214);
            mEDICOLabel.Name = "mEDICOLabel";
            mEDICOLabel.Size = new System.Drawing.Size(116, 13);
            mEDICOLabel.TabIndex = 5;
            mEDICOLabel.Text = "CÓDIGO DO MEDICO:";
            // 
            // mEDICOTextBox
            // 
            this.mEDICOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "MEDICO", true));
            this.mEDICOTextBox.Location = new System.Drawing.Point(226, 207);
            this.mEDICOTextBox.Name = "mEDICOTextBox";
            this.mEDICOTextBox.Size = new System.Drawing.Size(100, 20);
            this.mEDICOTextBox.TabIndex = 6;
            // 
            // pACIENTELabel
            // 
            pACIENTELabel.AutoSize = true;
            pACIENTELabel.Location = new System.Drawing.Point(75, 266);
            pACIENTELabel.Name = "pACIENTELabel";
            pACIENTELabel.Size = new System.Drawing.Size(127, 13);
            pACIENTELabel.TabIndex = 7;
            pACIENTELabel.Text = "CÓDIGO DO PACIENTE:";
            // 
            // pACIENTETextBox
            // 
            this.pACIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "PACIENTE", true));
            this.pACIENTETextBox.Location = new System.Drawing.Point(226, 263);
            this.pACIENTETextBox.Name = "pACIENTETextBox";
            this.pACIENTETextBox.Size = new System.Drawing.Size(100, 20);
            this.pACIENTETextBox.TabIndex = 8;
            // 
            // dATA_CONSULTALabel
            // 
            dATA_CONSULTALabel.AutoSize = true;
            dATA_CONSULTALabel.Location = new System.Drawing.Point(75, 304);
            dATA_CONSULTALabel.Name = "dATA_CONSULTALabel";
            dATA_CONSULTALabel.Size = new System.Drawing.Size(100, 13);
            dATA_CONSULTALabel.TabIndex = 9;
            dATA_CONSULTALabel.Text = "DATA CONSULTA:";
            // 
            // dATA_CONSULTADateTimePicker
            // 
            this.dATA_CONSULTADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultaBindingSource, "DATA_CONSULTA", true));
            this.dATA_CONSULTADateTimePicker.Location = new System.Drawing.Point(217, 304);
            this.dATA_CONSULTADateTimePicker.Name = "dATA_CONSULTADateTimePicker";
            this.dATA_CONSULTADateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dATA_CONSULTADateTimePicker.TabIndex = 10;
            // 
            // cadastro_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(dATA_CONSULTALabel);
            this.Controls.Add(this.dATA_CONSULTADateTimePicker);
            this.Controls.Add(pACIENTELabel);
            this.Controls.Add(this.pACIENTETextBox);
            this.Controls.Add(mEDICOLabel);
            this.Controls.Add(this.mEDICOTextBox);
            this.Controls.Add(cONSULTALabel);
            this.Controls.Add(this.cONSULTATextBox);
            this.Controls.Add(iDCONSULTALabel);
            this.Controls.Add(this.iDCONSULTALabel1);
            this.Controls.Add(this.consultaBindingNavigator);
            this.Name = "cadastro_consulta";
            this.Text = "Cadastro da Consulta";
            this.Load += new System.EventHandler(this.cadastro_consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).EndInit();
            this.consultaBindingNavigator.ResumeLayout(false);
            this.consultaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private consultorioDataSet consultorioDataSet;
        private System.Windows.Forms.BindingSource consultaBindingSource;
        private consultorioDataSetTableAdapters.consultaTableAdapter consultaTableAdapter;
        private consultorioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton consultaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iDCONSULTALabel1;
        private System.Windows.Forms.TextBox cONSULTATextBox;
        private System.Windows.Forms.TextBox mEDICOTextBox;
        private System.Windows.Forms.TextBox pACIENTETextBox;
        private System.Windows.Forms.DateTimePicker dATA_CONSULTADateTimePicker;
    }
}