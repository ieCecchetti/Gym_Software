namespace WindowsFormsApplication1
{
    partial class Form_controlDetail
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
            this.lbl_typeOpDescr = new System.Windows.Forms.Label();
            this.dgv_resultRate = new System.Windows.Forms.DataGridView();
            this.btn_chiudi = new System.Windows.Forms.Button();
            this.dgv_resultCert = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultCert)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_typeOpDescr
            // 
            this.lbl_typeOpDescr.AutoSize = true;
            this.lbl_typeOpDescr.Location = new System.Drawing.Point(38, 25);
            this.lbl_typeOpDescr.Name = "lbl_typeOpDescr";
            this.lbl_typeOpDescr.Size = new System.Drawing.Size(24, 13);
            this.lbl_typeOpDescr.TabIndex = 0;
            this.lbl_typeOpDescr.Text = "text";
            // 
            // dgv_resultRate
            // 
            this.dgv_resultRate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_resultRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultRate.Location = new System.Drawing.Point(41, 52);
            this.dgv_resultRate.Name = "dgv_resultRate";
            this.dgv_resultRate.ReadOnly = true;
            this.dgv_resultRate.Size = new System.Drawing.Size(690, 326);
            this.dgv_resultRate.TabIndex = 1;
            this.dgv_resultRate.Visible = false;
            // 
            // btn_chiudi
            // 
            this.btn_chiudi.Location = new System.Drawing.Point(656, 403);
            this.btn_chiudi.Name = "btn_chiudi";
            this.btn_chiudi.Size = new System.Drawing.Size(75, 23);
            this.btn_chiudi.TabIndex = 2;
            this.btn_chiudi.Text = "Chiudi";
            this.btn_chiudi.UseVisualStyleBackColor = true;
            this.btn_chiudi.Click += new System.EventHandler(this.btn_chiudi_Click);
            // 
            // dgv_resultCert
            // 
            this.dgv_resultCert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_resultCert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultCert.Location = new System.Drawing.Point(41, 52);
            this.dgv_resultCert.Name = "dgv_resultCert";
            this.dgv_resultCert.ReadOnly = true;
            this.dgv_resultCert.Size = new System.Drawing.Size(690, 326);
            this.dgv_resultCert.TabIndex = 3;
            this.dgv_resultCert.Visible = false;
            // 
            // Form_controlDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 438);
            this.Controls.Add(this.dgv_resultCert);
            this.Controls.Add(this.btn_chiudi);
            this.Controls.Add(this.dgv_resultRate);
            this.Controls.Add(this.lbl_typeOpDescr);
            this.Name = "Form_controlDetail";
            this.Text = "Risultati";
            this.Activated += new System.EventHandler(this.Form_controlDetail_Activated);
            this.Load += new System.EventHandler(this.Form_controlDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultCert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_typeOpDescr;
        private System.Windows.Forms.DataGridView dgv_resultRate;
        private System.Windows.Forms.Button btn_chiudi;
        private System.Windows.Forms.DataGridView dgv_resultCert;
    }
}