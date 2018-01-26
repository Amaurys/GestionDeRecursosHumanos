namespace GestionDeRecursosHumanos.Views
{
    partial class FrmLanguage
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
            this.dgvLanguage = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLanguage
            // 
            this.dgvLanguage.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvLanguage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLanguage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLanguage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.DESCRIPCION,
            this.EDITAR,
            this.ELIMINAR});
            this.dgvLanguage.Location = new System.Drawing.Point(33, 158);
            this.dgvLanguage.Name = "dgvLanguage";
            this.dgvLanguage.Size = new System.Drawing.Size(544, 203);
            this.dgvLanguage.TabIndex = 0;
            this.dgvLanguage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLanguage_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(245, 54);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(81, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(118, 57);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(37, 20);
            this.tbId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DESCRIPCION";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(429, 54);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(81, 20);
            this.tbDescription.TabIndex = 5;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(118, 116);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "AGREGAR";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "EDITAR";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(254, 116);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "ACTUALIZAR";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(429, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            // DESCRIPCION
            // 
            this.DESCRIPCION.Frozen = true;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // EDITAR
            // 
            this.EDITAR.Frozen = true;
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = global::GestionDeRecursosHumanos.Properties.Resources.edit_icon;
            this.EDITAR.Name = "EDITAR";
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = global::GestionDeRecursosHumanos.Properties.Resources.delete_icon;
            this.ELIMINAR.Name = "ELIMINAR";
            // 
            // FrmLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(603, 402);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLanguage";
            this.Text = "frmLanguage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.MaskedTextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
    }
}