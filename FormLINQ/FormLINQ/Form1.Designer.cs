namespace FormLINQ
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
            this.components = new System.ComponentModel.Container();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dannaEmployeesDataSet = new FormLINQ.DannaEmployeesDataSet();
            this.fKemployeesmanag3E52440BBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKemployeesmanag3E52440BBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationsTableAdapter = new FormLINQ.DannaEmployeesDataSetTableAdapters.locationsTableAdapter();
            this.employeesTableAdapter = new FormLINQ.DannaEmployeesDataSetTableAdapters.employeesTableAdapter();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dannaEmployeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKemployeesmanag3E52440BBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKemployeesmanag3E52440BBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1108, 530);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "Escribe un apellido";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(607, 530);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "Escribe un nombre";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Escribe una ciudad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1477, 436);
            this.dataGridView1.TabIndex = 45;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.dannaEmployeesDataSet;
            // 
            // dannaEmployeesDataSet
            // 
            this.dannaEmployeesDataSet.DataSetName = "DannaEmployeesDataSet";
            this.dannaEmployeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKemployeesmanag3E52440BBindingSource1
            // 
            this.fKemployeesmanag3E52440BBindingSource1.DataMember = "FK__employees__manag__3E52440B";
            this.fKemployeesmanag3E52440BBindingSource1.DataSource = this.employeesBindingSource;
            // 
            // fKemployeesmanag3E52440BBindingSource
            // 
            this.fKemployeesmanag3E52440BBindingSource.DataMember = "FK__employees__manag__3E52440B";
            this.fKemployeesmanag3E52440BBindingSource.DataSource = this.employeesBindingSource;
            // 
            // comboBoxCiudad
            // 
            this.comboBoxCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxCiudad.FormattingEnabled = true;
            this.comboBoxCiudad.Location = new System.Drawing.Point(58, 554);
            this.comboBoxCiudad.Name = "comboBoxCiudad";
            this.comboBoxCiudad.Size = new System.Drawing.Size(306, 28);
            this.comboBoxCiudad.TabIndex = 48;
            this.comboBoxCiudad.SelectedIndexChanged += new System.EventHandler(this.comboBoxCiudad_SelectedIndexChanged_1);
            // 
            // locationsBindingSource
            // 
            this.locationsBindingSource.DataMember = "locations";
            this.locationsBindingSource.DataSource = this.dannaEmployeesDataSet;
            // 
            // locationsTableAdapter
            // 
            this.locationsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxNombre.Location = new System.Drawing.Point(555, 555);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(313, 26);
            this.textBoxNombre.TabIndex = 49;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxApellido.Location = new System.Drawing.Point(1056, 556);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(313, 26);
            this.textBoxApellido.TabIndex = 50;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1501, 705);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.comboBoxCiudad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dannaEmployeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKemployeesmanag3E52440BBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKemployeesmanag3E52440BBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxCiudad;
        private DannaEmployeesDataSet dannaEmployeesDataSet;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private DannaEmployeesDataSetTableAdapters.locationsTableAdapter locationsTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private DannaEmployeesDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource fKemployeesmanag3E52440BBindingSource;
        private System.Windows.Forms.BindingSource fKemployeesmanag3E52440BBindingSource1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
    }
}

