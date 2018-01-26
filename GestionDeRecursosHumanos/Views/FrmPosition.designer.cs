namespace GestionDeRecursosHumanos.Views
{
    partial class FrmPosition
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.MaskedTextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.cbRiskLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbMinSalary = new System.Windows.Forms.MaskedTextBox();
            this.mtbMaxSalary = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVELDERIESGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALARIOMIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALARIOMAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(385, 158);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "ACEPTAR";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "NIVEL DE RIESGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "NOMBRE";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(192, 56);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(37, 20);
            this.tbId.TabIndex = 11;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(310, 56);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(81, 20);
            this.tbName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // dgvPosition
            // 
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.NIVELDERIESGO,
            this.STATUS,
            this.SALARIOMIN,
            this.SALARIOMAX,
            this.EDITAR,
            this.delete});
            this.dgvPosition.Location = new System.Drawing.Point(12, 187);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.Size = new System.Drawing.Size(841, 203);
            this.dgvPosition.TabIndex = 8;
            // 
            // cbRiskLevel
            // 
            this.cbRiskLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRiskLevel.FormattingEnabled = true;
            this.cbRiskLevel.Items.AddRange(new object[] {
            "DISPONIBLE",
            "NO DISPONIBLE"});
            this.cbRiskLevel.Location = new System.Drawing.Point(515, 55);
            this.cbRiskLevel.Name = "cbRiskLevel";
            this.cbRiskLevel.Size = new System.Drawing.Size(121, 21);
            this.cbRiskLevel.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "SALARIO MÍNIMO";
            // 
            // mtbMinSalary
            // 
            this.mtbMinSalary.Location = new System.Drawing.Point(195, 99);
            this.mtbMinSalary.Mask = "000000.00";
            this.mtbMinSalary.Name = "mtbMinSalary";
            this.mtbMinSalary.Size = new System.Drawing.Size(100, 20);
            this.mtbMinSalary.TabIndex = 20;
            // 
            // mtbMaxSalary
            // 
            this.mtbMaxSalary.Location = new System.Drawing.Point(455, 102);
            this.mtbMaxSalary.Mask = "000000.00";
            this.mtbMaxSalary.Name = "mtbMaxSalary";
            this.mtbMaxSalary.Size = new System.Drawing.Size(100, 20);
            this.mtbMaxSalary.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "SALARIO MÁXIMO";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "DISPONIBLE",
            "NO DISPONIBLE"});
            this.cbStatus.Location = new System.Drawing.Point(638, 102);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "STATUS";
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
            // NIVELDERIESGO
            // 
            this.NIVELDERIESGO.Frozen = true;
            this.NIVELDERIESGO.HeaderText = "NIVEL DE RIESGO";
            this.NIVELDERIESGO.Name = "NIVELDERIESGO";
            this.NIVELDERIESGO.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.Frozen = true;
            this.STATUS.HeaderText = "ESTATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // SALARIOMIN
            // 
            this.SALARIOMIN.Frozen = true;
            this.SALARIOMIN.HeaderText = "SALARIO MINIMO";
            this.SALARIOMIN.Name = "SALARIOMIN";
            this.SALARIOMIN.ReadOnly = true;
            // 
            // SALARIOMAX
            // 
            this.SALARIOMAX.Frozen = true;
            this.SALARIOMAX.HeaderText = "SALARIO MAXIMO";
            this.SALARIOMAX.Name = "SALARIOMAX";
            this.SALARIOMAX.ReadOnly = true;
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
            // FrmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(871, 402);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtbMaxSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtbMinSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbRiskLevel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPosition);
            this.Name = "FrmPosition";
            this.Text = "FrmPosition";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPosition;
        private System.Windows.Forms.ComboBox cbRiskLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbMinSalary;
        private System.Windows.Forms.MaskedTextBox mtbMaxSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVELDERIESGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALARIOMIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALARIOMAX;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}