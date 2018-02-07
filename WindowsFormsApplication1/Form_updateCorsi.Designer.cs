namespace WindowsFormsApplication1
{
    partial class Form_updateCorsi
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
            this.lbl_selezionaCorsi = new System.Windows.Forms.Label();
            this.dgv_selCorsi = new System.Windows.Forms.DataGridView();
            this.btn_salva = new System.Windows.Forms.Button();
            this.btn_annulla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selCorsi)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_selezionaCorsi
            // 
            this.lbl_selezionaCorsi.AutoSize = true;
            this.lbl_selezionaCorsi.Location = new System.Drawing.Point(11, 24);
            this.lbl_selezionaCorsi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_selezionaCorsi.Name = "lbl_selezionaCorsi";
            this.lbl_selezionaCorsi.Size = new System.Drawing.Size(78, 13);
            this.lbl_selezionaCorsi.TabIndex = 20;
            this.lbl_selezionaCorsi.Text = "Seleziona corsi";
            // 
            // dgv_selCorsi
            // 
            this.dgv_selCorsi.AllowUserToAddRows = false;
            this.dgv_selCorsi.AllowUserToDeleteRows = false;
            this.dgv_selCorsi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_selCorsi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_selCorsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_selCorsi.Location = new System.Drawing.Point(14, 48);
            this.dgv_selCorsi.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_selCorsi.Name = "dgv_selCorsi";
            this.dgv_selCorsi.RowTemplate.Height = 24;
            this.dgv_selCorsi.Size = new System.Drawing.Size(260, 167);
            this.dgv_selCorsi.TabIndex = 19;
            // 
            // btn_salva
            // 
            this.btn_salva.Location = new System.Drawing.Point(199, 235);
            this.btn_salva.Name = "btn_salva";
            this.btn_salva.Size = new System.Drawing.Size(75, 23);
            this.btn_salva.TabIndex = 21;
            this.btn_salva.Text = "Salva";
            this.btn_salva.UseVisualStyleBackColor = true;
            this.btn_salva.Click += new System.EventHandler(this.btn_salva_Click);
            // 
            // btn_annulla
            // 
            this.btn_annulla.Location = new System.Drawing.Point(118, 235);
            this.btn_annulla.Name = "btn_annulla";
            this.btn_annulla.Size = new System.Drawing.Size(75, 23);
            this.btn_annulla.TabIndex = 22;
            this.btn_annulla.Text = "Annulla";
            this.btn_annulla.UseVisualStyleBackColor = true;
            this.btn_annulla.Click += new System.EventHandler(this.btn_annulla_Click);
            // 
            // Form_updateCorsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 270);
            this.Controls.Add(this.btn_annulla);
            this.Controls.Add(this.btn_salva);
            this.Controls.Add(this.lbl_selezionaCorsi);
            this.Controls.Add(this.dgv_selCorsi);
            this.Name = "Form_updateCorsi";
            this.Text = "Seleziona Corso";
            this.Load += new System.EventHandler(this.Form_updateCorsi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selCorsi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_selezionaCorsi;
        private System.Windows.Forms.DataGridView dgv_selCorsi;
        private System.Windows.Forms.Button btn_salva;
        private System.Windows.Forms.Button btn_annulla;
    }
}