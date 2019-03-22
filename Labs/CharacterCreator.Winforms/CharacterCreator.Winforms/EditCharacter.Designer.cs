namespace CharacterCreator.Winforms
{
    partial class EditCharacter
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
            this.B_ExitEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_ExitEdit
            // 
            this.B_ExitEdit.Location = new System.Drawing.Point(669, 339);
            this.B_ExitEdit.Name = "B_ExitEdit";
            this.B_ExitEdit.Size = new System.Drawing.Size(75, 23);
            this.B_ExitEdit.TabIndex = 0;
            this.B_ExitEdit.Text = "Exit";
            this.B_ExitEdit.UseVisualStyleBackColor = true;
            this.B_ExitEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_ExitEdit);
            this.Name = "EditCharacter";
            this.Text = "EditCharacter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_ExitEdit;
    }
}