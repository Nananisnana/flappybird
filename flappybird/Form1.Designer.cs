namespace flappybird
{
    partial class bird
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bird));
            this.kuş = new System.Windows.Forms.PictureBox();
            this.boru1alt = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.boru1ust = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.boru2ust = new System.Windows.Forms.PictureBox();
            this.boru2alt = new System.Windows.Forms.PictureBox();
            this.boru3ust = new System.Windows.Forms.PictureBox();
            this.boru3alt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kuş)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru1alt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru1ust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru2ust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru2alt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru3ust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru3alt)).BeginInit();
            this.SuspendLayout();
            // 
            // kuş
            // 
            this.kuş.Image = ((System.Drawing.Image)(resources.GetObject("kuş.Image")));
            this.kuş.Location = new System.Drawing.Point(71, 277);
            this.kuş.Name = "kuş";
            this.kuş.Size = new System.Drawing.Size(62, 57);
            this.kuş.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kuş.TabIndex = 0;
            this.kuş.TabStop = false;
            // 
            // boru1alt
            // 
            this.boru1alt.Image = ((System.Drawing.Image)(resources.GetObject("boru1alt.Image")));
            this.boru1alt.Location = new System.Drawing.Point(459, 418);
            this.boru1alt.Name = "boru1alt";
            this.boru1alt.Size = new System.Drawing.Size(100, 208);
            this.boru1alt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boru1alt.TabIndex = 1;
            this.boru1alt.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.Image = ((System.Drawing.Image)(resources.GetObject("zemin.Image")));
            this.zemin.Location = new System.Drawing.Point(-9, 623);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(1208, 50);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 2;
            this.zemin.TabStop = false;
            // 
            // boru1ust
            // 
            this.boru1ust.Image = ((System.Drawing.Image)(resources.GetObject("boru1ust.Image")));
            this.boru1ust.Location = new System.Drawing.Point(359, 0);
            this.boru1ust.Name = "boru1ust";
            this.boru1ust.Size = new System.Drawing.Size(100, 170);
            this.boru1ust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boru1ust.TabIndex = 3;
            this.boru1ust.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.Location = new System.Drawing.Point(12, 24);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(102, 32);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Skor:0";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // boru2ust
            // 
            this.boru2ust.Image = ((System.Drawing.Image)(resources.GetObject("boru2ust.Image")));
            this.boru2ust.Location = new System.Drawing.Point(774, 0);
            this.boru2ust.Name = "boru2ust";
            this.boru2ust.Size = new System.Drawing.Size(100, 334);
            this.boru2ust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boru2ust.TabIndex = 6;
            this.boru2ust.TabStop = false;
            // 
            // boru2alt
            // 
            this.boru2alt.Image = ((System.Drawing.Image)(resources.GetObject("boru2alt.Image")));
            this.boru2alt.Location = new System.Drawing.Point(774, 523);
            this.boru2alt.Name = "boru2alt";
            this.boru2alt.Size = new System.Drawing.Size(100, 103);
            this.boru2alt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boru2alt.TabIndex = 5;
            this.boru2alt.TabStop = false;
            // 
            // boru3ust
            // 
            this.boru3ust.Image = ((System.Drawing.Image)(resources.GetObject("boru3ust.Image")));
            this.boru3ust.Location = new System.Drawing.Point(1054, 0);
            this.boru3ust.Name = "boru3ust";
            this.boru3ust.Size = new System.Drawing.Size(100, 142);
            this.boru3ust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boru3ust.TabIndex = 8;
            this.boru3ust.TabStop = false;
            // 
            // boru3alt
            // 
            this.boru3alt.Image = ((System.Drawing.Image)(resources.GetObject("boru3alt.Image")));
            this.boru3alt.Location = new System.Drawing.Point(1054, 370);
            this.boru3alt.Name = "boru3alt";
            this.boru3alt.Size = new System.Drawing.Size(100, 256);
            this.boru3alt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boru3alt.TabIndex = 7;
            this.boru3alt.TabStop = false;
            // 
            // bird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(999, 752);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.boru3ust);
            this.Controls.Add(this.boru3alt);
            this.Controls.Add(this.boru2ust);
            this.Controls.Add(this.boru2alt);
            this.Controls.Add(this.boru1ust);
            this.Controls.Add(this.boru1alt);
            this.Controls.Add(this.kuş);
            this.Name = "bird";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.bird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.kuş)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru1alt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru1ust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru2ust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru2alt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru3ust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru3alt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kuş;
        private System.Windows.Forms.PictureBox boru1alt;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.PictureBox boru1ust;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox boru2ust;
        private System.Windows.Forms.PictureBox boru2alt;
        private System.Windows.Forms.PictureBox boru3ust;
        private System.Windows.Forms.PictureBox boru3alt;
    }
}

