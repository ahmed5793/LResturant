namespace Restuarnt.PL
{
    partial class Frm_Hold
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Hold));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdb_all = new System.Windows.Forms.RadioButton();
            this.rdb_takeaway = new System.Windows.Forms.RadioButton();
            this.rdb_delivery = new System.Windows.Forms.RadioButton();
            this.rdb_sala = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_Order = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name_Cust = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_take = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Statues = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeliveryService = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.عرض = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.عرض)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rdb_all);
            this.groupControl1.Controls.Add(this.rdb_takeaway);
            this.groupControl1.Controls.Add(this.rdb_delivery);
            this.groupControl1.Controls.Add(this.rdb_sala);
            this.groupControl1.Location = new System.Drawing.Point(21, 38);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(847, 159);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // rdb_all
            // 
            this.rdb_all.AutoSize = true;
            this.rdb_all.Checked = true;
            this.rdb_all.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_all.Image = ((System.Drawing.Image)(resources.GetObject("rdb_all.Image")));
            this.rdb_all.Location = new System.Drawing.Point(709, 23);
            this.rdb_all.Name = "rdb_all";
            this.rdb_all.Size = new System.Drawing.Size(109, 126);
            this.rdb_all.TabIndex = 87;
            this.rdb_all.TabStop = true;
            this.rdb_all.Text = "الكل";
            this.rdb_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdb_all.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdb_all.UseVisualStyleBackColor = true;
            this.rdb_all.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_takeaway
            // 
            this.rdb_takeaway.AutoSize = true;
            this.rdb_takeaway.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_takeaway.Image = ((System.Drawing.Image)(resources.GetObject("rdb_takeaway.Image")));
            this.rdb_takeaway.Location = new System.Drawing.Point(19, 21);
            this.rdb_takeaway.Name = "rdb_takeaway";
            this.rdb_takeaway.Size = new System.Drawing.Size(114, 131);
            this.rdb_takeaway.TabIndex = 84;
            this.rdb_takeaway.Text = "تيك اواى";
            this.rdb_takeaway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdb_takeaway.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdb_takeaway.UseVisualStyleBackColor = true;
            this.rdb_takeaway.CheckedChanged += new System.EventHandler(this.rdb_takeaway_CheckedChanged);
            // 
            // rdb_delivery
            // 
            this.rdb_delivery.AutoSize = true;
            this.rdb_delivery.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_delivery.Image = global::Restuarnt.Properties.Resources.delivery2;
            this.rdb_delivery.Location = new System.Drawing.Point(203, 30);
            this.rdb_delivery.Name = "rdb_delivery";
            this.rdb_delivery.Size = new System.Drawing.Size(142, 122);
            this.rdb_delivery.TabIndex = 86;
            this.rdb_delivery.Text = "دليفرى";
            this.rdb_delivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdb_delivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdb_delivery.UseVisualStyleBackColor = true;
            this.rdb_delivery.CheckedChanged += new System.EventHandler(this.rdb_delivery_CheckedChanged);
            // 
            // rdb_sala
            // 
            this.rdb_sala.AutoSize = true;
            this.rdb_sala.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_sala.Image = global::Restuarnt.Properties.Resources.restaurant_table_icon_9;
            this.rdb_sala.Location = new System.Drawing.Point(443, 32);
            this.rdb_sala.Name = "rdb_sala";
            this.rdb_sala.Size = new System.Drawing.Size(142, 109);
            this.rdb_sala.TabIndex = 85;
            this.rdb_sala.Text = "صالة";
            this.rdb_sala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdb_sala.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdb_sala.UseVisualStyleBackColor = true;
            this.rdb_sala.CheckedChanged += new System.EventHandler(this.rdb_sala_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AppearanceHovered.Options.UseTextOptions = true;
            this.labelControl1.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(243, -3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(435, 28);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "الفواتير المعلقة -holder order";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridControl2);
            this.groupBox2.Location = new System.Drawing.Point(2, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 322);
            this.groupBox2.TabIndex = 168;
            this.groupBox2.TabStop = false;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl2.Location = new System.Drawing.Point(3, 16);
            this.gridControl2.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.gridControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.عرض,
            this.repositoryItemButtonEdit1});
            this.gridControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl2.Size = new System.Drawing.Size(863, 303);
            this.gridControl2.TabIndex = 127;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            this.gridControl2.DoubleClick += new System.EventHandler(this.gridControl2_DoubleClick);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.gridView2.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView2.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView2.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridView2.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridView2.Appearance.FooterPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FooterPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Yellow;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.Row.Options.UseTextOptions = true;
            this.gridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridView2.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView2.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridView2.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridView2.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gridView2.AppearancePrint.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView2.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView2.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView2.AppearancePrint.Row.Options.UseFont = true;
            this.gridView2.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_Order,
            this.Name_Cust,
            this.id_take,
            this.Date,
            this.Total,
            this.Statues,
            this.DeliveryService,
            this.gridColumn1,
            this.delete});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsPrint.PrintPreview = true;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView2_RowCellClick);
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanged);
            // 
            // ID_Order
            // 
            this.ID_Order.Caption = "رقم الفاتورة";
            this.ID_Order.FieldName = "رقم الفاتورة";
            this.ID_Order.Name = "ID_Order";
            this.ID_Order.Visible = true;
            this.ID_Order.VisibleIndex = 0;
            this.ID_Order.Width = 102;
            // 
            // Name_Cust
            // 
            this.Name_Cust.Caption = "اسم العميل";
            this.Name_Cust.FieldName = "اسم العميل";
            this.Name_Cust.Name = "Name_Cust";
            this.Name_Cust.Visible = true;
            this.Name_Cust.VisibleIndex = 1;
            this.Name_Cust.Width = 103;
            // 
            // id_take
            // 
            this.id_take.Caption = "رقم الطلب";
            this.id_take.FieldName = "رقم الطلب";
            this.id_take.Name = "id_take";
            this.id_take.Visible = true;
            this.id_take.VisibleIndex = 2;
            this.id_take.Width = 103;
            // 
            // Date
            // 
            this.Date.Caption = "تاريخ الفاتورة";
            this.Date.FieldName = "تاريخ الفاتورة";
            this.Date.Name = "Date";
            this.Date.Visible = true;
            this.Date.VisibleIndex = 3;
            this.Date.Width = 103;
            // 
            // Total
            // 
            this.Total.Caption = "الاجمالي";
            this.Total.FieldName = "الاجمالي";
            this.Total.Name = "Total";
            this.Total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "الاجمالي", "مبيعات={0:0.##}")});
            this.Total.Visible = true;
            this.Total.VisibleIndex = 4;
            this.Total.Width = 103;
            // 
            // Statues
            // 
            this.Statues.Caption = "نوع الطلب";
            this.Statues.FieldName = "نوع الطلب";
            this.Statues.Name = "Statues";
            this.Statues.Visible = true;
            this.Statues.VisibleIndex = 5;
            this.Statues.Width = 103;
            // 
            // DeliveryService
            // 
            this.DeliveryService.Caption = "دليفرى";
            this.DeliveryService.FieldName = "DeliveryService";
            this.DeliveryService.Name = "DeliveryService";
            this.DeliveryService.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DeliveryService", "دليفرى={0:0.##}")});
            this.DeliveryService.Visible = true;
            this.DeliveryService.VisibleIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "عرض";
            this.gridColumn1.ColumnEdit = this.عرض;
            this.gridColumn1.FieldName = "عرض";
            this.gridColumn1.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.gridColumn1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn1.ImageOptions.Image")));
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 110;
            // 
            // عرض
            // 
            this.عرض.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.عرض.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.عرض.Name = "عرض";
            this.عرض.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.عرض.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.عرض_ButtonClick);
            this.عرض.DoubleClick += new System.EventHandler(this.عرض_DoubleClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(835, -3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(36, 35);
            this.simpleButton1.TabIndex = 169;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // delete
            // 
            this.delete.ColumnEdit = this.repositoryItemButtonEdit1;
            this.delete.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn2.ImageOptions.Image")));
            this.delete.Name = "delete";
            this.delete.Visible = true;
            this.delete.VisibleIndex = 8;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // Frm_Hold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.MaximumSize = new System.Drawing.Size(882, 562);
            this.MinimumSize = new System.Drawing.Size(882, 562);
            this.Name = "Frm_Hold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Hold";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Hold_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Hold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.عرض)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.RadioButton rdb_all;
        public System.Windows.Forms.RadioButton rdb_takeaway;
        public System.Windows.Forms.RadioButton rdb_delivery;
        public System.Windows.Forms.RadioButton rdb_sala;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.Columns.GridColumn ID_Order;
        private DevExpress.XtraGrid.Columns.GridColumn Name_Cust;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit عرض;
        private DevExpress.XtraGrid.Columns.GridColumn id_take;
        public DevExpress.XtraGrid.GridControl gridControl2;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        public DevExpress.XtraGrid.Columns.GridColumn Statues;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn DeliveryService;
        private DevExpress.XtraGrid.Columns.GridColumn delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}