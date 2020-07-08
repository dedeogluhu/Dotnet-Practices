namespace OOPPrototype_Fps
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
            this.btnPistol = new System.Windows.Forms.Button();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.btnMachineGun = new System.Windows.Forms.Button();
            this.btnSniper = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.cbxWeapon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSoldier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPistol
            // 
            this.btnPistol.Location = new System.Drawing.Point(12, 12);
            this.btnPistol.Name = "btnPistol";
            this.btnPistol.Size = new System.Drawing.Size(136, 44);
            this.btnPistol.TabIndex = 0;
            this.btnPistol.Text = "Equip Pistol";
            this.btnPistol.UseVisualStyleBackColor = true;
            this.btnPistol.Click += new System.EventHandler(this.btnPistol_Click);
            // 
            // btnShotgun
            // 
            this.btnShotgun.Location = new System.Drawing.Point(12, 62);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(136, 44);
            this.btnShotgun.TabIndex = 1;
            this.btnShotgun.Text = "Equip Shotgun";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            // 
            // btnMachineGun
            // 
            this.btnMachineGun.Location = new System.Drawing.Point(12, 112);
            this.btnMachineGun.Name = "btnMachineGun";
            this.btnMachineGun.Size = new System.Drawing.Size(136, 44);
            this.btnMachineGun.TabIndex = 2;
            this.btnMachineGun.Text = "Equip Machine Gun";
            this.btnMachineGun.UseVisualStyleBackColor = true;
            this.btnMachineGun.Click += new System.EventHandler(this.btnMachineGun_Click);
            // 
            // btnSniper
            // 
            this.btnSniper.Location = new System.Drawing.Point(12, 162);
            this.btnSniper.Name = "btnSniper";
            this.btnSniper.Size = new System.Drawing.Size(136, 44);
            this.btnSniper.TabIndex = 3;
            this.btnSniper.Text = "Equip Sniper";
            this.btnSniper.UseVisualStyleBackColor = true;
            this.btnSniper.Click += new System.EventHandler(this.btnSniper_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(247, 62);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(175, 94);
            this.btnShoot.TabIndex = 4;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddSoldier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxWeapon);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(449, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 326);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a Soldier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(119, 45);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(228, 22);
            this.tbxName.TabIndex = 1;
            // 
            // cbxWeapon
            // 
            this.cbxWeapon.FormattingEnabled = true;
            this.cbxWeapon.Location = new System.Drawing.Point(119, 161);
            this.cbxWeapon.Name = "cbxWeapon";
            this.cbxWeapon.Size = new System.Drawing.Size(228, 24);
            this.cbxWeapon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weapon:";
            // 
            // btnAddSoldier
            // 
            this.btnAddSoldier.Location = new System.Drawing.Point(157, 223);
            this.btnAddSoldier.Name = "btnAddSoldier";
            this.btnAddSoldier.Size = new System.Drawing.Size(136, 44);
            this.btnAddSoldier.TabIndex = 4;
            this.btnAddSoldier.Text = "Add";
            this.btnAddSoldier.UseVisualStyleBackColor = true;
            this.btnAddSoldier.Click += new System.EventHandler(this.btnAddSoldier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.btnSniper);
            this.Controls.Add(this.btnMachineGun);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.btnPistol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPistol;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.Button btnMachineGun;
        private System.Windows.Forms.Button btnSniper;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddSoldier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxWeapon;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
    }
}

