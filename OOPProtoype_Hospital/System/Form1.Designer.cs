namespace OOPProtoype_Hospital
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPatientName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxSelectPatient = new System.Windows.Forms.ComboBox();
            this.cbxSelectDoctor = new System.Windows.Forms.ComboBox();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.lbxPatients = new System.Windows.Forms.ListBox();
            this.lbxAppointments = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tbxPatientName
            // 
            this.tbxPatientName.Location = new System.Drawing.Point(153, 28);
            this.tbxPatientName.Name = "tbxPatientName";
            this.tbxPatientName.Size = new System.Drawing.Size(204, 22);
            this.tbxPatientName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxPatients);
            this.groupBox1.Controls.Add(this.btnAddPatient);
            this.groupBox1.Controls.Add(this.tbxPatientName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 547);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a Patient";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxAppointments);
            this.groupBox2.Controls.Add(this.btnAddAppointment);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpAppointmentDate);
            this.groupBox2.Controls.Add(this.cbxSelectDoctor);
            this.groupBox2.Controls.Add(this.cbxSelectPatient);
            this.groupBox2.Location = new System.Drawing.Point(469, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 547);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Appointment";
            // 
            // cbxSelectPatient
            // 
            this.cbxSelectPatient.FormattingEnabled = true;
            this.cbxSelectPatient.Location = new System.Drawing.Point(129, 30);
            this.cbxSelectPatient.Name = "cbxSelectPatient";
            this.cbxSelectPatient.Size = new System.Drawing.Size(263, 24);
            this.cbxSelectPatient.TabIndex = 0;
            // 
            // cbxSelectDoctor
            // 
            this.cbxSelectDoctor.FormattingEnabled = true;
            this.cbxSelectDoctor.Location = new System.Drawing.Point(129, 75);
            this.cbxSelectDoctor.Name = "cbxSelectDoctor";
            this.cbxSelectDoctor.Size = new System.Drawing.Size(263, 24);
            this.cbxSelectDoctor.TabIndex = 1;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(129, 118);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(263, 22);
            this.dtpAppointmentDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(194, 67);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(122, 51);
            this.btnAddPatient.TabIndex = 2;
            this.btnAddPatient.Text = "Add";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(187, 157);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(144, 52);
            this.btnAddAppointment.TabIndex = 6;
            this.btnAddAppointment.Text = "Add";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // lbxPatients
            // 
            this.lbxPatients.FormattingEnabled = true;
            this.lbxPatients.ItemHeight = 16;
            this.lbxPatients.Location = new System.Drawing.Point(26, 157);
            this.lbxPatients.Name = "lbxPatients";
            this.lbxPatients.Size = new System.Drawing.Size(391, 356);
            this.lbxPatients.TabIndex = 3;
            // 
            // lbxAppointments
            // 
            this.lbxAppointments.FormattingEnabled = true;
            this.lbxAppointments.ItemHeight = 16;
            this.lbxAppointments.Location = new System.Drawing.Point(64, 223);
            this.lbxAppointments.Name = "lbxAppointments";
            this.lbxAppointments.Size = new System.Drawing.Size(391, 308);
            this.lbxAppointments.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPatientName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxSelectPatient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.ComboBox cbxSelectDoctor;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.ListBox lbxPatients;
        private System.Windows.Forms.ListBox lbxAppointments;
    }
}

