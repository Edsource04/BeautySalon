namespace UI.BeautySalon
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.btnCerrar = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumberDocument = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CboTypeDocument = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCancel_Clean = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel_Searc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFull_Name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CboSex = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCerrar.Location = new System.Drawing.Point(1347, 6);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(223, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(185, 46);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "BUSCAR";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.txtSearch.Location = new System.Drawing.Point(416, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(811, 45);
            this.txtSearch.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.groupBox4);
            this.panel9.Controls.Add(this.groupBox3);
            this.panel9.Controls.Add(this.groupBox1);
            this.panel9.Controls.Add(this.groupBox2);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(16, 52);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1293, 726);
            this.panel9.TabIndex = 37;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.txtMail);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtNumberDocument);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtAddress);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtTel);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.CboTypeDocument);
            this.groupBox4.Location = new System.Drawing.Point(32, 304);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(1247, 314);
            this.groupBox4.TabIndex = 188;
            this.groupBox4.TabStop = false;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.txtMail.Location = new System.Drawing.Point(424, 180);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(437, 43);
            this.txtMail.TabIndex = 205;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label7.Location = new System.Drawing.Point(296, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 33);
            this.label7.TabIndex = 204;
            this.label7.Text = "Correo:";
            // 
            // txtNumberDocument
            // 
            this.txtNumberDocument.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtNumberDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.txtNumberDocument.Location = new System.Drawing.Point(424, 74);
            this.txtNumberDocument.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumberDocument.Multiline = true;
            this.txtNumberDocument.Name = "txtNumberDocument";
            this.txtNumberDocument.Size = new System.Drawing.Size(437, 43);
            this.txtNumberDocument.TabIndex = 203;
            this.txtNumberDocument.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label5.Location = new System.Drawing.Point(229, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 33);
            this.label5.TabIndex = 202;
            this.label5.Text = "Documento:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.txtAddress.Location = new System.Drawing.Point(424, 231);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(437, 57);
            this.txtAddress.TabIndex = 201;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label9.Location = new System.Drawing.Point(256, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 33);
            this.label9.TabIndex = 200;
            this.label9.Text = "Dirección:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.txtTel.Location = new System.Drawing.Point(424, 132);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTel.Mask = "1-000-000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(437, 39);
            this.txtTel.TabIndex = 199;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label8.Location = new System.Drawing.Point(269, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 33);
            this.label8.TabIndex = 180;
            this.label8.Text = "Telefono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(165, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 172;
            this.label1.Text = "Tipo Documento:";
            // 
            // CboTypeDocument
            // 
            this.CboTypeDocument.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.CboTypeDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.CboTypeDocument.FormattingEnabled = true;
            this.CboTypeDocument.Items.AddRange(new object[] {
            "Seleccionar Tipo Documento",
            "Cedula",
            "Licencia",
            "Pasaporte",
            "Otros"});
            this.CboTypeDocument.Location = new System.Drawing.Point(424, 21);
            this.CboTypeDocument.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboTypeDocument.Name = "CboTypeDocument";
            this.CboTypeDocument.Size = new System.Drawing.Size(437, 39);
            this.CboTypeDocument.TabIndex = 171;
            this.CboTypeDocument.Text = "Seleccionar Tipo Documento";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnSaveChanges);
            this.groupBox3.Controls.Add(this.btnCancel_Clean);
            this.groupBox3.Location = new System.Drawing.Point(32, 625);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1248, 65);
            this.groupBox3.TabIndex = 187;
            this.groupBox3.TabStop = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(62)))));
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveChanges.Image")));
            this.btnSaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChanges.Location = new System.Drawing.Point(1051, 15);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(189, 43);
            this.btnSaveChanges.TabIndex = 185;
            this.btnSaveChanges.Text = "GUARDAR";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCancel_Clean
            // 
            this.btnCancel_Clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.btnCancel_Clean.FlatAppearance.BorderSize = 0;
            this.btnCancel_Clean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancel_Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel_Clean.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_Clean.ForeColor = System.Drawing.Color.White;
            this.btnCancel_Clean.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel_Clean.Image")));
            this.btnCancel_Clean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel_Clean.Location = new System.Drawing.Point(8, 15);
            this.btnCancel_Clean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel_Clean.Name = "btnCancel_Clean";
            this.btnCancel_Clean.Size = new System.Drawing.Size(189, 43);
            this.btnCancel_Clean.TabIndex = 186;
            this.btnCancel_Clean.Text = "CANCELAR";
            this.btnCancel_Clean.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel_Searc);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(32, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1248, 78);
            this.groupBox1.TabIndex = 184;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel_Searc
            // 
            this.btnCancel_Searc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(32)))));
            this.btnCancel_Searc.FlatAppearance.BorderSize = 0;
            this.btnCancel_Searc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancel_Searc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel_Searc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_Searc.ForeColor = System.Drawing.Color.White;
            this.btnCancel_Searc.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel_Searc.Image")));
            this.btnCancel_Searc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel_Searc.Location = new System.Drawing.Point(25, 20);
            this.btnCancel_Searc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel_Searc.Name = "btnCancel_Searc";
            this.btnCancel_Searc.Size = new System.Drawing.Size(189, 43);
            this.btnCancel_Searc.TabIndex = 13;
            this.btnCancel_Searc.Text = "CANCELAR";
            this.btnCancel_Searc.UseVisualStyleBackColor = false;
            this.btnCancel_Searc.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.BirthDate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtFull_Name);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CboSex);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(32, 151);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1248, 142);
            this.groupBox2.TabIndex = 183;
            this.groupBox2.TabStop = false;
            // 
            // BirthDate
            // 
            this.BirthDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.BirthDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.BirthDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDate.Location = new System.Drawing.Point(839, 16);
            this.BirthDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(361, 27);
            this.BirthDate.TabIndex = 192;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label12.Location = new System.Drawing.Point(560, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(266, 33);
            this.label12.TabIndex = 193;
            this.label12.Text = "Fecha Nacimiento:";
            // 
            // txtFull_Name
            // 
            this.txtFull_Name.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtFull_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.txtFull_Name.Location = new System.Drawing.Point(165, 16);
            this.txtFull_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFull_Name.Multiline = true;
            this.txtFull_Name.Name = "txtFull_Name";
            this.txtFull_Name.Size = new System.Drawing.Size(385, 43);
            this.txtFull_Name.TabIndex = 178;
            this.txtFull_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label11.Location = new System.Drawing.Point(12, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 33);
            this.label11.TabIndex = 177;
            this.label11.Text = "Nombres:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.txtName.Location = new System.Drawing.Point(165, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(385, 43);
            this.txtName.TabIndex = 176;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 33);
            this.label6.TabIndex = 172;
            this.label6.Text = "Apellidos:";
            // 
            // CboSex
            // 
            this.CboSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboSex.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.CboSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.CboSex.FormattingEnabled = true;
            this.CboSex.Items.AddRange(new object[] {
            "Seleccionar Sexo",
            "Masculino",
            "Femenino",
            "Otros"});
            this.CboSex.Location = new System.Drawing.Point(839, 71);
            this.CboSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboSex.Name = "CboSex";
            this.CboSex.Size = new System.Drawing.Size(361, 39);
            this.CboSex.TabIndex = 173;
            this.CboSex.Text = "Seleccionar Sexo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label10.Location = new System.Drawing.Point(740, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 33);
            this.label10.TabIndex = 174;
            this.label10.Text = "Sexo:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(33)))), ((int)(((byte)(124)))));
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1291, 59);
            this.panel10.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(32, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "15, 485";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, -62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(528, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registro de Clientes";
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1373, 772);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomersForm";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panel9.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnCancel_Searc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFull_Name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboSex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumberDocument;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboTypeDocument;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCancel_Clean;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}