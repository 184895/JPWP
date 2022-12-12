namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.jablko = new System.Windows.Forms.PictureBox();
            this.banan = new System.Windows.Forms.PictureBox();
            this.brokul = new System.Windows.Forms.PictureBox();
            this.marchewka = new System.Windows.Forms.PictureBox();
            this.arbuz = new System.Windows.Forms.PictureBox();
            this.pizza = new System.Windows.Forms.PictureBox();
            this.burger = new System.Windows.Forms.PictureBox();
            this.points = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lifetxt = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.PictureBox();
            this.jakGrac = new System.Windows.Forms.PictureBox();
            this.zdrowaZywnosc_opis = new System.Windows.Forms.Label();
            this.jablko_opis = new System.Windows.Forms.Label();
            this.brokul_opis = new System.Windows.Forms.Label();
            this.banan_opis = new System.Windows.Forms.Label();
            this.marchew_opis = new System.Windows.Forms.Label();
            this.NieZdrowaZywnosc_opis = new System.Windows.Forms.Label();
            this.burger_opis = new System.Windows.Forms.Label();
            this.pizza_opis = new System.Windows.Forms.Label();
            this.arbuz_opis = new System.Windows.Forms.Label();
            this.Opis_gry = new System.Windows.Forms.Label();
            this.hpImage1 = new System.Windows.Forms.PictureBox();
            this.hpImage2 = new System.Windows.Forms.PictureBox();
            this.hpImage3 = new System.Windows.Forms.PictureBox();
            this.exitImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jablko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brokul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marchewka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jakGrac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitImg)).BeginInit();
            this.SuspendLayout();
            // 
            // jablko
            // 
            this.jablko.Image = ((System.Drawing.Image)(resources.GetObject("jablko.Image")));
            this.jablko.Location = new System.Drawing.Point(34, 178);
            this.jablko.Name = "jablko";
            this.jablko.Size = new System.Drawing.Size(160, 160);
            this.jablko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.jablko.TabIndex = 0;
            this.jablko.TabStop = false;
            this.jablko.Tag = "GoodFood";
            this.jablko.Click += new System.EventHandler(this.ClickGoodFood);
            // 
            // banan
            // 
            this.banan.Image = ((System.Drawing.Image)(resources.GetObject("banan.Image")));
            this.banan.Location = new System.Drawing.Point(34, 344);
            this.banan.Name = "banan";
            this.banan.Size = new System.Drawing.Size(160, 160);
            this.banan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.banan.TabIndex = 1;
            this.banan.TabStop = false;
            this.banan.Tag = "GoodFood";
            this.banan.Click += new System.EventHandler(this.ClickGoodFood);
            // 
            // brokul
            // 
            this.brokul.Image = ((System.Drawing.Image)(resources.GetObject("brokul.Image")));
            this.brokul.Location = new System.Drawing.Point(1074, 36);
            this.brokul.Name = "brokul";
            this.brokul.Size = new System.Drawing.Size(160, 160);
            this.brokul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.brokul.TabIndex = 2;
            this.brokul.TabStop = false;
            this.brokul.Tag = "GoodFood";
            this.brokul.Click += new System.EventHandler(this.ClickGoodFood);
            // 
            // marchewka
            // 
            this.marchewka.Image = ((System.Drawing.Image)(resources.GetObject("marchewka.Image")));
            this.marchewka.Location = new System.Drawing.Point(1074, 368);
            this.marchewka.Name = "marchewka";
            this.marchewka.Size = new System.Drawing.Size(160, 160);
            this.marchewka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.marchewka.TabIndex = 3;
            this.marchewka.TabStop = false;
            this.marchewka.Tag = "GoodFood";
            this.marchewka.Click += new System.EventHandler(this.ClickGoodFood);
            // 
            // arbuz
            // 
            this.arbuz.Image = ((System.Drawing.Image)(resources.GetObject("arbuz.Image")));
            this.arbuz.Location = new System.Drawing.Point(1074, 202);
            this.arbuz.Name = "arbuz";
            this.arbuz.Size = new System.Drawing.Size(160, 160);
            this.arbuz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.arbuz.TabIndex = 4;
            this.arbuz.TabStop = false;
            this.arbuz.Tag = "GoodFood";
            this.arbuz.Click += new System.EventHandler(this.ClickGoodFood);
            // 
            // pizza
            // 
            this.pizza.Image = ((System.Drawing.Image)(resources.GetObject("pizza.Image")));
            this.pizza.Location = new System.Drawing.Point(34, 510);
            this.pizza.Name = "pizza";
            this.pizza.Size = new System.Drawing.Size(160, 160);
            this.pizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pizza.TabIndex = 5;
            this.pizza.TabStop = false;
            this.pizza.Tag = "BadFood";
            this.pizza.Click += new System.EventHandler(this.ClickBadFood);
            // 
            // burger
            // 
            this.burger.Image = ((System.Drawing.Image)(resources.GetObject("burger.Image")));
            this.burger.Location = new System.Drawing.Point(34, 12);
            this.burger.Name = "burger";
            this.burger.Size = new System.Drawing.Size(160, 160);
            this.burger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.burger.TabIndex = 6;
            this.burger.TabStop = false;
            this.burger.Tag = "BadFood";
            this.burger.Click += new System.EventHandler(this.ClickBadFood);
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.points.Location = new System.Drawing.Point(29, 935);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(92, 25);
            this.points.TabIndex = 7;
            this.points.Text = "Score: 0";
            this.points.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.MainTimeEvent);
            // 
            // lifetxt
            // 
            this.lifetxt.AutoSize = true;
            this.lifetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lifetxt.Location = new System.Drawing.Point(222, 935);
            this.lifetxt.Name = "lifetxt";
            this.lifetxt.Size = new System.Drawing.Size(36, 25);
            this.lifetxt.TabIndex = 8;
            this.lifetxt.Text = "life";
            // 
            // menu
            // 
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(1092, 931);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(160, 42);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.menu.TabIndex = 9;
            this.menu.TabStop = false;
            this.menu.Tag = "Menu";
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Image = ((System.Drawing.Image)(resources.GetObject("start.Image")));
            this.start.Location = new System.Drawing.Point(560, 251);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(160, 160);
            this.start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.start.TabIndex = 10;
            this.start.TabStop = false;
            this.start.Tag = "start";
            this.start.Visible = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // jakGrac
            // 
            this.jakGrac.Enabled = false;
            this.jakGrac.Image = ((System.Drawing.Image)(resources.GetObject("jakGrac.Image")));
            this.jakGrac.Location = new System.Drawing.Point(560, 417);
            this.jakGrac.Name = "jakGrac";
            this.jakGrac.Size = new System.Drawing.Size(160, 160);
            this.jakGrac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.jakGrac.TabIndex = 11;
            this.jakGrac.TabStop = false;
            this.jakGrac.Tag = "jakGrac";
            this.jakGrac.Visible = false;
            this.jakGrac.Click += new System.EventHandler(this.jakGrac_Click);
            // 
            // zdrowaZywnosc_opis
            // 
            this.zdrowaZywnosc_opis.AutoSize = true;
            this.zdrowaZywnosc_opis.Enabled = false;
            this.zdrowaZywnosc_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zdrowaZywnosc_opis.Location = new System.Drawing.Point(253, 36);
            this.zdrowaZywnosc_opis.Name = "zdrowaZywnosc_opis";
            this.zdrowaZywnosc_opis.Size = new System.Drawing.Size(172, 25);
            this.zdrowaZywnosc_opis.TabIndex = 12;
            this.zdrowaZywnosc_opis.Text = "Zdrowa żwyność";
            this.zdrowaZywnosc_opis.Visible = false;
            // 
            // jablko_opis
            // 
            this.jablko_opis.AutoSize = true;
            this.jablko_opis.Enabled = false;
            this.jablko_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jablko_opis.Location = new System.Drawing.Point(253, 81);
            this.jablko_opis.Name = "jablko_opis";
            this.jablko_opis.Size = new System.Drawing.Size(69, 25);
            this.jablko_opis.TabIndex = 13;
            this.jablko_opis.Text = "jabłko";
            this.jablko_opis.Visible = false;
            // 
            // brokul_opis
            // 
            this.brokul_opis.AutoSize = true;
            this.brokul_opis.Enabled = false;
            this.brokul_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brokul_opis.Location = new System.Drawing.Point(253, 147);
            this.brokul_opis.Name = "brokul_opis";
            this.brokul_opis.Size = new System.Drawing.Size(71, 25);
            this.brokul_opis.TabIndex = 14;
            this.brokul_opis.Text = "brokuł";
            this.brokul_opis.Visible = false;
            // 
            // banan_opis
            // 
            this.banan_opis.AutoSize = true;
            this.banan_opis.Enabled = false;
            this.banan_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.banan_opis.Location = new System.Drawing.Point(253, 214);
            this.banan_opis.Name = "banan_opis";
            this.banan_opis.Size = new System.Drawing.Size(72, 25);
            this.banan_opis.TabIndex = 15;
            this.banan_opis.Text = "banan";
            this.banan_opis.Visible = false;
            // 
            // marchew_opis
            // 
            this.marchew_opis.AutoSize = true;
            this.marchew_opis.Enabled = false;
            this.marchew_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.marchew_opis.Location = new System.Drawing.Point(253, 271);
            this.marchew_opis.Name = "marchew_opis";
            this.marchew_opis.Size = new System.Drawing.Size(98, 25);
            this.marchew_opis.TabIndex = 16;
            this.marchew_opis.Text = "marchew";
            this.marchew_opis.Visible = false;
            // 
            // NieZdrowaZywnosc_opis
            // 
            this.NieZdrowaZywnosc_opis.AutoSize = true;
            this.NieZdrowaZywnosc_opis.Enabled = false;
            this.NieZdrowaZywnosc_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NieZdrowaZywnosc_opis.Location = new System.Drawing.Point(858, 36);
            this.NieZdrowaZywnosc_opis.Name = "NieZdrowaZywnosc_opis";
            this.NieZdrowaZywnosc_opis.Size = new System.Drawing.Size(202, 25);
            this.NieZdrowaZywnosc_opis.TabIndex = 17;
            this.NieZdrowaZywnosc_opis.Text = "Niezdrowa żywność";
            this.NieZdrowaZywnosc_opis.Visible = false;
            // 
            // burger_opis
            // 
            this.burger_opis.AutoSize = true;
            this.burger_opis.Enabled = false;
            this.burger_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.burger_opis.Location = new System.Drawing.Point(858, 107);
            this.burger_opis.Name = "burger_opis";
            this.burger_opis.Size = new System.Drawing.Size(74, 25);
            this.burger_opis.TabIndex = 18;
            this.burger_opis.Text = "burger";
            this.burger_opis.Visible = false;
            // 
            // pizza_opis
            // 
            this.pizza_opis.AutoSize = true;
            this.pizza_opis.Enabled = false;
            this.pizza_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pizza_opis.Location = new System.Drawing.Point(858, 171);
            this.pizza_opis.Name = "pizza_opis";
            this.pizza_opis.Size = new System.Drawing.Size(63, 25);
            this.pizza_opis.TabIndex = 19;
            this.pizza_opis.Text = "pizza";
            this.pizza_opis.Visible = false;
            // 
            // arbuz_opis
            // 
            this.arbuz_opis.AutoSize = true;
            this.arbuz_opis.Enabled = false;
            this.arbuz_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.arbuz_opis.Location = new System.Drawing.Point(253, 344);
            this.arbuz_opis.Name = "arbuz_opis";
            this.arbuz_opis.Size = new System.Drawing.Size(66, 25);
            this.arbuz_opis.TabIndex = 20;
            this.arbuz_opis.Text = "arbuz";
            this.arbuz_opis.Visible = false;
            // 
            // Opis_gry
            // 
            this.Opis_gry.AutoSize = true;
            this.Opis_gry.Enabled = false;
            this.Opis_gry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Opis_gry.Location = new System.Drawing.Point(175, 848);
            this.Opis_gry.Name = "Opis_gry";
            this.Opis_gry.Size = new System.Drawing.Size(958, 25);
            this.Opis_gry.TabIndex = 21;
            this.Opis_gry.Text = "Aby zdobywać punkty klikaj w zdrową żywność, unikaj niezdrowej żywności by nie st" +
    "arcić punktów!";
            this.Opis_gry.Visible = false;
            // 
            // hpImage1
            // 
            this.hpImage1.Enabled = false;
            this.hpImage1.Image = ((System.Drawing.Image)(resources.GetObject("hpImage1.Image")));
            this.hpImage1.Location = new System.Drawing.Point(270, 914);
            this.hpImage1.Name = "hpImage1";
            this.hpImage1.Size = new System.Drawing.Size(55, 46);
            this.hpImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hpImage1.TabIndex = 22;
            this.hpImage1.TabStop = false;
            this.hpImage1.Tag = "hp";
            // 
            // hpImage2
            // 
            this.hpImage2.Enabled = false;
            this.hpImage2.Image = ((System.Drawing.Image)(resources.GetObject("hpImage2.Image")));
            this.hpImage2.Location = new System.Drawing.Point(331, 914);
            this.hpImage2.Name = "hpImage2";
            this.hpImage2.Size = new System.Drawing.Size(55, 46);
            this.hpImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hpImage2.TabIndex = 23;
            this.hpImage2.TabStop = false;
            this.hpImage2.Tag = "hp";
            // 
            // hpImage3
            // 
            this.hpImage3.Enabled = false;
            this.hpImage3.Image = ((System.Drawing.Image)(resources.GetObject("hpImage3.Image")));
            this.hpImage3.Location = new System.Drawing.Point(392, 914);
            this.hpImage3.Name = "hpImage3";
            this.hpImage3.Size = new System.Drawing.Size(55, 46);
            this.hpImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hpImage3.TabIndex = 24;
            this.hpImage3.TabStop = false;
            this.hpImage3.Tag = "hp";
            // 
            // exitImg
            // 
            this.exitImg.Enabled = false;
            this.exitImg.Image = ((System.Drawing.Image)(resources.GetObject("exitImg.Image")));
            this.exitImg.Location = new System.Drawing.Point(560, 583);
            this.exitImg.Name = "exitImg";
            this.exitImg.Size = new System.Drawing.Size(160, 160);
            this.exitImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitImg.TabIndex = 25;
            this.exitImg.TabStop = false;
            this.exitImg.Tag = "exit";
            this.exitImg.Visible = false;
            this.exitImg.Click += new System.EventHandler(this.exitImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.exitImg);
            this.Controls.Add(this.hpImage3);
            this.Controls.Add(this.hpImage2);
            this.Controls.Add(this.hpImage1);
            this.Controls.Add(this.Opis_gry);
            this.Controls.Add(this.arbuz_opis);
            this.Controls.Add(this.pizza_opis);
            this.Controls.Add(this.burger_opis);
            this.Controls.Add(this.NieZdrowaZywnosc_opis);
            this.Controls.Add(this.marchew_opis);
            this.Controls.Add(this.banan_opis);
            this.Controls.Add(this.brokul_opis);
            this.Controls.Add(this.jablko_opis);
            this.Controls.Add(this.zdrowaZywnosc_opis);
            this.Controls.Add(this.jakGrac);
            this.Controls.Add(this.start);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.lifetxt);
            this.Controls.Add(this.points);
            this.Controls.Add(this.burger);
            this.Controls.Add(this.pizza);
            this.Controls.Add(this.arbuz);
            this.Controls.Add(this.marchewka);
            this.Controls.Add(this.brokul);
            this.Controls.Add(this.banan);
            this.Controls.Add(this.jablko);
            this.Name = "Form1";
            this.Tag = "BadFood";
            this.Text = "Zdrowa zywnosc game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jablko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brokul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marchewka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jakGrac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox jablko;
        private System.Windows.Forms.PictureBox banan;
        private System.Windows.Forms.PictureBox brokul;
        private System.Windows.Forms.PictureBox marchewka;
        private System.Windows.Forms.PictureBox arbuz;
        private System.Windows.Forms.PictureBox pizza;
        private System.Windows.Forms.PictureBox burger;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lifetxt;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.PictureBox jakGrac;
        private System.Windows.Forms.Label zdrowaZywnosc_opis;
        private System.Windows.Forms.Label jablko_opis;
        private System.Windows.Forms.Label brokul_opis;
        private System.Windows.Forms.Label banan_opis;
        private System.Windows.Forms.Label marchew_opis;
        private System.Windows.Forms.Label NieZdrowaZywnosc_opis;
        private System.Windows.Forms.Label burger_opis;
        private System.Windows.Forms.Label pizza_opis;
        private System.Windows.Forms.Label arbuz_opis;
        private System.Windows.Forms.Label Opis_gry;
        private System.Windows.Forms.PictureBox hpImage1;
        private System.Windows.Forms.PictureBox hpImage2;
        private System.Windows.Forms.PictureBox hpImage3;
        private System.Windows.Forms.PictureBox exitImg;
    }
}

