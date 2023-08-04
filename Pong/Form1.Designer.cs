namespace Pong
{
    partial class Pong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.pongBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).BeginInit();
            this.SuspendLayout();
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.Color.Transparent;
            this.score1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.score1.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.ForeColor = System.Drawing.Color.White;
            this.score1.Location = new System.Drawing.Point(70, 35);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(48, 61);
            this.score1.TabIndex = 4;
            this.score1.Text = "0";
            this.score1.Click += new System.EventHandler(this.score1_Click);
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.BackColor = System.Drawing.Color.Transparent;
            this.score2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.score2.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.ForeColor = System.Drawing.Color.White;
            this.score2.Location = new System.Drawing.Point(874, 35);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(48, 61);
            this.score2.TabIndex = 5;
            this.score2.Text = "0";
            this.score2.Click += new System.EventHandler(this.score2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Pong.Properties.Resources.pong_table;
            this.pictureBox1.Location = new System.Drawing.Point(306, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 800);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.White;
            this.player2.Location = new System.Drawing.Point(952, 340);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(20, 120);
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            this.player2.Click += new System.EventHandler(this.player2_Click);
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.White;
            this.player1.Location = new System.Drawing.Point(12, 340);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(20, 120);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            this.player1.Click += new System.EventHandler(this.player1_Click);
            // 
            // pongBall
            // 
            this.pongBall.BackColor = System.Drawing.Color.Transparent;
            this.pongBall.Image = global::Pong.Properties.Resources.pong_ball;
            this.pongBall.Location = new System.Drawing.Point(489, 362);
            this.pongBall.Name = "pongBall";
            this.pongBall.Size = new System.Drawing.Size(40, 40);
            this.pongBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pongBall.TabIndex = 2;
            this.pongBall.TabStop = false;
            this.pongBall.Click += new System.EventHandler(this.pongBall_Click);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.pongBall);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Pong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox pongBall;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

