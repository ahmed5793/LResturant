namespace Restuarnt.PL
{
    partial class Frm_ShowUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ShowUpdate));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_Dep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_Items = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Neg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Post = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.grb_customer = new System.Windows.Forms.GroupBox();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txt_address = new DevExpress.XtraEditors.TextEdit();
            this.txt_phones = new DevExpress.XtraEditors.TextEdit();
            this.grb_delivry = new System.Windows.Forms.GroupBox();
            this.cmb_delivery = new System.Windows.Forms.ComboBox();
            this.grb_sala = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_stuff = new System.Windows.Forms.ComboBox();
            this.cmb_Table = new System.Windows.Forms.ComboBox();
            this.label_Table = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_cust = new System.Windows.Forms.TextBox();
            this.Lable_Num = new System.Windows.Forms.Label();
            this.lable_date = new System.Windows.Forms.Label();
            this.txt_delivery = new System.Windows.Forms.TextBox();
            this.txt_invo = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.texT = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdb_takeaway = new System.Windows.Forms.RadioButton();
            this.rdb_delivery = new System.Windows.Forms.RadioButton();
            this.rdb_sala = new System.Windows.Forms.RadioButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).BeginInit();
            this.grb_customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_phones.Properties)).BeginInit();
            this.grb_delivry.SuspendLayout();
            this.grb_sala.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl2.Location = new System.Drawing.Point(2, 21);
            this.gridControl2.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.gridControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2,
            this.repositoryItemButtonEdit3});
            this.gridControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl2.Size = new System.Drawing.Size(592, 251);
            this.gridControl2.TabIndex = 129;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.gridView2.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridView2.Appearance.FooterPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gridView2.Appearance.RowSeparator.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridView2.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.AppearancePrint.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView2.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView2.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.AppearancePrint.Row.Options.UseFont = true;
            this.gridView2.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_Dep,
            this.Dep,
            this.ID_Items,
            this.Item_Name,
            this.Price,
            this.quantity,
            this.Total,
            this.Neg,
            this.Post,
            this.gridColumn1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsPrint.PrintPreview = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView2_RowCellClick);
            this.gridView2.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView2_RowDeleting);
            this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            // 
            // ID_Dep
            // 
            this.ID_Dep.Caption = "رقم القسم";
            this.ID_Dep.FieldName = "رقم القسم";
            this.ID_Dep.Name = "ID_Dep";
            this.ID_Dep.Visible = true;
            this.ID_Dep.VisibleIndex = 0;
            this.ID_Dep.Width = 90;
            // 
            // Dep
            // 
            this.Dep.Caption = "القسم";
            this.Dep.FieldName = "القسم";
            this.Dep.Name = "Dep";
            this.Dep.Visible = true;
            this.Dep.VisibleIndex = 1;
            this.Dep.Width = 90;
            // 
            // ID_Items
            // 
            this.ID_Items.Caption = "رقم الصنف";
            this.ID_Items.FieldName = "رقم الصنف";
            this.ID_Items.Name = "ID_Items";
            this.ID_Items.Visible = true;
            this.ID_Items.VisibleIndex = 2;
            this.ID_Items.Width = 106;
            // 
            // Item_Name
            // 
            this.Item_Name.Caption = "اسم الصنف";
            this.Item_Name.FieldName = "اسم الصنف";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.OptionsColumn.AllowSize = false;
            this.Item_Name.OptionsColumn.FixedWidth = true;
            this.Item_Name.OptionsColumn.ReadOnly = true;
            this.Item_Name.Visible = true;
            this.Item_Name.VisibleIndex = 3;
            this.Item_Name.Width = 90;
            // 
            // Price
            // 
            this.Price.Caption = "السعر";
            this.Price.FieldName = "السعر";
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowSize = false;
            this.Price.OptionsColumn.FixedWidth = true;
            this.Price.OptionsColumn.ReadOnly = true;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 4;
            this.Price.Width = 40;
            // 
            // quantity
            // 
            this.quantity.Caption = "الكمية";
            this.quantity.FieldName = "الكمية";
            this.quantity.Name = "quantity";
            this.quantity.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.quantity.OptionsColumn.AllowSize = false;
            this.quantity.OptionsColumn.FixedWidth = true;
            this.quantity.OptionsColumn.ReadOnly = true;
            this.quantity.Visible = true;
            this.quantity.VisibleIndex = 5;
            this.quantity.Width = 40;
            // 
            // Total
            // 
            this.Total.Caption = "الأجمالي";
            this.Total.FieldName = "الأجمالي";
            this.Total.Name = "Total";
            this.Total.OptionsColumn.AllowSize = false;
            this.Total.OptionsColumn.FixedWidth = true;
            this.Total.OptionsColumn.ReadOnly = true;
            this.Total.Visible = true;
            this.Total.VisibleIndex = 6;
            this.Total.Width = 40;
            // 
            // Neg
            // 
            this.Neg.AppearanceCell.BackColor = System.Drawing.Color.OrangeRed;
            this.Neg.AppearanceCell.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Neg.AppearanceCell.Options.UseBackColor = true;
            this.Neg.AppearanceCell.Options.UseFont = true;
            this.Neg.ColumnEdit = this.repositoryItemButtonEdit1;
            this.Neg.FieldName = "btn";
            this.Neg.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.Neg.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Neg.ImageOptions.SvgImage")));
            this.Neg.Name = "Neg";
            this.Neg.OptionsColumn.AllowSize = false;
            this.Neg.OptionsColumn.FixedWidth = true;
            this.Neg.OptionsColumn.ReadOnly = true;
            this.Neg.Visible = true;
            this.Neg.VisibleIndex = 7;
            this.Neg.Width = 25;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.repositoryItemButtonEdit1.LookAndFeel.SkinMaskColor = System.Drawing.Color.CornflowerBlue;
            this.repositoryItemButtonEdit1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.DodgerBlue;
            this.repositoryItemButtonEdit1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.repositoryItemButtonEdit1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick_1);
            this.repositoryItemButtonEdit1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.repositoryItemButtonEdit1_KeyUp);
            // 
            // Post
            // 
            this.Post.ColumnEdit = this.repositoryItemButtonEdit2;
            this.Post.FieldName = "post";
            this.Post.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.Post.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Post.ImageOptions.SvgImage")));
            this.Post.Name = "Post";
            this.Post.OptionsColumn.AllowSize = false;
            this.Post.OptionsColumn.FixedWidth = true;
            this.Post.OptionsColumn.ReadOnly = true;
            this.Post.Visible = true;
            this.Post.VisibleIndex = 8;
            this.Post.Width = 25;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)});
            this.repositoryItemButtonEdit2.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red;
            this.repositoryItemButtonEdit2.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Red;
            this.repositoryItemButtonEdit2.LookAndFeel.SkinName = "Office 2010 Silver";
            this.repositoryItemButtonEdit2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEdit3;
            this.gridColumn1.FieldName = "Remove";
            this.gridColumn1.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.gridColumn1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn1.ImageOptions.Image")));
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowSize = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            this.gridColumn1.Width = 25;
            // 
            // repositoryItemButtonEdit3
            // 
            this.repositoryItemButtonEdit3.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.repositoryItemButtonEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit3.Name = "repositoryItemButtonEdit3";
            this.repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // grb_customer
            // 
            this.grb_customer.Controls.Add(this.label2);
            this.grb_customer.Controls.Add(this.label3);
            this.grb_customer.Controls.Add(this.label1);
            this.grb_customer.Controls.Add(this.textEdit1);
            this.grb_customer.Controls.Add(this.txt_address);
            this.grb_customer.Controls.Add(this.txt_phones);
            this.grb_customer.Controls.Add(this.grb_delivry);
            this.grb_customer.Location = new System.Drawing.Point(8, 122);
            this.grb_customer.Name = "grb_customer";
            this.grb_customer.Size = new System.Drawing.Size(596, 140);
            this.grb_customer.TabIndex = 78;
            this.grb_customer.TabStop = false;
            this.grb_customer.Text = "بيانات العميل";
            this.grb_customer.Enter += new System.EventHandler(this.grb_customer_Enter);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(330, 59);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(254, 20);
            this.textEdit1.TabIndex = 97;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(335, 112);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(255, 20);
            this.txt_address.TabIndex = 99;
            // 
            // txt_phones
            // 
            this.txt_phones.Location = new System.Drawing.Point(6, 57);
            this.txt_phones.Name = "txt_phones";
            this.txt_phones.Size = new System.Drawing.Size(235, 20);
            this.txt_phones.TabIndex = 98;
            // 
            // grb_delivry
            // 
            this.grb_delivry.Controls.Add(this.cmb_delivery);
            this.grb_delivry.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_delivry.Location = new System.Drawing.Point(6, 88);
            this.grb_delivry.Name = "grb_delivry";
            this.grb_delivry.Size = new System.Drawing.Size(251, 45);
            this.grb_delivry.TabIndex = 84;
            this.grb_delivry.TabStop = false;
            this.grb_delivry.Text = "اسم الطيار";
            // 
            // cmb_delivery
            // 
            this.cmb_delivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_delivery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_delivery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_delivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_delivery.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_delivery.FormattingEnabled = true;
            this.cmb_delivery.Location = new System.Drawing.Point(6, 13);
            this.cmb_delivery.Name = "cmb_delivery";
            this.cmb_delivery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_delivery.Size = new System.Drawing.Size(240, 26);
            this.cmb_delivery.TabIndex = 62;
            // 
            // grb_sala
            // 
            this.grb_sala.Controls.Add(this.label8);
            this.grb_sala.Controls.Add(this.cmb_stuff);
            this.grb_sala.Controls.Add(this.cmb_Table);
            this.grb_sala.Controls.Add(this.label_Table);
            this.grb_sala.Location = new System.Drawing.Point(12, 115);
            this.grb_sala.Name = "grb_sala";
            this.grb_sala.Size = new System.Drawing.Size(592, 129);
            this.grb_sala.TabIndex = 85;
            this.grb_sala.TabStop = false;
            this.grb_sala.Text = "بيانات الطاولة";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(444, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 94;
            this.label8.Text = "اسم الكابتن";
            // 
            // cmb_stuff
            // 
            this.cmb_stuff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_stuff.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_stuff.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_stuff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_stuff.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stuff.FormattingEnabled = true;
            this.cmb_stuff.Location = new System.Drawing.Point(83, 81);
            this.cmb_stuff.Name = "cmb_stuff";
            this.cmb_stuff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_stuff.Size = new System.Drawing.Size(345, 32);
            this.cmb_stuff.TabIndex = 77;
            // 
            // cmb_Table
            // 
            this.cmb_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_Table.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Table.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Table.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Table.FormattingEnabled = true;
            this.cmb_Table.Location = new System.Drawing.Point(83, 16);
            this.cmb_Table.Name = "cmb_Table";
            this.cmb_Table.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Table.Size = new System.Drawing.Size(345, 32);
            this.cmb_Table.TabIndex = 76;
            // 
            // label_Table
            // 
            this.label_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Table.AutoSize = true;
            this.label_Table.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Table.Location = new System.Drawing.Point(447, 30);
            this.label_Table.Name = "label_Table";
            this.label_Table.Size = new System.Drawing.Size(65, 18);
            this.label_Table.TabIndex = 61;
            this.label_Table.Text = "رقم الطاولة";
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num.Location = new System.Drawing.Point(727, -2);
            this.txt_num.Name = "txt_num";
            this.txt_num.ReadOnly = true;
            this.txt_num.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_num.Size = new System.Drawing.Size(28, 29);
            this.txt_num.TabIndex = 90;
            this.txt_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cust
            // 
            this.txt_cust.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cust.Location = new System.Drawing.Point(679, -2);
            this.txt_cust.Name = "txt_cust";
            this.txt_cust.ReadOnly = true;
            this.txt_cust.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_cust.Size = new System.Drawing.Size(31, 29);
            this.txt_cust.TabIndex = 89;
            this.txt_cust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lable_Num
            // 
            this.Lable_Num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lable_Num.AutoSize = true;
            this.Lable_Num.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_Num.ForeColor = System.Drawing.Color.Black;
            this.Lable_Num.Location = new System.Drawing.Point(1096, 3);
            this.Lable_Num.Name = "Lable_Num";
            this.Lable_Num.Size = new System.Drawing.Size(0, 22);
            this.Lable_Num.TabIndex = 83;
            // 
            // lable_date
            // 
            this.lable_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lable_date.AutoSize = true;
            this.lable_date.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_date.ForeColor = System.Drawing.Color.Black;
            this.lable_date.Location = new System.Drawing.Point(850, 2);
            this.lable_date.Name = "lable_date";
            this.lable_date.Size = new System.Drawing.Size(50, 22);
            this.lable_date.TabIndex = 91;
            this.lable_date.Text = "date";
            // 
            // txt_delivery
            // 
            this.txt_delivery.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_delivery.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_delivery.ForeColor = System.Drawing.Color.Yellow;
            this.txt_delivery.Location = new System.Drawing.Point(472, 43);
            this.txt_delivery.Multiline = true;
            this.txt_delivery.Name = "txt_delivery";
            this.txt_delivery.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_delivery.Size = new System.Drawing.Size(115, 34);
            this.txt_delivery.TabIndex = 79;
            this.txt_delivery.Text = "0";
            this.txt_delivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_delivery.Click += new System.EventHandler(this.Txt_delivery_Click);
            this.txt_delivery.TextChanged += new System.EventHandler(this.Txt_delivery_TextChanged_1);
            this.txt_delivery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_delivery_KeyDown);
            this.txt_delivery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_delivery_KeyPress);
            this.txt_delivery.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_delivery_KeyUp_1);
            this.txt_delivery.Leave += new System.EventHandler(this.Txt_delivery_Leave_1);
            // 
            // txt_invo
            // 
            this.txt_invo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_invo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invo.ForeColor = System.Drawing.Color.Yellow;
            this.txt_invo.Location = new System.Drawing.Point(19, 36);
            this.txt_invo.Multiline = true;
            this.txt_invo.Name = "txt_invo";
            this.txt_invo.ReadOnly = true;
            this.txt_invo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_invo.Size = new System.Drawing.Size(163, 38);
            this.txt_invo.TabIndex = 71;
            this.txt_invo.Text = "0";
            this.txt_invo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_invo.TextChanged += new System.EventHandler(this.Txt_invo_TextChanged);
            this.txt_invo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_invo_KeyUp);
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox10.Controls.Add(this.label24);
            this.groupBox10.Controls.Add(this.label22);
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.txt_discount);
            this.groupBox10.Controls.Add(this.txt_delivery);
            this.groupBox10.Controls.Add(this.txt_invo);
            this.groupBox10.Location = new System.Drawing.Point(12, 538);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(592, 83);
            this.groupBox10.TabIndex = 84;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "الحسابات";
            // 
            // txt_discount
            // 
            this.txt_discount.BackColor = System.Drawing.SystemColors.ControlText;
            this.txt_discount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.ForeColor = System.Drawing.Color.Yellow;
            this.txt_discount.Location = new System.Drawing.Point(242, 40);
            this.txt_discount.Multiline = true;
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_discount.Size = new System.Drawing.Size(140, 34);
            this.txt_discount.TabIndex = 81;
            this.txt_discount.Text = "0";
            this.txt_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_discount.Click += new System.EventHandler(this.Txt_discount_Click);
            this.txt_discount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_discount_MouseClick);
            this.txt_discount.TextChanged += new System.EventHandler(this.Txt_discount_TextChanged);
            this.txt_discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_discount_KeyPress);
            this.txt_discount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_discount_KeyUp);
            this.txt_discount.Leave += new System.EventHandler(this.Txt_discount_Leave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(610, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(541, 224);
            this.flowLayoutPanel1.TabIndex = 104;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(610, 261);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(541, 476);
            this.flowLayoutPanel2.TabIndex = 105;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // texT
            // 
            this.texT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.texT.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texT.ForeColor = System.Drawing.Color.Yellow;
            this.texT.Location = new System.Drawing.Point(634, 0);
            this.texT.Multiline = true;
            this.texT.Name = "texT";
            this.texT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.texT.Size = new System.Drawing.Size(39, 24);
            this.texT.TabIndex = 106;
            this.texT.Text = "0";
            this.texT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.texT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TexT_KeyUp_1);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rdb_takeaway);
            this.groupControl1.Controls.Add(this.rdb_delivery);
            this.groupControl1.Controls.Add(this.rdb_sala);
            this.groupControl1.Location = new System.Drawing.Point(3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(601, 103);
            this.groupControl1.TabIndex = 118;
            this.groupControl1.Text = "groupControl1";
            // 
            // rdb_takeaway
            // 
            this.rdb_takeaway.AutoSize = true;
            this.rdb_takeaway.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_takeaway.Image = ((System.Drawing.Image)(resources.GetObject("rdb_takeaway.Image")));
            this.rdb_takeaway.Location = new System.Drawing.Point(61, 26);
            this.rdb_takeaway.Name = "rdb_takeaway";
            this.rdb_takeaway.Size = new System.Drawing.Size(92, 71);
            this.rdb_takeaway.TabIndex = 84;
            this.rdb_takeaway.Text = "تيك اواى";
            this.rdb_takeaway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdb_takeaway.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdb_takeaway.UseVisualStyleBackColor = true;
            this.rdb_takeaway.CheckedChanged += new System.EventHandler(this.rdb_takeaway_CheckedChanged_1);
            // 
            // rdb_delivery
            // 
            this.rdb_delivery.AutoSize = true;
            this.rdb_delivery.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_delivery.Image = global::Restuarnt.Properties.Resources.delivery21;
            this.rdb_delivery.Location = new System.Drawing.Point(251, 26);
            this.rdb_delivery.Name = "rdb_delivery";
            this.rdb_delivery.Size = new System.Drawing.Size(77, 73);
            this.rdb_delivery.TabIndex = 86;
            this.rdb_delivery.Text = "دليفرى";
            this.rdb_delivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdb_delivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdb_delivery.UseVisualStyleBackColor = true;
            this.rdb_delivery.CheckedChanged += new System.EventHandler(this.rdb_delivery_CheckedChanged_1);
            // 
            // rdb_sala
            // 
            this.rdb_sala.AutoSize = true;
            this.rdb_sala.Checked = true;
            this.rdb_sala.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_sala.Image = global::Restuarnt.Properties.Resources.restaurant_table_icon_91;
            this.rdb_sala.Location = new System.Drawing.Point(407, 29);
            this.rdb_sala.Name = "rdb_sala";
            this.rdb_sala.Size = new System.Drawing.Size(74, 67);
            this.rdb_sala.TabIndex = 85;
            this.rdb_sala.TabStop = true;
            this.rdb_sala.Text = "صالة";
            this.rdb_sala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdb_sala.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdb_sala.UseVisualStyleBackColor = true;
            this.rdb_sala.CheckedChanged += new System.EventHandler(this.rdb_sala_CheckedChanged_1);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_update.Appearance.BackColor = System.Drawing.Color.Black;
            this.btn_update.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_update.Appearance.Options.UseBackColor = true;
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.Appearance.Options.UseForeColor = true;
            this.btn_update.Appearance.Options.UseTextOptions = true;
            this.btn_update.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_update.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_update.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.Location = new System.Drawing.Point(143, 50);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(327, 37);
            this.btn_update.TabIndex = 124;
            this.btn_update.Text = "حفظ";
            this.btn_update.Click += new System.EventHandler(this.simpleButton3_Click_2);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Red;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Controls.Add(this.btn_update);
            this.groupControl2.Location = new System.Drawing.Point(14, 627);
            this.groupControl2.LookAndFeel.SkinName = "Office 2016 Black";
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(585, 110);
            this.groupControl2.TabIndex = 125;
            this.groupControl2.Text = "groupControl2";
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl4.Controls.Add(this.gridControl2);
            this.groupControl4.Location = new System.Drawing.Point(8, 258);
            this.groupControl4.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.groupControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(596, 274);
            this.groupControl4.TabIndex = 130;
            this.groupControl4.Text = "groupControl4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(427, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 103;
            this.label2.Text = "العنوان";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(83, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 104;
            this.label3.Text = "رقم موبايل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(427, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 102;
            this.label1.Text = "اسم العميل";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Black;
            this.label24.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(62, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 24);
            this.label24.TabIndex = 82;
            this.label24.Text = "الاجمالي";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Black;
            this.label22.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(470, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(110, 25);
            this.label22.TabIndex = 83;
            this.label22.Text = "خدمه توصيل";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(297, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 24);
            this.label7.TabIndex = 84;
            this.label7.Text = "خصم";
            // 
            // Frm_ShowUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1159, 742);
            this.Controls.Add(this.grb_customer);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.txt_cust);
            this.Controls.Add(this.texT);
            this.Controls.Add(this.lable_date);
            this.Controls.Add(this.Lable_Num);
            this.Controls.Add(this.grb_sala);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox10);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(1028, 566);
            this.Name = "Frm_ShowUpdate";
            this.Text = "شاشة الاوردر";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FOrder_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FOrder_FormClosed);
            this.Load += new System.EventHandler(this.FOrder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FOrder_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).EndInit();
            this.grb_customer.ResumeLayout(false);
            this.grb_customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_phones.Properties)).EndInit();
            this.grb_delivry.ResumeLayout(false);
            this.grb_sala.ResumeLayout(false);
            this.grb_sala.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox cmb_Table;
        public System.Windows.Forms.GroupBox grb_customer;
        public System.Windows.Forms.Label label_Table;
        public System.Windows.Forms.GroupBox grb_sala;
        public System.Windows.Forms.TextBox txt_num;
        public System.Windows.Forms.TextBox txt_cust;
        public System.Windows.Forms.Label Lable_Num;
        public System.Windows.Forms.TextBox txt_delivery;
        public System.Windows.Forms.TextBox txt_invo;
        public System.Windows.Forms.GroupBox groupBox10;
        public System.Windows.Forms.TextBox txt_discount;
        public System.Windows.Forms.Label lable_date;
        public System.Windows.Forms.TextBox texT;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cmb_stuff;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.RadioButton rdb_takeaway;
        public System.Windows.Forms.RadioButton rdb_delivery;
        public System.Windows.Forms.RadioButton rdb_sala;
        public DevExpress.XtraEditors.TextEdit txt_address;
        public DevExpress.XtraEditors.TextEdit txt_phones;
        public DevExpress.XtraEditors.TextEdit textEdit1;
        public DevExpress.XtraEditors.SimpleButton btn_update;
        public DevExpress.XtraGrid.GridControl gridControl2;
        public System.Windows.Forms.GroupBox grb_delivry;
        public System.Windows.Forms.ComboBox cmb_delivery;
        private DevExpress.XtraGrid.Columns.GridColumn Neg;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Post;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        public DevExpress.XtraGrid.Columns.GridColumn ID_Dep;
        public DevExpress.XtraGrid.Columns.GridColumn Dep;
        public DevExpress.XtraGrid.Columns.GridColumn ID_Items;
        public DevExpress.XtraGrid.Columns.GridColumn Item_Name;
        public DevExpress.XtraGrid.Columns.GridColumn Price;
        public DevExpress.XtraGrid.Columns.GridColumn quantity;
        public DevExpress.XtraGrid.Columns.GridColumn Total;
        public DevExpress.XtraEditors.GroupControl groupControl1;
        public DevExpress.XtraEditors.GroupControl groupControl2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label label7;
    }
}