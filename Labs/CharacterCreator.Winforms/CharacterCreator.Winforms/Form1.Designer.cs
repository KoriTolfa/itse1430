﻿namespace CharacterCreator.Winforms
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
            this.label1 = new System.Windows.Forms.Label();
            this.B_CreateCharacter = new System.Windows.Forms.Button();
            this.B_Edit = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.B_About = new System.Windows.Forms.Button();
            this.B_DeleteCharacter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "RPG Character Creator";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // B_CreateCharacter
            // 
            this.B_CreateCharacter.Location = new System.Drawing.Point(30, 223);
            this.B_CreateCharacter.Name = "B_CreateCharacter";
            this.B_CreateCharacter.Size = new System.Drawing.Size(90, 26);
            this.B_CreateCharacter.TabIndex = 1;
            this.B_CreateCharacter.Text = "New Character";
            this.B_CreateCharacter.UseVisualStyleBackColor = true;
            this.B_CreateCharacter.Click += new System.EventHandler(this.B_CreateCharacter_Click);
            // 
            // B_Edit
            // 
            this.B_Edit.Location = new System.Drawing.Point(147, 223);
            this.B_Edit.Name = "B_Edit";
            this.B_Edit.Size = new System.Drawing.Size(90, 26);
            this.B_Edit.TabIndex = 2;
            this.B_Edit.Text = "Edit  Character";
            this.B_Edit.UseVisualStyleBackColor = true;
            this.B_Edit.Click += new System.EventHandler(this.button1_Click);
            // 
            // B_Exit
            // 
            this.B_Exit.Location = new System.Drawing.Point(147, 293);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(90, 26);
            this.B_Exit.TabIndex = 5;
            this.B_Exit.Text = "Exit";
            this.B_Exit.UseVisualStyleBackColor = true;
            this.B_Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // B_About
            // 
            this.B_About.Location = new System.Drawing.Point(30, 296);
            this.B_About.Name = "B_About";
            this.B_About.Size = new System.Drawing.Size(75, 23);
            this.B_About.TabIndex = 4;
            this.B_About.Text = "About";
            this.B_About.UseVisualStyleBackColor = true;
            this.B_About.Click += new System.EventHandler(this.B_About_Click);
            // 
            // B_DeleteCharacter
            // 
            this.B_DeleteCharacter.Location = new System.Drawing.Point(298, 226);
            this.B_DeleteCharacter.Name = "B_DeleteCharacter";
            this.B_DeleteCharacter.Size = new System.Drawing.Size(101, 22);
            this.B_DeleteCharacter.TabIndex = 6;
            this.B_DeleteCharacter.Text = "Delete Character";
            this.B_DeleteCharacter.UseVisualStyleBackColor = true;
            this.B_DeleteCharacter.Click += new System.EventHandler(this.B_DeleteCharacter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 412);
            this.Controls.Add(this.B_DeleteCharacter);
            this.Controls.Add(this.B_About);
            this.Controls.Add(this.B_Exit);
            this.Controls.Add(this.B_Edit);
            this.Controls.Add(this.B_CreateCharacter);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_CreateCharacter;
        private System.Windows.Forms.Button B_Edit;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Button B_About;
        private System.Windows.Forms.Button B_DeleteCharacter;
    }
}

