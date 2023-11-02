namespace Hospital_WindowsForm.Forms
{
    partial class FormEditarPaciente
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
            this.listBoxDoctores = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEditarDoctor = new System.Windows.Forms.Button();
            this.txtBoxDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxDoctores
            // 
            this.listBoxDoctores.FormattingEnabled = true;
            this.listBoxDoctores.ItemHeight = 20;
            this.listBoxDoctores.Location = new System.Drawing.Point(80, 265);
            this.listBoxDoctores.Name = "listBoxDoctores";
            this.listBoxDoctores.Size = new System.Drawing.Size(431, 164);
            this.listBoxDoctores.TabIndex = 37;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(621, 247);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(110, 65);
            this.btnVolver.TabIndex = 36;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnEditarDoctor
            // 
            this.btnEditarDoctor.Location = new System.Drawing.Point(621, 127);
            this.btnEditarDoctor.Name = "btnEditarDoctor";
            this.btnEditarDoctor.Size = new System.Drawing.Size(110, 65);
            this.btnEditarDoctor.TabIndex = 35;
            this.btnEditarDoctor.Text = "Editar Paciente";
            this.btnEditarDoctor.UseVisualStyleBackColor = true;
            this.btnEditarDoctor.Click += new System.EventHandler(this.btnEditarDoctor_Click);
            // 
            // txtBoxDni
            // 
            this.txtBoxDni.Location = new System.Drawing.Point(151, 180);
            this.txtBoxDni.Name = "txtBoxDni";
            this.txtBoxDni.Size = new System.Drawing.Size(326, 26);
            this.txtBoxDni.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Dni/Nie: ";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(150, 127);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(326, 26);
            this.txtBoxApellido.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Apellido:";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(150, 76);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(326, 26);
            this.txtBoxNombre.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "¿ A que doctor esta asociado ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Va a proceder a crear un paciente con los siguientes datos: ";
            // 
            // FormEditarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxDoctores);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEditarDoctor);
            this.Controls.Add(this.txtBoxDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEditarPaciente";
            this.Text = "FormEditarPaciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDoctores;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEditarDoctor;
        private System.Windows.Forms.TextBox txtBoxDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}