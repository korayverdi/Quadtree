using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int rastgele_dugum_say = 0;
        public static int x1 = 0;
        public static int x2 = 512;
        public static int y1 = 0;
        public static int y2 = 512;
        public static int sorgu_yaricap;
        Pen grafik_renk;
        Brush nokta_renk, cakisan_renk, arkaplan;

        public static int renk_sayicisi = 1;

        public static int x, y;
        public static int a, b;
        public static double c;
        public static List<Point> cakisan_noktalar = new List<Point>();
        public static List<Point> cakisan_noktalar_sirali = new List<Point>();
        public static Point gecici_nokta;

        class TreeNode
        {
            public Point nokta;
            public TreeNode KB;
            public TreeNode KD;
            public TreeNode GB;
            public TreeNode GD;
        }

        class Tree
        {
            public TreeNode root;
            public TreeNode newNode;
            public TreeNode current;
            public TreeNode parent;
            
            public Tree()
            {
                root = null;    
            }
            
            public void insert(Point newPoint)
            {
                renk_sayicisi = 1;
                newNode = new TreeNode();
                newNode.nokta = newPoint;

                if (root == null)
                {
                    root = newNode;
                }
                else
                {
                    current = root;

                    while (true)
                    {
                        renk_sayicisi++;
                        if(renk_sayicisi == 11)
                        {
                            renk_sayicisi = 1;
                        }
                        parent = current;
                        
                        if (newPoint.X <= current.nokta.X)
                        {
                            if (newPoint.Y <= current.nokta.Y)
                            {
                                current = current.KB;
                                y2 = parent.nokta.Y;
                                x2 = parent.nokta.X;
                                if (current == null)
                                {                                  
                                    parent.KB = newNode;
                                    return;
                                }          
                            }
                            else
                            {                           
                                current = current.GB;
                                y1 = parent.nokta.Y;
                                x2 = parent.nokta.X;
                                if (current == null)
                                {
                                    parent.GB = newNode;
                                    return;
                                }                               
                            }
                        }
                        else
                        {
                            if (newPoint.X > current.nokta.X)
                            {
                                if (newPoint.Y <= current.nokta.Y)
                                {                                   
                                    current = current.KD;
                                    y2 = parent.nokta.Y;
                                    x1 = parent.nokta.X;
                                    if (current == null)
                                    {
                                        parent.KD = newNode;
                                        return;
                                    }                                    
                                }
                                else
                                {                                   
                                    current = current.GD;
                                    y1 = parent.nokta.Y;
                                    x1 = parent.nokta.X;
                                    if (current == null)
                                    {
                                        parent.GD = newNode;
                                        return;
                                    }                                   
                                }
                            }
                        }                       
                    }
                }
            }
            
            public void sorgula(TreeNode yerelRoot, Point sorgu_merkezi, int yaricap)
            {
                if (yerelRoot != null)
                {
                    a = Math.Abs(yerelRoot.nokta.X - x);
                    b = Math.Abs(yerelRoot.nokta.Y - y);
                    c = Math.Sqrt((a * a) + (b * b));

                    if (yaricap >= c)
                    {
                        cakisan_noktalar.Add(yerelRoot.nokta);
                    }

                    sorgula(yerelRoot.KB, sorgu_merkezi, yaricap);
                    sorgula(yerelRoot.GB, sorgu_merkezi, yaricap);
                    sorgula(yerelRoot.KD, sorgu_merkezi, yaricap);
                    sorgula(yerelRoot.GD, sorgu_merkezi, yaricap);                  
                }
            }
        }

        public void renk_sec()
        {
            if (renk_sayicisi == 1) //kırmızı
            {
                grafik_renk = new Pen(System.Drawing.Color.Red, 1);
                nokta_renk = new SolidBrush(System.Drawing.Color.Red);
            }
            else if (renk_sayicisi == 2) //turuncu
            {
                grafik_renk = new Pen(System.Drawing.Color.Orange, 1);
                nokta_renk = new SolidBrush(System.Drawing.Color.Orange);
            }
            else if (renk_sayicisi == 3) //sarı
            {
                grafik_renk = new Pen(System.Drawing.Color.Yellow, 1);
                nokta_renk = new SolidBrush(System.Drawing.Color.Yellow);
            }
            else if (renk_sayicisi == 4) //yeşil
            {
                grafik_renk = new Pen(System.Drawing.Color.Green, 1);
                nokta_renk = new SolidBrush(System.Drawing.Color.Green);
            }
            else if (renk_sayicisi == 5) //mavi
            {
                grafik_renk = new Pen(System.Drawing.Color.Blue, 1);
                nokta_renk = new SolidBrush(System.Drawing.Color.Blue);
            }
            else if (renk_sayicisi == 6) //mor
            {
                grafik_renk = new Pen(System.Drawing.Color.Purple, 1);
                nokta_renk = new SolidBrush(System.Drawing.Color.Purple);
            }
            else if (renk_sayicisi == 7) //pembe
            {
                grafik_renk = new Pen(System.Drawing.Color.Pink, 1);
                nokta_renk = new SolidBrush(System.Drawing.Color.Pink);
            }
            else if (renk_sayicisi == 8)//bronz
            {
                grafik_renk = new Pen(System.Drawing.Color.Tan, 1);
                nokta_renk = new SolidBrush(System.Drawing.Color.Tan);
            }
            else if (renk_sayicisi == 9)//yeşilsarı
            {
                grafik_renk = new Pen(System.Drawing.Color.GreenYellow, 1);
                nokta_renk = new SolidBrush(System.Drawing.Color.GreenYellow);
            }
            else if (renk_sayicisi == 10)//turkuaz
            {
                grafik_renk = new Pen(System.Drawing.Color.Turquoise, 1);
                nokta_renk = new SolidBrush(System.Drawing.Color.Turquoise);
            }
        }

        Boolean tiklama = false;
        Boolean sorgu_tıklama = false;
        int tıklama_sayac = 1;
        int sorgu_sayac = 1;
        Point mouse,random;
        
        Tree agac = new Tree();
        Pen[] renk_dizisi = {
            new Pen(System.Drawing.Color.Red, 1),
            new Pen(System.Drawing.Color.Orange, 1),
            new Pen(System.Drawing.Color.Yellow, 1),
            new Pen(System.Drawing.Color.Green, 1),
            new Pen(System.Drawing.Color.Blue, 1),
            new Pen(System.Drawing.Color.Purple, 1),
            new Pen(System.Drawing.Color.Pink, 1),
            new Pen(System.Drawing.Color.Tan, 1),
            new Pen(System.Drawing.Color.GreenYellow, 1),
            new Pen(System.Drawing.Color.Turquoise, 1)
        };

        Brush[] nokta_renkleri = {
            new SolidBrush(System.Drawing.Color.Red),
            new SolidBrush(System.Drawing.Color.Orange),
            new SolidBrush(System.Drawing.Color.Yellow),
            new SolidBrush(System.Drawing.Color.Green),
            new SolidBrush(System.Drawing.Color.Blue),
            new SolidBrush(System.Drawing.Color.Purple),
            new SolidBrush(System.Drawing.Color.Pink),
            new SolidBrush(System.Drawing.Color.Tan),
            new SolidBrush(System.Drawing.Color.GreenYellow),
            new SolidBrush(System.Drawing.Color.Turquoise)
        };

        System.Drawing.Graphics grafiknesne;
        System.Drawing.Graphics grafiknesne_rastgele;
        Brush beyaz = new SolidBrush(System.Drawing.Color.White);

        private void Btn_mouse_ile_Click(object sender, EventArgs e)
        {
            agac.root = null;
            listView1.Items.Clear();
            tıklama_sayac = 1;
            lbl_dugum_say.Visible = false;
            textBox_dugum_say.Visible = false;
            btn_rastgele_baslat.Visible = false;
            Btn_rastgele.Enabled = false;
            Btn_agac_temizle.Enabled = false;
            btn_sorgu_olustur.Enabled = false;
            Btn_sorgu_temizle.Enabled = false;

            grafiknesne = this.CreateGraphics();
            listView1.Items.Clear();

            //tuval
            grafiknesne.FillRectangle(beyaz, 13, 13, 512, 512);
            Btn_mouse_ile_kaydet.Visible = true;
        }

        private void Btn_rastgele_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Form.DefaultBackColor);
            agac.root = null;
            listView1.Items.Clear();
            tıklama_sayac = 1;

            lbl_dugum_say.Visible = true;
            textBox_dugum_say.Visible = true;
            btn_rastgele_baslat.Visible = true;
            Btn_mouse_ile.Enabled = false;
            Btn_agac_temizle.Enabled = false;
            btn_sorgu_olustur.Enabled = false;
            Btn_sorgu_temizle.Enabled = false;
        }

        private void Btn_mouse_ile_kaydet_Click(object sender, EventArgs e)
        {
            Btn_mouse_ile_kaydet.Visible = false;
            Btn_rastgele.Enabled = true;
            Btn_agac_temizle.Enabled = true;
            btn_sorgu_olustur.Enabled = true;
            Btn_sorgu_temizle.Enabled = true;
            tiklama = false;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            mouse = new Point(e.X - 13, e.Y - 13);
            x = mouse.X;
            y = mouse.Y;

            if(e.X >= 13 && e.X <= 525 )
            {
                if(e.Y >= 13 && e.Y <= 525)
                {
                    if (e.Button == MouseButtons.Left && Btn_mouse_ile_kaydet.Visible == true)
                    {
                        tiklama = true;
                    }
                    else if(e.Button == MouseButtons.Left && btn_sorgu_durdur.Visible == true)
                    {
                        sorgu_tıklama = true;
                    }
                }
            }

            while (tiklama == true)
            {
                int sira = listView1.Items.Count;
                listView1.Items.Add(tıklama_sayac.ToString()); //0.Sütün
                listView1.Items[sira].SubItems.Add(x.ToString()); //1.Sütün
                listView1.Items[sira].SubItems.Add(y.ToString()); //2.Sütün

                System.Drawing.Graphics grafiknesne;
                grafiknesne = this.CreateGraphics();
                Random rnd = new Random();

                Color rnd_renk = System.Drawing.Color.FromArgb(((int)(((byte)(rnd.Next(0, 255))))), ((int)(((byte)(rnd.Next(0, 255))))), ((int)(((byte)(rnd.Next(0, 255))))));

                tıklama_sayac++;

                agac.insert(mouse);
                renk_sec();
                listView1.Items[sira].SubItems.Add(x1.ToString()); //3.Sütün
                listView1.Items[sira].SubItems.Add(x2.ToString()); //4.Sütün
                listView1.Items[sira].SubItems.Add(y1.ToString()); //5.Sütün
                listView1.Items[sira].SubItems.Add(y2.ToString()); //6.Sütün
                listView1.Items[sira].SubItems.Add(renk_sayicisi.ToString()); //7.Sütün

                //dikey
                grafiknesne.DrawLine(grafik_renk, mouse.X + 13, y1 + 13, mouse.X + 13, y2 + 13);
                //yatay
                grafiknesne.DrawLine(grafik_renk, x1 + 13, mouse.Y + 13, x2 + 13, mouse.Y + 13);
                //nokta
                grafiknesne.FillEllipse(nokta_renk, mouse.X + 13 - 4, mouse.Y + 13 - 4, 8, 8);

                x1 = 0;
                x2 = 512;
                y1 = 0;
                y2 = 512;
                tiklama = false;
            }
            while (sorgu_tıklama == true)
            {
                Graphics g = this.CreateGraphics();
                g.Clear(Form.DefaultBackColor);

                listView3.Items.Clear();
                cakisan_noktalar.Clear();

                grafiknesne = this.CreateGraphics();
                Pen siyah = new Pen(System.Drawing.Color.Black, 1);
                cakisan_renk = new SolidBrush(System.Drawing.Color.DarkSalmon);
                arkaplan = new SolidBrush(System.Drawing.SystemColors.Control);

                //tuval
                grafiknesne.FillRectangle(beyaz, 13, 13, 512, 512);
                Point cakisan_nokta;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    //dikey
                    grafiknesne.DrawLine(renk_dizisi[Convert.ToInt32(listView1.Items[i].SubItems[7].Text) - 1], Convert.ToInt32(listView1.Items[i].SubItems[1].Text) + 13, Convert.ToInt32(listView1.Items[i].SubItems[5].Text) + 13, Convert.ToInt32(listView1.Items[i].SubItems[1].Text) + 13, Convert.ToInt32(listView1.Items[i].SubItems[6].Text) + 13);
                    //yatay
                    grafiknesne.DrawLine(renk_dizisi[Convert.ToInt32(listView1.Items[i].SubItems[7].Text) - 1], Convert.ToInt32(listView1.Items[i].SubItems[3].Text) + 13, Convert.ToInt32(listView1.Items[i].SubItems[2].Text) + 13, Convert.ToInt32(listView1.Items[i].SubItems[4].Text) + 13, Convert.ToInt32(listView1.Items[i].SubItems[2].Text) + 13);
                    //nokta
                    grafiknesne.FillEllipse(nokta_renkleri[Convert.ToInt32(listView1.Items[i].SubItems[7].Text) - 1], Convert.ToInt32(listView1.Items[i].SubItems[1].Text) + 13 - 4, Convert.ToInt32(listView1.Items[i].SubItems[2].Text) + 13 - 4, 8, 8);
                }
                
                sorgu_yaricap = Convert.ToInt32(textBox_sorgu_yaricap.Text);
                int sira = listView2.Items.Count;
                listView2.Items.Add(sorgu_sayac.ToString());
                listView2.Items[sira].SubItems.Add(x.ToString());
                listView2.Items[sira].SubItems.Add(y.ToString());

                sorgu_sayac++;

                //daire
                grafiknesne.DrawEllipse(siyah, mouse.X + 13 - sorgu_yaricap, mouse.Y + 13 - sorgu_yaricap, sorgu_yaricap * 2, sorgu_yaricap *2 );
                grafiknesne.FillRectangle(arkaplan, 0, 0, 13, 700);
                grafiknesne.FillRectangle(arkaplan, 0, 0, 795, 13);
                grafiknesne.FillRectangle(arkaplan, 525, 0, 270, 700);
                grafiknesne.FillRectangle(arkaplan, 0, 525, 795, 175);
                agac.sorgula(agac.root, mouse, sorgu_yaricap);
                int sira2 = listView2.Items.Count;

                for (int i = 0; i < cakisan_noktalar.Count - 1; i++)
                {
                    for (int j = i + 1; j < cakisan_noktalar.Count; j++)
                    {
                        if(cakisan_noktalar[i].X > cakisan_noktalar[j].X)
                        {
                            gecici_nokta = cakisan_noktalar[i];
                            cakisan_noktalar[i] = cakisan_noktalar[j];
                            cakisan_noktalar[j] = gecici_nokta;
                        }
                        else if(cakisan_noktalar[i].X == cakisan_noktalar[j].X)
                        {
                            if(cakisan_noktalar[i].Y > cakisan_noktalar[j].Y)
                            {
                                gecici_nokta = cakisan_noktalar[i];
                                cakisan_noktalar[i] = cakisan_noktalar[j];
                                cakisan_noktalar[j] = gecici_nokta;
                            }
                        }
                    }
                }

                for (int i = 0; i < cakisan_noktalar.Count; i++)
                {
                    listView3.Items.Add((i+1).ToString());
                    listView3.Items[i].SubItems.Add(cakisan_noktalar[i].ToString());
                    cakisan_nokta = cakisan_noktalar[i];

                    //nokta
                    grafiknesne.FillEllipse(cakisan_renk, cakisan_nokta.X + 13 - 4, cakisan_nokta.Y + 13 - 4, 8, 8);
                }


                sorgu_tıklama = false;
            }
        }

        private void Btn_agac_temizle_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Form.DefaultBackColor);
            agac.root = null;
            listView1.Items.Clear();
            tıklama_sayac = 1;
        }

        // Textbox'a sayı harici girişlerin engellendiği kısım
        private void textBox_dugum_say_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_sorgu_olustur_Click(object sender, EventArgs e)
        {
            if(agac.root == null)
            {
                MessageBox.Show("Ağaçta düğüm eklemediniz! Lütfen ağaca düğüm ekledikten sonra sorgu yapınız!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(textBox_sorgu_yaricap.Text == "")
            {
                MessageBox.Show("Lütfen sorgu çemberinin yarıçapını giriniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                btn_sorgu_durdur.Visible = true;
                Btn_rastgele.Enabled = false;
                Btn_mouse_ile.Enabled = false;
                Btn_agac_temizle.Enabled = false;
            }
        }

        private void textBox_sorgu_yaricap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_sorgu_durdur_Click(object sender, EventArgs e)
        {
            grafiknesne.FillRectangle(arkaplan, 0, 0, 13, 700);
            grafiknesne.FillRectangle(arkaplan, 0, 0, 795, 13);
            grafiknesne.FillRectangle(arkaplan, 525, 0, 270, 700);
            grafiknesne.FillRectangle(arkaplan, 0, 525, 795, 175);
            btn_sorgu_durdur.Visible = false;
            Btn_agac_temizle.Enabled = true;
            Btn_mouse_ile.Enabled = true;
            Btn_rastgele.Enabled = true;
            sorgu_tıklama = false;
            listView2.Items.Clear();
            listView3.Items.Clear();
            sorgu_sayac = 1;
        }

        private void Btn_sorgu_temizle_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Form.DefaultBackColor);
            listView2.Items.Clear();
            listView3.Items.Clear();
            sorgu_sayac = 1;
            grafiknesne.FillRectangle(arkaplan, 0, 0, 13, 700);
            grafiknesne.FillRectangle(arkaplan, 0, 0, 795, 13);
            grafiknesne.FillRectangle(arkaplan, 525, 0, 270, 700);
            grafiknesne.FillRectangle(arkaplan, 0, 525, 795, 175);
        }

        //Textbox ile düğüm sayısını belirtip butona bastığımızda çalışan kısım
        private void btn_rastgele_baslat_Click(object sender, EventArgs e)
        {
            if(textBox_dugum_say.Text == "")
            {
                MessageBox.Show("Lütfen düğüm sayısını giriniz!", "Uyarı Penceresi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lbl_dugum_say.Visible = false;
                textBox_dugum_say.Visible = false;
                btn_rastgele_baslat.Visible = false;
                grafiknesne = this.CreateGraphics();
                Brush beyaz = new SolidBrush(System.Drawing.Color.White);

                //tuval
                grafiknesne.FillRectangle(beyaz, 13, 13, 512, 512);
                Btn_rastgele_kaydet.Visible = true;

                rastgele_dugum_say = Convert.ToInt32(textBox_dugum_say.Text.ToString());
                Random rastgele = new Random();
                int sayici = 0;
                int rnd_x, rnd_y;
                while (sayici < rastgele_dugum_say)
                {
                    rnd_x = rastgele.Next(0, 512);
                    rnd_y = rastgele.Next(0, 512);
                    random = new Point(rnd_x, rnd_y);
                    x = random.X;
                    y = random.Y;

                    tiklama = true;

                    while (tiklama == true)
                    {
                        int sira = listView1.Items.Count;
                        listView1.Items.Add(tıklama_sayac.ToString()); //0.Sütün
                        listView1.Items[sira].SubItems.Add(x.ToString()); //1.Sütün
                        listView1.Items[sira].SubItems.Add(y.ToString()); //2.Sütün

                        grafiknesne_rastgele = this.CreateGraphics();
                        Pen siyah = new Pen(System.Drawing.Color.Black, 20);

                        tıklama_sayac++;

                        agac.insert(random);
                        renk_sec();

                        listView1.Items[sira].SubItems.Add(x1.ToString()); //3.Sütün
                        listView1.Items[sira].SubItems.Add(x2.ToString()); //4.Sütün
                        listView1.Items[sira].SubItems.Add(y1.ToString()); //5.Sütün
                        listView1.Items[sira].SubItems.Add(y2.ToString()); //6.Sütün
                        listView1.Items[sira].SubItems.Add(renk_sayicisi.ToString()); //7.Sütün

                        //dikey
                        grafiknesne_rastgele.DrawLine(grafik_renk, random.X + 13, y1 + 13, random.X + 13, y2 + 13);
                        //yatay
                        grafiknesne_rastgele.DrawLine(grafik_renk, x1 + 13, random.Y + 13, x2 + 13, random.Y + 13);
                        //nokta
                        grafiknesne.FillEllipse(nokta_renk, random.X + 13 - 4, random.Y + 13 - 4, 8, 8);

                        x1 = 0;
                        x2 = 512;
                        y1 = 0;
                        y2 = 512;

                        tiklama = false;
                    }
                    sayici++;
                }
            }        
        }

        private void Btn_rastgele_kaydet_Click(object sender, EventArgs e)
        {
            Btn_rastgele_kaydet.Visible = false;
            Btn_mouse_ile.Enabled = true;
            Btn_agac_temizle.Enabled = true;
            btn_sorgu_olustur.Enabled = true;
            Btn_sorgu_temizle.Enabled = true;
            tiklama = false;
        }
    }
}