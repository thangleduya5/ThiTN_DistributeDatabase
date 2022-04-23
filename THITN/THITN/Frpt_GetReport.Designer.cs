
namespace THITN
{
    partial class Frpt_GetReport
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCoso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.deTu = new DevExpress.XtraEditors.DateEdit();
            this.deDen = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.deTu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(752, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Đến ngày:";
            // 
            // cbbCoso
            // 
            this.cbbCoso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCoso.FormattingEnabled = true;
            this.cbbCoso.Items.AddRange(new object[] {
            "CS1",
            "CS2"});
            this.cbbCoso.Location = new System.Drawing.Point(167, 58);
            this.cbbCoso.Name = "cbbCoso";
            this.cbbCoso.Size = new System.Drawing.Size(164, 30);
            this.cbbCoso.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cơ sở";
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(497, 139);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(116, 41);
            this.btnPreview.TabIndex = 14;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // deTu
            // 
            this.deTu.EditValue = null;
            this.deTu.Location = new System.Drawing.Point(486, 59);
            this.deTu.Name = "deTu";
            this.deTu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deTu.Properties.Appearance.Options.UseFont = true;
            this.deTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTu.Size = new System.Drawing.Size(187, 28);
            this.deTu.TabIndex = 16;
            // 
            // deDen
            // 
            this.deDen.EditValue = null;
            this.deDen.Location = new System.Drawing.Point(854, 60);
            this.deDen.Name = "deDen";
            this.deDen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deDen.Properties.Appearance.Options.UseFont = true;
            this.deDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDen.Size = new System.Drawing.Size(159, 28);
            this.deDen.TabIndex = 18;
            // 
            // Frpt_GetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 216);
            this.Controls.Add(this.deDen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deTu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cbbCoso);
            this.Controls.Add(this.label1);
            this.Name = "Frpt_GetReport";
            this.Text = "Frpt_GetReport";
            this.Load += new System.EventHandler(this.Frpt_GetReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deTu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDen.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCoso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreview;
        private DevExpress.XtraEditors.DateEdit deTu;
        private DevExpress.XtraEditors.DateEdit deDen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}