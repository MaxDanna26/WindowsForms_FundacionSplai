namespace Hospital_WindowsForm.Forms
{
    partial class FormVerDatos
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
            this.comboBoxListar = new System.Windows.Forms.ComboBox();
            this.listBoxListar = new System.Windows.Forms.ListBox();
            this.btnVerDatos = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxListar
            // 
            this.comboBoxListar.FormattingEnabled = true;
            this.comboBoxListar.Items.AddRange(new object[] {
            "Listar Personas",
            "Listar Doctores",
            "Listar Pacientes"});
            this.comboBoxListar.Location = new System.Drawing.Point(34, 55);
            this.comboBoxListar.Name = "comboBoxListar";
            this.comboBoxListar.Size = new System.Drawing.Size(439, 28);
            this.comboBoxListar.TabIndex = 0;
            // 
            // listBoxListar
            // 
            this.listBoxListar.FormattingEnabled = true;
            this.listBoxListar.ItemHeight = 20;
            this.listBoxListar.Location = new System.Drawing.Point(34, 127);
            this.listBoxListar.Name = "listBoxListar";
            this.listBoxListar.Size = new System.Drawing.Size(439, 264);
            this.listBoxListar.TabIndex = 1;
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.Location = new System.Drawing.Point(590, 55);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(124, 59);
            this.btnVerDatos.TabIndex = 2;
            this.btnVerDatos.Text = "Ver datos";
            this.btnVerDatos.UseVisualStyleBackColor = true;
            this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(590, 240);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 59);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(590, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 59);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar datos";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormVerDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnVerDatos);
            this.Controls.Add(this.listBoxListar);
            this.Controls.Add(this.comboBoxListar);
            this.Name = "FormVerDatos";
            this.Text = "FormVerDatos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxListar;
        private System.Windows.Forms.ListBox listBoxListar;
        private System.Windows.Forms.Button btnVerDatos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnDelete;
    }
}