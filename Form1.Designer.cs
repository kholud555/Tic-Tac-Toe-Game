namespace Tic_Tac_Toe_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGameStatus = new System.Windows.Forms.Label();
            this.lbPlayer = new System.Windows.Forms.Label();
            this.pbQuestion128 = new System.Windows.Forms.PictureBox();
            this.pbQuestion256 = new System.Windows.Forms.PictureBox();
            this.pbQuestion32 = new System.Windows.Forms.PictureBox();
            this.pbQuestion8 = new System.Windows.Forms.PictureBox();
            this.pbQuestion64 = new System.Windows.Forms.PictureBox();
            this.pbQuestion16 = new System.Windows.Forms.PictureBox();
            this.pbQuestion4 = new System.Windows.Forms.PictureBox();
            this.pbQuestion2 = new System.Windows.Forms.PictureBox();
            this.pbQuestion1 = new System.Windows.Forms.PictureBox();
            this.btnRest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbGameResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion128)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion256)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MV Boli", 43.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(580, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(111, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turn";
            // 
            // lbGameStatus
            // 
            this.lbGameStatus.AutoSize = true;
            this.lbGameStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbGameStatus.Font = new System.Drawing.Font("Stencil", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameStatus.ForeColor = System.Drawing.Color.White;
            this.lbGameStatus.Location = new System.Drawing.Point(48, 374);
            this.lbGameStatus.Name = "lbGameStatus";
            this.lbGameStatus.Size = new System.Drawing.Size(339, 56);
            this.lbGameStatus.TabIndex = 5;
            this.lbGameStatus.Text = "Game Status";
            // 
            // lbPlayer
            // 
            this.lbPlayer.AutoSize = true;
            this.lbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayer.Font = new System.Drawing.Font("MV Boli", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer.ForeColor = System.Drawing.Color.Yellow;
            this.lbPlayer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbPlayer.Location = new System.Drawing.Point(89, 229);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(216, 73);
            this.lbPlayer.TabIndex = 3;
            this.lbPlayer.Text = "Player1";
            // 
            // pbQuestion128
            // 
            this.pbQuestion128.BackColor = System.Drawing.Color.Transparent;
            this.pbQuestion128.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question;
            this.pbQuestion128.Location = new System.Drawing.Point(741, 493);
            this.pbQuestion128.Name = "pbQuestion128";
            this.pbQuestion128.Size = new System.Drawing.Size(132, 127);
            this.pbQuestion128.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion128.TabIndex = 14;
            this.pbQuestion128.TabStop = false;
            this.pbQuestion128.Tag = "128";
            this.pbQuestion128.Click += new System.EventHandler(this.pbQuestion128_Click);
            // 
            // pbQuestion256
            // 
            this.pbQuestion256.BackColor = System.Drawing.Color.Transparent;
            this.pbQuestion256.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question;
            this.pbQuestion256.Location = new System.Drawing.Point(915, 493);
            this.pbQuestion256.Name = "pbQuestion256";
            this.pbQuestion256.Size = new System.Drawing.Size(132, 127);
            this.pbQuestion256.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion256.TabIndex = 13;
            this.pbQuestion256.TabStop = false;
            this.pbQuestion256.Tag = "256";
            this.pbQuestion256.Click += new System.EventHandler(this.pbQuestion256_Click);
            // 
            // pbQuestion32
            // 
            this.pbQuestion32.BackColor = System.Drawing.Color.Transparent;
            this.pbQuestion32.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question;
            this.pbQuestion32.Location = new System.Drawing.Point(916, 344);
            this.pbQuestion32.Name = "pbQuestion32";
            this.pbQuestion32.Size = new System.Drawing.Size(132, 127);
            this.pbQuestion32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion32.TabIndex = 12;
            this.pbQuestion32.TabStop = false;
            this.pbQuestion32.Tag = "32";
            this.pbQuestion32.Click += new System.EventHandler(this.pbQuestion32_Click);
            // 
            // pbQuestion8
            // 
            this.pbQuestion8.BackColor = System.Drawing.Color.Transparent;
            this.pbQuestion8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question;
            this.pbQuestion8.Location = new System.Drawing.Point(558, 344);
            this.pbQuestion8.Name = "pbQuestion8";
            this.pbQuestion8.Size = new System.Drawing.Size(132, 127);
            this.pbQuestion8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion8.TabIndex = 11;
            this.pbQuestion8.TabStop = false;
            this.pbQuestion8.Tag = "8";
            this.pbQuestion8.Click += new System.EventHandler(this.pbQuestion8_Click);
            // 
            // pbQuestion64
            // 
            this.pbQuestion64.BackColor = System.Drawing.Color.Transparent;
            this.pbQuestion64.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question;
            this.pbQuestion64.Location = new System.Drawing.Point(567, 493);
            this.pbQuestion64.Name = "pbQuestion64";
            this.pbQuestion64.Size = new System.Drawing.Size(132, 127);
            this.pbQuestion64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion64.TabIndex = 10;
            this.pbQuestion64.TabStop = false;
            this.pbQuestion64.Tag = "64";
            this.pbQuestion64.Click += new System.EventHandler(this.pbQuestion64_Click);
            // 
            // pbQuestion16
            // 
            this.pbQuestion16.BackColor = System.Drawing.Color.Transparent;
            this.pbQuestion16.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question;
            this.pbQuestion16.Location = new System.Drawing.Point(737, 344);
            this.pbQuestion16.Name = "pbQuestion16";
            this.pbQuestion16.Size = new System.Drawing.Size(132, 127);
            this.pbQuestion16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion16.TabIndex = 9;
            this.pbQuestion16.TabStop = false;
            this.pbQuestion16.Tag = "16";
            this.pbQuestion16.Click += new System.EventHandler(this.pbQuestion16_Click);
            // 
            // pbQuestion4
            // 
            this.pbQuestion4.BackColor = System.Drawing.Color.Transparent;
            this.pbQuestion4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question;
            this.pbQuestion4.Location = new System.Drawing.Point(916, 195);
            this.pbQuestion4.Name = "pbQuestion4";
            this.pbQuestion4.Size = new System.Drawing.Size(132, 127);
            this.pbQuestion4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion4.TabIndex = 8;
            this.pbQuestion4.TabStop = false;
            this.pbQuestion4.Tag = "4";
            this.pbQuestion4.Click += new System.EventHandler(this.pbQuestion4_Click);
            // 
            // pbQuestion2
            // 
            this.pbQuestion2.BackColor = System.Drawing.Color.Transparent;
            this.pbQuestion2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question;
            this.pbQuestion2.Location = new System.Drawing.Point(737, 195);
            this.pbQuestion2.Name = "pbQuestion2";
            this.pbQuestion2.Size = new System.Drawing.Size(132, 127);
            this.pbQuestion2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion2.TabIndex = 7;
            this.pbQuestion2.TabStop = false;
            this.pbQuestion2.Tag = "2";
            this.pbQuestion2.Click += new System.EventHandler(this.pbQuestion2_Click);
            // 
            // pbQuestion1
            // 
            this.pbQuestion1.BackColor = System.Drawing.Color.Transparent;
            this.pbQuestion1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question;
            this.pbQuestion1.Location = new System.Drawing.Point(558, 195);
            this.pbQuestion1.Name = "pbQuestion1";
            this.pbQuestion1.Size = new System.Drawing.Size(132, 127);
            this.pbQuestion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion1.TabIndex = 6;
            this.pbQuestion1.TabStop = false;
            this.pbQuestion1.Tag = "1";
            this.pbQuestion1.Click += new System.EventHandler(this.pbQuestion1_Click);
            // 
            // btnRest
            // 
            this.btnRest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRest.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.ForeColor = System.Drawing.Color.Black;
            this.btnRest.Image = global::Tic_Tac_Toe_Game.Properties.Resources.Image6;
            this.btnRest.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRest.Location = new System.Drawing.Point(38, 556);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(333, 82);
            this.btnRest.TabIndex = 4;
            this.btnRest.Text = "Rest Game";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.tic_tac_toe;
            this.pictureBox1.Location = new System.Drawing.Point(145, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbGameResult
            // 
            this.lbGameResult.AutoSize = true;
            this.lbGameResult.BackColor = System.Drawing.Color.Transparent;
            this.lbGameResult.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameResult.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbGameResult.Location = new System.Drawing.Point(103, 443);
            this.lbGameResult.Name = "lbGameResult";
            this.lbGameResult.Size = new System.Drawing.Size(241, 52);
            this.lbGameResult.TabIndex = 16;
            this.lbGameResult.Text = "In Progress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1176, 678);
            this.Controls.Add(this.lbGameResult);
            this.Controls.Add(this.lbGameStatus);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.lbPlayer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbQuestion4);
            this.Controls.Add(this.pbQuestion8);
            this.Controls.Add(this.pbQuestion16);
            this.Controls.Add(this.pbQuestion32);
            this.Controls.Add(this.pbQuestion64);
            this.Controls.Add(this.pbQuestion128);
            this.Controls.Add(this.pbQuestion256);
            this.Controls.Add(this.pbQuestion2);
            this.Controls.Add(this.pbQuestion1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe Game";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion128)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion256)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbPlayer;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Label lbGameStatus;
        private System.Windows.Forms.PictureBox pbQuestion1;
        private System.Windows.Forms.PictureBox pbQuestion2;
        private System.Windows.Forms.PictureBox pbQuestion4;
        private System.Windows.Forms.PictureBox pbQuestion16;
        private System.Windows.Forms.PictureBox pbQuestion64;
        private System.Windows.Forms.PictureBox pbQuestion8;
        private System.Windows.Forms.PictureBox pbQuestion32;
        private System.Windows.Forms.PictureBox pbQuestion256;
        private System.Windows.Forms.PictureBox pbQuestion128;
        private System.Windows.Forms.Label lbGameResult;
    }
}

