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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxListar
            // 
            this.comboBoxListar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListar.FormattingEnabled = true;
            this.comboBoxListar.Items.AddRange(new object[] {
            "Listar Personas",
            "Listar Doctores",
            "Listar Pacientes"});
            this.comboBoxListar.Location = new System.Drawing.Point(34, 55);
            this.comboBoxListar.Name = "comboBoxListar";
            this.comboBoxListar.Size = new System.Drawing.Size(439, 28);
            this.comboBoxListar.TabIndex = 0;
            this.comboBoxListar.SelectedIndexChanged += new System.EventHandler(this.comboBoxListar_SelectedIndexChanged);
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
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(581, 266);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 59);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(581, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 59);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar datos";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(581, 80);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 59);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Editar Datos";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FormVerDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.listBoxListar);
            this.Controls.Add(this.comboBoxListar);
            this.Name = "FormVerDatos";
            this.Text = "FormVerDatos";
            this.Load += new System.EventHandler(this.FormVerDatos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxListar;
        private System.Windows.Forms.ListBox listBoxListar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}