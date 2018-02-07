namespace WindowsFormsApplication1
{
    partial class Form_displayInfo
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_pres = new System.Windows.Forms.TextBox();
            this.tb_dataScad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cert = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_dataFine = new System.Windows.Forms.TextBox();
            this.tb_dataIn = new System.Windows.Forms.TextBox();
            this.tb_ingressi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_costo = new System.Windows.Forms.TextBox();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.lbl_nInggressi = new System.Windows.Forms.Label();
            this.lbl_dataFine = new System.Windows.Forms.Label();
            this.lbl_dataIn = new System.Windows.Forms.Label();
            this.dgv_corsi = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_recapito = new System.Windows.Forms.TextBox();
            this.tb_via = new System.Windows.Forms.TextBox();
            this.tb_residenza = new System.Windows.Forms.TextBox();
            this.lbl_recapito = new System.Windows.Forms.Label();
            this.lbl_via = new System.Windows.Forms.Label();
            this.lbl_residenza = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_dataN = new System.Windows.Forms.TextBox();
            this.tb_cognome = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lbl_dataN = new System.Windows.Forms.Label();
            this.lbl_cognome = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_refreshCorsi = new System.Windows.Forms.Button();
            this.btn_corsoMod = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_refreshRate = new System.Windows.Forms.Button();
            this.btn_rateMod = new System.Windows.Forms.Button();
            this.dgv_rate = new System.Windows.Forms.DataGridView();
            this.btn_annulla = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_saveMod = new System.Windows.Forms.Button();
            this.pb_userImage = new System.Windows.Forms.PictureBox();
            this.tb_nTessera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_corsi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_pres);
            this.groupBox4.Controls.Add(this.tb_dataScad);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lbl_cert);
            this.groupBox4.Location = new System.Drawing.Point(534, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 103);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Certificato";
            // 
            // tb_pres
            // 
            this.tb_pres.Enabled = false;
            this.tb_pres.Location = new System.Drawing.Point(65, 23);
            this.tb_pres.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pres.Name = "tb_pres";
            this.tb_pres.Size = new System.Drawing.Size(32, 20);
            this.tb_pres.TabIndex = 8;
            // 
            // tb_dataScad
            // 
            this.tb_dataScad.Enabled = false;
            this.tb_dataScad.Location = new System.Drawing.Point(10, 73);
            this.tb_dataScad.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dataScad.Name = "tb_dataScad";
            this.tb_dataScad.Size = new System.Drawing.Size(152, 20);
            this.tb_dataScad.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Presente?";
            // 
            // lbl_cert
            // 
            this.lbl_cert.AutoSize = true;
            this.lbl_cert.Location = new System.Drawing.Point(8, 50);
            this.lbl_cert.Name = "lbl_cert";
            this.lbl_cert.Size = new System.Drawing.Size(55, 13);
            this.lbl_cert.TabIndex = 1;
            this.lbl_cert.Text = "Scadenza";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_nTessera);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_dataFine);
            this.groupBox3.Controls.Add(this.tb_dataIn);
            this.groupBox3.Controls.Add(this.tb_ingressi);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tb_costo);
            this.groupBox3.Controls.Add(this.lbl_costo);
            this.groupBox3.Controls.Add(this.lbl_nInggressi);
            this.groupBox3.Controls.Add(this.lbl_dataFine);
            this.groupBox3.Controls.Add(this.lbl_dataIn);
            this.groupBox3.Location = new System.Drawing.Point(30, 306);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(351, 236);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Abbonamento";
            // 
            // tb_dataFine
            // 
            this.tb_dataFine.Enabled = false;
            this.tb_dataFine.Location = new System.Drawing.Point(176, 103);
            this.tb_dataFine.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dataFine.Name = "tb_dataFine";
            this.tb_dataFine.Size = new System.Drawing.Size(152, 20);
            this.tb_dataFine.TabIndex = 21;
            // 
            // tb_dataIn
            // 
            this.tb_dataIn.Enabled = false;
            this.tb_dataIn.Location = new System.Drawing.Point(175, 73);
            this.tb_dataIn.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dataIn.Name = "tb_dataIn";
            this.tb_dataIn.Size = new System.Drawing.Size(152, 20);
            this.tb_dataIn.TabIndex = 20;
            // 
            // tb_ingressi
            // 
            this.tb_ingressi.Enabled = false;
            this.tb_ingressi.Location = new System.Drawing.Point(175, 131);
            this.tb_ingressi.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ingressi.Name = "tb_ingressi";
            this.tb_ingressi.Size = new System.Drawing.Size(152, 20);
            this.tb_ingressi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "(€)";
            // 
            // tb_costo
            // 
            this.tb_costo.Enabled = false;
            this.tb_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_costo.Location = new System.Drawing.Point(176, 184);
            this.tb_costo.Margin = new System.Windows.Forms.Padding(2);
            this.tb_costo.Name = "tb_costo";
            this.tb_costo.Size = new System.Drawing.Size(87, 28);
            this.tb_costo.TabIndex = 16;
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo.Location = new System.Drawing.Point(88, 189);
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
            // dgv_corsi
            // 
            this.dgv_corsi.AllowUserToAddRows = false;
            this.dgv_corsi.AllowUserToDeleteRows = false;
            this.dgv_corsi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_corsi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_corsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_corsi.Location = new System.Drawing.Point(18, 17);
            this.dgv_corsi.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_corsi.Name = "dgv_corsi";
            this.dgv_corsi.ReadOnly = true;
            this.dgv_corsi.RowTemplate.Height = 24;
            this.dgv_corsi.Size = new System.Drawing.Size(142, 108);
            this.dgv_corsi.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_recapito);
            this.groupBox2.Controls.Add(this.tb_via);
            this.groupBox2.Controls.Add(this.tb_residenza);
            this.groupBox2.Controls.Add(this.lbl_recapito);
            this.groupBox2.Controls.Add(this.lbl_via);
            this.groupBox2.Controls.Add(this.lbl_residenza);
            this.groupBox2.Location = new System.Drawing.Point(187, 144);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(334, 158);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contatti";
            // 
            // tb_recapito
            // 
            this.tb_recapito.Enabled = false;
            this.tb_recapito.Location = new System.Drawing.Point(161, 82);
            this.tb_recapito.Margin = new System.Windows.Forms.Padding(2);
            this.tb_recapito.Name = "tb_recapito";
            this.tb_recapito.Size = new System.Drawing.Size(152, 20);
            this.tb_recapito.TabIndex = 8;
            // 
            // tb_via
            // 
            this.tb_via.Enabled = false;
            this.tb_via.Location = new System.Drawing.Point(161, 56);
            this.tb_via.Margin = new System.Windows.Forms.Padding(2);
            this.tb_via.Name = "tb_via";
            this.tb_via.Size = new System.Drawing.Size(152, 20);
            this.tb_via.TabIndex = 7;
            // 
            // tb_residenza
            // 
            this.tb_residenza.Enabled = false;
            this.tb_residenza.Location = new System.Drawing.Point(161, 31);
            this.tb_residenza.Margin = new System.Windows.Forms.Padding(2);
            this.tb_residenza.Name = "tb_residenza";
            this.tb_residenza.Size = new System.Drawing.Size(152, 20);
            this.tb_residenza.TabIndex = 6;
            // 
            // lbl_recapito
            // 
            this.lbl_recapito.AutoSize = true;
            this.lbl_recapito.Location = new System.Drawing.Point(15, 84);
            this.lbl_recapito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_recapito.Name = "lbl_recapito";
            this.lbl_recapito.Size = new System.Drawing.Size(95, 13);
            this.lbl_recapito.TabIndex = 5;
            this.lbl_recapito.Text = "Recapito(Cell/Tell)";
            // 
            // lbl_via
            // 
            this.lbl_via.AutoSize = true;
            this.lbl_via.Location = new System.Drawing.Point(15, 58);
            this.lbl_via.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_via.Name = "lbl_via";
            this.lbl_via.Size = new System.Drawing.Size(22, 13);
            this.lbl_via.TabIndex = 4;
            this.lbl_via.Text = "Via";
            // 
            // lbl_residenza
            // 
            this.lbl_residenza.AutoSize = true;
            this.lbl_residenza.Location = new System.Drawing.Point(15, 35);
            this.lbl_residenza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_residenza.Name = "lbl_residenza";
            this.lbl_residenza.Size = new System.Drawing.Size(57, 13);
            this.lbl_residenza.TabIndex = 3;
            this.lbl_residenza.Text = "Residenza";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_dataN);
            this.groupBox1.Controls.Add(this.tb_cognome);
            this.groupBox1.Controls.Add(this.tb_nome);
            this.groupBox1.Controls.Add(this.lbl_dataN);
            this.groupBox1.Controls.Add(this.lbl_cognome);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Location = new System.Drawing.Point(187, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(334, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informazioni Iniziali";
            // 
            // tb_dataN
            // 
            this.tb_dataN.Enabled = false;
            this.tb_dataN.Location = new System.Drawing.Point(161, 73);
            this.tb_dataN.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dataN.Name = "tb_dataN";
            this.tb_dataN.Size = new System.Drawing.Size(152, 20);
            this.tb_dataN.TabIndex = 9;
            // 
            // tb_cognome
            // 
            this.tb_cognome.Enabled = false;
            this.tb_cognome.Location = new System.Drawing.Point(161, 47);
            this.tb_cognome.Margin = new System.Windows.Forms.Padding(2);
            this.tb_cognome.Name = "tb_cognome";
            this.tb_cognome.Size = new System.Drawing.Size(152, 20);
            this.tb_cognome.TabIndex = 4;
            // 
            // tb_nome
            // 
            this.tb_nome.Enabled = false;
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
            this.lbl_cognome.Location = new System.Drawing.Point(15, 50);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_refreshCorsi);
            this.groupBox5.Controls.Add(this.btn_corsoMod);
            this.groupBox5.Controls.Add(this.dgv_corsi);
            this.groupBox5.Location = new System.Drawing.Point(542, 146);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(175, 155);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Corsi";
            // 
            // btn_refreshCorsi
            // 
            this.btn_refreshCorsi.Enabled = false;
            this.btn_refreshCorsi.Location = new System.Drawing.Point(22, 130);
            this.btn_refreshCorsi.Name = "btn_refreshCorsi";
            this.btn_refreshCorsi.Size = new System.Drawing.Size(66, 19);
            this.btn_refreshCorsi.TabIndex = 20;
            this.btn_refreshCorsi.Text = "Aggiorna";
            this.btn_refreshCorsi.UseVisualStyleBackColor = true;
            this.btn_refreshCorsi.Visible = false;
            this.btn_refreshCorsi.Click += new System.EventHandler(this.btn_refreshCorsi_Click);
            // 
            // btn_corsoMod
            // 
            this.btn_corsoMod.Enabled = false;
            this.btn_corsoMod.Location = new System.Drawing.Point(94, 130);
            this.btn_corsoMod.Name = "btn_corsoMod";
            this.btn_corsoMod.Size = new System.Drawing.Size(66, 19);
            this.btn_corsoMod.TabIndex = 18;
            this.btn_corsoMod.Text = "Modifica";
            this.btn_corsoMod.UseVisualStyleBackColor = true;
            this.btn_corsoMod.Visible = false;
            this.btn_corsoMod.Click += new System.EventHandler(this.btn_corsoMod_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_refreshRate);
            this.groupBox6.Controls.Add(this.btn_rateMod);
            this.groupBox6.Controls.Add(this.dgv_rate);
            this.groupBox6.Location = new System.Drawing.Point(396, 306);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(321, 236);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rate";
            // 
            // btn_refreshRate
            // 
            this.btn_refreshRate.Enabled = false;
            this.btn_refreshRate.Location = new System.Drawing.Point(159, 208);
            this.btn_refreshRate.Name = "btn_refreshRate";
            this.btn_refreshRate.Size = new System.Drawing.Size(66, 23);
            this.btn_refreshRate.TabIndex = 21;
            this.btn_refreshRate.Text = "Aggiorna";
            this.btn_refreshRate.UseVisualStyleBackColor = true;
            this.btn_refreshRate.Visible = false;
            this.btn_refreshRate.Click += new System.EventHandler(this.btn_refreshRate_Click);
            // 
            // btn_rateMod
            // 
            this.btn_rateMod.Enabled = false;
            this.btn_rateMod.Location = new System.Drawing.Point(231, 208);
            this.btn_rateMod.Name = "btn_rateMod";
            this.btn_rateMod.Size = new System.Drawing.Size(75, 23);
            this.btn_rateMod.TabIndex = 19;
            this.btn_rateMod.Text = "Modifica";
            this.btn_rateMod.UseVisualStyleBackColor = true;
            this.btn_rateMod.Visible = false;
            this.btn_rateMod.Click += new System.EventHandler(this.btn_rateMod_Click);
            // 
            // dgv_rate
            // 
            this.dgv_rate.AllowUserToAddRows = false;
            this.dgv_rate.AllowUserToDeleteRows = false;
            this.dgv_rate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rate.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_rate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rate.Location = new System.Drawing.Point(20, 21);
            this.dgv_rate.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_rate.Name = "dgv_rate";
            this.dgv_rate.ReadOnly = true;
            this.dgv_rate.RowTemplate.Height = 24;
            this.dgv_rate.Size = new System.Drawing.Size(286, 182);
            this.dgv_rate.TabIndex = 18;
            // 
            // btn_annulla
            // 
            this.btn_annulla.Enabled = false;
            this.btn_annulla.Location = new System.Drawing.Point(668, 552);
            this.btn_annulla.Margin = new System.Windows.Forms.Padding(2);
            this.btn_annulla.Name = "btn_annulla";
            this.btn_annulla.Size = new System.Drawing.Size(75, 24);
            this.btn_annulla.TabIndex = 15;
            this.btn_annulla.Text = "Annulla";
            this.btn_annulla.UseVisualStyleBackColor = true;
            this.btn_annulla.Visible = false;
            this.btn_annulla.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(30, 553);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_modify.TabIndex = 16;
            this.btn_modify.Text = "Modifica";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(111, 553);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Elimina";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_saveMod
            // 
            this.btn_saveMod.Enabled = false;
            this.btn_saveMod.Location = new System.Drawing.Point(588, 553);
            this.btn_saveMod.Name = "btn_saveMod";
            this.btn_saveMod.Size = new System.Drawing.Size(75, 24);
            this.btn_saveMod.TabIndex = 18;
            this.btn_saveMod.Text = "Salva";
            this.btn_saveMod.UseVisualStyleBackColor = true;
            this.btn_saveMod.Visible = false;
            this.btn_saveMod.Click += new System.EventHandler(this.btn_saveMod_Click);
            // 
            // pb_userImage
            // 
            this.pb_userImage.Image = global::WindowsFormsApplication1.Properties.Resources.unknown_user;
            this.pb_userImage.Location = new System.Drawing.Point(30, 37);
            this.pb_userImage.Margin = new System.Windows.Forms.Padding(2);
            this.pb_userImage.Name = "pb_userImage";
            this.pb_userImage.Size = new System.Drawing.Size(94, 103);
            this.pb_userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_userImage.TabIndex = 9;
            this.pb_userImage.TabStop = false;
            // 
            // tb_nTessera
            // 
            this.tb_nTessera.Enabled = false;
            this.tb_nTessera.Location = new System.Drawing.Point(175, 44);
            this.tb_nTessera.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nTessera.Name = "tb_nTessera";
            this.tb_nTessera.Size = new System.Drawing.Size(152, 20);
            this.tb_nTessera.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ntessera";
            // 
            // Form_displayInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.btn_saveMod);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_annulla);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pb_userImage);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_displayInfo";
            this.Text = "Profilo";
            this.Activated += new System.EventHandler(this.Form_displayInfo_Activated);
            this.Load += new System.EventHandler(this.Form_displayInfo_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_corsi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_cert;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_corsi;
        private System.Windows.Forms.TextBox tb_costo;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.Label lbl_nInggressi;
        private System.Windows.Forms.Label lbl_dataFine;
        private System.Windows.Forms.Label lbl_dataIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_recapito;
        private System.Windows.Forms.TextBox tb_via;
        private System.Windows.Forms.TextBox tb_residenza;
        private System.Windows.Forms.Label lbl_recapito;
        private System.Windows.Forms.Label lbl_via;
        private System.Windows.Forms.Label lbl_residenza;
        private System.Windows.Forms.PictureBox pb_userImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_cognome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lbl_dataN;
        private System.Windows.Forms.Label lbl_cognome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgv_rate;
        private System.Windows.Forms.Button btn_annulla;
        private System.Windows.Forms.TextBox tb_dataScad;
        private System.Windows.Forms.TextBox tb_dataFine;
        private System.Windows.Forms.TextBox tb_dataIn;
        private System.Windows.Forms.TextBox tb_ingressi;
        private System.Windows.Forms.TextBox tb_dataN;
        private System.Windows.Forms.TextBox tb_pres;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_saveMod;
        private System.Windows.Forms.Button btn_corsoMod;
        private System.Windows.Forms.Button btn_rateMod;
        private System.Windows.Forms.Button btn_refreshCorsi;
        private System.Windows.Forms.Button btn_refreshRate;
        private System.Windows.Forms.TextBox tb_nTessera;
        private System.Windows.Forms.Label label3;
    }
}