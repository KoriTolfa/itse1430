namespace CharacterCreator.Winforms
{
    partial class About
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
            this.B_AboutExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_AboutExit
            // 
            this.B_AboutExit.Location = new System.Drawing.Point(595, 372);
            this.B_AboutExit.Name = "B_AboutExit";
            this.B_AboutExit.Size = new System.Drawing.Size(75, 23);
            this.B_AboutExit.TabIndex = 0;
            this.B_AboutExit.Text = "Exit";
            this.B_AboutExit.UseVisualStyleBackColor = true;
            this.B_AboutExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_AboutExit);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_AboutExit;
    }
}