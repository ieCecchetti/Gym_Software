namespace WindowsFormsApplication1
{
    partial class Form_NewCorso
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
            this.cb_selOp = new System.Windows.Forms.ComboBox();
            this.gb_modify = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_modify = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dataFineMod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_dataInMod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NomeMod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_selCorsoMod = new System.Windows.Forms.ComboBox();
            this.btn_chiudi = new System.Windows.Forms.Button();
            this.gb_add = new System.Windows.Forms.GroupBox();
            this.dtp_dataFineAdd = new System.Windows.Forms.DateTimePicker();
            this.dtp_dataInAdd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_NomeAdd = new System.Windows.Forms.TextBox();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.gb_delete = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_dataFineDel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_dataInDel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_NomeDel = new System.Windows.Forms.TextBox();
            this.btn_elimina = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_selCorsoDel = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_modify.SuspendLayout();
            this.gb_add.SuspendLayout();
            this.gb_delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleziona operazione";
            // 
            // cb_selOp
            // 
            this.cb_selOp.FormattingEnabled = true;
            this.cb_selOp.Items.AddRange(new object[] {
            "Modifica Corso",
            "Elimina Corso",
            "Aggiungi Corso "});
            this.cb_selOp.Location = new System.Drawing.Point(61, 53);
            this.cb_selOp.Margin = new System.Windows.Forms.Padding(2);
            this.cb_selOp.Name = "cb_selOp";
            this.cb_selOp.Size = new System.Drawing.Size(135, 21);
            this.cb_selOp.TabIndex = 1;
            this.cb_selOp.SelectedIndexChanged += new System.EventHandler(this.cb_selOp_SelectedIndexChanged);
            // 
            // gb_modify
            // 
            this.gb_modify.Controls.Add(this.label15);
            this.gb_modify.Controls.Add(this.label14);
            this.gb_modify.Controls.Add(this.btn_modify);
            this.gb_modify.Controls.Add(this.label5);
            this.gb_modify.Controls.Add(this.tb_dataFineMod);
            this.gb_modify.Controls.Add(this.label4);
            this.gb_modify.Controls.Add(this.tb_dataInMod);
            this.gb_modify.Controls.Add(this.label3);
            this.gb_modify.Controls.Add(this.tb_NomeMod);
            this.gb_modify.Controls.Add(this.label2);
            this.gb_modify.Controls.Add(this.cb_selCorsoMod);
            this.gb_modify.Location = new System.Drawing.Point(37, 97);
            this.gb_modify.Margin = new System.Windows.Forms.Padding(2);
            this.gb_modify.Name = "gb_modify";
            this.gb_modify.Padding = new System.Windows.Forms.Padding(2);
            this.gb_modify.Size = new System.Drawing.Size(210, 200);
            this.gb_modify.TabIndex = 4;
            this.gb_modify.TabStop = false;
            this.gb_modify.Text = "Modifica Corso";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(192, 141);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(192, 115);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "*";
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(126, 167);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(62, 28);
            this.btn_modify.TabIndex = 8;
            this.btn_modify.Text = "Modifica";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data Fine";
            // 
            // tb_dataFineMod
            // 
            this.tb_dataFineMod.Location = new System.Drawing.Point(112, 141);
            this.tb_dataFineMod.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dataFineMod.Name = "tb_dataFineMod";
            this.tb_dataFineMod.Size = new System.Drawing.Size(76, 20);
            this.tb_dataFineMod.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data Inizio";
            // 
            // tb_dataInMod
            // 
            this.tb_dataInMod.Location = new System.Drawing.Point(112, 115);
            this.tb_dataInMod.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dataInMod.Name = "tb_dataInMod";
            this.tb_dataInMod.Size = new System.Drawing.Size(76, 20);
            this.tb_dataInMod.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            // 
            // tb_NomeMod
            // 
            this.tb_NomeMod.Location = new System.Drawing.Point(112, 87);
            this.tb_NomeMod.Margin = new System.Windows.Forms.Padding(2);
            this.tb_NomeMod.Name = "tb_NomeMod";
            this.tb_NomeMod.Size = new System.Drawing.Size(76, 20);
            this.tb_NomeMod.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleziona corso";
            // 
            // cb_selCorsoMod
            // 
            this.cb_selCorsoMod.FormattingEnabled = true;
            this.cb_selCorsoMod.Location = new System.Drawing.Point(24, 50);
            this.cb_selCorsoMod.Margin = new System.Windows.Forms.Padding(2);
            this.cb_selCorsoMod.Name = "cb_selCorsoMod";
            this.cb_selCorsoMod.Size = new System.Drawing.Size(144, 21);
            this.cb_selCorsoMod.TabIndex = 0;
            this.cb_selCorsoMod.SelectedIndexChanged += new System.EventHandler(this.cb_selCorsoMod_SelectedIndexChanged);
            // 
            // btn_chiudi
            // 
            this.btn_chiudi.Location = new System.Drawing.Point(429, 462);
            this.btn_chiudi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_chiudi.Name = "btn_chiudi";
            this.btn_chiudi.Size = new System.Drawing.Size(56, 19);
            this.btn_chiudi.TabIndex = 5;
            this.btn_chiudi.Text = "Chiudi";
            this.btn_chiudi.UseVisualStyleBackColor = true;
            this.btn_chiudi.Click += new System.EventHandler(this.btn_chiudi_Click);
            // 
            // gb_add
            // 
            this.gb_add.Controls.Add(this.dtp_dataFineAdd);
            this.gb_add.Controls.Add(this.dtp_dataInAdd);
            this.gb_add.Controls.Add(this.label9);
            this.gb_add.Controls.Add(this.label10);
            this.gb_add.Controls.Add(this.label11);
            this.gb_add.Controls.Add(this.tb_NomeAdd);
            this.gb_add.Controls.Add(this.btn_aggiungi);
            this.gb_add.Location = new System.Drawing.Point(37, 308);
            this.gb_add.Margin = new System.Windows.Forms.Padding(2);
            this.gb_add.Name = "gb_add";
            this.gb_add.Padding = new System.Windows.Forms.Padding(2);
            this.gb_add.Size = new System.Drawing.Size(439, 132);
            this.gb_add.TabIndex = 9;
            this.gb_add.TabStop = false;
            this.gb_add.Text = "Aggiungi Corso";
            // 
            // dtp_dataFineAdd
            // 
            this.dtp_dataFineAdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataFineAdd.Location = new System.Drawing.Point(112, 76);
            this.dtp_dataFineAdd.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_dataFineAdd.Name = "dtp_dataFineAdd";
            this.dtp_dataFineAdd.Size = new System.Drawing.Size(151, 20);
            this.dtp_dataFineAdd.TabIndex = 16;
            // 
            // dtp_dataInAdd
            // 
            this.dtp_dataInAdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataInAdd.Location = new System.Drawing.Point(112, 50);
            this.dtp_dataInAdd.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_dataInAdd.Name = "dtp_dataInAdd";
            this.dtp_dataInAdd.Size = new System.Drawing.Size(151, 20);
            this.dtp_dataInAdd.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Data Fine";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Data Inizio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nome";
            // 
            // tb_NomeAdd
            // 
            this.tb_NomeAdd.Location = new System.Drawing.Point(112, 27);
            this.tb_NomeAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tb_NomeAdd.Name = "tb_NomeAdd";
            this.tb_NomeAdd.Size = new System.Drawing.Size(76, 20);
            this.tb_NomeAdd.TabIndex = 9;
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.Location = new System.Drawing.Point(355, 100);
            this.btn_aggiungi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(62, 28);
            this.btn_aggiungi.TabIndex = 8;
            this.btn_aggiungi.Text = "Aggiungi";
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click);
            // 
            // gb_delete
            // 
            this.gb_delete.Controls.Add(this.label17);
            this.gb_delete.Controls.Add(this.label16);
            this.gb_delete.Controls.Add(this.label6);
            this.gb_delete.Controls.Add(this.tb_dataFineDel);
            this.gb_delete.Controls.Add(this.label7);
            this.gb_delete.Controls.Add(this.tb_dataInDel);
            this.gb_delete.Controls.Add(this.label8);
            this.gb_delete.Controls.Add(this.tb_NomeDel);
            this.gb_delete.Controls.Add(this.btn_elimina);
            this.gb_delete.Controls.Add(this.label13);
            this.gb_delete.Controls.Add(this.cb_selCorsoDel);
            this.gb_delete.Location = new System.Drawing.Point(266, 97);
            this.gb_delete.Margin = new System.Windows.Forms.Padding(2);
            this.gb_delete.Name = "gb_delete";
            this.gb_delete.Padding = new System.Windows.Forms.Padding(2);
            this.gb_delete.Size = new System.Drawing.Size(210, 200);
            this.gb_delete.TabIndex = 9;
            this.gb_delete.TabStop = false;
            this.gb_delete.Text = "Elimina Corso";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(196, 145);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(196, 117);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data Fine";
            // 
            // tb_dataFineDel
            // 
            this.tb_dataFineDel.Location = new System.Drawing.Point(112, 143);
            this.tb_dataFineDel.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dataFineDel.Name = "tb_dataFineDel";
            this.tb_dataFineDel.ReadOnly = true;
            this.tb_dataFineDel.Size = new System.Drawing.Size(76, 20);
            this.tb_dataFineDel.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data Inizio";
            // 
            // tb_dataInDel
            // 
            this.tb_dataInDel.Location = new System.Drawing.Point(112, 117);
            this.tb_dataInDel.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dataInDel.Name = "tb_dataInDel";
            this.tb_dataInDel.ReadOnly = true;
            this.tb_dataInDel.Size = new System.Drawing.Size(76, 20);
            this.tb_dataInDel.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nome";
            // 
            // tb_NomeDel
            // 
            this.tb_NomeDel.Location = new System.Drawing.Point(112, 89);
            this.tb_NomeDel.Margin = new System.Windows.Forms.Padding(2);
            this.tb_NomeDel.Name = "tb_NomeDel";
            this.tb_NomeDel.ReadOnly = true;
            this.tb_NomeDel.Size = new System.Drawing.Size(76, 20);
            this.tb_NomeDel.TabIndex = 9;
            // 
            // btn_elimina
            // 
            this.btn_elimina.Location = new System.Drawing.Point(126, 167);
            this.btn_elimina.Margin = new System.Windows.Forms.Padding(2);
            this.btn_elimina.Name = "btn_elimina";
            this.btn_elimina.Size = new System.Drawing.Size(62, 28);
            this.btn_elimina.TabIndex = 8;
            this.btn_elimina.Text = "Elimina";
            this.btn_elimina.UseVisualStyleBackColor = true;
            this.btn_elimina.Click += new System.EventHandler(this.btn_elimina_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Seleziona corso";
            // 
            // cb_selCorsoDel
            // 
            this.cb_selCorsoDel.FormattingEnabled = true;
            this.cb_selCorsoDel.Location = new System.Drawing.Point(24, 50);
            this.cb_selCorsoDel.Margin = new System.Windows.Forms.Padding(2);
            this.cb_selCorsoDel.Name = "cb_selCorsoDel";
            this.cb_selCorsoDel.Size = new System.Drawing.Size(144, 21);
            this.cb_selCorsoDel.TabIndex = 0;
            this.cb_selCorsoDel.SelectedIndexChanged += new System.EventHandler(this.cb_selCorsoDel_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(34, 453);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(327, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "*Le date contrassegnate devono rispettare il formato AAAA-MM-GG ";
            // 
            // Form_NewCorso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 491);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gb_delete);
            this.Controls.Add(this.gb_add);
            this.Controls.Add(this.btn_chiudi);
            this.Controls.Add(this.gb_modify);
            this.Controls.Add(this.cb_selOp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_NewCorso";
            this.Text = "Corsi";
            this.Load += new System.EventHandler(this.Form_NewCorso_Load);
            this.gb_modify.ResumeLayout(false);
            this.gb_modify.PerformLayout();
            this.gb_add.ResumeLayout(false);
            this.gb_add.PerformLayout();
            this.gb_delete.ResumeLayout(false);
            this.gb_delete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_selOp;
        private System.Windows.Forms.GroupBox gb_modify;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dataFineMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_dataInMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_NomeMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_selCorsoMod;
        private System.Windows.Forms.Button btn_chiudi;
        private System.Windows.Forms.GroupBox gb_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_NomeAdd;
        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.GroupBox gb_delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_dataFineDel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_dataInDel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_NomeDel;
        private System.Windows.Forms.Button btn_elimina;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_selCorsoDel;
        private System.Windows.Forms.DateTimePicker dtp_dataFineAdd;
        private System.Windows.Forms.DateTimePicker dtp_dataInAdd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
    }
}