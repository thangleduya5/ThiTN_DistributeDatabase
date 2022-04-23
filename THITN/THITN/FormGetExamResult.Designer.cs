
namespace THITN
{
    partial class FormGetExamResult
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
            this.cbbBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dSSubject = new THITN.DSSubject();
            this.mONHOC1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOC1TableAdapter = new THITN.DSSubjectTableAdapters.MONHOC1TableAdapter();
            this.tableAdapterManager = new THITN.DSSubjectTableAdapters.TableAdapterManager();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dSSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOC1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbBrand
            // 
            this.cbbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBrand.FormattingEnabled = true;
            this.cbbBrand.Location = new System.Drawing.Point(133, 46);
            this.cbbBrand.Name = "cbbBrand";
            this.cbbBrand.Size = new System.Drawing.Size(273, 31);
            this.cbbBrand.TabIndex = 3;
            this.cbbBrand.SelectedIndexChanged += new System.EventHandler(this.cbbBrand_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cơ sở";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Môn học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã học sinh:";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(214, 132);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(154, 30);
            this.txtMaHS.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(887, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lần:";
            // 
            // cmbLan
            // 
            this.cmbLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLan.FormattingEnabled = true;
            this.cmbLan.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbLan.Location = new System.Drawing.Point(954, 132);
            this.cmbLan.Name = "cmbLan";
            this.cmbLan.Size = new System.Drawing.Size(121, 31);
            this.cmbLan.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dSSubject
            // 
            this.dSSubject.DataSetName = "DSSubject";
            this.dSSubject.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOC1BindingSource
            // 
            this.mONHOC1BindingSource.DataMember = "MONHOC1";
            this.mONHOC1BindingSource.DataSource = this.dSSubject;
            // 
            // mONHOC1TableAdapter
            // 
            this.mONHOC1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.DSSubjectTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataSource = this.mONHOC1BindingSource;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(525, 130);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(271, 31);
            this.cmbMonHoc.TabIndex = 13;
            this.cmbMonHoc.ValueMember = "MAMH";
            // 
            // FormGetExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 286);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbLan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbBrand);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGetExamResult";
            this.Text = "frpt_GetExamResult";
            this.Load += new System.EventHandler(this.frpt_GetExamResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOC1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLan;
        private System.Windows.Forms.Button button1;
        private DSSubject dSSubject;
        private System.Windows.Forms.BindingSource mONHOC1BindingSource;
        private DSSubjectTableAdapters.MONHOC1TableAdapter mONHOC1TableAdapter;
        private DSSubjectTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbMonHoc;
    }
}