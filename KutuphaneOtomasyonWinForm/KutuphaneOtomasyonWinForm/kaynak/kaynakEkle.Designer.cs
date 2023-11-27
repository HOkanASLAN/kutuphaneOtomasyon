namespace KutuphaneOtomasyonWinForm.kaynak
{
    partial class kaynakEkle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adKaynaktxt = new System.Windows.Forms.TextBox();
            this.yazarKaynaktxt = new System.Windows.Forms.TextBox();
            this.yayinciKaynaktxt = new System.Windows.Forms.TextBox();
            this.sSayisi = new System.Windows.Forms.NumericUpDown();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.kaynakEklebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yayıncı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sayfa Sayısı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tarih :";
            // 
            // adKaynaktxt
            // 
            this.adKaynaktxt.Location = new System.Drawing.Point(84, 44);
            this.adKaynaktxt.Name = "adKaynaktxt";
            this.adKaynaktxt.Size = new System.Drawing.Size(197, 20);
            this.adKaynaktxt.TabIndex = 2;
            // 
            // yazarKaynaktxt
            // 
            this.yazarKaynaktxt.Location = new System.Drawing.Point(84, 72);
            this.yazarKaynaktxt.Name = "yazarKaynaktxt";
            this.yazarKaynaktxt.Size = new System.Drawing.Size(197, 20);
            this.yazarKaynaktxt.TabIndex = 2;
            // 
            // yayinciKaynaktxt
            // 
            this.yayinciKaynaktxt.Location = new System.Drawing.Point(84, 103);
            this.yayinciKaynaktxt.Name = "yayinciKaynaktxt";
            this.yayinciKaynaktxt.Size = new System.Drawing.Size(197, 20);
            this.yayinciKaynaktxt.TabIndex = 2;
            // 
            // sSayisi
            // 
            this.sSayisi.Location = new System.Drawing.Point(85, 134);
            this.sSayisi.Name = "sSayisi";
            this.sSayisi.Size = new System.Drawing.Size(196, 20);
            this.sSayisi.TabIndex = 3;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(85, 165);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(200, 20);
            this.tarih.TabIndex = 4;
            // 
            // kaynakEklebtn
            // 
            this.kaynakEklebtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.kaynakEklebtn.Location = new System.Drawing.Point(85, 214);
            this.kaynakEklebtn.Name = "kaynakEklebtn";
            this.kaynakEklebtn.Size = new System.Drawing.Size(196, 23);
            this.kaynakEklebtn.TabIndex = 5;
            this.kaynakEklebtn.Text = "EKLE";
            this.kaynakEklebtn.UseVisualStyleBackColor = false;
            this.kaynakEklebtn.Click += new System.EventHandler(this.kaynakEklebtn_Click);
            // 
            // kaynakEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 390);
            this.Controls.Add(this.kaynakEklebtn);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.sSayisi);
            this.Controls.Add(this.yayinciKaynaktxt);
            this.Controls.Add(this.yazarKaynaktxt);
            this.Controls.Add(this.adKaynaktxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kaynakEkle";
            this.Text = "kaynakEkle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adKaynaktxt;
        private System.Windows.Forms.TextBox yazarKaynaktxt;
        private System.Windows.Forms.TextBox yayinciKaynaktxt;
        private System.Windows.Forms.NumericUpDown sSayisi;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Button kaynakEklebtn;
    }
}