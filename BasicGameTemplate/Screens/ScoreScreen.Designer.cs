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
            this.rankLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(294, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "HIGHSCORES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rankLabel
            // 
            this.rankLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.rankLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankLabel.Location = new System.Drawing.Point(0, 57);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.rankLabel.Size = new System.Drawing.Size(43, 207);
            this.rankLabel.TabIndex = 1;
            this.rankLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.playerNameLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(43, 57);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.playerNameLabel.Size = new System.Drawing.Size(220, 207);
            this.playerNameLabel.TabIndex = 2;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.scoreLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(187, 57);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.scoreLabel.Size = new System.Drawing.Size(107, 207);
            this.scoreLabel.TabIndex = 3;
            // 
            // ScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.rankLabel);
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
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label scoreLabel;
    }
}
