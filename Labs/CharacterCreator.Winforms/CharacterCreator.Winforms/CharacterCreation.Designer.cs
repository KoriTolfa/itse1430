namespace CharacterCreator.Winforms
{
    partial class CharacterCreation
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
            this.Lbl_CharacterName = new System.Windows.Forms.Label();
            this.Txt_CharacterName = new System.Windows.Forms.TextBox();
            this.Gb_Gender = new System.Windows.Forms.GroupBox();
            this.Rb_Male = new System.Windows.Forms.RadioButton();
            this.Rb_Female = new System.Windows.Forms.RadioButton();
            this.Cb_Race = new System.Windows.Forms.ComboBox();
            this.Lbl_Race = new System.Windows.Forms.Label();
            this.Lbl_Profession = new System.Windows.Forms.Label();
            this.Cb_Profession = new System.Windows.Forms.ComboBox();
            this.B_SaveCharacter = new System.Windows.Forms.Button();
            this.B_ExitCharCreate = new System.Windows.Forms.Button();
            this.Gb_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_CharacterName
            // 
            this.Lbl_CharacterName.AutoSize = true;
            this.Lbl_CharacterName.Location = new System.Drawing.Point(27, 13);
            this.Lbl_CharacterName.Name = "Lbl_CharacterName";
            this.Lbl_CharacterName.Size = new System.Drawing.Size(84, 13);
            this.Lbl_CharacterName.TabIndex = 0;
            this.Lbl_CharacterName.Text = "Character Name";
            this.Lbl_CharacterName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_CharacterName
            // 
            this.Txt_CharacterName.Location = new System.Drawing.Point(117, 13);
            this.Txt_CharacterName.Name = "Txt_CharacterName";
            this.Txt_CharacterName.Size = new System.Drawing.Size(150, 20);
            this.Txt_CharacterName.TabIndex = 1;
            // 
            // Gb_Gender
            // 
            this.Gb_Gender.Controls.Add(this.Rb_Male);
            this.Gb_Gender.Controls.Add(this.Rb_Female);
            this.Gb_Gender.Location = new System.Drawing.Point(104, 190);
            this.Gb_Gender.Name = "Gb_Gender";
            this.Gb_Gender.Size = new System.Drawing.Size(234, 93);
            this.Gb_Gender.TabIndex = 2;
            this.Gb_Gender.TabStop = false;
            this.Gb_Gender.Text = "Character Gender";
            // 
            // Rb_Male
            // 
            this.Rb_Male.AutoSize = true;
            this.Rb_Male.Location = new System.Drawing.Point(99, 35);
            this.Rb_Male.Name = "Rb_Male";
            this.Rb_Male.Size = new System.Drawing.Size(48, 17);
            this.Rb_Male.TabIndex = 1;
            this.Rb_Male.TabStop = true;
            this.Rb_Male.Text = "Male";
            this.Rb_Male.UseVisualStyleBackColor = true;
            // 
            // Rb_Female
            // 
            this.Rb_Female.AutoSize = true;
            this.Rb_Female.Location = new System.Drawing.Point(18, 35);
            this.Rb_Female.Name = "Rb_Female";
            this.Rb_Female.Size = new System.Drawing.Size(59, 17);
            this.Rb_Female.TabIndex = 0;
            this.Rb_Female.TabStop = true;
            this.Rb_Female.Text = "Female";
            this.Rb_Female.UseVisualStyleBackColor = true;
            // 
            // Cb_Race
            // 
            this.Cb_Race.FormattingEnabled = true;
            this.Cb_Race.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half-elf",
            "Human",
            "Metalhead"});
            this.Cb_Race.Location = new System.Drawing.Point(122, 70);
            this.Cb_Race.Name = "Cb_Race";
            this.Cb_Race.Size = new System.Drawing.Size(144, 21);
            this.Cb_Race.TabIndex = 3;
            // 
            // Lbl_Race
            // 
            this.Lbl_Race.AutoSize = true;
            this.Lbl_Race.Location = new System.Drawing.Point(29, 78);
            this.Lbl_Race.Name = "Lbl_Race";
            this.Lbl_Race.Size = new System.Drawing.Size(82, 13);
            this.Lbl_Race.TabIndex = 4;
            this.Lbl_Race.Text = "Character Race";
            // 
            // Lbl_Profession
            // 
            this.Lbl_Profession.AutoSize = true;
            this.Lbl_Profession.Location = new System.Drawing.Point(55, 125);
            this.Lbl_Profession.Name = "Lbl_Profession";
            this.Lbl_Profession.Size = new System.Drawing.Size(56, 13);
            this.Lbl_Profession.TabIndex = 5;
            this.Lbl_Profession.Text = "Profession";
            // 
            // Cb_Profession
            // 
            this.Cb_Profession.FormattingEnabled = true;
            this.Cb_Profession.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard",
            "Bard"});
            this.Cb_Profession.Location = new System.Drawing.Point(118, 125);
            this.Cb_Profession.Name = "Cb_Profession";
            this.Cb_Profession.Size = new System.Drawing.Size(147, 21);
            this.Cb_Profession.TabIndex = 6;
            // 
            // B_SaveCharacter
            // 
            this.B_SaveCharacter.Location = new System.Drawing.Point(31, 312);
            this.B_SaveCharacter.Name = "B_SaveCharacter";
            this.B_SaveCharacter.Size = new System.Drawing.Size(91, 30);
            this.B_SaveCharacter.TabIndex = 7;
            this.B_SaveCharacter.Text = "Save Character";
            this.B_SaveCharacter.UseVisualStyleBackColor = true;
            this.B_SaveCharacter.Click += new System.EventHandler(this.B_SaveCharacter_Click);
            // 
            // B_ExitCharCreate
            // 
            this.B_ExitCharCreate.Location = new System.Drawing.Point(149, 312);
            this.B_ExitCharCreate.Name = "B_ExitCharCreate";
            this.B_ExitCharCreate.Size = new System.Drawing.Size(91, 30);
            this.B_ExitCharCreate.TabIndex = 8;
            this.B_ExitCharCreate.Text = "Exit";
            this.B_ExitCharCreate.UseVisualStyleBackColor = true;
            this.B_ExitCharCreate.Click += new System.EventHandler(this.B_ExitCharCreate_Click);
            // 
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 412);
            this.Controls.Add(this.B_ExitCharCreate);
            this.Controls.Add(this.B_SaveCharacter);
            this.Controls.Add(this.Cb_Profession);
            this.Controls.Add(this.Lbl_Profession);
            this.Controls.Add(this.Lbl_Race);
            this.Controls.Add(this.Cb_Race);
            this.Controls.Add(this.Gb_Gender);
            this.Controls.Add(this.Txt_CharacterName);
            this.Controls.Add(this.Lbl_CharacterName);
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "CharacterCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Creator";
            this.Load += new System.EventHandler(this.CharacterCreation_Load);
            this.Gb_Gender.ResumeLayout(false);
            this.Gb_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CharacterName;
        private System.Windows.Forms.TextBox Txt_CharacterName;
        private System.Windows.Forms.GroupBox Gb_Gender;
        private System.Windows.Forms.RadioButton Rb_Male;
        private System.Windows.Forms.RadioButton Rb_Female;
        private System.Windows.Forms.ComboBox Cb_Race;
        private System.Windows.Forms.Label Lbl_Race;
        private System.Windows.Forms.Label Lbl_Profession;
        private System.Windows.Forms.ComboBox Cb_Profession;
        private System.Windows.Forms.Button B_SaveCharacter;
        private System.Windows.Forms.Button B_ExitCharCreate;
    }
}