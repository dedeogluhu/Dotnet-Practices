﻿namespace OOPPrototype_Basketball
{
    partial class Form1
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
            this.Players = new System.Windows.Forms.ListBox();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnLayup = new System.Windows.Forms.Button();
            this.btnShootThree = new System.Windows.Forms.Button();
            this.btnDunk = new System.Windows.Forms.Button();
            this.btnRebaund = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Players
            // 
            this.Players.FormattingEnabled = true;
            this.Players.ItemHeight = 16;
            this.Players.Location = new System.Drawing.Point(12, 12);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(392, 564);
            this.Players.TabIndex = 0;
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(421, 12);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(166, 65);
            this.btnShoot.TabIndex = 1;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            // 
            // btnLayup
            // 
            this.btnLayup.Location = new System.Drawing.Point(421, 83);
            this.btnLayup.Name = "btnLayup";
            this.btnLayup.Size = new System.Drawing.Size(166, 65);
            this.btnLayup.TabIndex = 2;
            this.btnLayup.Text = "Layup";
            this.btnLayup.UseVisualStyleBackColor = true;
            // 
            // btnShootThree
            // 
            this.btnShootThree.Location = new System.Drawing.Point(421, 154);
            this.btnShootThree.Name = "btnShootThree";
            this.btnShootThree.Size = new System.Drawing.Size(166, 65);
            this.btnShootThree.TabIndex = 3;
            this.btnShootThree.Text = "ShootThreePointer";
            this.btnShootThree.UseVisualStyleBackColor = true;
            // 
            // btnDunk
            // 
            this.btnDunk.Location = new System.Drawing.Point(421, 225);
            this.btnDunk.Name = "btnDunk";
            this.btnDunk.Size = new System.Drawing.Size(166, 65);
            this.btnDunk.TabIndex = 4;
            this.btnDunk.Text = "Dunk";
            this.btnDunk.UseVisualStyleBackColor = true;
            // 
            // btnRebaund
            // 
            this.btnRebaund.Location = new System.Drawing.Point(421, 296);
            this.btnRebaund.Name = "btnRebaund";
            this.btnRebaund.Size = new System.Drawing.Size(166, 65);
            this.btnRebaund.TabIndex = 5;
            this.btnRebaund.Text = "Rebaund";
            this.btnRebaund.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 591);
            this.Controls.Add(this.btnRebaund);
            this.Controls.Add(this.btnDunk);
            this.Controls.Add(this.btnShootThree);
            this.Controls.Add(this.btnLayup);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.Players);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Players;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnLayup;
        private System.Windows.Forms.Button btnShootThree;
        private System.Windows.Forms.Button btnDunk;
        private System.Windows.Forms.Button btnRebaund;
    }
}

