namespace OOPPrototype_Rpg
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
            this.gbxTank = new System.Windows.Forms.GroupBox();
            this.gbxStealth = new System.Windows.Forms.GroupBox();
            this.gbxNecromancer = new System.Windows.Forms.GroupBox();
            this.gbxDamageDealer = new System.Windows.Forms.GroupBox();
            this.gbxArcher = new System.Windows.Forms.GroupBox();
            this.gbxPriest = new System.Windows.Forms.GroupBox();
            this.btnCastTank = new System.Windows.Forms.Button();
            this.btnAttackTank = new System.Windows.Forms.Button();
            this.btnAttackStealth = new System.Windows.Forms.Button();
            this.btnCastStealth = new System.Windows.Forms.Button();
            this.btnAttackNecromancer = new System.Windows.Forms.Button();
            this.btnCastNecromancer = new System.Windows.Forms.Button();
            this.btnAttackPriest = new System.Windows.Forms.Button();
            this.btnCastPriest = new System.Windows.Forms.Button();
            this.btnAttackArcher = new System.Windows.Forms.Button();
            this.btnCastArcher = new System.Windows.Forms.Button();
            this.btnAttackDamageDealer = new System.Windows.Forms.Button();
            this.btnCastDamageDealer = new System.Windows.Forms.Button();
            this.gbxTank.SuspendLayout();
            this.gbxStealth.SuspendLayout();
            this.gbxNecromancer.SuspendLayout();
            this.gbxDamageDealer.SuspendLayout();
            this.gbxArcher.SuspendLayout();
            this.gbxPriest.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTank
            // 
            this.gbxTank.Controls.Add(this.btnAttackTank);
            this.gbxTank.Controls.Add(this.btnCastTank);
            this.gbxTank.Location = new System.Drawing.Point(12, 12);
            this.gbxTank.Name = "gbxTank";
            this.gbxTank.Size = new System.Drawing.Size(354, 262);
            this.gbxTank.TabIndex = 0;
            this.gbxTank.TabStop = false;
            this.gbxTank.Text = "Tank Warrior";
            // 
            // gbxStealth
            // 
            this.gbxStealth.Controls.Add(this.btnAttackStealth);
            this.gbxStealth.Controls.Add(this.btnCastStealth);
            this.gbxStealth.Location = new System.Drawing.Point(372, 12);
            this.gbxStealth.Name = "gbxStealth";
            this.gbxStealth.Size = new System.Drawing.Size(354, 262);
            this.gbxStealth.TabIndex = 1;
            this.gbxStealth.TabStop = false;
            this.gbxStealth.Text = "Stealth Assassin";
            // 
            // gbxNecromancer
            // 
            this.gbxNecromancer.Controls.Add(this.btnAttackNecromancer);
            this.gbxNecromancer.Controls.Add(this.btnCastNecromancer);
            this.gbxNecromancer.Location = new System.Drawing.Point(732, 12);
            this.gbxNecromancer.Name = "gbxNecromancer";
            this.gbxNecromancer.Size = new System.Drawing.Size(354, 262);
            this.gbxNecromancer.TabIndex = 2;
            this.gbxNecromancer.TabStop = false;
            this.gbxNecromancer.Text = "Necromancer Mage";
            // 
            // gbxDamageDealer
            // 
            this.gbxDamageDealer.Controls.Add(this.btnAttackDamageDealer);
            this.gbxDamageDealer.Controls.Add(this.btnCastDamageDealer);
            this.gbxDamageDealer.Location = new System.Drawing.Point(12, 280);
            this.gbxDamageDealer.Name = "gbxDamageDealer";
            this.gbxDamageDealer.Size = new System.Drawing.Size(354, 262);
            this.gbxDamageDealer.TabIndex = 3;
            this.gbxDamageDealer.TabStop = false;
            this.gbxDamageDealer.Text = "Damage Dealer Warrior";
            // 
            // gbxArcher
            // 
            this.gbxArcher.Controls.Add(this.btnAttackArcher);
            this.gbxArcher.Controls.Add(this.btnCastArcher);
            this.gbxArcher.Location = new System.Drawing.Point(372, 280);
            this.gbxArcher.Name = "gbxArcher";
            this.gbxArcher.Size = new System.Drawing.Size(354, 262);
            this.gbxArcher.TabIndex = 4;
            this.gbxArcher.TabStop = false;
            this.gbxArcher.Text = "Archer Assassin";
            // 
            // gbxPriest
            // 
            this.gbxPriest.Controls.Add(this.btnAttackPriest);
            this.gbxPriest.Controls.Add(this.btnCastPriest);
            this.gbxPriest.Location = new System.Drawing.Point(732, 280);
            this.gbxPriest.Name = "gbxPriest";
            this.gbxPriest.Size = new System.Drawing.Size(354, 262);
            this.gbxPriest.TabIndex = 5;
            this.gbxPriest.TabStop = false;
            this.gbxPriest.Text = "Priest Mage";
            // 
            // btnCastTank
            // 
            this.btnCastTank.Location = new System.Drawing.Point(85, 73);
            this.btnCastTank.Name = "btnCastTank";
            this.btnCastTank.Size = new System.Drawing.Size(182, 45);
            this.btnCastTank.TabIndex = 0;
            this.btnCastTank.Text = "Cast Spell";
            this.btnCastTank.UseVisualStyleBackColor = true;
            this.btnCastTank.Click += new System.EventHandler(this.btnCastTank_Click);
            // 
            // btnAttackTank
            // 
            this.btnAttackTank.Location = new System.Drawing.Point(85, 125);
            this.btnAttackTank.Name = "btnAttackTank";
            this.btnAttackTank.Size = new System.Drawing.Size(182, 50);
            this.btnAttackTank.TabIndex = 1;
            this.btnAttackTank.Text = "Attack";
            this.btnAttackTank.UseVisualStyleBackColor = true;
            this.btnAttackTank.Click += new System.EventHandler(this.btnAttackTank_Click);
            // 
            // btnAttackStealth
            // 
            this.btnAttackStealth.Location = new System.Drawing.Point(86, 132);
            this.btnAttackStealth.Name = "btnAttackStealth";
            this.btnAttackStealth.Size = new System.Drawing.Size(182, 50);
            this.btnAttackStealth.TabIndex = 3;
            this.btnAttackStealth.Text = "Attack";
            this.btnAttackStealth.UseVisualStyleBackColor = true;
            this.btnAttackStealth.Click += new System.EventHandler(this.btnAttackStealth_Click);
            // 
            // btnCastStealth
            // 
            this.btnCastStealth.Location = new System.Drawing.Point(86, 80);
            this.btnCastStealth.Name = "btnCastStealth";
            this.btnCastStealth.Size = new System.Drawing.Size(182, 45);
            this.btnCastStealth.TabIndex = 2;
            this.btnCastStealth.Text = "Cast Spell";
            this.btnCastStealth.UseVisualStyleBackColor = true;
            this.btnCastStealth.Click += new System.EventHandler(this.btnCastStealth_Click);
            // 
            // btnAttackNecromancer
            // 
            this.btnAttackNecromancer.Location = new System.Drawing.Point(86, 132);
            this.btnAttackNecromancer.Name = "btnAttackNecromancer";
            this.btnAttackNecromancer.Size = new System.Drawing.Size(182, 50);
            this.btnAttackNecromancer.TabIndex = 3;
            this.btnAttackNecromancer.Text = "Attack";
            this.btnAttackNecromancer.UseVisualStyleBackColor = true;
            this.btnAttackNecromancer.Click += new System.EventHandler(this.btnAttackNecromancer_Click);
            // 
            // btnCastNecromancer
            // 
            this.btnCastNecromancer.Location = new System.Drawing.Point(86, 80);
            this.btnCastNecromancer.Name = "btnCastNecromancer";
            this.btnCastNecromancer.Size = new System.Drawing.Size(182, 45);
            this.btnCastNecromancer.TabIndex = 2;
            this.btnCastNecromancer.Text = "Cast Spell";
            this.btnCastNecromancer.UseVisualStyleBackColor = true;
            this.btnCastNecromancer.Click += new System.EventHandler(this.btnCastNecromancer_Click);
            // 
            // btnAttackPriest
            // 
            this.btnAttackPriest.Location = new System.Drawing.Point(86, 132);
            this.btnAttackPriest.Name = "btnAttackPriest";
            this.btnAttackPriest.Size = new System.Drawing.Size(182, 50);
            this.btnAttackPriest.TabIndex = 3;
            this.btnAttackPriest.Text = "Attack";
            this.btnAttackPriest.UseVisualStyleBackColor = true;
            this.btnAttackPriest.Click += new System.EventHandler(this.btnAttackPriest_Click);
            // 
            // btnCastPriest
            // 
            this.btnCastPriest.Location = new System.Drawing.Point(86, 80);
            this.btnCastPriest.Name = "btnCastPriest";
            this.btnCastPriest.Size = new System.Drawing.Size(182, 45);
            this.btnCastPriest.TabIndex = 2;
            this.btnCastPriest.Text = "Cast Spell";
            this.btnCastPriest.UseVisualStyleBackColor = true;
            this.btnCastPriest.Click += new System.EventHandler(this.btnCastPriest_Click);
            // 
            // btnAttackArcher
            // 
            this.btnAttackArcher.Location = new System.Drawing.Point(86, 132);
            this.btnAttackArcher.Name = "btnAttackArcher";
            this.btnAttackArcher.Size = new System.Drawing.Size(182, 50);
            this.btnAttackArcher.TabIndex = 3;
            this.btnAttackArcher.Text = "Attack";
            this.btnAttackArcher.UseVisualStyleBackColor = true;
            this.btnAttackArcher.Click += new System.EventHandler(this.btnAttackArcher_Click);
            // 
            // btnCastArcher
            // 
            this.btnCastArcher.Location = new System.Drawing.Point(86, 80);
            this.btnCastArcher.Name = "btnCastArcher";
            this.btnCastArcher.Size = new System.Drawing.Size(182, 45);
            this.btnCastArcher.TabIndex = 2;
            this.btnCastArcher.Text = "Cast Spell";
            this.btnCastArcher.UseVisualStyleBackColor = true;
            this.btnCastArcher.Click += new System.EventHandler(this.btnCastArcher_Click);
            // 
            // btnAttackDamageDealer
            // 
            this.btnAttackDamageDealer.Location = new System.Drawing.Point(86, 132);
            this.btnAttackDamageDealer.Name = "btnAttackDamageDealer";
            this.btnAttackDamageDealer.Size = new System.Drawing.Size(182, 50);
            this.btnAttackDamageDealer.TabIndex = 3;
            this.btnAttackDamageDealer.Text = "Attack";
            this.btnAttackDamageDealer.UseVisualStyleBackColor = true;
            this.btnAttackDamageDealer.Click += new System.EventHandler(this.btnAttackDamageDealer_Click);
            // 
            // btnCastDamageDealer
            // 
            this.btnCastDamageDealer.Location = new System.Drawing.Point(86, 80);
            this.btnCastDamageDealer.Name = "btnCastDamageDealer";
            this.btnCastDamageDealer.Size = new System.Drawing.Size(182, 45);
            this.btnCastDamageDealer.TabIndex = 2;
            this.btnCastDamageDealer.Text = "Cast Spell";
            this.btnCastDamageDealer.UseVisualStyleBackColor = true;
            this.btnCastDamageDealer.Click += new System.EventHandler(this.btnCastDamageDealer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 588);
            this.Controls.Add(this.gbxPriest);
            this.Controls.Add(this.gbxArcher);
            this.Controls.Add(this.gbxDamageDealer);
            this.Controls.Add(this.gbxNecromancer);
            this.Controls.Add(this.gbxStealth);
            this.Controls.Add(this.gbxTank);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTank.ResumeLayout(false);
            this.gbxStealth.ResumeLayout(false);
            this.gbxNecromancer.ResumeLayout(false);
            this.gbxDamageDealer.ResumeLayout(false);
            this.gbxArcher.ResumeLayout(false);
            this.gbxPriest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTank;
        private System.Windows.Forms.GroupBox gbxStealth;
        private System.Windows.Forms.GroupBox gbxNecromancer;
        private System.Windows.Forms.GroupBox gbxDamageDealer;
        private System.Windows.Forms.GroupBox gbxArcher;
        private System.Windows.Forms.GroupBox gbxPriest;
        private System.Windows.Forms.Button btnAttackTank;
        private System.Windows.Forms.Button btnCastTank;
        private System.Windows.Forms.Button btnAttackStealth;
        private System.Windows.Forms.Button btnCastStealth;
        private System.Windows.Forms.Button btnAttackNecromancer;
        private System.Windows.Forms.Button btnCastNecromancer;
        private System.Windows.Forms.Button btnAttackDamageDealer;
        private System.Windows.Forms.Button btnCastDamageDealer;
        private System.Windows.Forms.Button btnAttackArcher;
        private System.Windows.Forms.Button btnCastArcher;
        private System.Windows.Forms.Button btnAttackPriest;
        private System.Windows.Forms.Button btnCastPriest;
    }
}

