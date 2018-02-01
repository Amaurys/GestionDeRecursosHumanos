namespace GestionDeRecursosHumanos.Views
{
    partial class FrmTraining
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTrainingLevel = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.MaskedTextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTraining = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbInstitute = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpMinSalary = new System.Windows.Forms.DateTimePicker();
            this.dtpMaxSalary = new System.Windows.Forms.DateTimePicker();
            this.recursosHumanosDataSet = new GestionDeRecursosHumanos.recursosHumanosDataSet();
            this.nIVELESCAPACITACIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nIVELESCAPACITACIONESTableAdapter = new GestionDeRecursosHumanos.recursosHumanosDataSetTableAdapters.NIVELESCAPACITACIONESTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHADESDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAHASTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSTITUCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIVELESCAPACITACIONESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "INSTITUCIÓN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "FECHA FINALIZÓ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "FECHA INICIO";
            // 
            // cbTrainingLevel
            // 
            this.cbTrainingLevel.DataSource = this.nIVELESCAPACITACIONESBindingSource;
            this.cbTrainingLevel.DisplayMember = "nombre";
            this.cbTrainingLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrainingLevel.FormattingEnabled = true;
            this.cbTrainingLevel.Location = new System.Drawing.Point(529, 35);
            this.cbTrainingLevel.Name = "cbTrainingLevel";
            this.cbTrainingLevel.Size = new System.Drawing.Size(121, 21);
            this.cbTrainingLevel.TabIndex = 32;
            this.cbTrainingLevel.ValueMember = "id";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(212, 137);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 31;
            this.btnAccept.Text = "ACEPTAR";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "NIVEL DE TRAINING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "NOMBRE";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(195, 35);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(37, 20);
            this.tbId.TabIndex = 28;
            // 
            // tbName
            // 
            this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbName.Location = new System.Drawing.Point(313, 35);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(81, 20);
            this.tbName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // dgvTraining
            // 
            this.dgvTraining.AllowUserToAddRows = false;
            this.dgvTraining.AllowUserToDeleteRows = false;
            this.dgvTraining.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvTraining.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTraining.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraining.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.DESCRIPCION,
            this.nivel,
            this.FECHADESDE,
            this.FECHAHASTA,
            this.INSTITUCION,
            this.EDITAR,
            this.delete});
            this.dgvTraining.Location = new System.Drawing.Point(12, 166);
            this.dgvTraining.Name = "dgvTraining";
            this.dgvTraining.Size = new System.Drawing.Size(946, 203);
            this.dgvTraining.TabIndex = 25;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "EDITAR";
            this.dataGridViewImageColumn1.Image = global::GestionDeRecursosHumanos.Properties.Resources.edit_icon;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "DELETE";
            this.dataGridViewImageColumn2.Image = global::GestionDeRecursosHumanos.Properties.Resources.delete_icon;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // tbInstitute
            // 
            this.tbInstitute.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbInstitute.Location = new System.Drawing.Point(766, 80);
            this.tbInstitute.Name = "tbInstitute";
            this.tbInstitute.Size = new System.Drawing.Size(81, 20);
            this.tbInstitute.TabIndex = 38;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(516, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(359, 137);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 23);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "ACTUALIZAR";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            // 
            // dtpMinSalary
            // 
            this.dtpMinSalary.CalendarTitleBackColor = System.Drawing.Color.CornflowerBlue;
            this.dtpMinSalary.Location = new System.Drawing.Point(104, 80);
            this.dtpMinSalary.Name = "dtpMinSalary";
            this.dtpMinSalary.Size = new System.Drawing.Size(212, 20);
            this.dtpMinSalary.TabIndex = 41;
            this.dtpMinSalary.Value = new System.DateTime(2018, 1, 31, 13, 56, 16, 0);
            // 
            // dtpMaxSalary
            // 
            this.dtpMaxSalary.Location = new System.Drawing.Point(443, 80);
            this.dtpMaxSalary.Name = "dtpMaxSalary";
            this.dtpMaxSalary.Size = new System.Drawing.Size(212, 20);
            this.dtpMaxSalary.TabIndex = 42;
            this.dtpMaxSalary.Value = new System.DateTime(2018, 1, 31, 13, 56, 16, 0);
            // 
            // recursosHumanosDataSet
            // 
            this.recursosHumanosDataSet.DataSetName = "recursosHumanosDataSet";
            this.recursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nIVELESCAPACITACIONESBindingSource
            // 
            this.nIVELESCAPACITACIONESBindingSource.DataMember = "NIVELESCAPACITACIONES";
            this.nIVELESCAPACITACIONESBindingSource.DataSource = this.recursosHumanosDataSet;
            // 
            // nIVELESCAPACITACIONESTableAdapter
            // 
            this.nIVELESCAPACITACIONESTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.Frozen = true;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // nivel
            // 
            this.nivel.Frozen = true;
            this.nivel.HeaderText = "NIVEL DE CAPACITACION";
            this.nivel.Name = "nivel";
            this.nivel.ReadOnly = true;
            // 
            // FECHADESDE
            // 
            this.FECHADESDE.Frozen = true;
            this.FECHADESDE.HeaderText = "FECHA INICIO";
            this.FECHADESDE.Name = "FECHADESDE";
            this.FECHADESDE.ReadOnly = true;
            // 
            // FECHAHASTA
            // 
            this.FECHAHASTA.Frozen = true;
            this.FECHAHASTA.HeaderText = "FECHAFINALIZO";
            this.FECHAHASTA.Name = "FECHAHASTA";
            this.FECHAHASTA.ReadOnly = true;
            // 
            // INSTITUCION
            // 
            this.INSTITUCION.Frozen = true;
            this.INSTITUCION.HeaderText = "INSTITUTO";
            this.INSTITUCION.Name = "INSTITUCION";
            this.INSTITUCION.ReadOnly = true;
            // 
            // EDITAR
            // 
            this.EDITAR.Frozen = true;
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = global::GestionDeRecursosHumanos.Properties.Resources.edit_icon;
            this.EDITAR.Name = "EDITAR";
            // 
            // delete
            // 
            this.delete.HeaderText = "DELETE";
            this.delete.Image = global::GestionDeRecursosHumanos.Properties.Resources.delete_icon;
            this.delete.Name = "delete";
            // 
            // FrmTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(970, 402);
            this.Controls.Add(this.dtpMaxSalary);
            this.Controls.Add(this.dtpMinSalary);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbInstitute);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTrainingLevel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTraining);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTraining";
            this.Text = "Competencias";
            this.Load += new System.EventHandler(this.FrmTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIVELESCAPACITACIONESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTrainingLevel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTraining;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox tbInstitute;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpMinSalary;
        private System.Windows.Forms.DateTimePicker dtpMaxSalary;
        private recursosHumanosDataSet recursosHumanosDataSet;
        private System.Windows.Forms.BindingSource nIVELESCAPACITACIONESBindingSource;
        private recursosHumanosDataSetTableAdapters.NIVELESCAPACITACIONESTableAdapter nIVELESCAPACITACIONESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHADESDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAHASTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSTITUCION;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}