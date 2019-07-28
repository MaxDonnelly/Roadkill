﻿namespace Roadkill
{
    partial class FrmRoadkill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoadkill));
            this.label3 = new System.Windows.Forms.Label();
            this.TmrCharacter = new System.Windows.Forms.Timer(this.components);
            this.TmrCar = new System.Windows.Forms.Timer(this.components);
            this.PnlGame = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Roadkill";
            // 
            // TmrCharacter
            // 
            this.TmrCharacter.Interval = 30;
            this.TmrCharacter.Tick += new System.EventHandler(this.TmrCharacter_Tick);
            // 
            // TmrCar
            // 
            this.TmrCar.Interval = 5;
            this.TmrCar.Tick += new System.EventHandler(this.TmrCar_Tick);
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.PnlGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlGame.BackgroundImage")));
            this.PnlGame.Controls.Add(this.pictureBox2);
            this.PnlGame.Controls.Add(this.pictureBox1);
            this.PnlGame.Location = new System.Drawing.Point(12, 29);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(460, 520);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Roadkill.Properties.Resources.ezgif_com_gif_maker;
            this.pictureBox2.Location = new System.Drawing.Point(15, 290);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Roadkill.Properties.Resources.ezgif_com_gif_maker;
            this.pictureBox1.Location = new System.Drawing.Point(335, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStart,
            this.MnuQuit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuStart
            // 
            this.MnuStart.BackColor = System.Drawing.Color.Chartreuse;
            this.MnuStart.Name = "MnuStart";
            this.MnuStart.Size = new System.Drawing.Size(52, 20);
            this.MnuStart.Text = "START";
            this.MnuStart.Click += new System.EventHandler(this.MnuStart_Click);
            // 
            // MnuQuit
            // 
            this.MnuQuit.BackColor = System.Drawing.Color.Red;
            this.MnuQuit.Name = "MnuQuit";
            this.MnuQuit.Size = new System.Drawing.Size(46, 20);
            this.MnuQuit.Text = "QUIT";
            this.MnuQuit.Click += new System.EventHandler(this.MnuQuit_Click);
            // 
            // FrmRoadkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmRoadkill";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRoadkill_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmRoadkill_KeyUp);
            this.PnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer TmrCharacter;
        private System.Windows.Forms.Timer TmrCar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuStart;
        private System.Windows.Forms.ToolStripMenuItem MnuQuit;
    }
}
