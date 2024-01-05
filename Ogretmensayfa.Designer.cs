
namespace öğrenci_kayıt
{
    partial class Ogretmensayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogretmensayfa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msk1 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxsurname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtretake = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfinalex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmidterm = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblaverage = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbnotkayitDataSet = new öğrenci_kayıt.DbnotkayitDataSet();
            this.tbldersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbldersTableAdapter = new öğrenci_kayıt.DbnotkayitDataSetTableAdapters.tbldersTableAdapter();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenumaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrvizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrfinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrbutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrortalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrdurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbnotkayitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxsurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxname);
            this.groupBox1.Controls.Add(this.msk1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 494);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Students";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student No:";
            // 
            // msk1
            // 
            this.msk1.Location = new System.Drawing.Point(203, 95);
            this.msk1.Mask = "0000";
            this.msk1.Name = "msk1";
            this.msk1.Size = new System.Drawing.Size(136, 34);
            this.msk1.TabIndex = 1;
            this.msk1.ValidatingType = typeof(int);
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(214, 142);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(136, 34);
            this.textBoxname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname";
            // 
            // textBoxsurname
            // 
            this.textBoxsurname.Location = new System.Drawing.Point(214, 193);
            this.textBoxsurname.Name = "textBoxsurname";
            this.textBoxsurname.Size = new System.Drawing.Size(136, 34);
            this.textBoxsurname.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.PapayaWhip;
            this.button1.Location = new System.Drawing.Point(89, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtmidterm);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtretake);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtfinalex);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(760, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 488);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Exam Notes";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.PapayaWhip;
            this.button2.Location = new System.Drawing.Point(89, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtretake
            // 
            this.txtretake.Location = new System.Drawing.Point(214, 193);
            this.txtretake.Name = "txtretake";
            this.txtretake.Size = new System.Drawing.Size(136, 34);
            this.txtretake.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "re-take";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Final";
            // 
            // txtfinalex
            // 
            this.txtfinalex.Location = new System.Drawing.Point(214, 142);
            this.txtfinalex.Name = "txtfinalex";
            this.txtfinalex.Size = new System.Drawing.Size(136, 34);
            this.txtfinalex.TabIndex = 2;
            this.txtfinalex.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Midterm";
            // 
            // txtmidterm
            // 
            this.txtmidterm.Location = new System.Drawing.Point(214, 95);
            this.txtmidterm.Name = "txtmidterm";
            this.txtmidterm.Size = new System.Drawing.Size(136, 34);
            this.txtmidterm.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblaverage);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(393, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 337);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show Average";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Exam Avarages:";
            // 
            // lblaverage
            // 
            this.lblaverage.AutoSize = true;
            this.lblaverage.Location = new System.Drawing.Point(244, 81);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(48, 27);
            this.lblaverage.TabIndex = 1;
            this.lblaverage.Text = "00";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(0, 358);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(809, 283);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "student List";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogradiDataGridViewTextBoxColumn,
            this.ogrenumaraDataGridViewTextBoxColumn,
            this.ogrvizeDataGridViewTextBoxColumn,
            this.ogrfinalDataGridViewTextBoxColumn,
            this.ogrbutDataGridViewTextBoxColumn,
            this.ogrortalamaDataGridViewTextBoxColumn,
            this.ogrdurumDataGridViewCheckBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbldersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 447);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1122, 244);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dbnotkayitDataSet
            // 
            this.dbnotkayitDataSet.DataSetName = "DbnotkayitDataSet";
            this.dbnotkayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbldersBindingSource
            // 
            this.tbldersBindingSource.DataMember = "tblders";
            this.tbldersBindingSource.DataSource = this.dbnotkayitDataSet;
            // 
            // tbldersTableAdapter
            // 
            this.tbldersTableAdapter.ClearBeforeFill = true;
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "ogrid";
            this.ogridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogradiDataGridViewTextBoxColumn
            // 
            this.ogradiDataGridViewTextBoxColumn.DataPropertyName = "ogradi";
            this.ogradiDataGridViewTextBoxColumn.HeaderText = "ogradi";
            this.ogradiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogradiDataGridViewTextBoxColumn.Name = "ogradiDataGridViewTextBoxColumn";
            // 
            // ogrenumaraDataGridViewTextBoxColumn
            // 
            this.ogrenumaraDataGridViewTextBoxColumn.DataPropertyName = "ogrenumara";
            this.ogrenumaraDataGridViewTextBoxColumn.HeaderText = "ogrenumara";
            this.ogrenumaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenumaraDataGridViewTextBoxColumn.Name = "ogrenumaraDataGridViewTextBoxColumn";
            // 
            // ogrvizeDataGridViewTextBoxColumn
            // 
            this.ogrvizeDataGridViewTextBoxColumn.DataPropertyName = "ogrvize";
            this.ogrvizeDataGridViewTextBoxColumn.HeaderText = "ogrvize";
            this.ogrvizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrvizeDataGridViewTextBoxColumn.Name = "ogrvizeDataGridViewTextBoxColumn";
            // 
            // ogrfinalDataGridViewTextBoxColumn
            // 
            this.ogrfinalDataGridViewTextBoxColumn.DataPropertyName = "ogrfinal";
            this.ogrfinalDataGridViewTextBoxColumn.HeaderText = "ogrfinal";
            this.ogrfinalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrfinalDataGridViewTextBoxColumn.Name = "ogrfinalDataGridViewTextBoxColumn";
            // 
            // ogrbutDataGridViewTextBoxColumn
            // 
            this.ogrbutDataGridViewTextBoxColumn.DataPropertyName = "ogrbut";
            this.ogrbutDataGridViewTextBoxColumn.HeaderText = "ogrbut";
            this.ogrbutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrbutDataGridViewTextBoxColumn.Name = "ogrbutDataGridViewTextBoxColumn";
            // 
            // ogrortalamaDataGridViewTextBoxColumn
            // 
            this.ogrortalamaDataGridViewTextBoxColumn.DataPropertyName = "ogrortalama";
            this.ogrortalamaDataGridViewTextBoxColumn.HeaderText = "ogrortalama";
            this.ogrortalamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrortalamaDataGridViewTextBoxColumn.Name = "ogrortalamaDataGridViewTextBoxColumn";
            // 
            // ogrdurumDataGridViewCheckBoxColumn
            // 
            this.ogrdurumDataGridViewCheckBoxColumn.DataPropertyName = "ogrdurum";
            this.ogrdurumDataGridViewCheckBoxColumn.HeaderText = "ogrdurum";
            this.ogrdurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ogrdurumDataGridViewCheckBoxColumn.Name = "ogrdurumDataGridViewCheckBoxColumn";
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            // 
            // Ogretmensayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::öğrenci_kayıt.Properties.Resources.shy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 709);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Manga Temple", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Ogretmensayfa";
            this.Text = "k-on öğretmen sayfası";
            this.Load += new System.EventHandler(this.Ogretmensayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbnotkayitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxsurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.MaskedTextBox msk1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtretake;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfinalex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmidterm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblaverage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbnotkayitDataSet dbnotkayitDataSet;
        private System.Windows.Forms.BindingSource tbldersBindingSource;
        private DbnotkayitDataSetTableAdapters.tbldersTableAdapter tbldersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenumaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrvizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrfinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrbutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ogrdurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
    }
}