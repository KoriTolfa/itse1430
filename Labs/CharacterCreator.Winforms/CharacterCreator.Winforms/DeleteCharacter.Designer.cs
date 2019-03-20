namespace CharacterCreator.Winforms
{
    partial class DeleteCharacter
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
            this.B_CharacterDeleteExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_CharacterDeleteExit
            // 
            this.B_CharacterDeleteExit.Location = new System.Drawing.Point(628, 349);
            this.B_CharacterDeleteExit.Name = "B_CharacterDeleteExit";
            this.B_CharacterDeleteExit.Size = new System.Drawing.Size(75, 23);
            this.B_CharacterDeleteExit.TabIndex = 0;
            this.B_CharacterDeleteExit.Text = "Exit";
            this.B_CharacterDeleteExit.UseVisualStyleBackColor = true;
            this.B_CharacterDeleteExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_CharacterDeleteExit);
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "DeleteCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeleteCharacter";
            this.Load += new System.EventHandler(this.DeleteCharacter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_CharacterDeleteExit;
    }
}