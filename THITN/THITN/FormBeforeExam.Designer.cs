
namespace THITN
{
    partial class FormBeforeExam
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbMASV = new System.Windows.Forms.Label();
            this.lbHOTEN = new System.Windows.Forms.Label();
            this.lbTENLOP = new System.Windows.Forms.Label();
            this.lbMALOP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MALOP = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTHOIGIAN = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTRINHDO = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSOCAUTHI = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbMALOP = new System.Windows.Forms.TextBox();
            this.labelMALOP = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.deNGAYTHI = new DevExpress.XtraEditors.DateEdit();
            this.cbbLAN = new System.Windows.Forms.ComboBox();
            this.cbbMONHOC = new System.Windows.Forms.ComboBox();
            this.BDSSubject = new System.Windows.Forms.BindingSource(this.components);
            this.DSSubject = new THITN.DSSubject();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TASubject = new THITN.DSSubjectTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new THITN.DSSubjectTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYTHI.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYTHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMASV);
            this.groupBox1.Controls.Add(this.lbHOTEN);
            this.groupBox1.Controls.Add(this.lbTENLOP);
            this.groupBox1.Controls.Add(this.lbMALOP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MALOP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1147, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // lbMASV
            // 
            this.lbMASV.AutoSize = true;
            this.lbMASV.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMASV.Location = new System.Drawing.Point(643, 31);
            this.lbMASV.Name = "lbMASV";
            this.lbMASV.Size = new System.Drawing.Size(66, 25);
            this.lbMASV.TabIndex = 7;
            this.lbMASV.Text = "label8";
            // 
            // lbHOTEN
            // 
            this.lbHOTEN.AutoSize = true;
            this.lbHOTEN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHOTEN.Location = new System.Drawing.Point(643, 87);
            this.lbHOTEN.Name = "lbHOTEN";
            this.lbHOTEN.Size = new System.Drawing.Size(66, 25);
            this.lbHOTEN.TabIndex = 6;
            this.lbHOTEN.Text = "label7";
            // 
            // lbTENLOP
            // 
            this.lbTENLOP.AutoSize = true;
            this.lbTENLOP.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTENLOP.Location = new System.Drawing.Point(225, 87);
            this.lbTENLOP.Name = "lbTENLOP";
            this.lbTENLOP.Size = new System.Drawing.Size(66, 25);
            this.lbTENLOP.TabIndex = 5;
            this.lbTENLOP.Text = "label6";
            // 
            // lbMALOP
            // 
            this.lbMALOP.AutoSize = true;
            this.lbMALOP.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMALOP.Location = new System.Drawing.Point(225, 31);
            this.lbMALOP.Name = "lbMALOP";
            this.lbMALOP.Size = new System.Drawing.Size(66, 25);
            this.lbMALOP.TabIndex = 4;
            this.lbMALOP.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "TENLOP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "MASV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(516, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "HOTEN:";
            // 
            // MALOP
            // 
            this.MALOP.AutoSize = true;
            this.MALOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MALOP.Location = new System.Drawing.Point(111, 31);
            this.MALOP.Name = "MALOP";
            this.MALOP.Size = new System.Drawing.Size(90, 23);
            this.MALOP.TabIndex = 0;
            this.MALOP.Text = "MALOP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTHOIGIAN);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbTRINHDO);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbSOCAUTHI);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(0, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1147, 207);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lbTHOIGIAN
            // 
            this.lbTHOIGIAN.AutoSize = true;
            this.lbTHOIGIAN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTHOIGIAN.Location = new System.Drawing.Point(914, 62);
            this.lbTHOIGIAN.MinimumSize = new System.Drawing.Size(50, 25);
            this.lbTHOIGIAN.Name = "lbTHOIGIAN";
            this.lbTHOIGIAN.Size = new System.Drawing.Size(50, 25);
            this.lbTHOIGIAN.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(789, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "THOIGIAN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "TRINHDO:";
            // 
            // lbTRINHDO
            // 
            this.lbTRINHDO.AutoSize = true;
            this.lbTRINHDO.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTRINHDO.Location = new System.Drawing.Point(173, 62);
            this.lbTRINHDO.MinimumSize = new System.Drawing.Size(50, 25);
            this.lbTRINHDO.Name = "lbTRINHDO";
            this.lbTRINHDO.Size = new System.Drawing.Size(50, 25);
            this.lbTRINHDO.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(450, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "SOCAUTHI:";
            // 
            // lbSOCAUTHI
            // 
            this.lbSOCAUTHI.AutoSize = true;
            this.lbSOCAUTHI.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSOCAUTHI.Location = new System.Drawing.Point(574, 62);
            this.lbSOCAUTHI.MinimumSize = new System.Drawing.Size(50, 25);
            this.lbSOCAUTHI.Name = "lbSOCAUTHI";
            this.lbSOCAUTHI.Size = new System.Drawing.Size(50, 25);
            this.lbSOCAUTHI.TabIndex = 9;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(454, 146);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 38);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "VAOTHI";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMALOP);
            this.groupBox3.Controls.Add(this.labelMALOP);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.deNGAYTHI);
            this.groupBox3.Controls.Add(this.cbbLAN);
            this.groupBox3.Controls.Add(this.cbbMONHOC);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1147, 221);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // tbMALOP
            // 
            this.tbMALOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMALOP.Location = new System.Drawing.Point(161, 21);
            this.tbMALOP.Name = "tbMALOP";
            this.tbMALOP.Size = new System.Drawing.Size(202, 30);
            this.tbMALOP.TabIndex = 9;
            // 
            // labelMALOP
            // 
            this.labelMALOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMALOP.Location = new System.Drawing.Point(38, 24);
            this.labelMALOP.Name = "labelMALOP";
            this.labelMALOP.Size = new System.Drawing.Size(115, 25);
            this.labelMALOP.TabIndex = 8;
            this.labelMALOP.Text = "MALOP:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(454, 171);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 38);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "TIM KIEM";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // deNGAYTHI
            // 
            this.deNGAYTHI.EditValue = null;
            this.deNGAYTHI.Location = new System.Drawing.Point(656, 95);
            this.deNGAYTHI.Margin = new System.Windows.Forms.Padding(4);
            this.deNGAYTHI.Name = "deNGAYTHI";
            this.deNGAYTHI.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deNGAYTHI.Properties.Appearance.Options.UseFont = true;
            this.deNGAYTHI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNGAYTHI.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNGAYTHI.Size = new System.Drawing.Size(164, 28);
            this.deNGAYTHI.TabIndex = 6;
            // 
            // cbbLAN
            // 
            this.cbbLAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLAN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLAN.FormattingEnabled = true;
            this.cbbLAN.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbLAN.Location = new System.Drawing.Point(979, 95);
            this.cbbLAN.Name = "cbbLAN";
            this.cbbLAN.Size = new System.Drawing.Size(82, 30);
            this.cbbLAN.TabIndex = 5;
            // 
            // cbbMONHOC
            // 
            this.cbbMONHOC.DataSource = this.BDSSubject;
            this.cbbMONHOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMONHOC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMONHOC.FormattingEnabled = true;
            this.cbbMONHOC.Location = new System.Drawing.Point(161, 95);
            this.cbbMONHOC.Name = "cbbMONHOC";
            this.cbbMONHOC.Size = new System.Drawing.Size(286, 30);
            this.cbbMONHOC.TabIndex = 4;
            // 
            // BDSSubject
            // 
            this.BDSSubject.DataMember = "MONHOC";
            this.BDSSubject.DataSource = this.DSSubject;
            // 
            // DSSubject
            // 
            this.DSSubject.DataSetName = "DSSubject";
            this.DSSubject.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "MONHOC:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(532, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 23);
            this.label10.TabIndex = 2;
            this.label10.Tag = "";
            this.label10.Text = "NGAYTHI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(873, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "LANTHI:";
            // 
            // TASubject
            // 
            this.TASubject.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.TASubject;
            this.tableAdapterManager.UpdateOrder = THITN.DSSubjectTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormBeforeExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 579);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBeforeExam";
            this.Text = "FormBeforeExam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBeforeExam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYTHI.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYTHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMASV;
        private System.Windows.Forms.Label lbHOTEN;
        private System.Windows.Forms.Label lbTENLOP;
        private System.Windows.Forms.Label lbMALOP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MALOP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTHOIGIAN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTRINHDO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSOCAUTHI;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearch;
        private DevExpress.XtraEditors.DateEdit deNGAYTHI;
        private System.Windows.Forms.ComboBox cbbLAN;
        private System.Windows.Forms.ComboBox cbbMONHOC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private DSSubject DSSubject;
        private System.Windows.Forms.BindingSource BDSSubject;
        private DSSubjectTableAdapters.MONHOCTableAdapter TASubject;
        private DSSubjectTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbMALOP;
        private System.Windows.Forms.Label labelMALOP;
    }
}