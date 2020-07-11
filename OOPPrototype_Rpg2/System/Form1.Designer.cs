namespace OOPPrototype_Rpg2
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
            this.gbxAddChar = new System.Windows.Forms.GroupBox();
            this.gbxGameScreen = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxCharName = new System.Windows.Forms.TextBox();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.lblSpell = new System.Windows.Forms.Label();
            this.cbxSpell = new System.Windows.Forms.ComboBox();
            this.cbxWeapon = new System.Windows.Forms.ComboBox();
            this.btnAddChar = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lbxChar = new System.Windows.Forms.ListBox();
            this.gbxAddChar.SuspendLayout();
            this.gbxGameScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAddChar
            // 
            this.gbxAddChar.Controls.Add(this.lblType);
            this.gbxAddChar.Controls.Add(this.cbxType);
            this.gbxAddChar.Controls.Add(this.btnAddChar);
            this.gbxAddChar.Controls.Add(this.cbxWeapon);
            this.gbxAddChar.Controls.Add(this.tbxCharName);
            this.gbxAddChar.Controls.Add(this.cbxSpell);
            this.gbxAddChar.Controls.Add(this.lblName);
            this.gbxAddChar.Controls.Add(this.lblSpell);
            this.gbxAddChar.Controls.Add(this.lblWeapon);
            this.gbxAddChar.Location = new System.Drawing.Point(12, 12);
            this.gbxAddChar.Name = "gbxAddChar";
            this.gbxAddChar.Size = new System.Drawing.Size(348, 308);
            this.gbxAddChar.TabIndex = 0;
            this.gbxAddChar.TabStop = false;
            this.gbxAddChar.Text = "Add Character";
            // 
            // gbxGameScreen
            // 
            this.gbxGameScreen.Controls.Add(this.lbxChar);
            this.gbxGameScreen.Location = new System.Drawing.Point(371, 12);
            this.gbxGameScreen.Name = "gbxGameScreen";
            this.gbxGameScreen.Size = new System.Drawing.Size(684, 308);
            this.gbxGameScreen.TabIndex = 3;
            this.gbxGameScreen.TabStop = false;
            this.gbxGameScreen.Text = "Game Screen";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // tbxCharName
            // 
            this.tbxCharName.Location = new System.Drawing.Point(105, 31);
            this.tbxCharName.Name = "tbxCharName";
            this.tbxCharName.Size = new System.Drawing.Size(211, 22);
            this.tbxCharName.TabIndex = 1;
            // 
            // lblWeapon
            // 
            this.lblWeapon.AutoSize = true;
            this.lblWeapon.Location = new System.Drawing.Point(17, 77);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(61, 17);
            this.lblWeapon.TabIndex = 2;
            this.lblWeapon.Text = "Weapon";
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.Location = new System.Drawing.Point(17, 123);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(39, 17);
            this.lblSpell.TabIndex = 3;
            this.lblSpell.Text = "Spell";
            // 
            // cbxSpell
            // 
            this.cbxSpell.FormattingEnabled = true;
            this.cbxSpell.Location = new System.Drawing.Point(105, 115);
            this.cbxSpell.Name = "cbxSpell";
            this.cbxSpell.Size = new System.Drawing.Size(211, 24);
            this.cbxSpell.TabIndex = 4;
            // 
            // cbxWeapon
            // 
            this.cbxWeapon.FormattingEnabled = true;
            this.cbxWeapon.Location = new System.Drawing.Point(105, 72);
            this.cbxWeapon.Name = "cbxWeapon";
            this.cbxWeapon.Size = new System.Drawing.Size(211, 24);
            this.cbxWeapon.TabIndex = 5;
            // 
            // btnAddChar
            // 
            this.btnAddChar.Location = new System.Drawing.Point(105, 210);
            this.btnAddChar.Name = "btnAddChar";
            this.btnAddChar.Size = new System.Drawing.Size(211, 48);
            this.btnAddChar.TabIndex = 6;
            this.btnAddChar.Text = "Add";
            this.btnAddChar.UseVisualStyleBackColor = true;
            this.btnAddChar.Click += new System.EventHandler(this.btnAddChar_Click);
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(105, 164);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(211, 24);
            this.cbxType.TabIndex = 7;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(17, 171);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type";
            // 
            // lbxChar
            // 
            this.lbxChar.FormattingEnabled = true;
            this.lbxChar.ItemHeight = 16;
            this.lbxChar.Location = new System.Drawing.Point(19, 31);
            this.lbxChar.Name = "lbxChar";
            this.lbxChar.Size = new System.Drawing.Size(643, 260);
            this.lbxChar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 361);
            this.Controls.Add(this.gbxAddChar);
            this.Controls.Add(this.gbxGameScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxAddChar.ResumeLayout(false);
            this.gbxAddChar.PerformLayout();
            this.gbxGameScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAddChar;
        private System.Windows.Forms.GroupBox gbxGameScreen;
        private System.Windows.Forms.ComboBox cbxWeapon;
        private System.Windows.Forms.TextBox tbxCharName;
        private System.Windows.Forms.ComboBox cbxSpell;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSpell;
        private System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.Button btnAddChar;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ListBox lbxChar;
    }
}

