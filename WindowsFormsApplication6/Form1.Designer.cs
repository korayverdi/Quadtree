namespace WindowsFormsApplication6
{
    partial class Form1
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
            this.Btn_rastgele = new System.Windows.Forms.Button();
            this.Btn_mouse_ile = new System.Windows.Forms.Button();
            this.Btn_agac_temizle = new System.Windows.Forms.Button();
            this.Btn_sorgu_temizle = new System.Windows.Forms.Button();
            this.textBox_sorgu_yaricap = new System.Windows.Forms.TextBox();
            this.Btn_mouse_ile_kaydet = new System.Windows.Forms.Button();
            this.Btn_rastgele_kaydet = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nokta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.koordinat_x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.koordinat_y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_dugum_say = new System.Windows.Forms.TextBox();
            this.btn_rastgele_baslat = new System.Windows.Forms.Button();
            this.lbl_dugum_say = new System.Windows.Forms.Label();
            this.btn_sorgu_olustur = new System.Windows.Forms.Button();
            this.lbl_sorgu_yaricap = new System.Windows.Forms.Label();
            this.btn_sorgu_durdur = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.sorgu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.merkez_x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.merkez_y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.kesisen_noktalar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.koordinat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Btn_rastgele
            // 
            this.Btn_rastgele.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_rastgele.Location = new System.Drawing.Point(531, 13);
            this.Btn_rastgele.Name = "Btn_rastgele";
            this.Btn_rastgele.Size = new System.Drawing.Size(112, 33);
            this.Btn_rastgele.TabIndex = 1;
            this.Btn_rastgele.Text = "Rastgele oluştur";
            this.Btn_rastgele.UseVisualStyleBackColor = true;
            this.Btn_rastgele.Click += new System.EventHandler(this.Btn_rastgele_Click);
            // 
            // Btn_mouse_ile
            // 
            this.Btn_mouse_ile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_mouse_ile.Location = new System.Drawing.Point(531, 52);
            this.Btn_mouse_ile.Name = "Btn_mouse_ile";
            this.Btn_mouse_ile.Size = new System.Drawing.Size(112, 33);
            this.Btn_mouse_ile.TabIndex = 2;
            this.Btn_mouse_ile.Text = "Mouse ile oluştur";
            this.Btn_mouse_ile.UseVisualStyleBackColor = true;
            this.Btn_mouse_ile.Click += new System.EventHandler(this.Btn_mouse_ile_Click);
            // 
            // Btn_agac_temizle
            // 
            this.Btn_agac_temizle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_agac_temizle.Location = new System.Drawing.Point(531, 91);
            this.Btn_agac_temizle.Name = "Btn_agac_temizle";
            this.Btn_agac_temizle.Size = new System.Drawing.Size(112, 33);
            this.Btn_agac_temizle.TabIndex = 3;
            this.Btn_agac_temizle.Text = "Ağacı temizle";
            this.Btn_agac_temizle.UseVisualStyleBackColor = true;
            this.Btn_agac_temizle.Click += new System.EventHandler(this.Btn_agac_temizle_Click);
            // 
            // Btn_sorgu_temizle
            // 
            this.Btn_sorgu_temizle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_sorgu_temizle.Location = new System.Drawing.Point(531, 169);
            this.Btn_sorgu_temizle.Name = "Btn_sorgu_temizle";
            this.Btn_sorgu_temizle.Size = new System.Drawing.Size(112, 33);
            this.Btn_sorgu_temizle.TabIndex = 4;
            this.Btn_sorgu_temizle.Text = "Sorguları temizle";
            this.Btn_sorgu_temizle.UseVisualStyleBackColor = true;
            this.Btn_sorgu_temizle.Click += new System.EventHandler(this.Btn_sorgu_temizle_Click);
            // 
            // textBox_sorgu_yaricap
            // 
            this.textBox_sorgu_yaricap.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sorgu_yaricap.Location = new System.Drawing.Point(649, 213);
            this.textBox_sorgu_yaricap.Name = "textBox_sorgu_yaricap";
            this.textBox_sorgu_yaricap.Size = new System.Drawing.Size(118, 21);
            this.textBox_sorgu_yaricap.TabIndex = 6;
            this.textBox_sorgu_yaricap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_sorgu_yaricap_KeyPress);
            // 
            // Btn_mouse_ile_kaydet
            // 
            this.Btn_mouse_ile_kaydet.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_mouse_ile_kaydet.Location = new System.Drawing.Point(531, 52);
            this.Btn_mouse_ile_kaydet.Name = "Btn_mouse_ile_kaydet";
            this.Btn_mouse_ile_kaydet.Size = new System.Drawing.Size(112, 33);
            this.Btn_mouse_ile_kaydet.TabIndex = 8;
            this.Btn_mouse_ile_kaydet.Text = "Kaydet";
            this.Btn_mouse_ile_kaydet.UseVisualStyleBackColor = true;
            this.Btn_mouse_ile_kaydet.Visible = false;
            this.Btn_mouse_ile_kaydet.Click += new System.EventHandler(this.Btn_mouse_ile_kaydet_Click);
            // 
            // Btn_rastgele_kaydet
            // 
            this.Btn_rastgele_kaydet.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_rastgele_kaydet.Location = new System.Drawing.Point(531, 13);
            this.Btn_rastgele_kaydet.Name = "Btn_rastgele_kaydet";
            this.Btn_rastgele_kaydet.Size = new System.Drawing.Size(112, 33);
            this.Btn_rastgele_kaydet.TabIndex = 9;
            this.Btn_rastgele_kaydet.Text = "Kaydet";
            this.Btn_rastgele_kaydet.UseVisualStyleBackColor = true;
            this.Btn_rastgele_kaydet.Visible = false;
            this.Btn_rastgele_kaydet.Click += new System.EventHandler(this.Btn_rastgele_kaydet_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nokta,
            this.koordinat_x,
            this.koordinat_y});
            this.listView1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(531, 247);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(236, 279);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nokta
            // 
            this.Nokta.Text = "Nokta";
            // 
            // koordinat_x
            // 
            this.koordinat_x.Text = "x";
            this.koordinat_x.Width = 86;
            // 
            // koordinat_y
            // 
            this.koordinat_y.Text = "y";
            this.koordinat_y.Width = 86;
            // 
            // textBox_dugum_say
            // 
            this.textBox_dugum_say.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_dugum_say.Location = new System.Drawing.Point(288, 247);
            this.textBox_dugum_say.Name = "textBox_dugum_say";
            this.textBox_dugum_say.Size = new System.Drawing.Size(112, 21);
            this.textBox_dugum_say.TabIndex = 12;
            this.textBox_dugum_say.Visible = false;
            this.textBox_dugum_say.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_dugum_say_KeyPress);
            // 
            // btn_rastgele_baslat
            // 
            this.btn_rastgele_baslat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rastgele_baslat.Location = new System.Drawing.Point(244, 274);
            this.btn_rastgele_baslat.Name = "btn_rastgele_baslat";
            this.btn_rastgele_baslat.Size = new System.Drawing.Size(112, 33);
            this.btn_rastgele_baslat.TabIndex = 13;
            this.btn_rastgele_baslat.Text = "Başlat";
            this.btn_rastgele_baslat.UseVisualStyleBackColor = true;
            this.btn_rastgele_baslat.Visible = false;
            this.btn_rastgele_baslat.Click += new System.EventHandler(this.btn_rastgele_baslat_Click);
            // 
            // lbl_dugum_say
            // 
            this.lbl_dugum_say.AutoSize = true;
            this.lbl_dugum_say.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dugum_say.Location = new System.Drawing.Point(193, 250);
            this.lbl_dugum_say.Name = "lbl_dugum_say";
            this.lbl_dugum_say.Size = new System.Drawing.Size(89, 13);
            this.lbl_dugum_say.TabIndex = 14;
            this.lbl_dugum_say.Text = "Düğüm sayısı:";
            this.lbl_dugum_say.Visible = false;
            // 
            // btn_sorgu_olustur
            // 
            this.btn_sorgu_olustur.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sorgu_olustur.Location = new System.Drawing.Point(531, 130);
            this.btn_sorgu_olustur.Name = "btn_sorgu_olustur";
            this.btn_sorgu_olustur.Size = new System.Drawing.Size(112, 33);
            this.btn_sorgu_olustur.TabIndex = 15;
            this.btn_sorgu_olustur.Text = "Sorgu oluşur";
            this.btn_sorgu_olustur.UseVisualStyleBackColor = true;
            this.btn_sorgu_olustur.Click += new System.EventHandler(this.btn_sorgu_olustur_Click);
            // 
            // lbl_sorgu_yaricap
            // 
            this.lbl_sorgu_yaricap.AutoSize = true;
            this.lbl_sorgu_yaricap.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sorgu_yaricap.Location = new System.Drawing.Point(539, 216);
            this.lbl_sorgu_yaricap.Name = "lbl_sorgu_yaricap";
            this.lbl_sorgu_yaricap.Size = new System.Drawing.Size(95, 13);
            this.lbl_sorgu_yaricap.TabIndex = 16;
            this.lbl_sorgu_yaricap.Text = "Sorgu yarıçapı:";
            // 
            // btn_sorgu_durdur
            // 
            this.btn_sorgu_durdur.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sorgu_durdur.Location = new System.Drawing.Point(531, 130);
            this.btn_sorgu_durdur.Name = "btn_sorgu_durdur";
            this.btn_sorgu_durdur.Size = new System.Drawing.Size(112, 33);
            this.btn_sorgu_durdur.TabIndex = 17;
            this.btn_sorgu_durdur.Text = "Sorguyu bitir";
            this.btn_sorgu_durdur.UseVisualStyleBackColor = true;
            this.btn_sorgu_durdur.Visible = false;
            this.btn_sorgu_durdur.Click += new System.EventHandler(this.btn_sorgu_durdur_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sorgu,
            this.merkez_x,
            this.merkez_y});
            this.listView2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView2.Location = new System.Drawing.Point(322, 539);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(203, 108);
            this.listView2.TabIndex = 18;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // sorgu
            // 
            this.sorgu.Text = "Sorgu";
            this.sorgu.Width = 50;
            // 
            // merkez_x
            // 
            this.merkez_x.Text = "Merkez x";
            this.merkez_x.Width = 70;
            // 
            // merkez_y
            // 
            this.merkez_y.Text = "Merkez y";
            this.merkez_y.Width = 70;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kesisen_noktalar,
            this.koordinat});
            this.listView3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView3.Location = new System.Drawing.Point(531, 539);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(236, 108);
            this.listView3.TabIndex = 19;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // kesisen_noktalar
            // 
            this.kesisen_noktalar.Text = "Kesişen noktalar";
            this.kesisen_noktalar.Width = 110;
            // 
            // koordinat
            // 
            this.koordinat.Text = "Koordinat";
            this.koordinat.Width = 118;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(779, 661);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btn_sorgu_durdur);
            this.Controls.Add(this.lbl_sorgu_yaricap);
            this.Controls.Add(this.btn_sorgu_olustur);
            this.Controls.Add(this.lbl_dugum_say);
            this.Controls.Add(this.btn_rastgele_baslat);
            this.Controls.Add(this.textBox_dugum_say);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Btn_rastgele_kaydet);
            this.Controls.Add(this.Btn_mouse_ile_kaydet);
            this.Controls.Add(this.textBox_sorgu_yaricap);
            this.Controls.Add(this.Btn_sorgu_temizle);
            this.Controls.Add(this.Btn_agac_temizle);
            this.Controls.Add(this.Btn_mouse_ile);
            this.Controls.Add(this.Btn_rastgele);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_rastgele;
        private System.Windows.Forms.Button Btn_mouse_ile;
        private System.Windows.Forms.Button Btn_agac_temizle;
        private System.Windows.Forms.Button Btn_sorgu_temizle;
        private System.Windows.Forms.TextBox textBox_sorgu_yaricap;
        private System.Windows.Forms.Button Btn_mouse_ile_kaydet;
        private System.Windows.Forms.Button Btn_rastgele_kaydet;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nokta;
        private System.Windows.Forms.ColumnHeader koordinat_x;
        private System.Windows.Forms.ColumnHeader koordinat_y;
        private System.Windows.Forms.TextBox textBox_dugum_say;
        private System.Windows.Forms.Button btn_rastgele_baslat;
        private System.Windows.Forms.Label lbl_dugum_say;
        private System.Windows.Forms.Button btn_sorgu_olustur;
        private System.Windows.Forms.Label lbl_sorgu_yaricap;
        private System.Windows.Forms.Button btn_sorgu_durdur;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader sorgu;
        private System.Windows.Forms.ColumnHeader merkez_x;
        private System.Windows.Forms.ColumnHeader merkez_y;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader kesisen_noktalar;
        private System.Windows.Forms.ColumnHeader koordinat;
    }
}

