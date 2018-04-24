namespace BasicGameTemplate
{
    partial class ScoreScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.Rank = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("8BIT WONDER", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(294, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "HIGHSCORES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rank
            // 
            this.Rank.Dock = System.Windows.Forms.DockStyle.Left;
            this.Rank.Font = new System.Drawing.Font("8BIT WONDER", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rank.Location = new System.Drawing.Point(0, 57);
            this.Rank.Name = "Rank";
            this.Rank.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Rank.Size = new System.Drawing.Size(43, 207);
            this.Rank.TabIndex = 1;
            this.Rank.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PlayerName
            // 
            this.PlayerName.Dock = System.Windows.Forms.DockStyle.Left;
            this.PlayerName.Font = new System.Drawing.Font("8BIT WONDER", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName.Location = new System.Drawing.Point(43, 57);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.PlayerName.Size = new System.Drawing.Size(220, 207);
            this.PlayerName.TabIndex = 2;
            // 
            // Score
            // 
            this.Score.Dock = System.Windows.Forms.DockStyle.Right;
            this.Score.Font = new System.Drawing.Font("8BIT WONDER", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(187, 57);
            this.Score.Name = "Score";
            this.Score.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Score.Size = new System.Drawing.Size(107, 207);
            this.Score.TabIndex = 3;
            // 
            // ScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.Score);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.Rank);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScoreScreen";
            this.Size = new System.Drawing.Size(294, 264);
            this.Load += new System.EventHandler(this.ScoreScreen_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ScoreScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Rank;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Label Score;
    }
}
