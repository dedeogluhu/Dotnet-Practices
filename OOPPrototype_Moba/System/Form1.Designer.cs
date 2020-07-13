namespace OOPPrototype_Moba
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
            this.gbxAddCharacter = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAttackType = new System.Windows.Forms.Label();
            this.lblPrimaryAttr = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblSkillName = new System.Windows.Forms.Label();
            this.lblUltiName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.cbxAttackType = new System.Windows.Forms.ComboBox();
            this.cbxPrimaryAttr = new System.Windows.Forms.ComboBox();
            this.tbxLevel = new System.Windows.Forms.TextBox();
            this.tbxSkillName = new System.Windows.Forms.TextBox();
            this.tbxUltiName = new System.Windows.Forms.TextBox();
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.gbxGameScreen = new System.Windows.Forms.GroupBox();
            this.lbxCharacters = new System.Windows.Forms.ListBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnUseSkill = new System.Windows.Forms.Button();
            this.btnUseUlti = new System.Windows.Forms.Button();
            this.btnFarm = new System.Windows.Forms.Button();
            this.btnBuyWards = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.gbxAddCharacter.SuspendLayout();
            this.gbxGameScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAddCharacter
            // 
            this.gbxAddCharacter.Controls.Add(this.lblRole);
            this.gbxAddCharacter.Controls.Add(this.cbxRole);
            this.gbxAddCharacter.Controls.Add(this.btnAddCharacter);
            this.gbxAddCharacter.Controls.Add(this.tbxUltiName);
            this.gbxAddCharacter.Controls.Add(this.tbxSkillName);
            this.gbxAddCharacter.Controls.Add(this.tbxLevel);
            this.gbxAddCharacter.Controls.Add(this.cbxPrimaryAttr);
            this.gbxAddCharacter.Controls.Add(this.cbxAttackType);
            this.gbxAddCharacter.Controls.Add(this.tbxName);
            this.gbxAddCharacter.Controls.Add(this.lblUltiName);
            this.gbxAddCharacter.Controls.Add(this.lblSkillName);
            this.gbxAddCharacter.Controls.Add(this.lblLevel);
            this.gbxAddCharacter.Controls.Add(this.lblPrimaryAttr);
            this.gbxAddCharacter.Controls.Add(this.lblAttackType);
            this.gbxAddCharacter.Controls.Add(this.lblName);
            this.gbxAddCharacter.Location = new System.Drawing.Point(13, 13);
            this.gbxAddCharacter.Name = "gbxAddCharacter";
            this.gbxAddCharacter.Size = new System.Drawing.Size(559, 572);
            this.gbxAddCharacter.TabIndex = 0;
            this.gbxAddCharacter.TabStop = false;
            this.gbxAddCharacter.Text = "Add a Character";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 129);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblAttackType
            // 
            this.lblAttackType.AutoSize = true;
            this.lblAttackType.Location = new System.Drawing.Point(45, 179);
            this.lblAttackType.Name = "lblAttackType";
            this.lblAttackType.Size = new System.Drawing.Size(87, 17);
            this.lblAttackType.TabIndex = 1;
            this.lblAttackType.Text = "Attack Type:";
            // 
            // lblPrimaryAttr
            // 
            this.lblPrimaryAttr.AutoSize = true;
            this.lblPrimaryAttr.Location = new System.Drawing.Point(45, 229);
            this.lblPrimaryAttr.Name = "lblPrimaryAttr";
            this.lblPrimaryAttr.Size = new System.Drawing.Size(117, 17);
            this.lblPrimaryAttr.TabIndex = 2;
            this.lblPrimaryAttr.Text = "Primary Attribute:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(45, 279);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 17);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "Level:";
            // 
            // lblSkillName
            // 
            this.lblSkillName.AutoSize = true;
            this.lblSkillName.Location = new System.Drawing.Point(45, 329);
            this.lblSkillName.Name = "lblSkillName";
            this.lblSkillName.Size = new System.Drawing.Size(78, 17);
            this.lblSkillName.TabIndex = 4;
            this.lblSkillName.Text = "Skill Name:";
            // 
            // lblUltiName
            // 
            this.lblUltiName.AutoSize = true;
            this.lblUltiName.Location = new System.Drawing.Point(45, 379);
            this.lblUltiName.Name = "lblUltiName";
            this.lblUltiName.Size = new System.Drawing.Size(73, 17);
            this.lblUltiName.TabIndex = 5;
            this.lblUltiName.Text = "Ulti Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(189, 125);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(287, 22);
            this.tbxName.TabIndex = 6;
            // 
            // cbxAttackType
            // 
            this.cbxAttackType.FormattingEnabled = true;
            this.cbxAttackType.Location = new System.Drawing.Point(189, 172);
            this.cbxAttackType.Name = "cbxAttackType";
            this.cbxAttackType.Size = new System.Drawing.Size(287, 24);
            this.cbxAttackType.TabIndex = 7;
            // 
            // cbxPrimaryAttr
            // 
            this.cbxPrimaryAttr.FormattingEnabled = true;
            this.cbxPrimaryAttr.Location = new System.Drawing.Point(189, 222);
            this.cbxPrimaryAttr.Name = "cbxPrimaryAttr";
            this.cbxPrimaryAttr.Size = new System.Drawing.Size(287, 24);
            this.cbxPrimaryAttr.TabIndex = 8;
            // 
            // tbxLevel
            // 
            this.tbxLevel.Location = new System.Drawing.Point(189, 275);
            this.tbxLevel.Name = "tbxLevel";
            this.tbxLevel.Size = new System.Drawing.Size(287, 22);
            this.tbxLevel.TabIndex = 9;
            // 
            // tbxSkillName
            // 
            this.tbxSkillName.Location = new System.Drawing.Point(189, 325);
            this.tbxSkillName.Name = "tbxSkillName";
            this.tbxSkillName.Size = new System.Drawing.Size(287, 22);
            this.tbxSkillName.TabIndex = 10;
            // 
            // tbxUltiName
            // 
            this.tbxUltiName.Location = new System.Drawing.Point(189, 375);
            this.tbxUltiName.Name = "tbxUltiName";
            this.tbxUltiName.Size = new System.Drawing.Size(287, 22);
            this.tbxUltiName.TabIndex = 11;
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.Location = new System.Drawing.Point(189, 434);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(287, 58);
            this.btnAddCharacter.TabIndex = 12;
            this.btnAddCharacter.Text = "Add Character";
            this.btnAddCharacter.UseVisualStyleBackColor = true;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click);
            // 
            // gbxGameScreen
            // 
            this.gbxGameScreen.Controls.Add(this.btnHeal);
            this.gbxGameScreen.Controls.Add(this.btnBuyWards);
            this.gbxGameScreen.Controls.Add(this.btnFarm);
            this.gbxGameScreen.Controls.Add(this.btnUseUlti);
            this.gbxGameScreen.Controls.Add(this.btnUseSkill);
            this.gbxGameScreen.Controls.Add(this.btnAttack);
            this.gbxGameScreen.Controls.Add(this.lbxCharacters);
            this.gbxGameScreen.Location = new System.Drawing.Point(593, 13);
            this.gbxGameScreen.Name = "gbxGameScreen";
            this.gbxGameScreen.Size = new System.Drawing.Size(570, 572);
            this.gbxGameScreen.TabIndex = 1;
            this.gbxGameScreen.TabStop = false;
            this.gbxGameScreen.Text = "Game Screen";
            // 
            // lbxCharacters
            // 
            this.lbxCharacters.FormattingEnabled = true;
            this.lbxCharacters.ItemHeight = 16;
            this.lbxCharacters.Location = new System.Drawing.Point(7, 22);
            this.lbxCharacters.Name = "lbxCharacters";
            this.lbxCharacters.Size = new System.Drawing.Size(557, 420);
            this.lbxCharacters.TabIndex = 0;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(7, 448);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(121, 44);
            this.btnAttack.TabIndex = 1;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnUseSkill
            // 
            this.btnUseSkill.Location = new System.Drawing.Point(134, 448);
            this.btnUseSkill.Name = "btnUseSkill";
            this.btnUseSkill.Size = new System.Drawing.Size(121, 44);
            this.btnUseSkill.TabIndex = 2;
            this.btnUseSkill.Text = "Use Skill";
            this.btnUseSkill.UseVisualStyleBackColor = true;
            this.btnUseSkill.Click += new System.EventHandler(this.btnUseSkill_Click);
            // 
            // btnUseUlti
            // 
            this.btnUseUlti.Location = new System.Drawing.Point(261, 448);
            this.btnUseUlti.Name = "btnUseUlti";
            this.btnUseUlti.Size = new System.Drawing.Size(121, 44);
            this.btnUseUlti.TabIndex = 3;
            this.btnUseUlti.Text = "Use Ulti";
            this.btnUseUlti.UseVisualStyleBackColor = true;
            this.btnUseUlti.Click += new System.EventHandler(this.btnUseUlti_Click);
            // 
            // btnFarm
            // 
            this.btnFarm.Location = new System.Drawing.Point(7, 498);
            this.btnFarm.Name = "btnFarm";
            this.btnFarm.Size = new System.Drawing.Size(121, 44);
            this.btnFarm.TabIndex = 4;
            this.btnFarm.Text = "Farm";
            this.btnFarm.UseVisualStyleBackColor = true;
            this.btnFarm.Click += new System.EventHandler(this.btnFarm_Click);
            // 
            // btnBuyWards
            // 
            this.btnBuyWards.Location = new System.Drawing.Point(134, 498);
            this.btnBuyWards.Name = "btnBuyWards";
            this.btnBuyWards.Size = new System.Drawing.Size(121, 44);
            this.btnBuyWards.TabIndex = 5;
            this.btnBuyWards.Text = "Buy Wards";
            this.btnBuyWards.UseVisualStyleBackColor = true;
            this.btnBuyWards.Click += new System.EventHandler(this.btnBuyWards_Click);
            // 
            // btnHeal
            // 
            this.btnHeal.Location = new System.Drawing.Point(261, 498);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(121, 44);
            this.btnHeal.TabIndex = 6;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // cbxRole
            // 
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(189, 73);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(287, 24);
            this.cbxRole.TabIndex = 13;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(45, 80);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(41, 17);
            this.lblRole.TabIndex = 14;
            this.lblRole.Text = "Role:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 597);
            this.Controls.Add(this.gbxGameScreen);
            this.Controls.Add(this.gbxAddCharacter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxAddCharacter.ResumeLayout(false);
            this.gbxAddCharacter.PerformLayout();
            this.gbxGameScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAddCharacter;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblUltiName;
        private System.Windows.Forms.Label lblSkillName;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblPrimaryAttr;
        private System.Windows.Forms.Label lblAttackType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbxPrimaryAttr;
        private System.Windows.Forms.ComboBox cbxAttackType;
        private System.Windows.Forms.TextBox tbxLevel;
        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.TextBox tbxUltiName;
        private System.Windows.Forms.TextBox tbxSkillName;
        private System.Windows.Forms.GroupBox gbxGameScreen;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnBuyWards;
        private System.Windows.Forms.Button btnFarm;
        private System.Windows.Forms.Button btnUseUlti;
        private System.Windows.Forms.Button btnUseSkill;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.ListBox lbxCharacters;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbxRole;
    }
}

