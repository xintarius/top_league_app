namespace pabpro
{
    partial class Dane
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tbxz1 = new System.Windows.Forms.TextBox();
            this.tbxz2 = new System.Windows.Forms.TextBox();
            this.tbxt1 = new System.Windows.Forms.TextBox();
            this.tbxt2 = new System.Windows.Forms.TextBox();
            this.tbxp1 = new System.Windows.Forms.TextBox();
            this.tbxp2 = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.odkiedyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokiedyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozycjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stawkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.przynależnośćdodrużynyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trenerImięDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trenerNazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trenerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zawodnikImięDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zawodnikNazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zawodnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przynależnośćdodrużynyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trenerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zawodnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zawodnikImięDataGridViewTextBoxColumn,
            this.zawodnikNazwiskoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zawodnikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(319, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trenerImięDataGridViewTextBoxColumn,
            this.trenerNazwiskoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.trenerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(524, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(309, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odkiedyDataGridViewTextBoxColumn,
            this.dokiedyDataGridViewTextBoxColumn,
            this.pozycjaDataGridViewTextBoxColumn,
            this.stawkaDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.przynależnośćdodrużynyBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(114, 321);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(449, 150);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(337, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(839, 155);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 14;
            this.button10.Text = "Dodaj";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(839, 184);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 13;
            this.button11.Text = "Zapisz";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(839, 213);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 12;
            this.button12.Text = "Usuń";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(569, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Dodaj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(569, 419);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Zapisz";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(569, 448);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Usuń";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tbxz1
            // 
            this.tbxz1.Location = new System.Drawing.Point(47, 242);
            this.tbxz1.Name = "tbxz1";
            this.tbxz1.Size = new System.Drawing.Size(100, 20);
            this.tbxz1.TabIndex = 18;
            // 
            // tbxz2
            // 
            this.tbxz2.Location = new System.Drawing.Point(231, 243);
            this.tbxz2.Name = "tbxz2";
            this.tbxz2.Size = new System.Drawing.Size(100, 20);
            this.tbxz2.TabIndex = 19;
            // 
            // tbxt1
            // 
            this.tbxt1.Location = new System.Drawing.Point(556, 244);
            this.tbxt1.Name = "tbxt1";
            this.tbxt1.Size = new System.Drawing.Size(100, 20);
            this.tbxt1.TabIndex = 20;
            // 
            // tbxt2
            // 
            this.tbxt2.Location = new System.Drawing.Point(733, 244);
            this.tbxt2.Name = "tbxt2";
            this.tbxt2.Size = new System.Drawing.Size(100, 20);
            this.tbxt2.TabIndex = 21;
            // 
            // tbxp1
            // 
            this.tbxp1.Location = new System.Drawing.Point(463, 477);
            this.tbxp1.Name = "tbxp1";
            this.tbxp1.Size = new System.Drawing.Size(100, 20);
            this.tbxp1.TabIndex = 24;
            // 
            // tbxp2
            // 
            this.tbxp2.Location = new System.Drawing.Point(463, 510);
            this.tbxp2.Name = "tbxp2";
            this.tbxp2.Size = new System.Drawing.Size(100, 20);
            this.tbxp2.TabIndex = 25;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(114, 477);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 26;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(114, 502);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 20);
            this.dtp2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 35);
            this.label1.TabIndex = 28;
            this.label1.Text = "Dane";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(614, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Trenerzy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(82, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "Zawodnicy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.Location = new System.Drawing.Point(204, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 26);
            this.label4.TabIndex = 31;
            this.label4.Text = "Przynalezność do drużyny";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(696, 333);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 40);
            this.button7.TabIndex = 32;
            this.button7.Text = "Dane";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(787, 333);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 40);
            this.button8.TabIndex = 33;
            this.button8.Text = "Statystyki";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(878, 333);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 40);
            this.button9.TabIndex = 34;
            this.button9.Text = "Spotkania";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Imię:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nazwisko:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Imię:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Nazwisko:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Pozycja:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 513);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Stawka:";
            // 
            // odkiedyDataGridViewTextBoxColumn
            // 
            this.odkiedyDataGridViewTextBoxColumn.DataPropertyName = "Od_kiedy";
            this.odkiedyDataGridViewTextBoxColumn.HeaderText = "Od_kiedy";
            this.odkiedyDataGridViewTextBoxColumn.Name = "odkiedyDataGridViewTextBoxColumn";
            // 
            // dokiedyDataGridViewTextBoxColumn
            // 
            this.dokiedyDataGridViewTextBoxColumn.DataPropertyName = "Do_kiedy";
            this.dokiedyDataGridViewTextBoxColumn.HeaderText = "Do_kiedy";
            this.dokiedyDataGridViewTextBoxColumn.Name = "dokiedyDataGridViewTextBoxColumn";
            // 
            // pozycjaDataGridViewTextBoxColumn
            // 
            this.pozycjaDataGridViewTextBoxColumn.DataPropertyName = "Pozycja";
            this.pozycjaDataGridViewTextBoxColumn.HeaderText = "Pozycja";
            this.pozycjaDataGridViewTextBoxColumn.Name = "pozycjaDataGridViewTextBoxColumn";
            // 
            // stawkaDataGridViewTextBoxColumn
            // 
            this.stawkaDataGridViewTextBoxColumn.DataPropertyName = "Stawka";
            this.stawkaDataGridViewTextBoxColumn.HeaderText = "Stawka";
            this.stawkaDataGridViewTextBoxColumn.Name = "stawkaDataGridViewTextBoxColumn";
            // 
            // przynależnośćdodrużynyBindingSource
            // 
            this.przynależnośćdodrużynyBindingSource.DataSource = typeof(pabpro.Przynależność);
            // 
            // trenerImięDataGridViewTextBoxColumn
            // 
            this.trenerImięDataGridViewTextBoxColumn.DataPropertyName = "Trener_Imię";
            this.trenerImięDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.trenerImięDataGridViewTextBoxColumn.Name = "trenerImięDataGridViewTextBoxColumn";
            // 
            // trenerNazwiskoDataGridViewTextBoxColumn
            // 
            this.trenerNazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Trener_Nazwisko";
            this.trenerNazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.trenerNazwiskoDataGridViewTextBoxColumn.Name = "trenerNazwiskoDataGridViewTextBoxColumn";
            // 
            // trenerBindingSource
            // 
            this.trenerBindingSource.DataSource = typeof(pabpro.Trener);
            // 
            // zawodnikImięDataGridViewTextBoxColumn
            // 
            this.zawodnikImięDataGridViewTextBoxColumn.DataPropertyName = "Zawodnik_Imię";
            this.zawodnikImięDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.zawodnikImięDataGridViewTextBoxColumn.Name = "zawodnikImięDataGridViewTextBoxColumn";
            // 
            // zawodnikNazwiskoDataGridViewTextBoxColumn
            // 
            this.zawodnikNazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Zawodnik_Nazwisko";
            this.zawodnikNazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.zawodnikNazwiskoDataGridViewTextBoxColumn.Name = "zawodnikNazwiskoDataGridViewTextBoxColumn";
            // 
            // zawodnikBindingSource
            // 
            this.zawodnikBindingSource.DataSource = typeof(pabpro.Zawodnik);
            // 
            // Dane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 534);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.tbxp2);
            this.Controls.Add(this.tbxp1);
            this.Controls.Add(this.tbxt2);
            this.Controls.Add(this.tbxt1);
            this.Controls.Add(this.tbxz2);
            this.Controls.Add(this.tbxz1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Dane";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przynależnośćdodrużynyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trenerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zawodnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zawodnikImięDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zawodnikNazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zawodnikBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource trenerBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn odkiedyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokiedyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozycjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stawkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource przynależnośćdodrużynyBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tbxz1;
        private System.Windows.Forms.TextBox tbxz2;
        private System.Windows.Forms.TextBox tbxt1;
        private System.Windows.Forms.TextBox tbxt2;
        private System.Windows.Forms.TextBox tbxp1;
        private System.Windows.Forms.TextBox tbxp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DataGridViewTextBoxColumn trenerImięDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trenerNazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}