
namespace THITN
{
    partial class FormGetTranscript
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
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label tENLOPLabel;
            this.cbbTenmh = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSubject = new THITN.DSSubject();
            this.cbbTenlop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSStudent = new THITN.DSStudent();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cbbLanthi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lOPTableAdapter = new THITN.DSStudentTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new THITN.DSStudentTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new THITN.DSSubjectTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager1 = new THITN.DSSubjectTableAdapters.TableAdapterManager();
            tENMHLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENMHLabel.Location = new System.Drawing.Point(496, 156);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(90, 23);
            tENMHLabel.TabIndex = 23;
            tENMHLabel.Text = "TENMH:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(22, 155);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(98, 23);
            tENLOPLabel.TabIndex = 22;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // cbbTenmh
            // 
            this.cbbTenmh.DataSource = this.mONHOCBindingSource;
            this.cbbTenmh.DisplayMember = "TENMH";
            this.cbbTenmh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenmh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenmh.FormattingEnabled = true;
            this.cbbTenmh.Location = new System.Drawing.Point(601, 149);
            this.cbbTenmh.Name = "cbbTenmh";
            this.cbbTenmh.Size = new System.Drawing.Size(259, 30);
            this.cbbTenmh.TabIndex = 25;
            this.cbbTenmh.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dSSubject;
            // 
            // dSSubject
            // 
            this.dSSubject.DataSetName = "DSSubject";
            this.dSSubject.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbTenlop
            // 
            this.cbbTenlop.DataSource = this.lOPBindingSource;
            this.cbbTenlop.DisplayMember = "TENLOP";
            this.cbbTenlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenlop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenlop.FormattingEnabled = true;
            this.cbbTenlop.Location = new System.Drawing.Point(135, 149);
            this.cbbTenlop.Name = "cbbTenlop";
            this.cbbTenlop.Size = new System.Drawing.Size(294, 30);
            this.cbbTenlop.TabIndex = 24;
            this.cbbTenlop.ValueMember = "MALOP";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dSStudent;
            // 
            // dSStudent
            // 
            this.dSStudent.DataSetName = "DSStudent";
            this.dSStudent.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(450, 248);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(147, 41);
            this.btnPreview.TabIndex = 21;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cbbLanthi
            // 
            this.cbbLanthi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLanthi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLanthi.FormattingEnabled = true;
            this.cbbLanthi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbLanthi.Location = new System.Drawing.Point(994, 153);
            this.cbbLanthi.Name = "cbbLanthi";
            this.cbbLanthi.Size = new System.Drawing.Size(121, 30);
            this.cbbLanthi.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(918, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Lần thi:";
            // 
            // cbbBrand
            // 
            this.cbbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBrand.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBrand.FormattingEnabled = true;
            this.cbbBrand.Location = new System.Drawing.Point(126, 53);
            this.cbbBrand.Name = "cbbBrand";
            this.cbbBrand.Size = new System.Drawing.Size(273, 30);
            this.cbbBrand.TabIndex = 18;
            this.cbbBrand.SelectedIndexChanged += new System.EventHandler(this.cbbBrand_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cơ sở";
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.DSStudentTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BANGDIEMTableAdapter = null;
            this.tableAdapterManager1.BODETableAdapter = null;
            this.tableAdapterManager1.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager1.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager1.UpdateOrder = THITN.DSSubjectTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormGetTranscript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 328);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.cbbTenmh);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.cbbTenlop);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cbbLanthi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbBrand);
            this.Controls.Add(this.label1);
            this.Name = "FormGetTranscript";
            this.Text = "FormGetTranscript";
            this.Load += new System.EventHandler(this.FormGetTranscript_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTenmh;
        private System.Windows.Forms.ComboBox cbbTenlop;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cbbLanthi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbBrand;
        private System.Windows.Forms.Label label1;
        private DSStudent dSStudent;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSStudentTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSStudentTableAdapters.TableAdapterManager tableAdapterManager;
        private DSSubject dSSubject;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSSubjectTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSSubjectTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}