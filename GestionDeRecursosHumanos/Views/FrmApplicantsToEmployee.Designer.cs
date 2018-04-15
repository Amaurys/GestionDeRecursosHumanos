namespace GestionDeRecursosHumanos.Views
{
    partial class FrmApplicantsToEmployee
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
            this.dgvApplicant = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantNameField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seeRequestField = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicant)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApplicant
            // 
            this.dgvApplicant.AllowUserToAddRows = false;
            this.dgvApplicant.AllowUserToDeleteRows = false;
            this.dgvApplicant.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvApplicant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvApplicant.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvApplicant.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplicant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.applicantNameField,
            this.seeRequestField});
            this.dgvApplicant.Location = new System.Drawing.Point(12, 175);
            this.dgvApplicant.Name = "dgvApplicant";
            this.dgvApplicant.Size = new System.Drawing.Size(548, 203);
            this.dgvApplicant.TabIndex = 3;
            this.dgvApplicant.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplicant_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // applicantNameField
            // 
            this.applicantNameField.Frozen = true;
            this.applicantNameField.HeaderText = "Nombre Candidato";
            this.applicantNameField.Name = "applicantNameField";
            this.applicantNameField.ReadOnly = true;
            this.applicantNameField.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.applicantNameField.Width = 300;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "CANDIDATOS";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::GestionDeRecursosHumanos.Properties.Resources.lupa2;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(353, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 42);
            this.btnSearch.TabIndex = 66;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSearch.Location = new System.Drawing.Point(134, 139);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(213, 20);
            this.tbSearch.TabIndex = 65;
            // 
            // FrmApplicantsToEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(580, 428);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvApplicant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmApplicantsToEmployee";
            this.Text = "Pasar CANDIDATOS a EMPLEADOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApplicant;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicantNameField;
        private System.Windows.Forms.DataGridViewImageColumn seeRequestField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}