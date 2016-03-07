namespace Simon_Game
{
    partial class GameOverScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.overLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // overLabel
            // 
            this.overLabel.AutoSize = true;
            this.overLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overLabel.ForeColor = System.Drawing.Color.Red;
            this.overLabel.Location = new System.Drawing.Point(97, 113);
            this.overLabel.Name = "overLabel";
            this.overLabel.Size = new System.Drawing.Size(244, 25);
            this.overLabel.TabIndex = 0;
            this.overLabel.Text = "Game Over. Your score:";
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(190, 171);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 23);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Main Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(280, 171);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.overLabel);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(600, 425);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label overLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button closeButton;
    }
}
