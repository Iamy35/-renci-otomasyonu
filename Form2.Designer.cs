
namespace öğrenci_kayıt
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelNo = new System.Windows.Forms.Label();
            this.labelmidterm = new System.Windows.Forms.Label();
            this.labelfinaex = new System.Windows.Forms.Label();
            this.labelretake = new System.Windows.Forms.Label();
            this.labelstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student midterm exam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student final exam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(55, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Student re-take exam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Location = new System.Drawing.Point(269, 67);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(75, 27);
            this.labelname.TabIndex = 6;
            this.labelname.Text = "NULL";
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.BackColor = System.Drawing.Color.Transparent;
            this.labelNo.Location = new System.Drawing.Point(274, 102);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(75, 27);
            this.labelNo.TabIndex = 7;
            this.labelNo.Text = "NULL";
            // 
            // labelmidterm
            // 
            this.labelmidterm.AutoSize = true;
            this.labelmidterm.BackColor = System.Drawing.Color.Transparent;
            this.labelmidterm.ForeColor = System.Drawing.Color.White;
            this.labelmidterm.Location = new System.Drawing.Point(421, 246);
            this.labelmidterm.Name = "labelmidterm";
            this.labelmidterm.Size = new System.Drawing.Size(48, 27);
            this.labelmidterm.TabIndex = 8;
            this.labelmidterm.Text = "00";
            this.labelmidterm.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelfinaex
            // 
            this.labelfinaex.AutoSize = true;
            this.labelfinaex.BackColor = System.Drawing.Color.Transparent;
            this.labelfinaex.ForeColor = System.Drawing.Color.White;
            this.labelfinaex.Location = new System.Drawing.Point(421, 280);
            this.labelfinaex.Name = "labelfinaex";
            this.labelfinaex.Size = new System.Drawing.Size(48, 27);
            this.labelfinaex.TabIndex = 9;
            this.labelfinaex.Text = "00";
            this.labelfinaex.Click += new System.EventHandler(this.label10_Click);
            // 
            // labelretake
            // 
            this.labelretake.AutoSize = true;
            this.labelretake.BackColor = System.Drawing.Color.Transparent;
            this.labelretake.ForeColor = System.Drawing.Color.White;
            this.labelretake.Location = new System.Drawing.Point(426, 336);
            this.labelretake.Name = "labelretake";
            this.labelretake.Size = new System.Drawing.Size(48, 27);
            this.labelretake.TabIndex = 10;
            this.labelretake.Text = "00";
            this.labelretake.Click += new System.EventHandler(this.label11_Click);
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.BackColor = System.Drawing.Color.Transparent;
            this.labelstatus.ForeColor = System.Drawing.Color.White;
            this.labelstatus.Location = new System.Drawing.Point(426, 377);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(75, 27);
            this.labelstatus.TabIndex = 11;
            this.labelstatus.Text = "Null";
            this.labelstatus.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::öğrenci_kayıt.Properties.Resources.gif_mugi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 490);
            this.Controls.Add(this.labelstatus);
            this.Controls.Add(this.labelretake);
            this.Controls.Add(this.labelfinaex);
            this.Controls.Add(this.labelmidterm);
            this.Controls.Add(this.labelNo);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Manga Temple", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form2";
            this.Text = "K-On öğrenci";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Label labelmidterm;
        private System.Windows.Forms.Label labelfinaex;
        private System.Windows.Forms.Label labelretake;
        private System.Windows.Forms.Label labelstatus;
    }
}