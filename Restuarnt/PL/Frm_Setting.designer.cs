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
            this.btnSaveOrder = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxPrinterClient = new System.Windows.Forms.ComboBox();
            this.rbtn8cmSales = new System.Windows.Forms.RadioButton();
            this.rbtnA4Sales = new System.Windows.Forms.RadioButton();
            this.rbtn8cmBuy = new System.Windows.Forms.RadioButton();
            this.rbtnA4Buy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rdb_Sala = new System.Windows.Forms.RadioButton();
            this.Rdb_Deleviry = new System.Windows.Forms.RadioButton();
            this.Rdb_TakeAway = new System.Windows.Forms.RadioButton();
            this.Txt_DeliveryService = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Cmb_PrintChecken = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Cmb_PrintDrinks = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Rdb_Collect = new System.Windows.Forms.RadioButton();
            this.Rdb_Seperator = new System.Windows.Forms.RadioButton();
            this.check_OrderInSave = new System.Windows.Forms.CheckBox();
            this.check_CheckenInSave = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.check_OrderInhold = new System.Windows.Forms.CheckBox();
            this.check_checkenInHold = new System.Windows.Forms.CheckBox();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnChoose = new DevExpress.XtraEditors.SimpleButton();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(38, 149);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(113, 32);
            this.txtPhone2.TabIndex = 21;
            this.txtPhone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone2.Visible = false;
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(6, 137);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(275, 32);
            this.txtPhone1.TabIndex = 19;
            this.txtPhone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone1_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 185);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(275, 32);
            this.txtDescription.TabIndex = 17;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(624, 70);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(240, 32);
            this.txtAddress.TabIndex = 15;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.Appearance.Options.UseFont = true;
            this.btnSaveOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveOrder.ImageOptions.Image")));
            this.btnSaveOrder.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnSaveOrder.Location = new System.Drawing.Point(421, 532);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(128, 34);
            this.btnSaveOrder.TabIndex = 23;
            this.btnSaveOrder.Text = "حفظ ";
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(188, 163);
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
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(285, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "رقم التوصيل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(285, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(150, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "جملة فى اسفل الفاتورة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(870, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "إسم المكان";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(692, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "اختر طابعة لطباعة فاتورة للعميل";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbxPrinterClient
            // 
            this.cbxPrinterClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPrinterClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPrinterClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrinterClient.FormattingEnabled = true;
            this.cbxPrinterClient.Location = new System.Drawing.Point(690, 56);
            this.cbxPrinterClient.Name = "cbxPrinterClient";
            this.cbxPrinterClient.Size = new System.Drawing.Size(238, 32);
            this.cbxPrinterClient.TabIndex = 10;
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
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(415, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "اخــتــر نــوع الــفــاتــورة الاكــثــر اســتــخــدامـــا فـــى شـــاشـــة الـــ" +
    "مـــبــيـــعـــات";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnChoose);
            this.groupBox2.Controls.Add(this.Rdb_Sala);
            this.groupBox2.Controls.Add(this.Rdb_Deleviry);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Txt_DeliveryService);
            this.groupBox2.Controls.Add(this.Rdb_TakeAway);
            this.groupBox2.Controls.Add(this.pictureLogo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPhone1);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(954, 232);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الفاتورة";
            // 
            // Rdb_Sala
            // 
            this.Rdb_Sala.AutoSize = true;
            this.Rdb_Sala.BackColor = System.Drawing.Color.White;
            this.Rdb_Sala.Checked = true;
            this.Rdb_Sala.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Sala.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rdb_Sala.Location = new System.Drawing.Point(318, 27);
            this.Rdb_Sala.Name = "Rdb_Sala";
            this.Rdb_Sala.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rdb_Sala.Size = new System.Drawing.Size(83, 26);
            this.Rdb_Sala.TabIndex = 82;
            this.Rdb_Sala.TabStop = true;
            this.Rdb_Sala.Text = "صـــالـــة";
            this.Rdb_Sala.UseVisualStyleBackColor = false;
            // 
            // Rdb_Deleviry
            // 
            this.Rdb_Deleviry.AutoSize = true;
            this.Rdb_Deleviry.BackColor = System.Drawing.Color.White;
            this.Rdb_Deleviry.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Deleviry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rdb_Deleviry.Location = new System.Drawing.Point(202, 27);
            this.Rdb_Deleviry.Name = "Rdb_Deleviry";
            this.Rdb_Deleviry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rdb_Deleviry.Size = new System.Drawing.Size(98, 26);
            this.Rdb_Deleviry.TabIndex = 83;
            this.Rdb_Deleviry.Text = "دلـــيــفــرى";
            this.Rdb_Deleviry.UseVisualStyleBackColor = false;
            // 
            // Rdb_TakeAway
            // 
            this.Rdb_TakeAway.AutoSize = true;
            this.Rdb_TakeAway.BackColor = System.Drawing.Color.White;
            this.Rdb_TakeAway.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_TakeAway.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rdb_TakeAway.Location = new System.Drawing.Point(82, 27);
            this.Rdb_TakeAway.Name = "Rdb_TakeAway";
            this.Rdb_TakeAway.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rdb_TakeAway.Size = new System.Drawing.Size(102, 26);
            this.Rdb_TakeAway.TabIndex = 81;
            this.Rdb_TakeAway.Text = "تـــيــك اواى";
            this.Rdb_TakeAway.UseVisualStyleBackColor = false;
            // 
            // Txt_DeliveryService
            // 
            this.Txt_DeliveryService.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_DeliveryService.Location = new System.Drawing.Point(128, 91);
            this.Txt_DeliveryService.Multiline = true;
            this.Txt_DeliveryService.Name = "Txt_DeliveryService";
            this.Txt_DeliveryService.Size = new System.Drawing.Size(153, 31);
            this.Txt_DeliveryService.TabIndex = 88;
            this.Txt_DeliveryService.Text = "0";
            this.Txt_DeliveryService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_DeliveryService.Click += new System.EventHandler(this.Txt_DeliveryService_Click);
            this.Txt_DeliveryService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_DeliveryService_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(287, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 22);
            this.label9.TabIndex = 89;
            this.label9.Text = "قيمة التوصيل";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(366, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 24);
            this.label10.TabIndex = 91;
            this.label10.Text = "اختر طابعة لطباعة امر تشغيل المطبخ";
            // 
            // Cmb_PrintChecken
            // 
            this.Cmb_PrintChecken.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_PrintChecken.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_PrintChecken.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_PrintChecken.FormattingEnabled = true;
            this.Cmb_PrintChecken.Location = new System.Drawing.Point(363, 56);
            this.Cmb_PrintChecken.Name = "Cmb_PrintChecken";
            this.Cmb_PrintChecken.Size = new System.Drawing.Size(274, 32);
            this.Cmb_PrintChecken.TabIndex = 90;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 24);
            this.label11.TabIndex = 93;
            this.label11.Text = "اختر طابعة لطباعة امر تشغيل المشروبات";
            // 
            // Cmb_PrintDrinks
            // 
            this.Cmb_PrintDrinks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_PrintDrinks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_PrintDrinks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_PrintDrinks.FormattingEnabled = true;
            this.Cmb_PrintDrinks.Location = new System.Drawing.Point(11, 58);
            this.Cmb_PrintDrinks.Name = "Cmb_PrintDrinks";
            this.Cmb_PrintDrinks.Size = new System.Drawing.Size(299, 32);
            this.Cmb_PrintDrinks.TabIndex = 92;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(732, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 24);
            this.label12.TabIndex = 94;
            this.label12.Text = "فـــى حـــالــة تعــليق الفاتورة";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.check_OrderInSave);
            this.groupBox1.Controls.Add(this.check_CheckenInSave);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.check_OrderInhold);
            this.groupBox1.Controls.Add(this.check_checkenInHold);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbxPrinterClient);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Cmb_PrintDrinks);
            this.groupBox1.Controls.Add(this.txtPhone2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Cmb_PrintChecken);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 285);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إعدادات الطباعة";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Rdb_Collect);
            this.groupBox3.Controls.Add(this.Rdb_Seperator);
            this.groupBox3.Location = new System.Drawing.Point(6, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(943, 77);
            this.groupBox3.TabIndex = 88;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "طــبــاعــة آمـــر التــشــغــيــل";
            // 
            // Rdb_Collect
            // 
            this.Rdb_Collect.AutoSize = true;
            this.Rdb_Collect.BackColor = System.Drawing.Color.White;
            this.Rdb_Collect.Checked = true;
            this.Rdb_Collect.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Collect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rdb_Collect.Location = new System.Drawing.Point(525, 38);
            this.Rdb_Collect.Name = "Rdb_Collect";
            this.Rdb_Collect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rdb_Collect.Size = new System.Drawing.Size(396, 28);
            this.Rdb_Collect.TabIndex = 83;
            this.Rdb_Collect.TabStop = true;
            this.Rdb_Collect.Text = "امر التشغيل مجمع (الماكولات والمشروبات مع بعض)";
            this.Rdb_Collect.UseVisualStyleBackColor = false;
            // 
            // Rdb_Seperator
            // 
            this.Rdb_Seperator.AutoSize = true;
            this.Rdb_Seperator.BackColor = System.Drawing.Color.White;
            this.Rdb_Seperator.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Seperator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rdb_Seperator.Location = new System.Drawing.Point(21, 38);
            this.Rdb_Seperator.Name = "Rdb_Seperator";
            this.Rdb_Seperator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rdb_Seperator.Size = new System.Drawing.Size(438, 28);
            this.Rdb_Seperator.TabIndex = 81;
            this.Rdb_Seperator.Text = "امر التشغيل منفصل (مشروبات لوحدها والاماكولات لوحدها)";
            this.Rdb_Seperator.UseVisualStyleBackColor = false;
            // 
            // check_OrderInSave
            // 
            this.check_OrderInSave.AutoSize = true;
            this.check_OrderInSave.BackColor = System.Drawing.Color.White;
            this.check_OrderInSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.check_OrderInSave.Location = new System.Drawing.Point(339, 163);
            this.check_OrderInSave.Name = "check_OrderInSave";
            this.check_OrderInSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_OrderInSave.Size = new System.Drawing.Size(167, 28);
            this.check_OrderInSave.TabIndex = 99;
            this.check_OrderInSave.Text = "طباعة فاتورة للعميل";
            this.check_OrderInSave.UseVisualStyleBackColor = false;
            this.check_OrderInSave.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // check_CheckenInSave
            // 
            this.check_CheckenInSave.AutoSize = true;
            this.check_CheckenInSave.BackColor = System.Drawing.Color.White;
            this.check_CheckenInSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.check_CheckenInSave.Location = new System.Drawing.Point(546, 164);
            this.check_CheckenInSave.Name = "check_CheckenInSave";
            this.check_CheckenInSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_CheckenInSave.Size = new System.Drawing.Size(148, 28);
            this.check_CheckenInSave.TabIndex = 98;
            this.check_CheckenInSave.Text = "طباعة امر تشغيل";
            this.check_CheckenInSave.UseVisualStyleBackColor = false;
            this.check_CheckenInSave.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(734, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 24);
            this.label8.TabIndex = 97;
            this.label8.Text = "فى حالة حفظ وسداد الفاتورة";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // check_OrderInhold
            // 
            this.check_OrderInhold.AutoSize = true;
            this.check_OrderInhold.BackColor = System.Drawing.Color.White;
            this.check_OrderInhold.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.check_OrderInhold.Location = new System.Drawing.Point(339, 112);
            this.check_OrderInhold.Name = "check_OrderInhold";
            this.check_OrderInhold.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_OrderInhold.Size = new System.Drawing.Size(167, 28);
            this.check_OrderInhold.TabIndex = 96;
            this.check_OrderInhold.Text = "طباعة فاتورة للعميل";
            this.check_OrderInhold.UseVisualStyleBackColor = false;
            this.check_OrderInhold.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // check_checkenInHold
            // 
            this.check_checkenInHold.AutoSize = true;
            this.check_checkenInHold.BackColor = System.Drawing.Color.White;
            this.check_checkenInHold.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.check_checkenInHold.Location = new System.Drawing.Point(544, 113);
            this.check_checkenInHold.Name = "check_checkenInHold";
            this.check_checkenInHold.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_checkenInHold.Size = new System.Drawing.Size(148, 28);
            this.check_checkenInHold.TabIndex = 95;
            this.check_checkenInHold.Text = "طباعة امر تشغيل";
            this.check_checkenInHold.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btndelete.Appearance.BackColor2 = System.Drawing.Color.Yellow;
            this.btndelete.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btndelete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Appearance.Options.UseBackColor = true;
            this.btndelete.Appearance.Options.UseBorderColor = true;
            this.btndelete.Appearance.Options.UseFont = true;
            this.btndelete.Appearance.Options.UseForeColor = true;
            this.btndelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btndelete.Location = new System.Drawing.Point(510, 188);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(103, 30);
            this.btndelete.TabIndex = 92;
            this.btndelete.Text = "مسح الصورة";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnChoose.Appearance.BackColor2 = System.Drawing.Color.Yellow;
            this.btnChoose.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnChoose.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnChoose.Appearance.Options.UseBackColor = true;
            this.btnChoose.Appearance.Options.UseBorderColor = true;
            this.btnChoose.Appearance.Options.UseFont = true;
            this.btnChoose.Appearance.Options.UseForeColor = true;
            this.btnChoose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnChoose.Location = new System.Drawing.Point(510, 133);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(103, 30);
            this.btnChoose.TabIndex = 91;
            this.btnChoose.Text = "اختر صورة";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLogo.Image = global::Restuarnt.Properties.Resources.image_not_found_scaled_1150x647;
            this.pictureLogo.Location = new System.Drawing.Point(624, 108);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(240, 112);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 90;
            this.pictureLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(898, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 93;
            this.label2.Text = "لوجو ";
            this.label2.Visible = false;
            // 
            // Frm_Setting
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(959, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSaveOrder);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(969, 600);
            this.MdiChildCaptionFormatString = "";
            this.MinimumSize = new System.Drawing.Size(969, 600);
            this.Name = "Frm_Setting";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادت البرنامج";
            this.Load += new System.EventHandler(this.Frm_Setting_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAddress;
        private DevExpress.XtraEditors.SimpleButton btnSaveOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxPrinterClient;
        private System.Windows.Forms.RadioButton rbtn8cmSales;
        private System.Windows.Forms.RadioButton rbtnA4Sales;
        private System.Windows.Forms.RadioButton rbtn8cmBuy;
        private System.Windows.Forms.RadioButton rbtnA4Buy;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton Rdb_Sala;
        public System.Windows.Forms.RadioButton Rdb_Deleviry;
        public System.Windows.Forms.RadioButton Rdb_TakeAway;
        private System.Windows.Forms.TextBox Txt_DeliveryService;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Cmb_PrintChecken;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Cmb_PrintDrinks;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox check_checkenInHold;
        private System.Windows.Forms.CheckBox check_OrderInSave;
        private System.Windows.Forms.CheckBox check_CheckenInSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox check_OrderInhold;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton Rdb_Collect;
        public System.Windows.Forms.RadioButton Rdb_Seperator;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnChoose;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label label2;
    }
}