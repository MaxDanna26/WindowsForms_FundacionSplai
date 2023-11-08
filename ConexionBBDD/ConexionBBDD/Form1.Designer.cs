namespace ConexionBBDD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.listBoxJobs = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInsert.Location = new System.Drawing.Point(11, 264);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(187, 44);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insertar Job";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(11, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 41);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Eliminar Job";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Min. Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max. Salary";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(13, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 26);
            this.txtNombre.TabIndex = 12;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(13, 201);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(185, 26);
            this.txtMax.TabIndex = 13;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(13, 137);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(185, 26);
            this.txtMin.TabIndex = 14;
            // 
            // listBoxJobs
            // 
            this.listBoxJobs.FormattingEnabled = true;
            this.listBoxJobs.ItemHeight = 20;
            this.listBoxJobs.Location = new System.Drawing.Point(225, 29);
            this.listBoxJobs.Name = "listBoxJobs";
            this.listBoxJobs.Size = new System.Drawing.Size(751, 464);
            this.listBoxJobs.TabIndex = 15;
            this.listBoxJobs.SelectedIndexChanged += new System.EventHandler(this.listBoxJobs_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Info;
            this.btnRefresh.Location = new System.Drawing.Point(617, 522);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(359, 49);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEdit.Location = new System.Drawing.Point(11, 421);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(187, 41);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Editar Job";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.LightBlue;
            this.btnEmployees.Location = new System.Drawing.Point(13, 522);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(347, 49);
            this.btnEmployees.TabIndex = 17;
            this.btnEmployees.Text = "Filtrar employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1008, 594);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listBoxJobs);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.ListBox listBoxJobs;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEmployees;
    }
}

