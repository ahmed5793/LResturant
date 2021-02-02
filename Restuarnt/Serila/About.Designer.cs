namespace Restuarnt.Serila
{
    partial class About
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_proudect = new DevExpress.XtraEditors.LabelControl();
            this.txt_Licence = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Day = new DevExpress.XtraEditors.LabelControl();
            this.Txt_key = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.groupControl1.Appearance.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.Txt_key);
            this.groupControl1.Controls.Add(this.Txt_Day);
            this.groupControl1.Controls.Add(this.txt_Licence);
            this.groupControl1.Controls.Add(this.txt_proudect);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(420, 182);
            this.groupControl1.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(55, 153);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Proudect Key";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(55, 117);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Experience Day";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(55, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Licence Type";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(55, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Proudect ID";
            // 
            // txt_proudect
            // 
            this.txt_proudect.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_proudect.Appearance.Options.UseForeColor = true;
            this.txt_proudect.Location = new System.Drawing.Point(196, 44);
            this.txt_proudect.Name = "txt_proudect";
            this.txt_proudect.Size = new System.Drawing.Size(5, 13);
            this.txt_proudect.TabIndex = 11;
            this.txt_proudect.Text = "?";
            // 
            // txt_Licence
            // 
            this.txt_Licence.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_Licence.Appearance.Options.UseForeColor = true;
            this.txt_Licence.Location = new System.Drawing.Point(196, 80);
            this.txt_Licence.Name = "txt_Licence";
            this.txt_Licence.Size = new System.Drawing.Size(5, 13);
            this.txt_Licence.TabIndex = 12;
            this.txt_Licence.Text = "?";
            // 
            // Txt_Day
            // 
            this.Txt_Day.Appearance.ForeColor = System.Drawing.Color.White;
            this.Txt_Day.Appearance.Options.UseForeColor = true;
            this.Txt_Day.Location = new System.Drawing.Point(196, 117);
            this.Txt_Day.Name = "Txt_Day";
            this.Txt_Day.Size = new System.Drawing.Size(5, 13);
            this.Txt_Day.TabIndex = 13;
            this.Txt_Day.Text = "?";
            // 
            // Txt_key
            // 
            this.Txt_key.Appearance.ForeColor = System.Drawing.Color.White;
            this.Txt_key.Appearance.Options.UseForeColor = true;
            this.Txt_key.Location = new System.Drawing.Point(196, 153);
            this.Txt_key.Name = "Txt_key";
            this.Txt_key.Size = new System.Drawing.Size(5, 13);
            this.Txt_key.TabIndex = 14;
            this.Txt_key.Text = "?";
            this.Txt_key.Click += new System.EventHandler(this.Txt_key_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 205);
            this.Controls.Add(this.groupControl1);
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl Txt_key;
        private DevExpress.XtraEditors.LabelControl Txt_Day;
        private DevExpress.XtraEditors.LabelControl txt_Licence;
        private DevExpress.XtraEditors.LabelControl txt_proudect;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}