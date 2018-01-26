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
            this.label6 = new System.Windows.Forms.Label();
            this.mtbMaxSalary = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbMinSalary = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTrainingLevel = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.MaskedTextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbInstitute = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVELDETRAINING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAINICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAFINALIZO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSTITUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "INSTITUCIÓN";
            // 
            // mtbMaxSalary
            // 
            this.mtbMaxSalary.Location = new System.Drawing.Point(458, 81);
            this.mtbMaxSalary.Mask = "00/00/0000";
            this.mtbMaxSalary.Name = "mtbMaxSalary";
            this.mtbMaxSalary.Size = new System.Drawing.Size(100, 20);
            this.mtbMaxSalary.TabIndex = 36;
            this.mtbMaxSalary.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "FECHA FINALIZÓ";
            // 
            // mtbMinSalary
            // 
            this.mtbMinSalary.Location = new System.Drawing.Point(198, 78);
            this.mtbMinSalary.Mask = "00/00/0000";
            this.mtbMinSalary.Name = "mtbMinSalary";
            this.mtbMinSalary.Size = new System.Drawing.Size(100, 20);
            this.mtbMinSalary.TabIndex = 34;
            this.mtbMinSalary.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "FECHA INICIO";
            // 
            // cbTrainingLevel
            // 
            this.cbTrainingLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrainingLevel.FormattingEnabled = true;
            this.cbTrainingLevel.Items.AddRange(new object[] {
            "DISPONIBLE",
            "NO DISPONIBLE"});
            this.cbTrainingLevel.Location = new System.Drawing.Point(529, 35);
            this.cbTrainingLevel.Name = "cbTrainingLevel";
            this.cbTrainingLevel.Size = new System.Drawing.Size(121, 21);
            this.cbTrainingLevel.TabIndex = 32;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(382, 137);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 31;
            this.btnAccept.Text = "ACEPTAR";
            this.btnAccept.UseVisualStyleBackColor = true;
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
            // dgvPosition
            // 
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.NIVELDETRAINING,
            this.FECHAINICIO,
            this.FECHAFINALIZO,
            this.INSTITUTO,
            this.EDITAR,
            this.delete});
            this.dgvPosition.Location = new System.Drawing.Point(15, 166);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.Size = new System.Drawing.Size(841, 203);
            this.dgvPosition.TabIndex = 25;
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
            this.tbInstitute.Location = new System.Drawing.Point(653, 78);
            this.tbInstitute.Name = "tbInstitute";
            this.tbInstitute.Size = new System.Drawing.Size(81, 20);
            this.tbInstitute.TabIndex = 38;
            // 
            // ID
            // 
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
            // NIVELDETRAINING
            // 
            this.NIVELDETRAINING.Frozen = true;
            this.NIVELDETRAINING.HeaderText = "NIVEL DE TRAINING";
            this.NIVELDETRAINING.Name = "NIVELDETRAINING";
            this.NIVELDETRAINING.ReadOnly = true;
            // 
            // FECHAINICIO
            // 
            this.FECHAINICIO.Frozen = true;
            this.FECHAINICIO.HeaderText = "FECHA INICIO";
            this.FECHAINICIO.Name = "FECHAINICIO";
            this.FECHAINICIO.ReadOnly = true;
            // 
            // FECHAFINALIZO
            // 
            this.FECHAFINALIZO.Frozen = true;
            this.FECHAFINALIZO.HeaderText = "FECHAFINALIZO";
            this.FECHAFINALIZO.Name = "FECHAFINALIZO";
            this.FECHAFINALIZO.ReadOnly = true;
            // 
            // INSTITUTO
            // 
            this.INSTITUTO.Frozen = true;
            this.INSTITUTO.HeaderText = "INSTITUTO";
            this.INSTITUTO.Name = "INSTITUTO";
            this.INSTITUTO.ReadOnly = true;
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
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(871, 402);
            this.Controls.Add(this.tbInstitute);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtbMaxSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtbMinSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTrainingLevel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPosition);
            this.Name = "FrmTraining";
            this.Text = "FrmTraining";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbMaxSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbMinSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTrainingLevel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPosition;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVELDETRAINING;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAINICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAFINALIZO;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSTITUTO;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.TextBox tbInstitute;
    }
}