namespace UI.BeautySalon
{
    partial class Central_Pane_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Central_Pane_Form));
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCustomersCentral_Panel = new System.Windows.Forms.Button();
            this.btnProvaiderCentral_Panel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBillCenPan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblFecha.Location = new System.Drawing.Point(231, 162);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(308, 23);
            this.lblFecha.TabIndex = 29;
            this.lblFecha.Text = "Miercoles, 10  noviembre  2017";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Century Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblhora.Location = new System.Drawing.Point(246, 81);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(293, 81);
            this.lblhora.TabIndex = 28;
            this.lblhora.Text = "10:59:58";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(295, 413);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(280, 21);
            this.label15.TabIndex = 37;
            this.label15.Text = "Sistema de Registro de Estudiantes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 74);
            this.panel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(319, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 203;
            this.label1.Text = "Bienvenido (a): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label2.Location = new System.Drawing.Point(189, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 202;
            this.label2.Text = "Bienvenido (a): ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 33);
            this.lblTitle.TabIndex = 201;
            this.lblTitle.Text = "BeautySalon-";
            // 
            // btnCustomersCentral_Panel
            // 
            this.btnCustomersCentral_Panel.BackColor = System.Drawing.Color.White;
            this.btnCustomersCentral_Panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomersCentral_Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCustomersCentral_Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCustomersCentral_Panel.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomersCentral_Panel.Image")));
            this.btnCustomersCentral_Panel.Location = new System.Drawing.Point(52, 212);
            this.btnCustomersCentral_Panel.Name = "btnCustomersCentral_Panel";
            this.btnCustomersCentral_Panel.Size = new System.Drawing.Size(260, 76);
            this.btnCustomersCentral_Panel.TabIndex = 39;
            this.btnCustomersCentral_Panel.Text = " Nuevos Clientes";
            this.btnCustomersCentral_Panel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomersCentral_Panel.UseVisualStyleBackColor = false;
            this.btnCustomersCentral_Panel.Click += new System.EventHandler(this.btnCustomersCentral_Panel_Click);
            // 
            // btnProvaiderCentral_Panel
            // 
            this.btnProvaiderCentral_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(166)))), ((int)(((byte)(137)))));
            this.btnProvaiderCentral_Panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvaiderCentral_Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnProvaiderCentral_Panel.ForeColor = System.Drawing.Color.White;
            this.btnProvaiderCentral_Panel.Image = ((System.Drawing.Image)(resources.GetObject("btnProvaiderCentral_Panel.Image")));
            this.btnProvaiderCentral_Panel.Location = new System.Drawing.Point(328, 212);
            this.btnProvaiderCentral_Panel.Name = "btnProvaiderCentral_Panel";
            this.btnProvaiderCentral_Panel.Size = new System.Drawing.Size(260, 76);
            this.btnProvaiderCentral_Panel.TabIndex = 40;
            this.btnProvaiderCentral_Panel.Text = " Proveedores";
            this.btnProvaiderCentral_Panel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProvaiderCentral_Panel.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(594, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 76);
            this.button2.TabIndex = 41;
            this.button2.Text = " Almacen e Inventarios";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(44)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(594, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 76);
            this.button3.TabIndex = 44;
            this.button3.Text = " Consultas";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(136)))), ((int)(((byte)(175)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(328, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 76);
            this.button4.TabIndex = 43;
            this.button4.Text = " Reportes";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnBillCenPan
            // 
            this.btnBillCenPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.btnBillCenPan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillCenPan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBillCenPan.ForeColor = System.Drawing.Color.White;
            this.btnBillCenPan.Image = ((System.Drawing.Image)(resources.GetObject("btnBillCenPan.Image")));
            this.btnBillCenPan.Location = new System.Drawing.Point(52, 307);
            this.btnBillCenPan.Name = "btnBillCenPan";
            this.btnBillCenPan.Size = new System.Drawing.Size(260, 76);
            this.btnBillCenPan.TabIndex = 42;
            this.btnBillCenPan.Text = " Facturacion";
            this.btnBillCenPan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBillCenPan.UseVisualStyleBackColor = false;
            //this.btnBillCenPan.Click += new System.EventHandler(this.button5_Click);
            // 
            // Central_Pane_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(855, 443);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnBillCenPan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnProvaiderCentral_Panel);
            this.Controls.Add(this.btnCustomersCentral_Panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.label15);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Central_Pane_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioResumen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCustomersCentral_Panel;
        private System.Windows.Forms.Button btnProvaiderCentral_Panel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBillCenPan;
    }
}