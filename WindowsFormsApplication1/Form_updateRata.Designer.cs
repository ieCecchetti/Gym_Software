namespace WindowsFormsApplication1
{
    partial class Form_updateRata
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
            this.dgv_rate = new System.Windows.Forms.DataGridView();
            this.gb_dettagli = new System.Windows.Forms.GroupBox();
            this.btn_annullaOP = new System.Windows.Forms.Button();
            this.btn_applica = new System.Windows.Forms.Button();
            this.cb_scelta = new System.Windows.Forms.ComboBox();
            this.dtp_dataPagam = new System.Windows.Forms.DateTimePicker();
            this.tb_costo = new System.Windows.Forms.TextBox();
            this.lbl_pagato = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.btn_modifica = new System.Windows.Forms.Button();
            this.btn_cancella = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_dataFine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dataIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_costoTot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_salva = new System.Windows.Forms.Button();
            this.btn_annulla = new System.Windows.Forms.Button();
            this.lbl_modTip = new System.Windows.Forms.Label();
            this.lbl_aggTip = new System.Windows.Forms.Label();
            this.lbl_delTip = new System.Windows.Forms.Label();
            this.lbl_tip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rate)).BeginInit();
            this.gb_dettagli.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_rate
            // 
            this.dgv_rate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rate.Location = new System.Drawing.Point(200, 352);
            this.dgv_rate.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_rate.MultiSelect = false;
            this.dgv_rate.Name = "dgv_rate";
            this.dgv_rate.RowTemplate.Height = 24;
            this.dgv_rate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_rate.Size = new System.Drawing.Size(346, 158);
            this.dgv_rate.TabIndex = 0;
            this.dgv_rate.SelectionChanged += new System.EventHandler(this.dgv_rate_SelectionChanged_1);
            // 
            // gb_dettagli
            // 
            this.gb_dettagli.Controls.Add(this.btn_annullaOP);
            this.gb_dettagli.Controls.Add(this.btn_applica);
            this.gb_dettagli.Controls.Add(this.cb_scelta);
            this.gb_dettagli.Controls.Add(this.dtp_dataPagam);
            this.gb_dettagli.Controls.Add(this.tb_costo);
            this.gb_dettagli.Controls.Add(this.lbl_pagato);
            this.gb_dettagli.Controls.Add(this.lbl_data);
            this.gb_dettagli.Controls.Add(this.lbl_costo);
            this.gb_dettagli.Enabled = false;
            this.gb_dettagli.Location = new System.Drawing.Point(41, 89);
            this.gb_dettagli.Margin = new System.Windows.Forms.Padding(2);
            this.gb_dettagli.Name = "gb_dettagli";
            this.gb_dettagli.Padding = new System.Windows.Forms.Padding(2);
            this.gb_dettagli.Size = new System.Drawing.Size(310, 146);
            this.gb_dettagli.TabIndex = 1;
            this.gb_dettagli.TabStop = false;
            this.gb_dettagli.Text = "Dettagli rata";
            // 
            // btn_annullaOP
            // 
            this.btn_annullaOP.Location = new System.Drawing.Point(96, 108);
            this.btn_annullaOP.Name = "btn_annullaOP";
            this.btn_annullaOP.Size = new System.Drawing.Size(75, 23);
            this.btn_annullaOP.TabIndex = 7;
            this.btn_annullaOP.Text = "Annulla";
            this.btn_annullaOP.UseVisualStyleBackColor = true;
            this.btn_annullaOP.Click += new System.EventHandler(this.btn_annullaOP_Click);
            // 
            // btn_applica
            // 
            this.btn_applica.Location = new System.Drawing.Point(177, 108);
            this.btn_applica.Name = "btn_applica";
            this.btn_applica.Size = new System.Drawing.Size(75, 23);
            this.btn_applica.TabIndex = 6;
            this.btn_applica.Text = "Applica";
            this.btn_applica.UseVisualStyleBackColor = true;
            this.btn_applica.Click += new System.EventHandler(this.btn_applica_Click);
            // 
            // cb_scelta
            // 
            this.cb_scelta.FormattingEnabled = true;
            this.cb_scelta.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cb_scelta.Location = new System.Drawing.Point(130, 82);
            this.cb_scelta.Margin = new System.Windows.Forms.Padding(2);
            this.cb_scelta.Name = "cb_scelta";
            this.cb_scelta.Size = new System.Drawing.Size(122, 21);
            this.cb_scelta.TabIndex = 5;
            // 
            // dtp_dataPagam
            // 
            this.dtp_dataPagam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataPagam.Location = new System.Drawing.Point(130, 54);
            this.dtp_dataPagam.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_dataPagam.Name = "dtp_dataPagam";
            this.dtp_dataPagam.Size = new System.Drawing.Size(122, 20);
            this.dtp_dataPagam.TabIndex = 4;
            // 
            // tb_costo
            // 
            this.tb_costo.Location = new System.Drawing.Point(130, 28);
            this.tb_costo.Margin = new System.Windows.Forms.Padding(2);
            this.tb_costo.Name = "tb_costo";
            this.tb_costo.Size = new System.Drawing.Size(122, 20);
            this.tb_costo.TabIndex = 3;
            // 
            // lbl_pagato
            // 
            this.lbl_pagato.AutoSize = true;
            this.lbl_pagato.Location = new System.Drawing.Point(35, 84);
            this.lbl_pagato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pagato.Name = "lbl_pagato";
            this.lbl_pagato.Size = new System.Drawing.Size(47, 13);
            this.lbl_pagato.TabIndex = 2;
            this.lbl_pagato.Text = "Pagato?";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(35, 58);
            this.lbl_data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(30, 13);
            this.lbl_data.TabIndex = 1;
            this.lbl_data.Text = "Data";
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.Location = new System.Drawing.Point(35, 30);
            this.lbl_costo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(34, 13);
            this.lbl_costo.TabIndex = 0;
            this.lbl_costo.Text = "Costo";
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.Location = new System.Drawing.Point(95, 409);
            this.btn_aggiungi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(101, 26);
            this.btn_aggiungi.TabIndex = 3;
            this.btn_aggiungi.Text = "Aggiungi";
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click);
            // 
            // btn_modifica
            // 
            this.btn_modifica.Location = new System.Drawing.Point(95, 379);
            this.btn_modifica.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modifica.Name = "btn_modifica";
            this.btn_modifica.Size = new System.Drawing.Size(101, 26);
            this.btn_modifica.TabIndex = 2;
            this.btn_modifica.Text = "Modifica";
            this.btn_modifica.UseVisualStyleBackColor = true;
            this.btn_modifica.Click += new System.EventHandler(this.btn_modifica_Click);
            // 
            // btn_cancella
            // 
            this.btn_cancella.Location = new System.Drawing.Point(95, 349);
            this.btn_cancella.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancella.Name = "btn_cancella";
            this.btn_cancella.Size = new System.Drawing.Size(101, 26);
            this.btn_cancella.TabIndex = 4;
            this.btn_cancella.Text = "Cancella";
            this.btn_cancella.UseVisualStyleBackColor = true;
            this.btn_cancella.Click += new System.EventHandler(this.btn_cancella_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(270, 29);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(184, 26);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "Nome Cognome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_dataFine);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_dataIn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_costoTot);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(366, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(310, 146);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Riepilogo abbonamento";
            // 
            // tb_dataFine
            // 
            this.tb_dataFine.Enabled = false;
            this.tb_dataFine.Location = new System.Drawing.Point(130, 85);
            this.tb_dataFine.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dataFine.Name = "tb_dataFine";
            this.tb_dataFine.ReadOnly = true;
            this.tb_dataFine.Size = new System.Drawing.Size(122, 20);
            this.tb_dataFine.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Fine";
            // 
            // tb_dataIn
            // 
            this.tb_dataIn.Enabled = false;
            this.tb_dataIn.Location = new System.Drawing.Point(130, 58);
            this.tb_dataIn.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dataIn.Name = "tb_dataIn";
            this.tb_dataIn.ReadOnly = true;
            this.tb_dataIn.Size = new System.Drawing.Size(122, 20);
            this.tb_dataIn.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Inizio";
            // 
            // tb_costoTot
            // 
            this.tb_costoTot.Enabled = false;
            this.tb_costoTot.Location = new System.Drawing.Point(130, 30);
            this.tb_costoTot.Margin = new System.Windows.Forms.Padding(2);
            this.tb_costoTot.Name = "tb_costoTot";
            this.tb_costoTot.ReadOnly = true;
            this.tb_costoTot.Size = new System.Drawing.Size(122, 20);
            this.tb_costoTot.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Costo Totale";
            // 
            // btn_salva
            // 
            this.btn_salva.Location = new System.Drawing.Point(620, 532);
            this.btn_salva.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salva.Name = "btn_salva";
            this.btn_salva.Size = new System.Drawing.Size(56, 19);
            this.btn_salva.TabIndex = 8;
            this.btn_salva.Text = "Salva";
            this.btn_salva.UseVisualStyleBackColor = true;
            this.btn_salva.Click += new System.EventHandler(this.btn_salva_Click);
            // 
            // btn_annulla
            // 
            this.btn_annulla.Location = new System.Drawing.Point(550, 532);
            this.btn_annulla.Margin = new System.Windows.Forms.Padding(2);
            this.btn_annulla.Name = "btn_annulla";
            this.btn_annulla.Size = new System.Drawing.Size(56, 19);
            this.btn_annulla.TabIndex = 9;
            this.btn_annulla.Text = "Annulla";
            this.btn_annulla.UseVisualStyleBackColor = true;
            this.btn_annulla.Click += new System.EventHandler(this.btn_annulla_Click);
            // 
            // lbl_modTip
            // 
            this.lbl_modTip.AutoSize = true;
            this.lbl_modTip.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_modTip.Location = new System.Drawing.Point(51, 247);
            this.lbl_modTip.Name = "lbl_modTip";
            this.lbl_modTip.Size = new System.Drawing.Size(583, 13);
            this.lbl_modTip.TabIndex = 10;
            this.lbl_modTip.Text = "*Seleziona la rata qua sotto e modificala nell\'apposito spazio \"dettagli rata\". I" +
    "nfine conferma premendo  il bottone \"Applica\"";
            // 
            // lbl_aggTip
            // 
            this.lbl_aggTip.AutoSize = true;
            this.lbl_aggTip.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_aggTip.Location = new System.Drawing.Point(51, 270);
            this.lbl_aggTip.Name = "lbl_aggTip";
            this.lbl_aggTip.Size = new System.Drawing.Size(389, 13);
            this.lbl_aggTip.TabIndex = 11;
            this.lbl_aggTip.Text = "*Compila i campi sopra riportati e premi \"aggiungi\" per aggiungere una nuova rata" +
    "";
            // 
            // lbl_delTip
            // 
            this.lbl_delTip.AutoSize = true;
            this.lbl_delTip.Location = new System.Drawing.Point(51, 295);
            this.lbl_delTip.Name = "lbl_delTip";
            this.lbl_delTip.Size = new System.Drawing.Size(393, 13);
            this.lbl_delTip.TabIndex = 12;
            this.lbl_delTip.Text = "*Seleziona una rata tra quelle elencate e premi il bottone \"Cancella \" per elimin" +
    "arla";
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.ForeColor = System.Drawing.Color.Red;
            this.lbl_tip.Location = new System.Drawing.Point(51, 319);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(294, 13);
            this.lbl_tip.TabIndex = 13;
            this.lbl_tip.Text = "*Nel caso di costo decimale mettere la virgola e NON il punto";
            // 
            // Form_updateRata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 562);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.lbl_delTip);
            this.Controls.Add(this.lbl_aggTip);
            this.Controls.Add(this.lbl_modTip);
            this.Controls.Add(this.btn_annulla);
            this.Controls.Add(this.btn_salva);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_aggiungi);
            this.Controls.Add(this.btn_cancella);
            this.Controls.Add(this.btn_modifica);
            this.Controls.Add(this.gb_dettagli);
            this.Controls.Add(this.dgv_rate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_updateRata";
            this.Text = "Modifica piano rate";
            this.Load += new System.EventHandler(this.Form_updateRata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rate)).EndInit();
            this.gb_dettagli.ResumeLayout(false);
            this.gb_dettagli.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_rate;
        private System.Windows.Forms.GroupBox gb_dettagli;
        private System.Windows.Forms.Button btn_modifica;
        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.Button btn_cancella;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.ComboBox cb_scelta;
        private System.Windows.Forms.DateTimePicker dtp_dataPagam;
        private System.Windows.Forms.TextBox tb_costo;
        private System.Windows.Forms.Label lbl_pagato;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_dataFine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dataIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_costoTot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_salva;
        private System.Windows.Forms.Button btn_annulla;
        private System.Windows.Forms.Label lbl_modTip;
        private System.Windows.Forms.Label lbl_aggTip;
        private System.Windows.Forms.Label lbl_delTip;
        private System.Windows.Forms.Button btn_applica;
        private System.Windows.Forms.Button btn_annullaOP;
        private System.Windows.Forms.Label lbl_tip;
    }
}