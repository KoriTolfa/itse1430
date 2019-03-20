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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.B_AboutExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_CharacterStats = new System.Windows.Forms.Label();
            this.TxtBx_CharacterStats = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 344);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(164, 51);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Kori Tolfa\r\nITSE 1430\r\nLab 2 - Character Creator\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Lbl_CharacterStats
            // 
            this.Lbl_CharacterStats.AutoSize = true;
            this.Lbl_CharacterStats.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CharacterStats.Location = new System.Drawing.Point(33, 26);
            this.Lbl_CharacterStats.Name = "Lbl_CharacterStats";
            this.Lbl_CharacterStats.Size = new System.Drawing.Size(109, 17);
            this.Lbl_CharacterStats.TabIndex = 2;
            this.Lbl_CharacterStats.Text = "Character Stats";
            // 
            // TxtBx_CharacterStats
            // 
            this.TxtBx_CharacterStats.Location = new System.Drawing.Point(34, 57);
            this.TxtBx_CharacterStats.Multiline = true;
            this.TxtBx_CharacterStats.Name = "TxtBx_CharacterStats";
            this.TxtBx_CharacterStats.ReadOnly = true;
            this.TxtBx_CharacterStats.Size = new System.Drawing.Size(674, 245);
            this.TxtBx_CharacterStats.TabIndex = 3;
            this.TxtBx_CharacterStats.Text = resources.GetString("TxtBx_CharacterStats.Text");
            this.TxtBx_CharacterStats.TextChanged += new System.EventHandler(this.TxtBx_CharacterStats_TextChanged);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBx_CharacterStats);
            this.Controls.Add(this.Lbl_CharacterStats);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.B_AboutExit);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_AboutExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_CharacterStats;
        private System.Windows.Forms.TextBox TxtBx_CharacterStats;
    }
}