namespace Piloto
{
    partial class FormPrincipal
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
            this.butChangeName = new System.Windows.Forms.Button();
            this.texTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.texLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxCreticity = new System.Windows.Forms.ComboBox();
            this.TexDescription = new System.Windows.Forms.RichTextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxPercent = new System.Windows.Forms.ComboBox();
            this.numericDuration = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // butChangeName
            // 
            this.butChangeName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.butChangeName.Location = new System.Drawing.Point(733, 516);
            this.butChangeName.Name = "butChangeName";
            this.butChangeName.Size = new System.Drawing.Size(106, 38);
            this.butChangeName.TabIndex = 0;
            this.butChangeName.Text = "Submit";
            this.butChangeName.UseVisualStyleBackColor = false;
            this.butChangeName.Click += new System.EventHandler(this.butChangeName_Click);
            // 
            // texTitle
            // 
            this.texTitle.Location = new System.Drawing.Point(31, 36);
            this.texTitle.Name = "texTitle";
            this.texTitle.Size = new System.Drawing.Size(360, 26);
            this.texTitle.TabIndex = 1;
            this.texTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location:";
            // 
            // texLocation
            // 
            this.texLocation.Location = new System.Drawing.Point(411, 36);
            this.texLocation.Name = "texLocation";
            this.texLocation.Size = new System.Drawing.Size(353, 26);
            this.texLocation.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(686, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Prod";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(686, 154);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 24);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Preprod";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(686, 187);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 24);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Demo";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(31, 117);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(289, 28);
            this.comboBoxType.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(688, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Enviroment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Creticity";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBoxCreticity
            // 
            this.comboBoxCreticity.FormattingEnabled = true;
            this.comboBoxCreticity.Location = new System.Drawing.Point(350, 115);
            this.comboBoxCreticity.Name = "comboBoxCreticity";
            this.comboBoxCreticity.Size = new System.Drawing.Size(281, 28);
            this.comboBoxCreticity.TabIndex = 15;
            // 
            // TexDescription
            // 
            this.TexDescription.Location = new System.Drawing.Point(31, 231);
            this.TexDescription.Name = "TexDescription";
            this.TexDescription.Size = new System.Drawing.Size(783, 114);
            this.TexDescription.TabIndex = 16;
            this.TexDescription.Text = "";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(31, 399);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(315, 26);
            this.date.TabIndex = 17;
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Start Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Duration(in hours)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(495, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Percent Complete";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(31, 468);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(238, 28);
            this.comboBoxStatus.TabIndex = 22;
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(31, 524);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(315, 24);
            this.checkBoxEmail.TabIndex = 23;
            this.checkBoxEmail.Text = "Check here if you want to send an email";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(621, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBoxPercent
            // 
            this.comboBoxPercent.FormattingEnabled = true;
            this.comboBoxPercent.Location = new System.Drawing.Point(490, 468);
            this.comboBoxPercent.Name = "comboBoxPercent";
            this.comboBoxPercent.Size = new System.Drawing.Size(264, 28);
            this.comboBoxPercent.TabIndex = 25;
            this.comboBoxPercent.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // numericDuration
            // 
            this.numericDuration.Location = new System.Drawing.Point(490, 399);
            this.numericDuration.Name = "numericDuration";
            this.numericDuration.Size = new System.Drawing.Size(260, 26);
            this.numericDuration.TabIndex = 26;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 574);
            this.Controls.Add(this.numericDuration);
            this.Controls.Add(this.comboBoxPercent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxEmail);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date);
            this.Controls.Add(this.TexDescription);
            this.Controls.Add(this.comboBoxCreticity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texTitle);
            this.Controls.Add(this.butChangeName);
            this.Name = "FormPrincipal";
            this.Text = "MiPrimerFormulario";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butChangeName;
        private System.Windows.Forms.TextBox texTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCreticity;
        private System.Windows.Forms.RichTextBox TexDescription;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.CheckBox checkBoxEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxPercent;
        private System.Windows.Forms.NumericUpDown numericDuration;
    }
}

