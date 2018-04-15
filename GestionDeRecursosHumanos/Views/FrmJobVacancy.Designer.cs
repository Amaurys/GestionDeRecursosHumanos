namespace GestionDeRecursosHumanos.Views
{
    partial class FrmJobVacancy
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
            this.dgvVacancy = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestNameField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seeRequestField = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "VACANTES";
            // 
            // dgvVacancy
            // 
            this.dgvVacancy.AllowUserToAddRows = false;
            this.dgvVacancy.AllowUserToDeleteRows = false;
            this.dgvVacancy.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvVacancy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVacancy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvVacancy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVacancy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.requestNameField,
            this.seeRequestField});
            this.dgvVacancy.Location = new System.Drawing.Point(12, 136);
            this.dgvVacancy.Name = "dgvVacancy";
            this.dgvVacancy.Size = new System.Drawing.Size(548, 203);
            this.dgvVacancy.TabIndex = 2;
            this.dgvVacancy.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVacancy_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // requestNameField
            // 
            this.requestNameField.Frozen = true;
            this.requestNameField.HeaderText = "Nombre de la Vacante";
            this.requestNameField.Name = "requestNameField";
            this.requestNameField.ReadOnly = true;
            this.requestNameField.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.requestNameField.Width = 300;
            // 
            // seeRequestField
            // 
            this.seeRequestField.Frozen = true;
            this.seeRequestField.HeaderText = "Visualizar Solicitud";
            this.seeRequestField.Image = global::GestionDeRecursosHumanos.Properties.Resources.lupa1;
            this.seeRequestField.Name = "seeRequestField";
            this.seeRequestField.ReadOnly = true;
            this.seeRequestField.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.seeRequestField.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.seeRequestField.Width = 180;
            // 
            // FrmJobVacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(576, 404);
            this.Controls.Add(this.dgvVacancy);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmJobVacancy";
            this.Text = "VACANTES";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVacancy;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestNameField;
        private System.Windows.Forms.DataGridViewImageColumn seeRequestField;
    }
}