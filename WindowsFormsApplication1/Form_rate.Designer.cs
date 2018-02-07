namespace WindowsFormsApplication1
{
    partial class Form_rate
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_costo = new System.Windows.Forms.TextBox();
            this.dgv_rate = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_newRowPagato = new System.Windows.Forms.ComboBox();
            this.dtp_newRowData = new System.Windows.Forms.DateTimePicker();
            this.tb_newRowCosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Costo Abbonamento";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(699, 271);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 19);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Salva";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(628, 271);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(56, 19);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Annulla";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_costo
            // 
            this.tb_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_costo.Location = new System.Drawing.Point(40, 37);
            this.tb_costo.Margin = new System.Windows.Forms.Padding(2);
            this.tb_costo.Name = "tb_costo";
            this.tb_costo.ReadOnly = true;
            this.tb_costo.Size = new System.Drawing.Size(76, 28);
            this.tb_costo.TabIndex = 3;
            // 
            // dgv_rate
            // 
            this.dgv_rate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rate.Location = new System.Drawing.Point(309, 21);
            this.dgv_rate.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_rate.MultiSelect = false;
            this.dgv_rate.Name = "dgv_rate";
            this.dgv_rate.RowTemplate.Height = 24;
            this.dgv_rate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_rate.Size = new System.Drawing.Size(425, 214);
            this.dgv_rate.TabIndex = 6;
            this.dgv_rate.SelectionChanged += new System.EventHandler(this.dgv_rate_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_tip);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.cb_newRowPagato);
            this.groupBox1.Controls.Add(this.dtp_newRowData);
            this.groupBox1.Controls.Add(this.tb_newRowCosto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(245, 209);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuova Rata";
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Location = new System.Drawing.Point(16, 24);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(23, 13);
            this.lbl_tip.TabIndex = 8;
            this.lbl_tip.Text = "tips";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(101, 154);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(56, 26);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(161, 154);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(56, 26);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Aggiungi";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_newRowPagato
            // 
            this.cb_newRowPagato.FormattingEnabled = true;
            this.cb_newRowPagato.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cb_newRowPagato.Location = new System.Drawing.Point(122, 120);
            this.cb_newRowPagato.Margin = new System.Windows.Forms.Padding(2);
            this.cb_newRowPagato.Name = "cb_newRowPagato";
            this.cb_newRowPagato.Size = new System.Drawing.Size(98, 21);
            this.cb_newRowPagato.TabIndex = 5;
            // 
            // dtp_newRowData
            // 
            this.dtp_newRowData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_newRowData.Location = new System.Drawing.Point(122, 92);
            this.dtp_newRowData.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_newRowData.Name = "dtp_newRowData";
            this.dtp_newRowData.Size = new System.Drawing.Size(98, 20);
            this.dtp_newRowData.TabIndex = 4;
            // 
            // tb_newRowCosto
            // 
            this.tb_newRowCosto.Location = new System.Drawing.Point(122, 59);
            this.tb_newRowCosto.Margin = new System.Windows.Forms.Padding(2);
            this.tb_newRowCosto.Name = "tb_newRowCosto";
            this.tb_newRowCosto.Size = new System.Drawing.Size(98, 20);
            this.tb_newRowCosto.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pagato?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Costo";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(309, 240);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(106, 26);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Elimina Selezionata";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form_rate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 296);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_rate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_costo);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_rate";
            this.Text = "Rateizzazione";
            this.Load += new System.EventHandler(this.Form_rate_Load);
            this.Shown += new System.EventHandler(this.Form_rate_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_costo;
        private System.Windows.Forms.DataGridView dgv_rate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_newRowPagato;
        private System.Windows.Forms.DateTimePicker dtp_newRowData;
        private System.Windows.Forms.TextBox tb_newRowCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_tip;
    }
}