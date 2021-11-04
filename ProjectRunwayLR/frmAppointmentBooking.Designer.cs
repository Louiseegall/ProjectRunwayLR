
namespace ProjectRunwayLR
{
    partial class frmAppointmentBooking
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
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.lvwBooking = new System.Windows.Forms.ListView();
            this.colStaffNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTreatmentCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlKennel = new System.Windows.Forms.Panel();
            this.cmbKennelNo = new System.Windows.Forms.ComboBox();
            this.lblKennelNo = new System.Windows.Forms.Label();
            this.pnlDog = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDog = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbNoDays = new System.Windows.Forms.ComboBox();
            this.lblNoDays = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblBookingDatee = new System.Windows.Forms.Label();
            this.lblCust3 = new System.Windows.Forms.Label();
            this.lblCust2 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBooking.SuspendLayout();
            this.pnlKennel.SuspendLayout();
            this.pnlDog.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBooking
            // 
            this.pnlBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBooking.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlBooking.Controls.Add(this.lvwBooking);
            this.pnlBooking.Location = new System.Drawing.Point(393, 240);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(318, 185);
            this.pnlBooking.TabIndex = 40;
            // 
            // lvwBooking
            // 
            this.lvwBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwBooking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStaffNo,
            this.colStaffName,
            this.colRoomNo,
            this.colTreatmentCode});
            this.lvwBooking.HideSelection = false;
            this.lvwBooking.Location = new System.Drawing.Point(0, 0);
            this.lvwBooking.Name = "lvwBooking";
            this.lvwBooking.Size = new System.Drawing.Size(318, 185);
            this.lvwBooking.TabIndex = 7;
            this.lvwBooking.UseCompatibleStateImageBehavior = false;
            this.lvwBooking.View = System.Windows.Forms.View.Details;
            this.lvwBooking.SelectedIndexChanged += new System.EventHandler(this.lvwBooking_SelectedIndexChanged);
            // 
            // colStaffNo
            // 
            this.colStaffNo.DisplayIndex = 1;
            this.colStaffNo.Text = "Staff  No";
            this.colStaffNo.Width = 79;
            // 
            // colStaffName
            // 
            this.colStaffName.DisplayIndex = 2;
            this.colStaffName.Text = "Staff Name";
            this.colStaffName.Width = 80;
            // 
            // colRoomNo
            // 
            this.colRoomNo.DisplayIndex = 3;
            this.colRoomNo.Text = "Room No";
            // 
            // colTreatmentCode
            // 
            this.colTreatmentCode.DisplayIndex = 0;
            this.colTreatmentCode.Text = "Treatment";
            this.colTreatmentCode.Width = 91;
            // 
            // pnlKennel
            // 
            this.pnlKennel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKennel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlKennel.Controls.Add(this.cmbKennelNo);
            this.pnlKennel.Controls.Add(this.lblKennelNo);
            this.pnlKennel.Location = new System.Drawing.Point(12, 351);
            this.pnlKennel.Name = "pnlKennel";
            this.pnlKennel.Size = new System.Drawing.Size(333, 69);
            this.pnlKennel.TabIndex = 39;
            // 
            // cmbKennelNo
            // 
            this.cmbKennelNo.FormattingEnabled = true;
            this.cmbKennelNo.Location = new System.Drawing.Point(138, 27);
            this.cmbKennelNo.Name = "cmbKennelNo";
            this.cmbKennelNo.Size = new System.Drawing.Size(195, 21);
            this.cmbKennelNo.TabIndex = 9;
            // 
            // lblKennelNo
            // 
            this.lblKennelNo.AutoSize = true;
            this.lblKennelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKennelNo.Location = new System.Drawing.Point(15, 27);
            this.lblKennelNo.Name = "lblKennelNo";
            this.lblKennelNo.Size = new System.Drawing.Size(76, 20);
            this.lblKennelNo.TabIndex = 0;
            this.lblKennelNo.Text = "Room No";
            // 
            // pnlDog
            // 
            this.pnlDog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDog.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlDog.Controls.Add(this.label2);
            this.pnlDog.Controls.Add(this.label1);
            this.pnlDog.Controls.Add(this.cmbDog);
            this.pnlDog.Controls.Add(this.label15);
            this.pnlDog.Location = new System.Drawing.Point(393, 22);
            this.pnlDog.Name = "pnlDog";
            this.pnlDog.Size = new System.Drawing.Size(318, 109);
            this.pnlDog.TabIndex = 38;
            this.pnlDog.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDog_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "-";
            // 
            // cmbDog
            // 
            this.cmbDog.FormattingEnabled = true;
            this.cmbDog.Location = new System.Drawing.Point(104, 13);
            this.cmbDog.Name = "cmbDog";
            this.cmbDog.Size = new System.Drawing.Size(214, 21);
            this.cmbDog.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Staff No";
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlCustomer.Controls.Add(this.label5);
            this.pnlCustomer.Controls.Add(this.label4);
            this.pnlCustomer.Controls.Add(this.dateTimePicker1);
            this.pnlCustomer.Controls.Add(this.dtpStartDate);
            this.pnlCustomer.Controls.Add(this.cmbNoDays);
            this.pnlCustomer.Controls.Add(this.lblNoDays);
            this.pnlCustomer.Controls.Add(this.lblStartDate);
            this.pnlCustomer.Controls.Add(this.lblBookingDatee);
            this.pnlCustomer.Controls.Add(this.lblCust3);
            this.pnlCustomer.Controls.Add(this.lblCust2);
            this.pnlCustomer.Controls.Add(this.cmbCustomer);
            this.pnlCustomer.Controls.Add(this.lblCustomerName);
            this.pnlCustomer.Location = new System.Drawing.Point(12, 22);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(333, 323);
            this.pnlCustomer.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "-";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(138, 173);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(195, 20);
            this.dtpStartDate.TabIndex = 11;
            // 
            // cmbNoDays
            // 
            this.cmbNoDays.FormattingEnabled = true;
            this.cmbNoDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNoDays.Location = new System.Drawing.Point(138, 213);
            this.cmbNoDays.Name = "cmbNoDays";
            this.cmbNoDays.Size = new System.Drawing.Size(195, 21);
            this.cmbNoDays.TabIndex = 9;
            // 
            // lblNoDays
            // 
            this.lblNoDays.AutoSize = true;
            this.lblNoDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDays.Location = new System.Drawing.Point(15, 210);
            this.lblNoDays.Name = "lblNoDays";
            this.lblNoDays.Size = new System.Drawing.Size(124, 20);
            this.lblNoDays.TabIndex = 8;
            this.lblNoDays.Text = "Treatment Code";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(15, 173);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(105, 20);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "Booking Time";
            // 
            // lblBookingDatee
            // 
            this.lblBookingDatee.AutoSize = true;
            this.lblBookingDatee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDatee.Location = new System.Drawing.Point(15, 135);
            this.lblBookingDatee.Name = "lblBookingDatee";
            this.lblBookingDatee.Size = new System.Drawing.Size(114, 20);
            this.lblBookingDatee.TabIndex = 6;
            this.lblBookingDatee.Text = "Booking Date: ";
            // 
            // lblCust3
            // 
            this.lblCust3.AutoSize = true;
            this.lblCust3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust3.Location = new System.Drawing.Point(25, 78);
            this.lblCust3.Name = "lblCust3";
            this.lblCust3.Size = new System.Drawing.Size(14, 20);
            this.lblCust3.TabIndex = 4;
            this.lblCust3.Text = "-";
            // 
            // lblCust2
            // 
            this.lblCust2.AutoSize = true;
            this.lblCust2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust2.Location = new System.Drawing.Point(25, 40);
            this.lblCust2.Name = "lblCust2";
            this.lblCust2.Size = new System.Drawing.Size(14, 20);
            this.lblCust2.TabIndex = 2;
            this.lblCust2.Text = "-";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(138, 15);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(195, 21);
            this.cmbCustomer.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(15, 13);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(124, 20);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(561, 431);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 50);
            this.button6.TabIndex = 108;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 50);
            this.button1.TabIndex = 109;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(208, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 50);
            this.button2.TabIndex = 110;
            this.button2.Text = "Remove Item";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(393, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 87);
            this.panel1.TabIndex = 111;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Payment No";
            // 
            // frmAppointmentBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pnlBooking);
            this.Controls.Add(this.pnlKennel);
            this.Controls.Add(this.pnlDog);
            this.Controls.Add(this.pnlCustomer);
            this.Name = "frmAppointmentBooking";
            this.Text = "frmAppointmentBooking";
            this.pnlBooking.ResumeLayout(false);
            this.pnlKennel.ResumeLayout(false);
            this.pnlKennel.PerformLayout();
            this.pnlDog.ResumeLayout(false);
            this.pnlDog.PerformLayout();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBooking;
        private System.Windows.Forms.ListView lvwBooking;
        private System.Windows.Forms.ColumnHeader colStaffNo;
        private System.Windows.Forms.Panel pnlKennel;
        private System.Windows.Forms.ComboBox cmbKennelNo;
        private System.Windows.Forms.Label lblKennelNo;
        private System.Windows.Forms.Panel pnlDog;
        private System.Windows.Forms.ComboBox cmbDog;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cmbNoDays;
        private System.Windows.Forms.Label lblNoDays;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblBookingDatee;
        private System.Windows.Forms.Label lblCust3;
        private System.Windows.Forms.Label lblCust2;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ColumnHeader colStaffName;
        private System.Windows.Forms.ColumnHeader colRoomNo;
        private System.Windows.Forms.ColumnHeader colTreatmentCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}