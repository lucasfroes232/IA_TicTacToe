namespace TicTacToe
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.label1 = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.btnVoltaPrinc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Commodore 64 Pixeled", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME OVER";
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Commodore 64 Pixeled", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.ForeColor = System.Drawing.Color.White;
            this.lbWinner.Location = new System.Drawing.Point(120, 92);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(19, 14);
            this.lbWinner.TabIndex = 2;
            this.lbWinner.Text = " ";
            this.lbWinner.Click += new System.EventHandler(this.lbWinner_Click);
            // 
            // btnVoltaPrinc
            // 
            this.btnVoltaPrinc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltaPrinc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVoltaPrinc.FlatAppearance.BorderSize = 0;
            this.btnVoltaPrinc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltaPrinc.Font = new System.Drawing.Font("Commodore 64 Pixeled", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltaPrinc.ForeColor = System.Drawing.Color.White;
            this.btnVoltaPrinc.Location = new System.Drawing.Point(139, 165);
            this.btnVoltaPrinc.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltaPrinc.Name = "btnVoltaPrinc";
            this.btnVoltaPrinc.Size = new System.Drawing.Size(85, 33);
            this.btnVoltaPrinc.TabIndex = 6;
            this.btnVoltaPrinc.Text = "<BACK";
            this.btnVoltaPrinc.UseVisualStyleBackColor = false;
            this.btnVoltaPrinc.Click += new System.EventHandler(this.btnVoltaPrinc_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(367, 222);
            this.Controls.Add(this.btnVoltaPrinc);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over";
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Button btnVoltaPrinc;
    }
}