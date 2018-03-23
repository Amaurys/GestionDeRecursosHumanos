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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.MaskedTextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbMinSalary = new System.Windows.Forms.MaskedTextBox();
            this.mtbMaxSalary = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVELRIESGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALARIOMINIMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALARIOMAXIMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbRiskLevel = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "NIVEL DE RIESGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "NOMBRE";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(192, 73);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(37, 20);
            this.tbId.TabIndex = 11;
            // 
            // tbName
            // 
            this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbName.Location = new System.Drawing.Point(310, 73);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(81, 20);
            this.tbName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "SALARIO MÍNIMO";
            // 
            // mtbMinSalary
            // 
            this.mtbMinSalary.Location = new System.Drawing.Point(195, 116);
            this.mtbMinSalary.Mask = "00000000";
            this.mtbMinSalary.Name = "mtbMinSalary";
            this.mtbMinSalary.Size = new System.Drawing.Size(100, 20);
            this.mtbMinSalary.TabIndex = 20;
            // 
            // mtbMaxSalary
            // 
            this.mtbMaxSalary.Location = new System.Drawing.Point(455, 119);
            this.mtbMaxSalary.Mask = "00000000";
            this.mtbMaxSalary.Name = "mtbMaxSalary";
            this.mtbMaxSalary.Size = new System.Drawing.Size(100, 20);
            this.mtbMaxSalary.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 119);
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
            "ACTIVO",
            "INACTIVO"});
            this.cbStatus.Location = new System.Drawing.Point(638, 119);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "STATUS";
            // 
            // dgvPosition
            // 
            this.dgvPosition.AllowUserToAddRows = false;
            this.dgvPosition.AllowUserToDeleteRows = false;
            this.dgvPosition.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPosition.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.NIVELRIESGO,
            this.SALARIOMINIMO,
            this.SALARIOMAXIMO,
            this.STATUS,
            this.edit,
            this.delete});
            this.dgvPosition.Location = new System.Drawing.Point(8, 323);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.Size = new System.Drawing.Size(851, 203);
            this.dgvPosition.TabIndex = 57;
            this.dgvPosition.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosition_CellContentClick);
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.Frozen = true;
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // NIVELRIESGO
            // 
            this.NIVELRIESGO.Frozen = true;
            this.NIVELRIESGO.HeaderText = "NIVEL DE RIESGO";
            this.NIVELRIESGO.Name = "NIVELRIESGO";
            this.NIVELRIESGO.ReadOnly = true;
            // 
            // SALARIOMINIMO
            // 
            this.SALARIOMINIMO.Frozen = true;
            this.SALARIOMINIMO.HeaderText = "SALARIO MÍNIMO";
            this.SALARIOMINIMO.Name = "SALARIOMINIMO";
            this.SALARIOMINIMO.ReadOnly = true;
            // 
            // SALARIOMAXIMO
            // 
            this.SALARIOMAXIMO.HeaderText = "SALARIO MÁXIMO";
            this.SALARIOMAXIMO.Name = "SALARIOMAXIMO";
            this.SALARIOMAXIMO.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // edit
            // 
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(543, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 23);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(386, 193);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 23);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "ACTUALIZAR";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(254, 193);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(84, 23);
            this.btnAccept.TabIndex = 54;
            this.btnAccept.Text = "ACEPTAR";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 36);
            this.label7.TabIndex = 58;
            this.label7.Text = "POSICIÓN";
            // 
            // cbRiskLevel
            // 
            this.cbRiskLevel.DisplayMember = "id";
            this.cbRiskLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRiskLevel.FormattingEnabled = true;
            this.cbRiskLevel.Location = new System.Drawing.Point(515, 72);
            this.cbRiskLevel.Name = "cbRiskLevel";
            this.cbRiskLevel.Size = new System.Drawing.Size(121, 21);
            this.cbRiskLevel.TabIndex = 17;
            this.cbRiskLevel.ValueMember = "id";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::GestionDeRecursosHumanos.Properties.Resources.lupa2;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Location = new System.Drawing.Point(498, 275);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 42);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSearch.Location = new System.Drawing.Point(279, 287);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(213, 20);
            this.tbSearch.TabIndex = 59;
            // 
            // FrmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(871, 570);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvPosition);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtbMaxSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtbMinSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbRiskLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPosition";
            this.Text = "FrmPosition";
            this.Load += new System.EventHandler(this.FrmPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbMinSalary;
        private System.Windows.Forms.MaskedTextBox mtbMaxSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPosition;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbRiskLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVELRIESGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALARIOMINIMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALARIOMAXIMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}