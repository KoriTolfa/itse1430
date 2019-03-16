namespace CharacterCreator.Winforms
{
    partial class MainForm
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
            this.lbl_CharacterName = new System.Windows.Forms.Label();
            this.Txt_CharacterName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rb_Male = new System.Windows.Forms.RadioButton();
            this.Rb_Female = new System.Windows.Forms.RadioButton();
            this.Cb_CharacterClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CharacterName
            // 
            this.lbl_CharacterName.AutoSize = true;
            this.lbl_CharacterName.Location = new System.Drawing.Point(22, 23);
            this.lbl_CharacterName.Name = "lbl_CharacterName";
            this.lbl_CharacterName.Size = new System.Drawing.Size(35, 13);
            this.lbl_CharacterName.TabIndex = 0;
            this.lbl_CharacterName.Text = "Name";
            this.lbl_CharacterName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_CharacterName
            // 
            this.Txt_CharacterName.Location = new System.Drawing.Point(63, 23);
            this.Txt_CharacterName.Name = "Txt_CharacterName";
            this.Txt_CharacterName.Size = new System.Drawing.Size(100, 20);
            this.Txt_CharacterName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rb_Female);
            this.groupBox1.Controls.Add(this.Rb_Male);
            this.groupBox1.Location = new System.Drawing.Point(63, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Gender";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Rb_Male
            // 
            this.Rb_Male.AutoSize = true;
            this.Rb_Male.Location = new System.Drawing.Point(17, 34);
            this.Rb_Male.Name = "Rb_Male";
            this.Rb_Male.Size = new System.Drawing.Size(48, 17);
            this.Rb_Male.TabIndex = 0;
            this.Rb_Male.TabStop = true;
            this.Rb_Male.Text = "Male";
            this.Rb_Male.UseVisualStyleBackColor = true;
            // 
            // Rb_Female
            // 
            this.Rb_Female.AutoSize = true;
            this.Rb_Female.Location = new System.Drawing.Point(71, 34);
            this.Rb_Female.Name = "Rb_Female";
            this.Rb_Female.Size = new System.Drawing.Size(59, 17);
            this.Rb_Female.TabIndex = 1;
            this.Rb_Female.TabStop = true;
            this.Rb_Female.Text = "Female";
            this.Rb_Female.UseVisualStyleBackColor = true;
            // 
            // Cb_CharacterClass
            // 
            this.Cb_CharacterClass.FormattingEnabled = true;
            this.Cb_CharacterClass.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human",
            "Metal Head"});
            this.Cb_CharacterClass.Location = new System.Drawing.Point(63, 73);
            this.Cb_CharacterClass.Name = "Cb_CharacterClass";
            this.Cb_CharacterClass.Size = new System.Drawing.Size(121, 21);
            this.Cb_CharacterClass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Race";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this.comboBox1.Location = new System.Drawing.Point(63, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Profession";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cb_CharacterClass);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txt_CharacterName);
            this.Controls.Add(this.lbl_CharacterName);
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CharacterName;
        private System.Windows.Forms.TextBox Txt_CharacterName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rb_Female;
        private System.Windows.Forms.RadioButton Rb_Male;
        private System.Windows.Forms.ComboBox Cb_CharacterClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

