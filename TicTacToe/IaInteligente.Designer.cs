namespace TicTacToe
{
    partial class IaInteligente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IaInteligente));
            this.btnVoltaPrinc = new System.Windows.Forms.Button();
            this.pnlMini = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnVoltaPrinc
            // 
            this.btnVoltaPrinc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltaPrinc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVoltaPrinc.FlatAppearance.BorderSize = 0;
            this.btnVoltaPrinc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltaPrinc.Font = new System.Drawing.Font("Commodore 64 Pixeled", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltaPrinc.ForeColor = System.Drawing.Color.White;
            this.btnVoltaPrinc.Location = new System.Drawing.Point(9, 460);
            this.btnVoltaPrinc.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltaPrinc.Name = "btnVoltaPrinc";
            this.btnVoltaPrinc.Size = new System.Drawing.Size(85, 33);
            this.btnVoltaPrinc.TabIndex = 5;
            this.btnVoltaPrinc.Text = "<BACK";
            this.btnVoltaPrinc.UseVisualStyleBackColor = false;
            this.btnVoltaPrinc.Click += new System.EventHandler(this.btnVoltaPrinc_Click);
            // 
            // pnlMini
            // 
            this.pnlMini.Location = new System.Drawing.Point(-3, -7);
            this.pnlMini.Name = "pnlMini";
            this.pnlMini.Size = new System.Drawing.Size(453, 472);
            this.pnlMini.TabIndex = 6;
            // 
            // IaInteligente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(445, 502);
            this.Controls.Add(this.pnlMini);
            this.Controls.Add(this.btnVoltaPrinc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IaInteligente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltaPrinc;
        private System.Windows.Forms.Panel pnlMini;
    }
}