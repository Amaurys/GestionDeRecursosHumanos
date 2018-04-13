namespace GestionDeRecursosHumanos.Views
{
    partial class FrmDetailVacancy
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
            this.lblNombreVacante = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVacancyDetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreVacante
            // 
            this.lblNombreVacante.AutoSize = true;
            this.lblNombreVacante.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVacante.Location = new System.Drawing.Point(141, 9);
            this.lblNombreVacante.Name = "lblNombreVacante";
            this.lblNombreVacante.Size = new System.Drawing.Size(208, 55);
            this.lblNombreVacante.TabIndex = 1;
            this.lblNombreVacante.Text = "Vacante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departamento: ";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(180, 101);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(72, 13);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "lblDepartment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Detalles de la vacante:";
            // 
            // lblVacancyDetail
            // 
            this.lblVacancyDetail.AutoEllipsis = true;
            this.lblVacancyDetail.AutoSize = true;
            this.lblVacancyDetail.Location = new System.Drawing.Point(94, 178);
            this.lblVacancyDetail.Name = "lblVacancyDetail";
            this.lblVacancyDetail.Size = new System.Drawing.Size(86, 13);
            this.lblVacancyDetail.TabIndex = 5;
            this.lblVacancyDetail.Text = "lblVacancyDetail";
            // 
            // FrmDetailVacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVacancyDetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreVacante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetailVacancy";
            this.Text = "Detalle de Vacante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreVacante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVacancyDetail;
    }
}