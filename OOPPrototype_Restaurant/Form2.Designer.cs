namespace OOPPrototype_Restaurant
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gbxAddWorker = new System.Windows.Forms.GroupBox();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.tbxWorkerWage = new System.Windows.Forms.TextBox();
            this.tbxWorkerAge = new System.Windows.Forms.TextBox();
            this.tbxWorkerName = new System.Windows.Forms.TextBox();
            this.lblWorkerWage = new System.Windows.Forms.Label();
            this.lblWorkerAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxAddWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAddWorker
            // 
            this.gbxAddWorker.Controls.Add(this.btnAddWorker);
            this.gbxAddWorker.Controls.Add(this.tbxWorkerWage);
            this.gbxAddWorker.Controls.Add(this.tbxWorkerAge);
            this.gbxAddWorker.Controls.Add(this.tbxWorkerName);
            this.gbxAddWorker.Controls.Add(this.lblWorkerWage);
            this.gbxAddWorker.Controls.Add(this.lblWorkerAge);
            this.gbxAddWorker.Controls.Add(this.lblName);
            this.gbxAddWorker.Location = new System.Drawing.Point(13, 13);
            this.gbxAddWorker.Name = "gbxAddWorker";
            this.gbxAddWorker.Size = new System.Drawing.Size(375, 457);
            this.gbxAddWorker.TabIndex = 0;
            this.gbxAddWorker.TabStop = false;
            this.gbxAddWorker.Text = "Add a Worker";
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(89, 366);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(201, 42);
            this.btnAddWorker.TabIndex = 6;
            this.btnAddWorker.Text = "Add";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // tbxWorkerWage
            // 
            this.tbxWorkerWage.Location = new System.Drawing.Point(89, 313);
            this.tbxWorkerWage.Name = "tbxWorkerWage";
            this.tbxWorkerWage.Size = new System.Drawing.Size(201, 22);
            this.tbxWorkerWage.TabIndex = 5;
            // 
            // tbxWorkerAge
            // 
            this.tbxWorkerAge.Location = new System.Drawing.Point(89, 202);
            this.tbxWorkerAge.Name = "tbxWorkerAge";
            this.tbxWorkerAge.Size = new System.Drawing.Size(201, 22);
            this.tbxWorkerAge.TabIndex = 4;
            // 
            // tbxWorkerName
            // 
            this.tbxWorkerName.Location = new System.Drawing.Point(89, 91);
            this.tbxWorkerName.Name = "tbxWorkerName";
            this.tbxWorkerName.Size = new System.Drawing.Size(201, 22);
            this.tbxWorkerName.TabIndex = 3;
            // 
            // lblWorkerWage
            // 
            this.lblWorkerWage.AutoSize = true;
            this.lblWorkerWage.Location = new System.Drawing.Point(89, 260);
            this.lblWorkerWage.Name = "lblWorkerWage";
            this.lblWorkerWage.Size = new System.Drawing.Size(49, 17);
            this.lblWorkerWage.TabIndex = 2;
            this.lblWorkerWage.Text = "Wage:";
            // 
            // lblWorkerAge
            // 
            this.lblWorkerAge.AutoSize = true;
            this.lblWorkerAge.Location = new System.Drawing.Point(89, 149);
            this.lblWorkerAge.Name = "lblWorkerAge";
            this.lblWorkerAge.Size = new System.Drawing.Size(37, 17);
            this.lblWorkerAge.TabIndex = 1;
            this.lblWorkerAge.Text = "Age:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(89, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 482);
            this.ControlBox = false;
            this.Controls.Add(this.gbxAddWorker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.gbxAddWorker.ResumeLayout(false);
            this.gbxAddWorker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAddWorker;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.TextBox tbxWorkerWage;
        private System.Windows.Forms.TextBox tbxWorkerAge;
        private System.Windows.Forms.TextBox tbxWorkerName;
        private System.Windows.Forms.Label lblWorkerWage;
        private System.Windows.Forms.Label lblWorkerAge;
        private System.Windows.Forms.Label lblName;
    }
}