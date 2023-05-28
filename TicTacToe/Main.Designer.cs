namespace TicTacToe
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbTitle2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Commodore 64 Pixeled", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(104, 51);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(191, 37);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "TicTac";
            this.lbTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTitle2
            // 
            this.lbTitle2.AutoSize = true;
            this.lbTitle2.Font = new System.Drawing.Font("Commodore 64 Pixeled", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle2.ForeColor = System.Drawing.Color.White;
            this.lbTitle2.Location = new System.Drawing.Point(104, 88);
            this.lbTitle2.Name = "lbTitle2";
            this.lbTitle2.Size = new System.Drawing.Size(104, 37);
            this.lbTitle2.TabIndex = 1;
            this.lbTitle2.Text = "Toe";
            this.lbTitle2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Commodore 64 Pixeled", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(175, 193);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 45);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCredits
            // 
            this.btnCredits.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCredits.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCredits.FlatAppearance.BorderSize = 0;
            this.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCredits.Font = new System.Drawing.Font("Commodore 64 Pixeled", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredits.ForeColor = System.Drawing.Color.White;
            this.btnCredits.Location = new System.Drawing.Point(167, 302);
            this.btnCredits.Margin = new System.Windows.Forms.Padding(0);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(107, 38);
            this.btnCredits.TabIndex = 3;
            this.btnCredits.Text = "CREDITS";
            this.btnCredits.UseVisualStyleBackColor = false;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMult.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMult.FlatAppearance.BorderSize = 0;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMult.Font = new System.Drawing.Font("Commodore 64 Pixeled", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.Color.White;
            this.btnMult.Location = new System.Drawing.Point(136, 247);
            this.btnMult.Margin = new System.Windows.Forms.Padding(0);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(168, 41);
            this.btnMult.TabIndex = 4;
            this.btnMult.Text = "MULTIPLAYER";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::TicTacToe.Properties.Resources.three_in_a_row;
            this.pictureBox1.InitialImage = global::TicTacToe.Properties.Resources.three_in_a_row;
            this.pictureBox1.Location = new System.Drawing.Point(211, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(445, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbTitle2);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbTitle2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

