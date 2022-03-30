namespace pabpro
{
    partial class TworzenieSpotkań
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.drużynaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drużyna1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminarzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meczBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.zadaniepabADataSet = new pabpro.zadaniepabADataSet();
            this.meczBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meczTableAdapter = new pabpro.zadaniepabADataSetTableAdapters.MeczTableAdapter();
            this.Cb1 = new System.Windows.Forms.ComboBox();
            this.drużynaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zadaniepabADataSet1 = new pabpro.zadaniepabADataSet1();
            this.drużynaTableAdapter = new pabpro.zadaniepabADataSet1TableAdapters.DrużynaTableAdapter();
            this.Cb2 = new System.Windows.Forms.ComboBox();
            this.drużynaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zadaniepabADataSet2 = new pabpro.zadaniepabADataSet2();
            this.drużynaTableAdapter1 = new pabpro.zadaniepabADataSet2TableAdapters.DrużynaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.Cb3 = new System.Windows.Forms.ComboBox();
            this.miejscaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zadaniepabADataSet3 = new pabpro.zadaniepabADataSet3();
            this.Cb4 = new System.Windows.Forms.ComboBox();
            this.terminarzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zadaniepabADataSet4 = new pabpro.zadaniepabADataSet4();
            this.miejscaTableAdapter = new pabpro.zadaniepabADataSet3TableAdapters.MiejscaTableAdapter();
            this.terminarzTableAdapter = new pabpro.zadaniepabADataSet4TableAdapters.TerminarzTableAdapter();
            this.zadaniepabADataSet5 = new pabpro.zadaniepabADataSet5();
            this.meczBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.meczTableAdapter1 = new pabpro.zadaniepabADataSet5TableAdapters.MeczTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meczBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadaniepabADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meczBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drużynaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadaniepabADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drużynaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadaniepabADataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miejscaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadaniepabADataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminarzBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadaniepabADataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadaniepabADataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meczBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drużynaDataGridViewTextBoxColumn,
            this.drużyna1DataGridViewTextBoxColumn,
            this.miejscaDataGridViewTextBoxColumn,
            this.terminarzDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.meczBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(182, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // drużynaDataGridViewTextBoxColumn
            // 
            this.drużynaDataGridViewTextBoxColumn.DataPropertyName = "Drużyna";
            this.drużynaDataGridViewTextBoxColumn.HeaderText = "Drużyna";
            this.drużynaDataGridViewTextBoxColumn.Name = "drużynaDataGridViewTextBoxColumn";
            // 
            // drużyna1DataGridViewTextBoxColumn
            // 
            this.drużyna1DataGridViewTextBoxColumn.DataPropertyName = "Drużyna1";
            this.drużyna1DataGridViewTextBoxColumn.HeaderText = "Drużyna1";
            this.drużyna1DataGridViewTextBoxColumn.Name = "drużyna1DataGridViewTextBoxColumn";
            // 
            // miejscaDataGridViewTextBoxColumn
            // 
            this.miejscaDataGridViewTextBoxColumn.DataPropertyName = "Miejsca";
            this.miejscaDataGridViewTextBoxColumn.HeaderText = "Miejsca";
            this.miejscaDataGridViewTextBoxColumn.Name = "miejscaDataGridViewTextBoxColumn";
            // 
            // terminarzDataGridViewTextBoxColumn
            // 
            this.terminarzDataGridViewTextBoxColumn.DataPropertyName = "Terminarz";
            this.terminarzDataGridViewTextBoxColumn.HeaderText = "Terminarz";
            this.terminarzDataGridViewTextBoxColumn.Name = "terminarzDataGridViewTextBoxColumn";
            // 
            // meczBindingSource2
            // 
            this.meczBindingSource2.DataSource = typeof(pabpro.Mecz);
            // 
            // zadaniepabADataSet
            // 
            this.zadaniepabADataSet.DataSetName = "zadaniepabADataSet";
            this.zadaniepabADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meczBindingSource
            // 
            this.meczBindingSource.DataMember = "Mecz";
            this.meczBindingSource.DataSource = this.zadaniepabADataSet;
            // 
            // meczTableAdapter
            // 
            this.meczTableAdapter.ClearBeforeFill = true;
            // 
            // Cb1
            // 
            this.Cb1.DataSource = this.drużynaBindingSource;
            this.Cb1.DisplayMember = "Drużyna";
            this.Cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb1.FormattingEnabled = true;
            this.Cb1.Location = new System.Drawing.Point(240, 256);
            this.Cb1.Name = "Cb1";
            this.Cb1.Size = new System.Drawing.Size(121, 21);
            this.Cb1.TabIndex = 1;
            this.Cb1.ValueMember = "Drużyna_ID";
            // 
            // drużynaBindingSource
            // 
            this.drużynaBindingSource.DataMember = "Drużyna";
            this.drużynaBindingSource.DataSource = this.zadaniepabADataSet1;
            // 
            // zadaniepabADataSet1
            // 
            this.zadaniepabADataSet1.DataSetName = "zadaniepabADataSet1";
            this.zadaniepabADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drużynaTableAdapter
            // 
            this.drużynaTableAdapter.ClearBeforeFill = true;
            // 
            // Cb2
            // 
            this.Cb2.DataSource = this.drużynaBindingSource1;
            this.Cb2.DisplayMember = "Drużyna";
            this.Cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb2.FormattingEnabled = true;
            this.Cb2.Location = new System.Drawing.Point(240, 285);
            this.Cb2.Name = "Cb2";
            this.Cb2.Size = new System.Drawing.Size(121, 21);
            this.Cb2.TabIndex = 2;
            this.Cb2.ValueMember = "Drużyna_ID";
            // 
            // drużynaBindingSource1
            // 
            this.drużynaBindingSource1.DataMember = "Drużyna";
            this.drużynaBindingSource1.DataSource = this.zadaniepabADataSet2;
            // 
            // zadaniepabADataSet2
            // 
            this.zadaniepabADataSet2.DataSetName = "zadaniepabADataSet2";
            this.zadaniepabADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drużynaTableAdapter1
            // 
            this.drużynaTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cb3
            // 
            this.Cb3.DataSource = this.miejscaBindingSource;
            this.Cb3.DisplayMember = "Miejscowość";
            this.Cb3.FormattingEnabled = true;
            this.Cb3.Location = new System.Drawing.Point(516, 256);
            this.Cb3.Name = "Cb3";
            this.Cb3.Size = new System.Drawing.Size(121, 21);
            this.Cb3.TabIndex = 4;
            this.Cb3.ValueMember = "Miejsca_ID";
            // 
            // miejscaBindingSource
            // 
            this.miejscaBindingSource.DataMember = "Miejsca";
            this.miejscaBindingSource.DataSource = this.zadaniepabADataSet3;
            // 
            // zadaniepabADataSet3
            // 
            this.zadaniepabADataSet3.DataSetName = "zadaniepabADataSet3";
            this.zadaniepabADataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cb4
            // 
            this.Cb4.DataSource = this.terminarzBindingSource;
            this.Cb4.DisplayMember = "Data";
            this.Cb4.FormattingEnabled = true;
            this.Cb4.Location = new System.Drawing.Point(516, 285);
            this.Cb4.Name = "Cb4";
            this.Cb4.Size = new System.Drawing.Size(121, 21);
            this.Cb4.TabIndex = 5;
            this.Cb4.ValueMember = "Treminarz_ID";
            // 
            // terminarzBindingSource
            // 
            this.terminarzBindingSource.DataMember = "Terminarz";
            this.terminarzBindingSource.DataSource = this.zadaniepabADataSet4;
            // 
            // zadaniepabADataSet4
            // 
            this.zadaniepabADataSet4.DataSetName = "zadaniepabADataSet4";
            this.zadaniepabADataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // miejscaTableAdapter
            // 
            this.miejscaTableAdapter.ClearBeforeFill = true;
            // 
            // terminarzTableAdapter
            // 
            this.terminarzTableAdapter.ClearBeforeFill = true;
            // 
            // zadaniepabADataSet5
            // 
            this.zadaniepabADataSet5.DataSetName = "zadaniepabADataSet5";
            this.zadaniepabADataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meczBindingSource1
            // 
            this.meczBindingSource1.DataMember = "Mecz";
            this.meczBindingSource1.DataSource = this.zadaniepabADataSet5;
            // 
            // meczTableAdapter1
            // 
            this.meczTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Spotkania";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(643, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Modyfikacja";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(179, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Drużyna:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Drużyna1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Miejsca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Terminarz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.label5.Location = new System.Drawing.Point(261, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 35);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tworzenie Spotkań";
            // 
            // TworzenieSpotkań
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Cb4);
            this.Controls.Add(this.Cb3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cb2);
            this.Controls.Add(this.Cb1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TworzenieSpotkań";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meczBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadaniepabADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meczBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drużynaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadaniepabADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drużynaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadaniepabADataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miejscaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadaniepabADataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminarzBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadaniepabADataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadaniepabADataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meczBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private zadaniepabADataSet zadaniepabADataSet;
        private System.Windows.Forms.BindingSource meczBindingSource;
        private zadaniepabADataSetTableAdapters.MeczTableAdapter meczTableAdapter;
        private System.Windows.Forms.ComboBox Cb1;
        private zadaniepabADataSet1 zadaniepabADataSet1;
        private System.Windows.Forms.BindingSource drużynaBindingSource;
        private zadaniepabADataSet1TableAdapters.DrużynaTableAdapter drużynaTableAdapter;
        private System.Windows.Forms.ComboBox Cb2;
        private zadaniepabADataSet2 zadaniepabADataSet2;
        private System.Windows.Forms.BindingSource drużynaBindingSource1;
        private zadaniepabADataSet2TableAdapters.DrużynaTableAdapter drużynaTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Cb3;
        private System.Windows.Forms.ComboBox Cb4;
        private zadaniepabADataSet3 zadaniepabADataSet3;
        private System.Windows.Forms.BindingSource miejscaBindingSource;
        private zadaniepabADataSet3TableAdapters.MiejscaTableAdapter miejscaTableAdapter;
        private zadaniepabADataSet4 zadaniepabADataSet4;
        private System.Windows.Forms.BindingSource terminarzBindingSource;
        private zadaniepabADataSet4TableAdapters.TerminarzTableAdapter terminarzTableAdapter;
        private zadaniepabADataSet5 zadaniepabADataSet5;
        private System.Windows.Forms.BindingSource meczBindingSource1;
        private zadaniepabADataSet5TableAdapters.MeczTableAdapter meczTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn drużynaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drużyna1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminarzDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource meczBindingSource2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

