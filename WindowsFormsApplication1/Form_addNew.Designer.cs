namespace WindowsFormsApplication1
{
    partial class Form_addNew
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_codFisc = new System.Windows.Forms.TextBox();
            this.dtp_dataN = new System.Windows.Forms.DateTimePicker();
            this.lbl_codFisc = new System.Windows.Forms.Label();
            this.tb_cognome = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lbl_dataN = new System.Windows.Forms.Label();
            this.lbl_cognome = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.tb_recapito = new System.Windows.Forms.TextBox();
            this.tb_via = new System.Windows.Forms.TextBox();
            this.tb_residenza = new System.Windows.Forms.TextBox();
            this.lbl_recapito = new System.Windows.Forms.Label();
            this.lbl_via = new System.Windows.Forms.Label();
            this.lbl_residenza = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_rate = new System.Windows.Forms.Button();
            this.nud_Ningressi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_selezionaCorsi = new System.Windows.Forms.Label();
            this.dgv_selCorsi = new System.Windows.Forms.DataGridView();
            this.tb_costo = new System.Windows.Forms.TextBox();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.lbl_nInggressi = new System.Windows.Forms.Label();
            this.dtp_dataFin = new System.Windows.Forms.DateTimePicker();
            this.dtp_dataIn = new System.Windows.Forms.DateTimePicker();
            this.lbl_dataFine = new System.Windows.Forms.Label();
            this.lbl_dataIn = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_annulla = new System.Windows.Forms.Button();
            this.pb_userImage = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtp_scadenzaCert = new System.Windows.Forms.DateTimePicker();
            this.lbl_cert = new System.Windows.Forms.Label();
            this.cb_certificato = new System.Windows.Forms.CheckBox();
            this.tb_nTessera = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Ningressi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selCorsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userImage)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_codFisc);
            this.groupBox1.Controls.Add(this.dtp_dataN);
            this.groupBox1.Controls.Add(this.lbl_codFisc);
            this.groupBox1.Controls.Add(this.tb_cognome);
            this.groupBox1.Controls.Add(this.tb_nome);
            this.groupBox1.Controls.Add(this.lbl_dataN);
            this.groupBox1.Controls.Add(this.lbl_cognome);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Location = new System.Drawing.Point(194, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(334, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informazioni Iniziali";
            // 
            // tb_codFisc
            // 
            this.tb_codFisc.Location = new System.Drawing.Point(161, 99);
            this.tb_codFisc.Margin = new System.Windows.Forms.Padding(2);
            this.tb_codFisc.Name = "tb_codFisc";
            this.tb_codFisc.Size = new System.Drawing.Size(152, 20);
            this.tb_codFisc.TabIndex = 12;
            // 
            // dtp_dataN
            // 
            this.dtp_dataN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataN.Location = new System.Drawing.Point(161, 73);
            this.dtp_dataN.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_dataN.Name = "dtp_dataN";
            this.dtp_dataN.Size = new System.Drawing.Size(152, 20);
            this.dtp_dataN.TabIndex = 5;
            // 
            // lbl_codFisc
            // 
            this.lbl_codFisc.AutoSize = true;
            this.lbl_codFisc.Location = new System.Drawing.Point(15, 102);
            this.lbl_codFisc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codFisc.Name = "lbl_codFisc";
            this.lbl_codFisc.Size = new System.Drawing.Size(45, 13);
            this.lbl_codFisc.TabIndex = 11;
            this.lbl_codFisc.Text = "CodFisc";
            // 
            // tb_cognome
            // 
            this.tb_cognome.Location = new System.Drawing.Point(161, 48);
            this.tb_cognome.Margin = new System.Windows.Forms.Padding(2);
            this.tb_cognome.Name = "tb_cognome";
            this.tb_cognome.Size = new System.Drawing.Size(152, 20);
            this.tb_cognome.TabIndex = 4;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(161, 23);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(152, 20);
            this.tb_nome.TabIndex = 3;
            // 
            // lbl_dataN
            // 
            this.lbl_dataN.AutoSize = true;
            this.lbl_dataN.Location = new System.Drawing.Point(15, 77);
            this.lbl_dataN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dataN.Name = "lbl_dataN";
            this.lbl_dataN.Size = new System.Drawing.Size(69, 13);
            this.lbl_dataN.TabIndex = 2;
            this.lbl_dataN.Text = "Data Nascita";
            // 
            // lbl_cognome
            // 
            this.lbl_cognome.AutoSize = true;
            this.lbl_cognome.Location = new System.Drawing.Point(15, 51);
            this.lbl_cognome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cognome.Name = "lbl_cognome";
            this.lbl_cognome.Size = new System.Drawing.Size(52, 13);
            this.lbl_cognome.TabIndex = 1;
            this.lbl_cognome.Text = "Cognome";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(15, 25);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_mail);
            this.groupBox2.Controls.Add(this.lbl_mail);
            this.groupBox2.Controls.Add(this.tb_recapito);
            this.groupBox2.Controls.Add(this.tb_via);
            this.groupBox2.Controls.Add(this.tb_residenza);
            this.groupBox2.Controls.Add(this.lbl_recapito);
            this.groupBox2.Controls.Add(this.lbl_via);
            this.groupBox2.Controls.Add(this.lbl_residenza);
            this.groupBox2.Location = new System.Drawing.Point(194, 163);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(334, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contatti";
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(161, 101);
            this.tb_mail.Margin = new System.Windows.Forms.Padding(2);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(152, 20);
            this.tb_mail.TabIndex = 10;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(15, 103);
            this.lbl_mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(32, 13);
            this.lbl_mail.TabIndex = 9;
            this.lbl_mail.Text = "Email";
            // 
            // tb_recapito
            // 
            this.tb_recapito.Location = new System.Drawing.Point(161, 75);
            this.tb_recapito.Margin = new System.Windows.Forms.Padding(2);
            this.tb_recapito.Name = "tb_recapito";
            this.tb_recapito.Size = new System.Drawing.Size(152, 20);
            this.tb_recapito.TabIndex = 8;
            // 
            // tb_via
            // 
            this.tb_via.Location = new System.Drawing.Point(161, 49);
            this.tb_via.Margin = new System.Windows.Forms.Padding(2);
            this.tb_via.Name = "tb_via";
            this.tb_via.Size = new System.Drawing.Size(152, 20);
            this.tb_via.TabIndex = 7;
            // 
            // tb_residenza
            // 
            this.tb_residenza.Location = new System.Drawing.Point(161, 24);
            this.tb_residenza.Margin = new System.Windows.Forms.Padding(2);
            this.tb_residenza.Name = "tb_residenza";
            this.tb_residenza.Size = new System.Drawing.Size(152, 20);
            this.tb_residenza.TabIndex = 6;
            // 
            // lbl_recapito
            // 
            this.lbl_recapito.AutoSize = true;
            this.lbl_recapito.Location = new System.Drawing.Point(15, 77);
            this.lbl_recapito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_recapito.Name = "lbl_recapito";
            this.lbl_recapito.Size = new System.Drawing.Size(95, 13);
            this.lbl_recapito.TabIndex = 5;
            this.lbl_recapito.Text = "Recapito(Cell/Tell)";
            // 
            // lbl_via
            // 
            this.lbl_via.AutoSize = true;
            this.lbl_via.Location = new System.Drawing.Point(15, 51);
            this.lbl_via.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_via.Name = "lbl_via";
            this.lbl_via.Size = new System.Drawing.Size(22, 13);
            this.lbl_via.TabIndex = 4;
            this.lbl_via.Text = "Via";
            // 
            // lbl_residenza
            // 
            this.lbl_residenza.AutoSize = true;
            this.lbl_residenza.Location = new System.Drawing.Point(15, 28);
            this.lbl_residenza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_residenza.Name = "lbl_residenza";
            this.lbl_residenza.Size = new System.Drawing.Size(57, 13);
            this.lbl_residenza.TabIndex = 3;
            this.lbl_residenza.Text = "Residenza";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_nTessera);
            this.groupBox3.Controls.Add(this.btn_rate);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.nud_Ningressi);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lbl_selezionaCorsi);
            this.groupBox3.Controls.Add(this.dgv_selCorsi);
            this.groupBox3.Controls.Add(this.tb_costo);
            this.groupBox3.Controls.Add(this.lbl_costo);
            this.groupBox3.Controls.Add(this.lbl_nInggressi);
            this.groupBox3.Controls.Add(this.dtp_dataFin);
            this.groupBox3.Controls.Add(this.dtp_dataIn);
            this.groupBox3.Controls.Add(this.lbl_dataFine);
            this.groupBox3.Controls.Add(this.lbl_dataIn);
            this.groupBox3.Location = new System.Drawing.Point(44, 352);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(680, 236);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Abbonamento";
            // 
            // btn_rate
            // 
            this.btn_rate.Location = new System.Drawing.Point(294, 176);
            this.btn_rate.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rate.Name = "btn_rate";
            this.btn_rate.Size = new System.Drawing.Size(56, 19);
            this.btn_rate.TabIndex = 21;
            this.btn_rate.Text = "Rate";
            this.btn_rate.UseVisualStyleBackColor = true;
            this.btn_rate.Click += new System.EventHandler(this.btn_rate_Click);
            // 
            // nud_Ningressi
            // 
            this.nud_Ningressi.Location = new System.Drawing.Point(179, 130);
            this.nud_Ningressi.Margin = new System.Windows.Forms.Padding(2);
            this.nud_Ningressi.Name = "nud_Ningressi";
            this.nud_Ningressi.Size = new System.Drawing.Size(152, 20);
            this.nud_Ningressi.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "(€)";
            // 
            // lbl_selezionaCorsi
            // 
            this.lbl_selezionaCorsi.AutoSize = true;
            this.lbl_selezionaCorsi.Location = new System.Drawing.Point(383, 28);
            this.lbl_selezionaCorsi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_selezionaCorsi.Name = "lbl_selezionaCorsi";
            this.lbl_selezionaCorsi.Size = new System.Drawing.Size(78, 13);
            this.lbl_selezionaCorsi.TabIndex = 18;
            this.lbl_selezionaCorsi.Text = "Seleziona corsi";
            // 
            // dgv_selCorsi
            // 
            this.dgv_selCorsi.AllowUserToAddRows = false;
            this.dgv_selCorsi.AllowUserToDeleteRows = false;
            this.dgv_selCorsi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_selCorsi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_selCorsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_selCorsi.Location = new System.Drawing.Point(386, 52);
            this.dgv_selCorsi.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_selCorsi.Name = "dgv_selCorsi";
            this.dgv_selCorsi.RowTemplate.Height = 24;
            this.dgv_selCorsi.Size = new System.Drawing.Size(260, 167);
            this.dgv_selCorsi.TabIndex = 17;
            // 
            // tb_costo
            // 
            this.tb_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_costo.Location = new System.Drawing.Point(179, 166);
            this.tb_costo.Margin = new System.Windows.Forms.Padding(2);
            this.tb_costo.Name = "tb_costo";
            this.tb_costo.Size = new System.Drawing.Size(87, 28);
            this.tb_costo.TabIndex = 16;
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo.Location = new System.Drawing.Point(88, 170);
            this.lbl_costo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(63, 24);
            this.lbl_costo.TabIndex = 15;
            this.lbl_costo.Text = "Costo";
            // 
            // lbl_nInggressi
            // 
            this.lbl_nInggressi.AutoSize = true;
            this.lbl_nInggressi.Location = new System.Drawing.Point(20, 132);
            this.lbl_nInggressi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nInggressi.Name = "lbl_nInggressi";
            this.lbl_nInggressi.Size = new System.Drawing.Size(127, 13);
            this.lbl_nInggressi.TabIndex = 13;
            this.lbl_nInggressi.Text = "Numero ingressi compresi";
            // 
            // dtp_dataFin
            // 
            this.dtp_dataFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataFin.Location = new System.Drawing.Point(179, 102);
            this.dtp_dataFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_dataFin.Name = "dtp_dataFin";
            this.dtp_dataFin.Size = new System.Drawing.Size(152, 20);
            this.dtp_dataFin.TabIndex = 9;
            // 
            // dtp_dataIn
            // 
            this.dtp_dataIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataIn.Location = new System.Drawing.Point(179, 76);
            this.dtp_dataIn.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_dataIn.Name = "dtp_dataIn";
            this.dtp_dataIn.Size = new System.Drawing.Size(152, 20);
            this.dtp_dataIn.TabIndex = 8;
            // 
            // lbl_dataFine
            // 
            this.lbl_dataFine.AutoSize = true;
            this.lbl_dataFine.Location = new System.Drawing.Point(20, 106);
            this.lbl_dataFine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dataFine.Name = "lbl_dataFine";
            this.lbl_dataFine.Size = new System.Drawing.Size(118, 13);
            this.lbl_dataFine.TabIndex = 7;
            this.lbl_dataFine.Text = "Data fine abbonamento";
            // 
            // lbl_dataIn
            // 
            this.lbl_dataIn.AutoSize = true;
            this.lbl_dataIn.Location = new System.Drawing.Point(20, 76);
            this.lbl_dataIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dataIn.Name = "lbl_dataIn";
            this.lbl_dataIn.Size = new System.Drawing.Size(121, 13);
            this.lbl_dataIn.TabIndex = 6;
            this.lbl_dataIn.Text = "Data inizio abbonameno";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(667, 603);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(56, 19);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "Salva";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_annulla
            // 
            this.btn_annulla.Location = new System.Drawing.Point(598, 603);
            this.btn_annulla.Margin = new System.Windows.Forms.Padding(2);
            this.btn_annulla.Name = "btn_annulla";
            this.btn_annulla.Size = new System.Drawing.Size(56, 19);
            this.btn_annulla.TabIndex = 4;
            this.btn_annulla.Text = "Annulla";
            this.btn_annulla.UseVisualStyleBackColor = true;
            this.btn_annulla.Click += new System.EventHandler(this.btn_annulla_Click);
            // 
            // pb_userImage
            // 
            this.pb_userImage.Image = global::WindowsFormsApplication1.Properties.Resources.unknown_user;
            this.pb_userImage.Location = new System.Drawing.Point(44, 38);
            this.pb_userImage.Margin = new System.Windows.Forms.Padding(2);
            this.pb_userImage.Name = "pb_userImage";
            this.pb_userImage.Size = new System.Drawing.Size(94, 103);
            this.pb_userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_userImage.TabIndex = 1;
            this.pb_userImage.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtp_scadenzaCert);
            this.groupBox4.Controls.Add(this.lbl_cert);
            this.groupBox4.Controls.Add(this.cb_certificato);
            this.groupBox4.Location = new System.Drawing.Point(194, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(334, 45);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Certificato";
            // 
            // dtp_scadenzaCert
            // 
            this.dtp_scadenzaCert.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_scadenzaCert.Location = new System.Drawing.Point(161, 13);
            this.dtp_scadenzaCert.Name = "dtp_scadenzaCert";
            this.dtp_scadenzaCert.Size = new System.Drawing.Size(146, 20);
            this.dtp_scadenzaCert.TabIndex = 2;
            // 
            // lbl_cert
            // 
            this.lbl_cert.AutoSize = true;
            this.lbl_cert.Location = new System.Drawing.Point(73, 19);
            this.lbl_cert.Name = "lbl_cert";
            this.lbl_cert.Size = new System.Drawing.Size(55, 13);
            this.lbl_cert.TabIndex = 1;
            this.lbl_cert.Text = "Scadenza";
            // 
            // cb_certificato
            // 
            this.cb_certificato.AutoSize = true;
            this.cb_certificato.Location = new System.Drawing.Point(18, 19);
            this.cb_certificato.Name = "cb_certificato";
            this.cb_certificato.Size = new System.Drawing.Size(15, 14);
            this.cb_certificato.TabIndex = 0;
            this.cb_certificato.UseVisualStyleBackColor = true;
            // 
            // tb_nTessera
            // 
            this.tb_nTessera.Location = new System.Drawing.Point(178, 50);
            this.tb_nTessera.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nTessera.Name = "tb_nTessera";
            this.tb_nTessera.Size = new System.Drawing.Size(153, 20);
            this.tb_nTessera.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ntessera";
            // 
            // Form_addNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 637);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_annulla);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pb_userImage);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_addNew";
            this.Text = "Nuovo Iscritto";
            this.Load += new System.EventHandler(this.Form_addNew_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Ningressi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selCorsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userImage)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb_userImage;
        private System.Windows.Forms.Label lbl_dataN;
        private System.Windows.Forms.Label lbl_cognome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_recapito;
        private System.Windows.Forms.Label lbl_via;
        private System.Windows.Forms.Label lbl_residenza;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_annulla;
        private System.Windows.Forms.DateTimePicker dtp_dataN;
        private System.Windows.Forms.TextBox tb_cognome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_recapito;
        private System.Windows.Forms.TextBox tb_via;
        private System.Windows.Forms.TextBox tb_residenza;
        private System.Windows.Forms.DateTimePicker dtp_dataFin;
        private System.Windows.Forms.DateTimePicker dtp_dataIn;
        private System.Windows.Forms.Label lbl_dataFine;
        private System.Windows.Forms.Label lbl_dataIn;
        private System.Windows.Forms.Label lbl_nInggressi;
        private System.Windows.Forms.TextBox tb_costo;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.Label lbl_selezionaCorsi;
        private System.Windows.Forms.DataGridView dgv_selCorsi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_Ningressi;
        private System.Windows.Forms.Button btn_rate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtp_scadenzaCert;
        private System.Windows.Forms.Label lbl_cert;
        private System.Windows.Forms.CheckBox cb_certificato;
        private System.Windows.Forms.TextBox tb_codFisc;
        private System.Windows.Forms.Label lbl_codFisc;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox tb_nTessera;
        private System.Windows.Forms.Label label2;
    }
}