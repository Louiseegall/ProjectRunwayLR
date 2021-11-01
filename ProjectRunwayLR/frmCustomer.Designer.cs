
namespace ProjectRunwayLR
{
    partial class frmCustomer
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
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabCustomer = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDisplayExit = new System.Windows.Forms.Button();
            this.btnDisplayEdit = new System.Windows.Forms.Button();
            this.btnDisplayAdd = new System.Windows.Forms.Button();
            this.btnDisplayDelete = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.tabCustomer.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.tabDisplay);
            this.tabCustomer.Controls.Add(this.tabAdd);
            this.tabCustomer.Controls.Add(this.tabEdit);
            this.tabCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCustomer.Location = new System.Drawing.Point(0, 0);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.SelectedIndex = 0;
            this.tabCustomer.Size = new System.Drawing.Size(634, 521);
            this.tabCustomer.TabIndex = 3;
            this.tabCustomer.SelectedIndexChanged += new System.EventHandler(this.tabCustomer_SelectedIndexChanged);
            // 
            // tabDisplay
            // 
            this.tabDisplay.BackColor = System.Drawing.Color.Transparent;
            this.tabDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDisplay.Controls.Add(this.dgvCustomers);
            this.tabDisplay.Controls.Add(this.btnDisplayDelete);
            this.tabDisplay.Controls.Add(this.btnDisplayEdit);
            this.tabDisplay.Controls.Add(this.btnDisplayExit);
            this.tabDisplay.Controls.Add(this.btnDisplayAdd);
            this.tabDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDisplay.Location = new System.Drawing.Point(4, 29);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(626, 548);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.Text = "Display";
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.Transparent;
            this.tabEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabEdit.Controls.Add(this.button1);
            this.tabEdit.Controls.Add(this.button6);
            this.tabEdit.Controls.Add(this.textBox10);
            this.tabEdit.Controls.Add(this.label15);
            this.tabEdit.Controls.Add(this.dateTimePicker1);
            this.tabEdit.Controls.Add(this.textBox9);
            this.tabEdit.Controls.Add(this.textBox8);
            this.tabEdit.Controls.Add(this.textBox7);
            this.tabEdit.Controls.Add(this.textBox6);
            this.tabEdit.Controls.Add(this.textBox5);
            this.tabEdit.Controls.Add(this.textBox4);
            this.tabEdit.Controls.Add(this.textBox3);
            this.tabEdit.Controls.Add(this.textBox2);
            this.tabEdit.Controls.Add(this.textBox1);
            this.tabEdit.Controls.Add(this.comboBox1);
            this.tabEdit.Controls.Add(this.label14);
            this.tabEdit.Controls.Add(this.label13);
            this.tabEdit.Controls.Add(this.label12);
            this.tabEdit.Controls.Add(this.label11);
            this.tabEdit.Controls.Add(this.label10);
            this.tabEdit.Controls.Add(this.label9);
            this.tabEdit.Controls.Add(this.label8);
            this.tabEdit.Controls.Add(this.label7);
            this.tabEdit.Controls.Add(this.label6);
            this.tabEdit.Controls.Add(this.label5);
            this.tabEdit.Controls.Add(this.label1);
            this.tabEdit.Controls.Add(this.label16);
            this.tabEdit.Controls.Add(this.label17);
            this.tabEdit.Controls.Add(this.label18);
            this.tabEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEdit.Location = new System.Drawing.Point(4, 29);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(626, 548);
            this.tabEdit.TabIndex = 2;
            this.tabEdit.Text = "Edit";
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.Location = new System.Drawing.Point(113, 440);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(417, 24);
            this.textBox10.TabIndex = 74;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(212, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 24);
            this.label15.TabIndex = 73;
            this.label15.Text = "-";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(417, 24);
            this.dateTimePicker1.TabIndex = 72;
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.Location = new System.Drawing.Point(113, 403);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(417, 24);
            this.textBox9.TabIndex = 71;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Location = new System.Drawing.Point(113, 367);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(417, 24);
            this.textBox8.TabIndex = 70;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(113, 332);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(417, 24);
            this.textBox7.TabIndex = 69;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(113, 295);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(417, 24);
            this.textBox6.TabIndex = 68;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(113, 260);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(417, 24);
            this.textBox5.TabIndex = 67;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(113, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(417, 24);
            this.textBox4.TabIndex = 66;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(113, 190);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(417, 24);
            this.textBox3.TabIndex = 65;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(113, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(417, 24);
            this.textBox2.TabIndex = 64;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(113, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 24);
            this.textBox1.TabIndex = 63;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(417, 26);
            this.comboBox1.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(57, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 24);
            this.label14.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 440);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 24);
            this.label13.TabIndex = 60;
            this.label13.Text = "Discount ";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 24);
            this.label12.TabIndex = 59;
            this.label12.Text = "DOB";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 24);
            this.label11.TabIndex = 58;
            this.label11.Text = "Tel No";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 24);
            this.label10.TabIndex = 57;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 24);
            this.label9.TabIndex = 56;
            this.label9.Text = "Postcode";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 55;
            this.label8.Text = "Country";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 54;
            this.label7.Text = "County";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 53;
            this.label6.Text = "Town";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "Street";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Surname";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 24);
            this.label16.TabIndex = 50;
            this.label16.Text = "Forename";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 24);
            this.label17.TabIndex = 49;
            this.label17.Text = "Title";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 24);
            this.label18.TabIndex = 48;
            this.label18.Text = "Customer No";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(113, 490);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 50);
            this.button6.TabIndex = 81;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(370, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 82;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.Transparent;
            this.tabAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAdd.Controls.Add(this.numericUpDown1);
            this.tabAdd.Controls.Add(this.button3);
            this.tabAdd.Controls.Add(this.button2);
            this.tabAdd.Controls.Add(this.label2);
            this.tabAdd.Controls.Add(this.dateTimePicker2);
            this.tabAdd.Controls.Add(this.textBox12);
            this.tabAdd.Controls.Add(this.textBox13);
            this.tabAdd.Controls.Add(this.textBox14);
            this.tabAdd.Controls.Add(this.textBox15);
            this.tabAdd.Controls.Add(this.textBox16);
            this.tabAdd.Controls.Add(this.textBox17);
            this.tabAdd.Controls.Add(this.textBox18);
            this.tabAdd.Controls.Add(this.textBox19);
            this.tabAdd.Controls.Add(this.textBox20);
            this.tabAdd.Controls.Add(this.comboBox2);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.label4);
            this.tabAdd.Controls.Add(this.label19);
            this.tabAdd.Controls.Add(this.label20);
            this.tabAdd.Controls.Add(this.label21);
            this.tabAdd.Controls.Add(this.label22);
            this.tabAdd.Controls.Add(this.label23);
            this.tabAdd.Controls.Add(this.label24);
            this.tabAdd.Controls.Add(this.label25);
            this.tabAdd.Controls.Add(this.label26);
            this.tabAdd.Controls.Add(this.label27);
            this.tabAdd.Controls.Add(this.label28);
            this.tabAdd.Controls.Add(this.label29);
            this.tabAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdd.Location = new System.Drawing.Point(4, 29);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(626, 488);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 99;
            this.label2.Text = "-";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(422, 38);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(162, 24);
            this.dateTimePicker2.TabIndex = 98;
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox12.Location = new System.Drawing.Point(111, 355);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(473, 24);
            this.textBox12.TabIndex = 97;
            // 
            // textBox13
            // 
            this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox13.Location = new System.Drawing.Point(111, 311);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(473, 24);
            this.textBox13.TabIndex = 96;
            // 
            // textBox14
            // 
            this.textBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox14.Location = new System.Drawing.Point(111, 269);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(473, 24);
            this.textBox14.TabIndex = 95;
            // 
            // textBox15
            // 
            this.textBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox15.Location = new System.Drawing.Point(390, 223);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(194, 24);
            this.textBox15.TabIndex = 94;
            // 
            // textBox16
            // 
            this.textBox16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox16.Location = new System.Drawing.Point(111, 222);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(184, 24);
            this.textBox16.TabIndex = 93;
            // 
            // textBox17
            // 
            this.textBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox17.Location = new System.Drawing.Point(111, 183);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(473, 24);
            this.textBox17.TabIndex = 92;
            // 
            // textBox18
            // 
            this.textBox18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox18.Location = new System.Drawing.Point(111, 146);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(473, 24);
            this.textBox18.TabIndex = 91;
            // 
            // textBox19
            // 
            this.textBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox19.Location = new System.Drawing.Point(111, 116);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(473, 24);
            this.textBox19.TabIndex = 90;
            // 
            // textBox20
            // 
            this.textBox20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox20.Location = new System.Drawing.Point(111, 77);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(473, 24);
            this.textBox20.TabIndex = 89;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(111, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 26);
            this.comboBox2.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 87;
            this.label3.Text = "Discount ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 86;
            this.label4.Text = "DOB";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(13, 310);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 24);
            this.label19.TabIndex = 85;
            this.label19.Text = "Tel No";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(13, 354);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 24);
            this.label20.TabIndex = 84;
            this.label20.Text = "Email";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(11, 268);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 24);
            this.label21.TabIndex = 83;
            this.label21.Text = "Postcode";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(309, 222);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 24);
            this.label22.TabIndex = 82;
            this.label22.Text = "Country";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(11, 221);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 24);
            this.label23.TabIndex = 81;
            this.label23.Text = "County";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(11, 182);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 24);
            this.label24.TabIndex = 80;
            this.label24.Text = "Town";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(11, 145);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 24);
            this.label25.TabIndex = 79;
            this.label25.Text = "Street";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(10, 112);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 24);
            this.label26.TabIndex = 78;
            this.label26.Text = "Surname";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(10, 77);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(98, 24);
            this.label27.TabIndex = 77;
            this.label27.Text = "Forename";
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(10, 40);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 24);
            this.label28.TabIndex = 76;
            this.label28.Text = "Title";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(6, 3);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(121, 24);
            this.label29.TabIndex = 75;
            this.label29.Text = "Customer No";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(111, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 102;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(300, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 103;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnDisplayExit
            // 
            this.btnDisplayExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayExit.BackColor = System.Drawing.Color.Black;
            this.btnDisplayExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayExit.ForeColor = System.Drawing.Color.White;
            this.btnDisplayExit.Location = new System.Drawing.Point(479, 490);
            this.btnDisplayExit.Name = "btnDisplayExit";
            this.btnDisplayExit.Size = new System.Drawing.Size(139, 50);
            this.btnDisplayExit.TabIndex = 83;
            this.btnDisplayExit.Text = "Exit";
            this.btnDisplayExit.UseVisualStyleBackColor = false;
            // 
            // btnDisplayEdit
            // 
            this.btnDisplayEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDisplayEdit.BackColor = System.Drawing.Color.Black;
            this.btnDisplayEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayEdit.ForeColor = System.Drawing.Color.White;
            this.btnDisplayEdit.Location = new System.Drawing.Point(168, 490);
            this.btnDisplayEdit.Name = "btnDisplayEdit";
            this.btnDisplayEdit.Size = new System.Drawing.Size(133, 50);
            this.btnDisplayEdit.TabIndex = 85;
            this.btnDisplayEdit.Text = "Edit";
            this.btnDisplayEdit.UseVisualStyleBackColor = false;
            // 
            // btnDisplayAdd
            // 
            this.btnDisplayAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDisplayAdd.BackColor = System.Drawing.Color.Black;
            this.btnDisplayAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAdd.ForeColor = System.Drawing.Color.White;
            this.btnDisplayAdd.Location = new System.Drawing.Point(3, 490);
            this.btnDisplayAdd.Name = "btnDisplayAdd";
            this.btnDisplayAdd.Size = new System.Drawing.Size(143, 50);
            this.btnDisplayAdd.TabIndex = 86;
            this.btnDisplayAdd.Text = "Add";
            this.btnDisplayAdd.UseVisualStyleBackColor = false;
            // 
            // btnDisplayDelete
            // 
            this.btnDisplayDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDisplayDelete.BackColor = System.Drawing.Color.Black;
            this.btnDisplayDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayDelete.ForeColor = System.Drawing.Color.White;
            this.btnDisplayDelete.Location = new System.Drawing.Point(325, 490);
            this.btnDisplayDelete.Name = "btnDisplayDelete";
            this.btnDisplayDelete.Size = new System.Drawing.Size(136, 50);
            this.btnDisplayDelete.TabIndex = 84;
            this.btnDisplayDelete.Text = "Delete";
            this.btnDisplayDelete.UseVisualStyleBackColor = false;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(3, 3);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(615, 469);
            this.dgvCustomers.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(111, 397);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 24);
            this.numericUpDown1.TabIndex = 104;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(634, 521);
            this.Controls.Add(this.tabCustomer);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.tabCustomer.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.TabControl tabCustomer;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDisplayExit;
        private System.Windows.Forms.Button btnDisplayEdit;
        private System.Windows.Forms.Button btnDisplayAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnDisplayDelete;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}