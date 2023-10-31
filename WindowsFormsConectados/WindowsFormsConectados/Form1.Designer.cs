namespace WindowsFormsConectados
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
            this.DateTime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBoxPaises = new System.Windows.Forms.ListBox();
            this.textBoxPaises = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnFecha = new System.Windows.Forms.Button();
            this.rBtnHombre = new System.Windows.Forms.RadioButton();
            this.rBtnMujer = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSexo = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.DeleteFecha = new System.Windows.Forms.CheckBox();
            this.btnNewForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateTime
            // 
            this.DateTime.AutoSize = true;
            this.DateTime.Location = new System.Drawing.Point(35, 26);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(82, 20);
            this.DateTime.TabIndex = 0;
            this.DateTime.Text = "DateTime:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 26);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listBoxPaises
            // 
            this.listBoxPaises.FormattingEnabled = true;
            this.listBoxPaises.ItemHeight = 20;
            this.listBoxPaises.Items.AddRange(new object[] {
            "Estados Unidos",
            "Mexico",
            "Argentina",
            "España",
            "Dinamarca",
            "Holanda"});
            this.listBoxPaises.Location = new System.Drawing.Point(39, 143);
            this.listBoxPaises.Name = "listBoxPaises";
            this.listBoxPaises.Size = new System.Drawing.Size(299, 144);
            this.listBoxPaises.TabIndex = 2;
            this.listBoxPaises.SelectedIndexChanged += new System.EventHandler(this.listBoxPaises_SelectedIndexChanged);
            // 
            // textBoxPaises
            // 
            this.textBoxPaises.Location = new System.Drawing.Point(39, 112);
            this.textBoxPaises.Name = "textBoxPaises";
            this.textBoxPaises.Size = new System.Drawing.Size(299, 26);
            this.textBoxPaises.TabIndex = 3;
            this.textBoxPaises.TextChanged += new System.EventHandler(this.textBoxPaises_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(445, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "EnableFecha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(600, 21);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(149, 39);
            this.btnFecha.TabIndex = 6;
            this.btnFecha.Text = "Mostrar Fecha";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // rBtnHombre
            // 
            this.rBtnHombre.AutoSize = true;
            this.rBtnHombre.Location = new System.Drawing.Point(600, 112);
            this.rBtnHombre.Name = "rBtnHombre";
            this.rBtnHombre.Size = new System.Drawing.Size(91, 24);
            this.rBtnHombre.TabIndex = 7;
            this.rBtnHombre.TabStop = true;
            this.rBtnHombre.Text = "Hombre";
            this.rBtnHombre.UseVisualStyleBackColor = true;
            this.rBtnHombre.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rBtnMujer
            // 
            this.rBtnMujer.AutoSize = true;
            this.rBtnMujer.Location = new System.Drawing.Point(600, 143);
            this.rBtnMujer.Name = "rBtnMujer";
            this.rBtnMujer.Size = new System.Drawing.Size(73, 24);
            this.rBtnMujer.TabIndex = 8;
            this.rBtnMujer.TabStop = true;
            this.rBtnMujer.Text = "Mujer";
            this.rBtnMujer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccione su pais:";
            // 
            // textBoxSexo
            // 
            this.textBoxSexo.Location = new System.Drawing.Point(570, 184);
            this.textBoxSexo.Name = "textBoxSexo";
            this.textBoxSexo.Size = new System.Drawing.Size(194, 26);
            this.textBoxSexo.TabIndex = 10;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Submit.Location = new System.Drawing.Point(670, 358);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(103, 54);
            this.Submit.TabIndex = 11;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            // 
            // DeleteFecha
            // 
            this.DeleteFecha.AutoSize = true;
            this.DeleteFecha.Location = new System.Drawing.Point(445, 56);
            this.DeleteFecha.Name = "DeleteFecha";
            this.DeleteFecha.Size = new System.Drawing.Size(127, 24);
            this.DeleteFecha.TabIndex = 12;
            this.DeleteFecha.Text = "DeleteFecha";
            this.DeleteFecha.UseVisualStyleBackColor = true;
            this.DeleteFecha.CheckedChanged += new System.EventHandler(this.DeleteFecha_CheckedChanged);
            // 
            // btnNewForm
            // 
            this.btnNewForm.Location = new System.Drawing.Point(355, 358);
            this.btnNewForm.Name = "btnNewForm";
            this.btnNewForm.Size = new System.Drawing.Size(88, 34);
            this.btnNewForm.TabIndex = 13;
            this.btnNewForm.Text = "btnNewForm";
            this.btnNewForm.UseVisualStyleBackColor = true;
            this.btnNewForm.Click += new System.EventHandler(this.btnNewForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewForm);
            this.Controls.Add(this.DeleteFecha);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.textBoxSexo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rBtnMujer);
            this.Controls.Add(this.rBtnHombre);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxPaises);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.listBoxPaises);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBoxPaises;
        private System.Windows.Forms.TextBox textBoxPaises;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.RadioButton rBtnHombre;
        private System.Windows.Forms.RadioButton rBtnMujer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSexo;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.CheckBox DeleteFecha;
        private System.Windows.Forms.Button btnNewForm;
    }
}

