
namespace ProjectRunwayLR
{
    partial class frmLogIn
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
            this.pnlGB = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ckbShow_Hide = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlGB.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 120);
            this.label1.TabIndex = 20;
            this.label1.Text = "Please Sign In";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlGB
            // 
            this.pnlGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGB.BackgroundImage = global::ProjectRunwayLR.Properties.Resources.goldd1;
            this.pnlGB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGB.Controls.Add(this.panel1);
            this.pnlGB.Controls.Add(this.label1);
            this.pnlGB.Location = new System.Drawing.Point(26, 36);
            this.pnlGB.Name = "pnlGB";
            this.pnlGB.Size = new System.Drawing.Size(581, 610);
            this.pnlGB.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.ckbShow_Hide);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Location = new System.Drawing.Point(46, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 314);
            this.panel1.TabIndex = 19;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(155, 248);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(166, 59);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // ckbShow_Hide
            // 
            this.ckbShow_Hide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbShow_Hide.AutoSize = true;
            this.ckbShow_Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ckbShow_Hide.Location = new System.Drawing.Point(185, 205);
            this.ckbShow_Hide.Name = "ckbShow_Hide";
            this.ckbShow_Hide.Size = new System.Drawing.Size(102, 17);
            this.ckbShow_Hide.TabIndex = 19;
            this.ckbShow_Hide.Text = "Show Password";
            this.ckbShow_Hide.UseVisualStyleBackColor = true;
            this.ckbShow_Hide.CheckedChanged += new System.EventHandler(this.ckbShow_Hide_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(180, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(62, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(365, 26);
            this.txtUsername.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(180, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(62, 152);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(365, 26);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 669);
            this.Controls.Add(this.pnlGB);
            this.DoubleBuffered = true;
            this.Name = "frmLogIn";
            this.Opacity = 0.6D;
            this.Text = "frmLogIn";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.pnlGB.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlGB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox ckbShow_Hide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
    }
}