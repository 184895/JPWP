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
            ((System.ComponentModel.ISupportInitialize)(this.jablko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brokul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marchewka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burger)).BeginInit();
            this.SuspendLayout();
            // 
            // jablko
            // 
            this.jablko.Image = ((System.Drawing.Image)(resources.GetObject("jablko.Image")));
            this.jablko.Location = new System.Drawing.Point(34, 162);
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
            this.banan.Location = new System.Drawing.Point(220, 162);
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
            this.brokul.Location = new System.Drawing.Point(405, 162);
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
            this.marchewka.Location = new System.Drawing.Point(603, 162);
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
            this.arbuz.Location = new System.Drawing.Point(808, 162);
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
            this.pizza.Location = new System.Drawing.Point(289, 424);
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
            this.burger.Location = new System.Drawing.Point(576, 424);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
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
    }
}

