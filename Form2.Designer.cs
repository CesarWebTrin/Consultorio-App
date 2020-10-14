namespace Consultorio
{
    partial class cadastro_medico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro_medico));
            System.Windows.Forms.Label iDMEDICOLabel;
            System.Windows.Forms.Label mEDICOLabel;
            System.Windows.Forms.Label cRMLabel;
            this.consultorioDataSet = new Consultorio.consultorioDataSet();
            this.cadastro_medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastro_medicoTableAdapter = new Consultorio.consultorioDataSetTableAdapters.cadastro_medicoTableAdapter();
            this.tableAdapterManager = new Consultorio.consultorioDataSetTableAdapters.TableAdapterManager();
            this.cadastro_medicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cadastro_medicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDMEDICOLabel1 = new System.Windows.Forms.Label();
            this.mEDICOTextBox = new System.Windows.Forms.TextBox();
            this.cRMTextBox = new System.Windows.Forms.TextBox();
            iDMEDICOLabel = new System.Windows.Forms.Label();
            mEDICOLabel = new System.Windows.Forms.Label();
            cRMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_medicoBindingNavigator)).BeginInit();
            this.cadastro_medicoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultorioDataSet
            // 
            this.consultorioDataSet.DataSetName = "consultorioDataSet";
            this.consultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastro_medicoBindingSource
            // 
            this.cadastro_medicoBindingSource.DataMember = "cadastro_medico";
            this.cadastro_medicoBindingSource.DataSource = this.consultorioDataSet;
            // 
            // cadastro_medicoTableAdapter
            // 
            this.cadastro_medicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cadastro_medicoTableAdapter = this.cadastro_medicoTableAdapter;
            this.tableAdapterManager.cadastro_pacienteTableAdapter = null;
            this.tableAdapterManager.consultaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Consultorio.consultorioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadastro_medicoBindingNavigator
            // 
            this.cadastro_medicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadastro_medicoBindingNavigator.BindingSource = this.cadastro_medicoBindingSource;
            this.cadastro_medicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadastro_medicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cadastro_medicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cadastro_medicoBindingNavigatorSaveItem});
            this.cadastro_medicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadastro_medicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadastro_medicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadastro_medicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadastro_medicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadastro_medicoBindingNavigator.Name = "cadastro_medicoBindingNavigator";
            this.cadastro_medicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cadastro_medicoBindingNavigator.Size = new System.Drawing.Size(716, 25);
            this.cadastro_medicoBindingNavigator.TabIndex = 0;
            this.cadastro_medicoBindingNavigator.Text = "bindingNavigator1";
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
            // cadastro_medicoBindingNavigatorSaveItem
            // 
            this.cadastro_medicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadastro_medicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastro_medicoBindingNavigatorSaveItem.Image")));
            this.cadastro_medicoBindingNavigatorSaveItem.Name = "cadastro_medicoBindingNavigatorSaveItem";
            this.cadastro_medicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cadastro_medicoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cadastro_medicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadastro_medicoBindingNavigatorSaveItem_Click);
            // 
            // iDMEDICOLabel
            // 
            iDMEDICOLabel.AutoSize = true;
            iDMEDICOLabel.Location = new System.Drawing.Point(78, 123);
            iDMEDICOLabel.Name = "iDMEDICOLabel";
            iDMEDICOLabel.Size = new System.Drawing.Size(116, 13);
            iDMEDICOLabel.TabIndex = 1;
            iDMEDICOLabel.Text = "CÓDIGO DO MEDICO:";
            // 
            // iDMEDICOLabel1
            // 
            this.iDMEDICOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastro_medicoBindingSource, "IDMEDICO", true));
            this.iDMEDICOLabel1.Location = new System.Drawing.Point(190, 113);
            this.iDMEDICOLabel1.Name = "iDMEDICOLabel1";
            this.iDMEDICOLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDMEDICOLabel1.TabIndex = 2;
            // 
            // mEDICOLabel
            // 
            mEDICOLabel.AutoSize = true;
            mEDICOLabel.Location = new System.Drawing.Point(78, 187);
            mEDICOLabel.Name = "mEDICOLabel";
            mEDICOLabel.Size = new System.Drawing.Size(52, 13);
            mEDICOLabel.TabIndex = 3;
            mEDICOLabel.Text = "MEDICO:";
            // 
            // mEDICOTextBox
            // 
            this.mEDICOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastro_medicoBindingSource, "MEDICO", true));
            this.mEDICOTextBox.Location = new System.Drawing.Point(190, 187);
            this.mEDICOTextBox.Name = "mEDICOTextBox";
            this.mEDICOTextBox.Size = new System.Drawing.Size(100, 20);
            this.mEDICOTextBox.TabIndex = 4;
            // 
            // cRMLabel
            // 
            cRMLabel.AutoSize = true;
            cRMLabel.Location = new System.Drawing.Point(78, 268);
            cRMLabel.Name = "cRMLabel";
            cRMLabel.Size = new System.Drawing.Size(34, 13);
            cRMLabel.TabIndex = 5;
            cRMLabel.Text = "CRM:";
            // 
            // cRMTextBox
            // 
            this.cRMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastro_medicoBindingSource, "CRM", true));
            this.cRMTextBox.Location = new System.Drawing.Point(190, 261);
            this.cRMTextBox.Name = "cRMTextBox";
            this.cRMTextBox.Size = new System.Drawing.Size(100, 20);
            this.cRMTextBox.TabIndex = 6;
            // 
            // cadastro_medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 454);
            this.Controls.Add(cRMLabel);
            this.Controls.Add(this.cRMTextBox);
            this.Controls.Add(mEDICOLabel);
            this.Controls.Add(this.mEDICOTextBox);
            this.Controls.Add(iDMEDICOLabel);
            this.Controls.Add(this.iDMEDICOLabel1);
            this.Controls.Add(this.cadastro_medicoBindingNavigator);
            this.Name = "cadastro_medico";
            this.Text = "Cadastro do Médico";
            this.Load += new System.EventHandler(this.cadastro_medico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_medicoBindingNavigator)).EndInit();
            this.cadastro_medicoBindingNavigator.ResumeLayout(false);
            this.cadastro_medicoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private consultorioDataSet consultorioDataSet;
        private System.Windows.Forms.BindingSource cadastro_medicoBindingSource;
        private consultorioDataSetTableAdapters.cadastro_medicoTableAdapter cadastro_medicoTableAdapter;
        private consultorioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadastro_medicoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cadastro_medicoBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iDMEDICOLabel1;
        private System.Windows.Forms.TextBox mEDICOTextBox;
        private System.Windows.Forms.TextBox cRMTextBox;
    }
}