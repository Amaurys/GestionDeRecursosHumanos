namespace GestionDeRecursosHumanos.Views
{
    partial class FrmApplicant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.mtbCedula = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbSalary = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCompetence = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCompetences = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddCompetence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetence)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "CANDIDATO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE COMPLETO";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(283, 108);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // mtbCedula
            // 
            this.mtbCedula.Location = new System.Drawing.Point(484, 111);
            this.mtbCedula.Mask = "000-0000000-0";
            this.mtbCedula.Name = "mtbCedula";
            this.mtbCedula.Size = new System.Drawing.Size(100, 20);
            this.mtbCedula.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CÉDULA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SALARIO AL QUE ASPIRA";
            // 
            // mtbSalary
            // 
            this.mtbSalary.Location = new System.Drawing.Point(500, 211);
            this.mtbSalary.Mask = "000000.00";
            this.mtbSalary.Name = "mtbSalary";
            this.mtbSalary.Size = new System.Drawing.Size(100, 20);
            this.mtbSalary.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PUESTO AL QUE ASPIRA";
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(136, 211);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(132, 21);
            this.cbPosition.TabIndex = 8;
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(318, 211);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(132, 21);
            this.cbDepartment.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "DEPARTAMENTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "PRINCIPALES COMPETENCIAS";
            // 
            // dgvCompetence
            // 
            this.dgvCompetence.AllowUserToAddRows = false;
            this.dgvCompetence.AllowUserToDeleteRows = false;
            this.dgvCompetence.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvCompetence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompetence.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCompetence.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompetence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompetence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dgvCompetence.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCompetence.Location = new System.Drawing.Point(136, 361);
            this.dgvCompetence.Name = "dgvCompetence";
            this.dgvCompetence.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompetence.Size = new System.Drawing.Size(179, 143);
            this.dgvCompetence.TabIndex = 48;
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "COMPETENCIAS";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // cbCompetences
            // 
            this.cbCompetences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompetences.FormattingEnabled = true;
            this.cbCompetences.Location = new System.Drawing.Point(357, 320);
            this.cbCompetences.Name = "cbCompetences";
            this.cbCompetences.Size = new System.Drawing.Size(132, 21);
            this.cbCompetences.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "ELIJA LAS COMPETENCIAS";
            // 
            // btnAddCompetence
            // 
            this.btnAddCompetence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCompetence.Location = new System.Drawing.Point(503, 320);
            this.btnAddCompetence.Name = "btnAddCompetence";
            this.btnAddCompetence.Size = new System.Drawing.Size(130, 33);
            this.btnAddCompetence.TabIndex = 51;
            this.btnAddCompetence.Text = "Agregar competencia";
            this.btnAddCompetence.UseVisualStyleBackColor = true;
            this.btnAddCompetence.Click += new System.EventHandler(this.btnAddCompetence_Click);
            // 
            // FrmApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(776, 432);
            this.Controls.Add(this.btnAddCompetence);
            this.Controls.Add(this.cbCompetences);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvCompetence);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbCedula);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmApplicant";
            this.Text = "CANDIDATOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.MaskedTextBox mtbCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvCompetence;
        private System.Windows.Forms.ComboBox cbCompetences;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddCompetence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}