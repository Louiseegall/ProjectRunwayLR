
namespace ProjectRunwayLR
{
    partial class frmMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();

            //this.btnPayment = new System.Windows.Forms.Button();
            //this.btnTreatment = new System.Windows.Forms.Button();
            //this.btnRoom = new System.Windows.Forms.Button();

            this.btnBooking = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.btnMenu = new System.Windows.Forms.Button();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.splitContent = new System.Windows.Forms.SplitContainer();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tlpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContent)).BeginInit();
            this.splitContent.Panel1.SuspendLayout();
            this.splitContent.Panel2.SuspendLayout();
            this.splitContent.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Black;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(259, 4);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(217, 60);
            this.btnCustomer.TabIndex = 8;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.Color.LightGray;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(1319, 15);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 29);
            this.txtUsername.TabIndex = 19;
            this.txtUsername.Text = "User ID";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Enabled = false;
            this.pbLogo.Image = global::ProjectRunwayLR.Properties.Resources.run;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";

            //this.pbLogo.Size = new System.Drawing.Size(404, 554);

            this.pbLogo.Size = new System.Drawing.Size(685, 682);

            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 18;
            this.pbLogo.TabStop = false;
            // 
            // btnAppointment
            // 
            this.btnAppointment.BackColor = System.Drawing.Color.Black;
            this.btnAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAppointment.Location = new System.Drawing.Point(4, 4);
            this.btnAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(217, 60);
            this.btnAppointment.TabIndex = 9;
            this.btnAppointment.Text = "Appointment";
            this.btnAppointment.UseVisualStyleBackColor = false;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.Black;
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Location = new System.Drawing.Point(514, 4);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(217, 60);
            this.btnStaff.TabIndex = 10;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Black;
            this.btnBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(769, 4);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(217, 60);
            this.btnBooking.TabIndex = 11;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.Black;
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Location = new System.Drawing.Point(1024, 4);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(217, 60);
            this.btnSchedule.TabIndex = 12;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(809, 682);
            this.dataGridView1.TabIndex = 15;
            // 
            // menuTimer
            // 
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(16, 2);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 68);
            this.btnMenu.TabIndex = 21;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.Controls.Add(this.dataGridView1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(809, 682);
            this.pnlContent.TabIndex = 24;
            // 
            // tlpMenu
            // 
            this.tlpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMenu.BackColor = System.Drawing.Color.Transparent;
            this.tlpMenu.ColumnCount = 11;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMenu.Controls.Add(this.btnStaff, 4, 0);
            this.tlpMenu.Controls.Add(this.btnSchedule, 8, 0);
            this.tlpMenu.Controls.Add(this.btnBooking, 6, 0);
            this.tlpMenu.Controls.Add(this.btnCustomer, 2, 0);
            this.tlpMenu.Controls.Add(this.btnAppointment, 0, 0);
            this.tlpMenu.Location = new System.Drawing.Point(16, 91);
            this.tlpMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(1503, 68);
            this.tlpMenu.TabIndex = 25;
            // 
            // splitContent
            // 
            this.splitContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContent.BackColor = System.Drawing.Color.Transparent;
            this.splitContent.Location = new System.Drawing.Point(20, 166);
            this.splitContent.Margin = new System.Windows.Forms.Padding(4);
            this.splitContent.Name = "splitContent";
            // 
            // splitContent.Panel1
            // 
            this.splitContent.Panel1.Controls.Add(this.pbLogo);
            // 
            // splitContent.Panel2
            // 
            this.splitContent.Panel2.Controls.Add(this.pnlContent);

            //this.splitContent.Size = new System.Drawing.Size(1124, 554);
            //this.splitContent.SplitterDistance = 404;

            this.splitContent.Size = new System.Drawing.Size(1499, 682);
            this.splitContent.SplitterDistance = 685;
            this.splitContent.SplitterWidth = 5;

            this.splitContent.TabIndex = 19;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(716, 554);
            this.pnlContent.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 554);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 554);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectRunwayLR.Properties.Resources.White_and_Gold;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1560, 863);
            this.Controls.Add(this.splitContent);
            this.Controls.Add(this.tlpMenu);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnMenu);
            this.DoubleBuffered = true;

            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1327, 900);

            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.SizeChanged += new System.EventHandler(this.frmMainMenu_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tlpMenu.ResumeLayout(false);
            this.splitContent.Panel1.ResumeLayout(false);
            this.splitContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContent)).EndInit();
            this.splitContent.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnStaff;

        //private System.Windows.Forms.Button btnPayment;
        //private System.Windows.Forms.Button btnTreatment;
        //private System.Windows.Forms.Button btnRoom;

        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.SplitContainer splitContent;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}