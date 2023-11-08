namespace ConexionBBDD
{
    partial class FormEmployees
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rBtnCiudad = new System.Windows.Forms.RadioButton();
            this.txtBoxCiudad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rBtnNombre = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rBtnApellido = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha de contratacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(885, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Job ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(991, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Manager ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1110, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Departamento ID:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(27, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1197, 444);
            this.listBox1.TabIndex = 16;
            // 
            // rBtnCiudad
            // 
            this.rBtnCiudad.AutoSize = true;
            this.rBtnCiudad.Location = new System.Drawing.Point(1260, 67);
            this.rBtnCiudad.Name = "rBtnCiudad";
            this.rBtnCiudad.Size = new System.Drawing.Size(112, 24);
            this.rBtnCiudad.TabIndex = 17;
            this.rBtnCiudad.TabStop = true;
            this.rBtnCiudad.Text = "Por Ciudad";
            this.rBtnCiudad.UseVisualStyleBackColor = true;
            this.rBtnCiudad.CheckedChanged += new System.EventHandler(this.rBtnCiudad_CheckedChanged);
            // 
            // txtBoxCiudad
            // 
            this.txtBoxCiudad.Enabled = false;
            this.txtBoxCiudad.Location = new System.Drawing.Point(1260, 127);
            this.txtBoxCiudad.Name = "txtBoxCiudad";
            this.txtBoxCiudad.Size = new System.Drawing.Size(230, 26);
            this.txtBoxCiudad.TabIndex = 18;
            this.txtBoxCiudad.TextChanged += new System.EventHandler(this.txtBoxCiudad_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2319, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1270, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Escribe una ciudad";
            // 
            // rBtnNombre
            // 
            this.rBtnNombre.AutoSize = true;
            this.rBtnNombre.Location = new System.Drawing.Point(1260, 214);
            this.rBtnNombre.Name = "rBtnNombre";
            this.rBtnNombre.Size = new System.Drawing.Size(122, 24);
            this.rBtnNombre.TabIndex = 21;
            this.rBtnNombre.TabStop = true;
            this.rBtnNombre.Text = "Por Nombre:";
            this.rBtnNombre.UseVisualStyleBackColor = true;
            this.rBtnNombre.CheckedChanged += new System.EventHandler(this.rBtnNombre_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1270, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Escribe una ciudad";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Enabled = false;
            this.txtBoxNombre.Location = new System.Drawing.Point(1260, 271);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(230, 26);
            this.txtBoxNombre.TabIndex = 23;
            this.txtBoxNombre.TextChanged += new System.EventHandler(this.txtBoxNombre_TextChanged);
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Enabled = false;
            this.txtBoxApellido.Location = new System.Drawing.Point(1260, 413);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(230, 26);
            this.txtBoxApellido.TabIndex = 26;
            this.txtBoxApellido.TextChanged += new System.EventHandler(this.txtBoxApellido_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1270, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Escribe una ciudad";
            // 
            // rBtnApellido
            // 
            this.rBtnApellido.AutoSize = true;
            this.rBtnApellido.Location = new System.Drawing.Point(1260, 356);
            this.rBtnApellido.Name = "rBtnApellido";
            this.rBtnApellido.Size = new System.Drawing.Size(122, 24);
            this.rBtnApellido.TabIndex = 24;
            this.rBtnApellido.TabStop = true;
            this.rBtnApellido.Text = "Por Apellido:";
            this.rBtnApellido.UseVisualStyleBackColor = true;
            this.rBtnApellido.CheckedChanged += new System.EventHandler(this.rBtnApellido_CheckedChanged);
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1510, 620);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rBtnApellido);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rBtnNombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxCiudad);
            this.Controls.Add(this.rBtnCiudad);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEmployees";
            this.Text = "FormEmployees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rBtnCiudad;
        private System.Windows.Forms.TextBox txtBoxCiudad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rBtnNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rBtnApellido;
    }
}