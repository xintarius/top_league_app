namespace pabpro
{
    partial class Spotkania
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.drużyna1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drużynaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.meczBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MiejscabindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TerminarzbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Drużyna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminarzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drużynaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meczBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiejscabindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerminarzbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drużyna1DataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.drużynaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(65, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // drużyna1DataGridViewTextBoxColumn1
            // 
            this.drużyna1DataGridViewTextBoxColumn1.DataPropertyName = "Drużyna1";
            this.drużyna1DataGridViewTextBoxColumn1.HeaderText = "Drużyna1";
            this.drużyna1DataGridViewTextBoxColumn1.Name = "drużyna1DataGridViewTextBoxColumn1";
            // 
            // drużynaBindingSource
            // 
            this.drużynaBindingSource.DataSource = typeof(pabpro.Drużyna);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Drużyna1,
            this.miejscaDataGridViewTextBoxColumn,
            this.terminarzDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.meczBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(333, 92);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(346, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // meczBindingSource
            // 
            this.meczBindingSource.DataSource = typeof(pabpro.Mecz);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Drużyna";
            this.dataGridViewTextBoxColumn1.HeaderText = "Drużyna";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Drużyna1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Drużyna1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tworzenie Spotkań";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.label1.Location = new System.Drawing.Point(266, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spotkania";
            // 
            // MiejscabindingSource
            // 
            this.MiejscabindingSource.DataSource = typeof(pabpro.Miejsca);
            // 
            // TerminarzbindingSource
            // 
            this.TerminarzbindingSource.DataSource = typeof(pabpro.Terminarz);
            // 
            // Drużyna1
            // 
            this.Drużyna1.DataPropertyName = "Drużyna1";
            this.Drużyna1.HeaderText = "Drużyna2";
            this.Drużyna1.Name = "Drużyna1";
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
            // Spotkania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Spotkania";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drużynaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meczBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiejscabindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerminarzbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn drużyna1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource drużynaBindingSource;
        private System.Windows.Forms.BindingSource meczBindingSource;
        private System.Windows.Forms.BindingSource MiejscabindingSource;
        private System.Windows.Forms.BindingSource TerminarzbindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drużyna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminarzDataGridViewTextBoxColumn;
    }
}