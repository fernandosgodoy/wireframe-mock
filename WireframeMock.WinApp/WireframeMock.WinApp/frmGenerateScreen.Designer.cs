
namespace WireframeMock.WinApp
{
    partial class frmGenerateScreen
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.chkRequired = new System.Windows.Forms.CheckBox();
            this.btnInclude = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvFields = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPathInfo = new System.Windows.Forms.Label();
            this.txtPathInfo = new System.Windows.Forms.TextBox();
            this.btnGenerateFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInclude);
            this.groupBox1.Controls.Add(this.chkRequired);
            this.groupBox1.Controls.Add(this.txtClass);
            this.groupBox1.Controls.Add(this.lblClass);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.txtFieldName);
            this.groupBox1.Controls.Add(this.lblFieldName);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(1)";
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Location = new System.Drawing.Point(6, 32);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(95, 16);
            this.lblFieldName.TabIndex = 0;
            this.lblFieldName.Text = "Field Name(*):";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(9, 51);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(174, 23);
            this.txtFieldName.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(186, 32);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(59, 16);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type(*):";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(189, 51);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(148, 24);
            this.cboType.TabIndex = 3;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(343, 51);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(174, 23);
            this.txtClass.TabIndex = 5;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(340, 32);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(66, 16);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Class(es):";
            // 
            // chkRequired
            // 
            this.chkRequired.AutoSize = true;
            this.chkRequired.Location = new System.Drawing.Point(538, 51);
            this.chkRequired.Name = "chkRequired";
            this.chkRequired.Size = new System.Drawing.Size(84, 20);
            this.chkRequired.TabIndex = 6;
            this.chkRequired.Text = "Required?";
            this.chkRequired.UseVisualStyleBackColor = true;
            // 
            // btnInclude
            // 
            this.btnInclude.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInclude.Location = new System.Drawing.Point(893, 13);
            this.btnInclude.Name = "btnInclude";
            this.btnInclude.Size = new System.Drawing.Size(85, 65);
            this.btnInclude.TabIndex = 7;
            this.btnInclude.Text = "Include";
            this.btnInclude.UseVisualStyleBackColor = true;
            this.btnInclude.Click += new System.EventHandler(this.btnInclude_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvFields);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 321);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(2)";
            // 
            // dgvFields
            // 
            this.dgvFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFields.Location = new System.Drawing.Point(6, 22);
            this.dgvFields.Name = "dgvFields";
            this.dgvFields.Size = new System.Drawing.Size(972, 293);
            this.dgvFields.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPathInfo);
            this.groupBox3.Controls.Add(this.lblPathInfo);
            this.groupBox3.Location = new System.Drawing.Point(12, 445);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(984, 82);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(3)";
            // 
            // lblPathInfo
            // 
            this.lblPathInfo.AutoSize = true;
            this.lblPathInfo.Location = new System.Drawing.Point(6, 29);
            this.lblPathInfo.Name = "lblPathInfo";
            this.lblPathInfo.Size = new System.Drawing.Size(134, 16);
            this.lblPathInfo.TabIndex = 0;
            this.lblPathInfo.Text = "Path(*): (must exists)";
            // 
            // txtPathInfo
            // 
            this.txtPathInfo.Location = new System.Drawing.Point(6, 48);
            this.txtPathInfo.Name = "txtPathInfo";
            this.txtPathInfo.Size = new System.Drawing.Size(524, 23);
            this.txtPathInfo.TabIndex = 1;
            // 
            // btnGenerateFile
            // 
            this.btnGenerateFile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateFile.Location = new System.Drawing.Point(12, 533);
            this.btnGenerateFile.Name = "btnGenerateFile";
            this.btnGenerateFile.Size = new System.Drawing.Size(984, 47);
            this.btnGenerateFile.TabIndex = 4;
            this.btnGenerateFile.Text = "Generate File";
            this.btnGenerateFile.UseVisualStyleBackColor = true;
            this.btnGenerateFile.Click += new System.EventHandler(this.btnGenerateFile_Click);
            // 
            // frmGenerateScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 584);
            this.Controls.Add(this.btnGenerateFile);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGenerateScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Screen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.CheckBox chkRequired;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btnInclude;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvFields;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPathInfo;
        private System.Windows.Forms.TextBox txtPathInfo;
        private System.Windows.Forms.Button btnGenerateFile;
    }
}