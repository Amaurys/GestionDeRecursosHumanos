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
            this.nIVELESCAPACITACIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFinishDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtbCedula = new System.Windows.Forms.MaskedTextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHADESDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAHASTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSTITUCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nIVELESCAPACITACIONESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "INSTITUCIÓN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "FECHA FINALIZÓ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 85);
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
            this.cbTrainingLevel.Location = new System.Drawing.Point(606, 32);
            this.cbTrainingLevel.Name = "cbTrainingLevel";
            this.cbTrainingLevel.Size = new System.Drawing.Size(121, 21);
            this.cbTrainingLevel.TabIndex = 32;
            this.cbTrainingLevel.Tag = "";
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
            this.label3.Location = new System.Drawing.Point(466, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "NIVEL DE COMPETENCIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "NOMBRE";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(50, 35);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(37, 20);
            this.tbId.TabIndex = 28;
            // 
            // tbName
            // 
            this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbName.Location = new System.Drawing.Point(168, 35);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(81, 20);
            this.tbName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
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
            this.CEDULA,
            this.edit,
            this.delete});
            this.dgvTraining.Location = new System.Drawing.Point(12, 166);
            this.dgvTraining.Name = "dgvTraining";
            this.dgvTraining.Size = new System.Drawing.Size(1043, 203);
            this.dgvTraining.TabIndex = 25;
            this.dgvTraining.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTraining_CellContentClick);
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
            this.tbInstitute.Location = new System.Drawing.Point(792, 82);
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarTitleBackColor = System.Drawing.Color.CornflowerBlue;
            this.dtpStartDate.Location = new System.Drawing.Point(130, 82);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(212, 20);
            this.dtpStartDate.TabIndex = 41;
            this.dtpStartDate.Value = new System.DateTime(2018, 1, 31, 13, 56, 16, 0);
            // 
            // dtpFinishDate
            // 
            this.dtpFinishDate.Location = new System.Drawing.Point(469, 82);
            this.dtpFinishDate.Name = "dtpFinishDate";
            this.dtpFinishDate.Size = new System.Drawing.Size(212, 20);
            this.dtpFinishDate.TabIndex = 42;
            this.dtpFinishDate.Value = new System.DateTime(2018, 1, 31, 13, 56, 16, 0);
        
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "DESCRIPCIÓN";
            // 
            // tbDescription
            // 
            this.tbDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDescription.Location = new System.Drawing.Point(369, 35);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(81, 20);
            this.tbDescription.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(749, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "CEDULA";
            // 
            // mtbCedula
            // 
            this.mtbCedula.Location = new System.Drawing.Point(805, 35);
            this.mtbCedula.Mask = "000-0000000-0";
            this.mtbCedula.Name = "mtbCedula";
            this.mtbCedula.Size = new System.Drawing.Size(100, 20);
            this.mtbCedula.TabIndex = 46;
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
            // CEDULA
            // 
            this.CEDULA.Frozen = true;
            this.CEDULA.HeaderText = "CEDULA";
            this.CEDULA.Name = "CEDULA";
            this.CEDULA.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.Frozen = true;
            this.edit.HeaderText = "EDITAR";
            this.edit.Image = global::GestionDeRecursosHumanos.Properties.Resources.edit_icon;
            this.edit.Name = "edit";
            // 
            // delete
            // 
            this.delete.HeaderText = "ELIMINAR";
            this.delete.Image = global::GestionDeRecursosHumanos.Properties.Resources.delete_icon;
            this.delete.Name = "delete";
            // 
            // FrmTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1114, 402);
            this.Controls.Add(this.mtbCedula);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.dtpFinishDate);
            this.Controls.Add(this.dtpStartDate);
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
            ((System.ComponentModel.ISupportInitialize)(this.nIVELESCAPACITACIONESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpFinishDate;
        private System.Windows.Forms.BindingSource nIVELESCAPACITACIONESBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHADESDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAHASTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSTITUCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.MaskedTextBox mtbCedula;
    }
}