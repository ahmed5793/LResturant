namespace Restuarnt.PL
{
    partial class Frm_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Setting));
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSaveOrder = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxPrinter = new System.Windows.Forms.ComboBox();
            this.rbtn8cmSales = new System.Windows.Forms.RadioButton();
            this.rbtnA4Sales = new System.Windows.Forms.RadioButton();
            this.rbtn8cmBuy = new System.Windows.Forms.RadioButton();
            this.rbtnA4Buy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rdb_Sala = new System.Windows.Forms.RadioButton();
            this.Rdb_Deleviry = new System.Windows.Forms.RadioButton();
            this.Rdb_TakeAway = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_DeliveryService = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(3, 392);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(113, 36);
            this.txtPhone2.TabIndex = 21;
            this.txtPhone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone2.Visible = false;
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(23, 166);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(275, 36);
            this.txtPhone1.TabIndex = 19;
            this.txtPhone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone1_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(88, 331);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(435, 36);
            this.txtDescription.TabIndex = 17;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(457, 223);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(275, 36);
            this.txtAddress.TabIndex = 15;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(457, 166);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 36);
            this.txtName.TabIndex = 13;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.Appearance.Options.UseFont = true;
            this.btnSaveOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveOrder.ImageOptions.Image")));
            this.btnSaveOrder.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnSaveOrder.Location = new System.Drawing.Point(316, 392);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(207, 46);
            this.btnSaveOrder.TabIndex = 23;
            this.btnSaveOrder.Text = "حفظ بيانات الفاتورة";
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(122, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "رقم التوصيل2 ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(310, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "رقم التوصيل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(533, 335);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(157, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "جملة فى اسفل الفاتورة:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(740, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "عنوان المطعم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(744, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "إسم المطعم";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(453, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "اختر طابعة لكى تكون هى طابعة الفواتير الرئيسية للبرنامج";
            // 
            // cbxPrinter
            // 
            this.cbxPrinter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPrinter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrinter.FormattingEnabled = true;
            this.cbxPrinter.Location = new System.Drawing.Point(49, 27);
            this.cbxPrinter.Name = "cbxPrinter";
            this.cbxPrinter.Size = new System.Drawing.Size(398, 36);
            this.cbxPrinter.TabIndex = 10;
            // 
            // rbtn8cmSales
            // 
            this.rbtn8cmSales.AutoSize = true;
            this.rbtn8cmSales.Checked = true;
            this.rbtn8cmSales.Location = new System.Drawing.Point(130, 46);
            this.rbtn8cmSales.Name = "rbtn8cmSales";
            this.rbtn8cmSales.Size = new System.Drawing.Size(180, 32);
            this.rbtn8cmSales.TabIndex = 37;
            this.rbtn8cmSales.TabStop = true;
            this.rbtn8cmSales.Text = "طباعة حراري (8 سنتى)";
            this.rbtn8cmSales.UseVisualStyleBackColor = true;
            this.rbtn8cmSales.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbtnA4Sales
            // 
            this.rbtnA4Sales.AutoSize = true;
            this.rbtnA4Sales.Location = new System.Drawing.Point(6, 46);
            this.rbtnA4Sales.Name = "rbtnA4Sales";
            this.rbtnA4Sales.Size = new System.Drawing.Size(97, 32);
            this.rbtnA4Sales.TabIndex = 38;
            this.rbtnA4Sales.Text = "طباعة A4";
            this.rbtnA4Sales.UseVisualStyleBackColor = true;
            // 
            // rbtn8cmBuy
            // 
            this.rbtn8cmBuy.AutoSize = true;
            this.rbtn8cmBuy.Checked = true;
            this.rbtn8cmBuy.Location = new System.Drawing.Point(130, 46);
            this.rbtn8cmBuy.Name = "rbtn8cmBuy";
            this.rbtn8cmBuy.Size = new System.Drawing.Size(180, 32);
            this.rbtn8cmBuy.TabIndex = 37;
            this.rbtn8cmBuy.TabStop = true;
            this.rbtn8cmBuy.Text = "طباعة حراري (8 سنتى)";
            this.rbtn8cmBuy.UseVisualStyleBackColor = true;
            // 
            // rbtnA4Buy
            // 
            this.rbtnA4Buy.AutoSize = true;
            this.rbtnA4Buy.Location = new System.Drawing.Point(6, 46);
            this.rbtnA4Buy.Name = "rbtnA4Buy";
            this.rbtnA4Buy.Size = new System.Drawing.Size(97, 32);
            this.rbtnA4Buy.TabIndex = 38;
            this.rbtnA4Buy.Text = "طباعة A4";
            this.rbtnA4Buy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(453, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "اختر نوع الفاتورة الاكثر استخداما فى شاشة المبيعات";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rdb_Sala);
            this.groupBox2.Controls.Add(this.Rdb_Deleviry);
            this.groupBox2.Controls.Add(this.Rdb_TakeAway);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(49, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 77);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نوع الاوردر";
            // 
            // Rdb_Sala
            // 
            this.Rdb_Sala.AutoSize = true;
            this.Rdb_Sala.BackColor = System.Drawing.Color.Yellow;
            this.Rdb_Sala.Checked = true;
            this.Rdb_Sala.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Sala.Location = new System.Drawing.Point(301, 35);
            this.Rdb_Sala.Name = "Rdb_Sala";
            this.Rdb_Sala.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rdb_Sala.Size = new System.Drawing.Size(65, 31);
            this.Rdb_Sala.TabIndex = 82;
            this.Rdb_Sala.TabStop = true;
            this.Rdb_Sala.Text = "صالة";
            this.Rdb_Sala.UseVisualStyleBackColor = false;
            // 
            // Rdb_Deleviry
            // 
            this.Rdb_Deleviry.AutoSize = true;
            this.Rdb_Deleviry.BackColor = System.Drawing.Color.Yellow;
            this.Rdb_Deleviry.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Deleviry.Location = new System.Drawing.Point(172, 35);
            this.Rdb_Deleviry.Name = "Rdb_Deleviry";
            this.Rdb_Deleviry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rdb_Deleviry.Size = new System.Drawing.Size(77, 31);
            this.Rdb_Deleviry.TabIndex = 83;
            this.Rdb_Deleviry.Text = "دليفرى";
            this.Rdb_Deleviry.UseVisualStyleBackColor = false;
            // 
            // Rdb_TakeAway
            // 
            this.Rdb_TakeAway.AutoSize = true;
            this.Rdb_TakeAway.BackColor = System.Drawing.Color.Yellow;
            this.Rdb_TakeAway.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_TakeAway.Location = new System.Drawing.Point(39, 35);
            this.Rdb_TakeAway.Name = "Rdb_TakeAway";
            this.Rdb_TakeAway.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rdb_TakeAway.Size = new System.Drawing.Size(92, 31);
            this.Rdb_TakeAway.TabIndex = 81;
            this.Rdb_TakeAway.Text = "تيك اواى";
            this.Rdb_TakeAway.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 79;
            // 
            // Txt_DeliveryService
            // 
            this.Txt_DeliveryService.Location = new System.Drawing.Point(23, 223);
            this.Txt_DeliveryService.Name = "Txt_DeliveryService";
            this.Txt_DeliveryService.Size = new System.Drawing.Size(275, 36);
            this.Txt_DeliveryService.TabIndex = 88;
            this.Txt_DeliveryService.Text = "0";
            this.Txt_DeliveryService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_DeliveryService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_DeliveryService_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(310, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 22);
            this.label9.TabIndex = 89;
            this.label9.Text = "قيمة التوصيل";
            // 
            // Frm_Setting
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.Txt_DeliveryService);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhone2);
            this.Controls.Add(this.txtPhone1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxPrinter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_Setting";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادت البرنامج";
            this.Load += new System.EventHandler(this.Frm_Setting_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private DevExpress.XtraEditors.SimpleButton btnSaveOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxPrinter;
        private System.Windows.Forms.RadioButton rbtn8cmSales;
        private System.Windows.Forms.RadioButton rbtnA4Sales;
        private System.Windows.Forms.RadioButton rbtn8cmBuy;
        private System.Windows.Forms.RadioButton rbtnA4Buy;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton Rdb_Sala;
        public System.Windows.Forms.RadioButton Rdb_Deleviry;
        public System.Windows.Forms.RadioButton Rdb_TakeAway;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_DeliveryService;
        private System.Windows.Forms.Label label9;
    }
}