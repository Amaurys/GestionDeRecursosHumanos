namespace GestionDeRecursosHumanos.Views
{
    partial class FrmEmployees
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAINGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CEDULA,
            this.NOMBRE,
            this.FECHAINGRESO,
            this.PUESTO,
            this.DEPARTAMENTO,
            this.SALARIO,
            this.ESTADO,
            this.edit,
            this.ELIMINAR});
            this.dgvEmployees.Location = new System.Drawing.Point(36, 144);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(1049, 203);
            this.dgvEmployees.TabIndex = 54;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CEDULA
            // 
            this.CEDULA.Frozen = true;
            this.CEDULA.HeaderText = "CEDULA";
            this.CEDULA.Name = "CEDULA";
            this.CEDULA.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.Frozen = true;
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // FECHAINGRESO
            // 
            this.FECHAINGRESO.Frozen = true;
            this.FECHAINGRESO.HeaderText = "FECHA DE INGRESO";
            this.FECHAINGRESO.Name = "FECHAINGRESO";
            this.FECHAINGRESO.ReadOnly = true;
            // 
            // PUESTO
            // 
            this.PUESTO.Frozen = true;
            this.PUESTO.HeaderText = "PUESTO";
            this.PUESTO.Name = "PUESTO";
            this.PUESTO.ReadOnly = true;
            // 
            // DEPARTAMENTO
            // 
            this.DEPARTAMENTO.Frozen = true;
            this.DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            this.DEPARTAMENTO.Name = "DEPARTAMENTO";
            this.DEPARTAMENTO.ReadOnly = true;
            // 
            // SALARIO
            // 
            this.SALARIO.Frozen = true;
            this.SALARIO.HeaderText = "SALARIO MENSUAL";
            this.SALARIO.Name = "SALARIO";
            this.SALARIO.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.Frozen = true;
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(437, 108);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(213, 20);
            this.tbSearch.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 36);
            this.label1.TabIndex = 56;
            this.label1.Text = "EMPLEADOS";
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
            this.dataGridViewImageColumn2.HeaderText = "ELIMINAR";
            this.dataGridViewImageColumn2.Image = global::GestionDeRecursosHumanos.Properties.Resources.delete_icon;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::GestionDeRecursosHumanos.Properties.Resources.lupa2;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Location = new System.Drawing.Point(656, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 42);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // edit
            // 
            this.edit.Frozen = true;
            this.edit.HeaderText = "EDITAR";
            this.edit.Image = global::GestionDeRecursosHumanos.Properties.Resources.edit_icon;
            this.edit.Name = "edit";
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = global::GestionDeRecursosHumanos.Properties.Resources.delete_icon;
            this.ELIMINAR.Name = "ELIMINAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "BUSQUEDA DE EMPLEADOS POR NOMBRE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 68);
            this.button1.TabIndex = 59;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 68);
            this.button2.TabIndex = 60;
            this.button2.Text = "VISUALIZAR EMPLEADO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1097, 530);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAINGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}