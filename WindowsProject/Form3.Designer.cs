namespace WindowsFormProject
{
    partial class Form3
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
            this.MathTest = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ImageViewer = new System.Windows.Forms.Button();
            this.MatchingGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MathTest
            // 
            this.MathTest.Location = new System.Drawing.Point(12, 262);
            this.MathTest.Name = "MathTest";
            this.MathTest.Size = new System.Drawing.Size(75, 23);
            this.MathTest.TabIndex = 0;
            this.MathTest.Text = "Test";
            this.MathTest.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(312, 262);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ImageViewer
            // 
            this.ImageViewer.Location = new System.Drawing.Point(112, 262);
            this.ImageViewer.Name = "ImageViewer";
            this.ImageViewer.Size = new System.Drawing.Size(75, 23);
            this.ImageViewer.TabIndex = 2;
            this.ImageViewer.Text = "Image";
            this.ImageViewer.UseVisualStyleBackColor = true;
            this.ImageViewer.Click += new System.EventHandler(this.ImageViewer_Click);
            // 
            // MatchingGame
            // 
            this.MatchingGame.Location = new System.Drawing.Point(212, 262);
            this.MatchingGame.Name = "MatchingGame";
            this.MatchingGame.Size = new System.Drawing.Size(75, 23);
            this.MatchingGame.TabIndex = 3;
            this.MatchingGame.Text = "Game";
            this.MatchingGame.UseVisualStyleBackColor = true;
            this.MatchingGame.Click += new System.EventHandler(this.MatchingGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to the Program of a life time.";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MatchingGame);
            this.Controls.Add(this.ImageViewer);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.MathTest);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MathTest;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ImageViewer;
        private System.Windows.Forms.Button MatchingGame;
        private System.Windows.Forms.Label label1;
    }
}