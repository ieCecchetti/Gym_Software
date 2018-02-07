namespace WindowsFormsApplication1
{
    partial class Form_Backup
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
            this.panel_choice = new System.Windows.Forms.Panel();
            this.lbl_choice4 = new System.Windows.Forms.Label();
            this.pb_choice4 = new System.Windows.Forms.PictureBox();
            this.lbl_choice3 = new System.Windows.Forms.Label();
            this.pb_choice3 = new System.Windows.Forms.PictureBox();
            this.lbl_choice2 = new System.Windows.Forms.Label();
            this.pb_choice2 = new System.Windows.Forms.PictureBox();
            this.lbl_choice1 = new System.Windows.Forms.Label();
            this.pb_choice1 = new System.Windows.Forms.PictureBox();
            this.panel_opzioniBackup = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_backupPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_BackupTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nameOpPan1 = new System.Windows.Forms.Label();
            this.btn_chiudi = new System.Windows.Forms.Button();
            this.panel_backupManuale = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_goToBackDir = new System.Windows.Forms.Button();
            this.btn_manualBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nameOpPan2 = new System.Windows.Forms.Label();
            this.panel_caricaDB = new System.Windows.Forms.Panel();
            this.btn_LoadDB = new System.Windows.Forms.Button();
            this.cb_DBlist = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_nameOpPan3 = new System.Windows.Forms.Label();
            this.panel_onlineOp = new System.Windows.Forms.Panel();
            this.lbl_nameOpPan4 = new System.Windows.Forms.Label();
            this.panel_choice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_choice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_choice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_choice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_choice1)).BeginInit();
            this.panel_opzioniBackup.SuspendLayout();
            this.panel_backupManuale.SuspendLayout();
            this.panel_caricaDB.SuspendLayout();
            this.panel_onlineOp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_choice
            // 
            this.panel_choice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_choice.Controls.Add(this.lbl_choice4);
            this.panel_choice.Controls.Add(this.pb_choice4);
            this.panel_choice.Controls.Add(this.lbl_choice3);
            this.panel_choice.Controls.Add(this.pb_choice3);
            this.panel_choice.Controls.Add(this.lbl_choice2);
            this.panel_choice.Controls.Add(this.pb_choice2);
            this.panel_choice.Controls.Add(this.lbl_choice1);
            this.panel_choice.Controls.Add(this.pb_choice1);
            this.panel_choice.Location = new System.Drawing.Point(24, 23);
            this.panel_choice.Name = "panel_choice";
            this.panel_choice.Size = new System.Drawing.Size(200, 328);
            this.panel_choice.TabIndex = 0;
            // 
            // lbl_choice4
            // 
            this.lbl_choice4.AutoSize = true;
            this.lbl_choice4.Location = new System.Drawing.Point(30, 156);
            this.lbl_choice4.Name = "lbl_choice4";
            this.lbl_choice4.Size = new System.Drawing.Size(124, 13);
            this.lbl_choice4.TabIndex = 7;
            this.lbl_choice4.Text = "Salva/Repristina Cartella";
            this.lbl_choice4.Click += new System.EventHandler(this.lbl_choice4_Click);
            // 
            // pb_choice4
            // 
            this.pb_choice4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_choice4.Location = new System.Drawing.Point(0, 137);
            this.pb_choice4.Name = "pb_choice4";
            this.pb_choice4.Size = new System.Drawing.Size(197, 50);
            this.pb_choice4.TabIndex = 6;
            this.pb_choice4.TabStop = false;
            this.pb_choice4.Click += new System.EventHandler(this.pb_choice4_Click);
            this.pb_choice4.MouseLeave += new System.EventHandler(this.pb_choice4_MouseLeave);
            this.pb_choice4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_choice4_MouseMove);
            // 
            // lbl_choice3
            // 
            this.lbl_choice3.AutoSize = true;
            this.lbl_choice3.Location = new System.Drawing.Point(63, 108);
            this.lbl_choice3.Name = "lbl_choice3";
            this.lbl_choice3.Size = new System.Drawing.Size(55, 13);
            this.lbl_choice3.TabIndex = 7;
            this.lbl_choice3.Text = "Carica DB";
            this.lbl_choice3.Click += new System.EventHandler(this.lbl_choice3_Click);
            // 
            // pb_choice3
            // 
            this.pb_choice3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_choice3.Location = new System.Drawing.Point(0, 91);
            this.pb_choice3.Name = "pb_choice3";
            this.pb_choice3.Size = new System.Drawing.Size(197, 50);
            this.pb_choice3.TabIndex = 6;
            this.pb_choice3.TabStop = false;
            this.pb_choice3.Click += new System.EventHandler(this.pb_choice3_Click);
            this.pb_choice3.MouseLeave += new System.EventHandler(this.pb_choice3_MouseLeave);
            this.pb_choice3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_choice3_MouseMove);
            // 
            // lbl_choice2
            // 
            this.lbl_choice2.AutoSize = true;
            this.lbl_choice2.Location = new System.Drawing.Point(45, 63);
            this.lbl_choice2.Name = "lbl_choice2";
            this.lbl_choice2.Size = new System.Drawing.Size(87, 13);
            this.lbl_choice2.TabIndex = 5;
            this.lbl_choice2.Text = "Backup manuale";
            this.lbl_choice2.Click += new System.EventHandler(this.lbl_choice2_Click);
            // 
            // pb_choice2
            // 
            this.pb_choice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_choice2.Location = new System.Drawing.Point(0, 46);
            this.pb_choice2.Name = "pb_choice2";
            this.pb_choice2.Size = new System.Drawing.Size(197, 50);
            this.pb_choice2.TabIndex = 4;
            this.pb_choice2.TabStop = false;
            this.pb_choice2.Click += new System.EventHandler(this.pb_choice2_Click);
            this.pb_choice2.MouseLeave += new System.EventHandler(this.pb_choice2_MouseLeave);
            this.pb_choice2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_choice2_MouseMove);
            // 
            // lbl_choice1
            // 
            this.lbl_choice1.AutoSize = true;
            this.lbl_choice1.Location = new System.Drawing.Point(45, 17);
            this.lbl_choice1.Name = "lbl_choice1";
            this.lbl_choice1.Size = new System.Drawing.Size(82, 13);
            this.lbl_choice1.TabIndex = 3;
            this.lbl_choice1.Text = "Opzioni Backup";
            this.lbl_choice1.Click += new System.EventHandler(this.lbl_choice1_Click);
            // 
            // pb_choice1
            // 
            this.pb_choice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_choice1.Location = new System.Drawing.Point(0, 0);
            this.pb_choice1.Name = "pb_choice1";
            this.pb_choice1.Size = new System.Drawing.Size(197, 50);
            this.pb_choice1.TabIndex = 0;
            this.pb_choice1.TabStop = false;
            this.pb_choice1.Click += new System.EventHandler(this.pb_choice1_Click);
            this.pb_choice1.MouseLeave += new System.EventHandler(this.pb_choice1_MouseLeave);
            this.pb_choice1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_choice1_MouseMove);
            // 
            // panel_opzioniBackup
            // 
            this.panel_opzioniBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_opzioniBackup.Controls.Add(this.button2);
            this.panel_opzioniBackup.Controls.Add(this.button1);
            this.panel_opzioniBackup.Controls.Add(this.tb_backupPath);
            this.panel_opzioniBackup.Controls.Add(this.label2);
            this.panel_opzioniBackup.Controls.Add(this.cb_BackupTime);
            this.panel_opzioniBackup.Controls.Add(this.label1);
            this.panel_opzioniBackup.Controls.Add(this.lbl_nameOpPan1);
            this.panel_opzioniBackup.Location = new System.Drawing.Point(222, 23);
            this.panel_opzioniBackup.Name = "panel_opzioniBackup";
            this.panel_opzioniBackup.Size = new System.Drawing.Size(523, 328);
            this.panel_opzioniBackup.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Applica";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Seleziona";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_backupPath
            // 
            this.tb_backupPath.Location = new System.Drawing.Point(52, 126);
            this.tb_backupPath.Name = "tb_backupPath";
            this.tb_backupPath.Size = new System.Drawing.Size(268, 20);
            this.tb_backupPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleziona percorso per la cartella di backup";
            // 
            // cb_BackupTime
            // 
            this.cb_BackupTime.FormattingEnabled = true;
            this.cb_BackupTime.Items.AddRange(new object[] {
            "2 settimane ",
            "1 mese",
            "mai"});
            this.cb_BackupTime.Location = new System.Drawing.Point(52, 65);
            this.cb_BackupTime.Name = "cb_BackupTime";
            this.cb_BackupTime.Size = new System.Drawing.Size(121, 21);
            this.cb_BackupTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ogni quanto vuoi eseguire il backup deli dati?";
            // 
            // lbl_nameOpPan1
            // 
            this.lbl_nameOpPan1.AutoSize = true;
            this.lbl_nameOpPan1.Location = new System.Drawing.Point(25, 19);
            this.lbl_nameOpPan1.Name = "lbl_nameOpPan1";
            this.lbl_nameOpPan1.Size = new System.Drawing.Size(88, 13);
            this.lbl_nameOpPan1.TabIndex = 0;
            this.lbl_nameOpPan1.Text = "Opzioni Backup :";
            // 
            // btn_chiudi
            // 
            this.btn_chiudi.Location = new System.Drawing.Point(675, 356);
            this.btn_chiudi.Name = "btn_chiudi";
            this.btn_chiudi.Size = new System.Drawing.Size(75, 23);
            this.btn_chiudi.TabIndex = 2;
            this.btn_chiudi.Text = "Chiudi";
            this.btn_chiudi.UseVisualStyleBackColor = true;
            this.btn_chiudi.Click += new System.EventHandler(this.btn_chiudi_Click);
            // 
            // panel_backupManuale
            // 
            this.panel_backupManuale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_backupManuale.Controls.Add(this.label5);
            this.panel_backupManuale.Controls.Add(this.btn_goToBackDir);
            this.panel_backupManuale.Controls.Add(this.btn_manualBack);
            this.panel_backupManuale.Controls.Add(this.label4);
            this.panel_backupManuale.Controls.Add(this.label3);
            this.panel_backupManuale.Controls.Add(this.lbl_nameOpPan2);
            this.panel_backupManuale.Location = new System.Drawing.Point(222, 23);
            this.panel_backupManuale.Name = "panel_backupManuale";
            this.panel_backupManuale.Size = new System.Drawing.Size(523, 328);
            this.panel_backupManuale.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Clicca il pulsante \"Vai\" per andare direttamente alla cartella di Backup";
            // 
            // btn_goToBackDir
            // 
            this.btn_goToBackDir.Location = new System.Drawing.Point(104, 165);
            this.btn_goToBackDir.Name = "btn_goToBackDir";
            this.btn_goToBackDir.Size = new System.Drawing.Size(121, 23);
            this.btn_goToBackDir.TabIndex = 4;
            this.btn_goToBackDir.Text = "Vai";
            this.btn_goToBackDir.UseVisualStyleBackColor = true;
            this.btn_goToBackDir.Click += new System.EventHandler(this.btn_goToBackDir_Click);
            // 
            // btn_manualBack
            // 
            this.btn_manualBack.Location = new System.Drawing.Point(104, 93);
            this.btn_manualBack.Name = "btn_manualBack";
            this.btn_manualBack.Size = new System.Drawing.Size(121, 23);
            this.btn_manualBack.TabIndex = 3;
            this.btn_manualBack.Text = "Manual Backup";
            this.btn_manualBack.UseVisualStyleBackColor = true;
            this.btn_manualBack.Click += new System.EventHandler(this.btn_manualBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Il backup sarà visibile nella cartella di sitema scelta nelle Opzioni Backup.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clicca il bottone qua sotto per eseguire il backup manuale del DB,";
            // 
            // lbl_nameOpPan2
            // 
            this.lbl_nameOpPan2.AutoSize = true;
            this.lbl_nameOpPan2.Location = new System.Drawing.Point(25, 19);
            this.lbl_nameOpPan2.Name = "lbl_nameOpPan2";
            this.lbl_nameOpPan2.Size = new System.Drawing.Size(88, 13);
            this.lbl_nameOpPan2.TabIndex = 0;
            this.lbl_nameOpPan2.Text = "Backup Manuale";
            // 
            // panel_caricaDB
            // 
            this.panel_caricaDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_caricaDB.Controls.Add(this.btn_LoadDB);
            this.panel_caricaDB.Controls.Add(this.cb_DBlist);
            this.panel_caricaDB.Controls.Add(this.label7);
            this.panel_caricaDB.Controls.Add(this.label6);
            this.panel_caricaDB.Controls.Add(this.lbl_nameOpPan3);
            this.panel_caricaDB.Location = new System.Drawing.Point(222, 23);
            this.panel_caricaDB.Name = "panel_caricaDB";
            this.panel_caricaDB.Size = new System.Drawing.Size(523, 328);
            this.panel_caricaDB.TabIndex = 3;
            // 
            // btn_LoadDB
            // 
            this.btn_LoadDB.Location = new System.Drawing.Point(53, 126);
            this.btn_LoadDB.Name = "btn_LoadDB";
            this.btn_LoadDB.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadDB.TabIndex = 4;
            this.btn_LoadDB.Text = "Carica";
            this.btn_LoadDB.UseVisualStyleBackColor = true;
            this.btn_LoadDB.Click += new System.EventHandler(this.btn_LoadDB_Click);
            // 
            // cb_DBlist
            // 
            this.cb_DBlist.FormattingEnabled = true;
            this.cb_DBlist.Location = new System.Drawing.Point(56, 99);
            this.cb_DBlist.Name = "cb_DBlist";
            this.cb_DBlist.Size = new System.Drawing.Size(216, 21);
            this.cb_DBlist.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Seleziona il DB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(371, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tramite questa procedura sarà possibile caricare un vecchio DB come nuovo";
            // 
            // lbl_nameOpPan3
            // 
            this.lbl_nameOpPan3.AutoSize = true;
            this.lbl_nameOpPan3.Location = new System.Drawing.Point(25, 19);
            this.lbl_nameOpPan3.Name = "lbl_nameOpPan3";
            this.lbl_nameOpPan3.Size = new System.Drawing.Size(55, 13);
            this.lbl_nameOpPan3.TabIndex = 0;
            this.lbl_nameOpPan3.Text = "Carica DB";
            // 
            // panel_onlineOp
            // 
            this.panel_onlineOp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_onlineOp.Controls.Add(this.lbl_nameOpPan4);
            this.panel_onlineOp.Location = new System.Drawing.Point(222, 23);
            this.panel_onlineOp.Name = "panel_onlineOp";
            this.panel_onlineOp.Size = new System.Drawing.Size(523, 328);
            this.panel_onlineOp.TabIndex = 4;
            // 
            // lbl_nameOpPan4
            // 
            this.lbl_nameOpPan4.AutoSize = true;
            this.lbl_nameOpPan4.Location = new System.Drawing.Point(25, 19);
            this.lbl_nameOpPan4.Name = "lbl_nameOpPan4";
            this.lbl_nameOpPan4.Size = new System.Drawing.Size(132, 13);
            this.lbl_nameOpPan4.TabIndex = 0;
            this.lbl_nameOpPan4.Text = "Salva/Ripristina Db Online";
            // 
            // Form_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 391);
            this.Controls.Add(this.panel_backupManuale);
            this.Controls.Add(this.panel_opzioniBackup);
            this.Controls.Add(this.panel_caricaDB);
            this.Controls.Add(this.btn_chiudi);
            this.Controls.Add(this.panel_choice);
            this.Controls.Add(this.panel_onlineOp);
            this.Name = "Form_Backup";
            this.Text = "Backup";
            this.Activated += new System.EventHandler(this.Form_Backup_Activated);
            this.Load += new System.EventHandler(this.Form_Backup_Load);
            this.panel_choice.ResumeLayout(false);
            this.panel_choice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_choice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_choice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_choice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_choice1)).EndInit();
            this.panel_opzioniBackup.ResumeLayout(false);
            this.panel_opzioniBackup.PerformLayout();
            this.panel_backupManuale.ResumeLayout(false);
            this.panel_backupManuale.PerformLayout();
            this.panel_caricaDB.ResumeLayout(false);
            this.panel_caricaDB.PerformLayout();
            this.panel_onlineOp.ResumeLayout(false);
            this.panel_onlineOp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_choice;
        private System.Windows.Forms.Label lbl_choice4;
        private System.Windows.Forms.Label lbl_choice3;
        private System.Windows.Forms.PictureBox pb_choice4;
        private System.Windows.Forms.PictureBox pb_choice3;
        private System.Windows.Forms.Label lbl_choice2;
        private System.Windows.Forms.PictureBox pb_choice2;
        private System.Windows.Forms.Label lbl_choice1;
        private System.Windows.Forms.PictureBox pb_choice1;
        private System.Windows.Forms.Panel panel_opzioniBackup;
        private System.Windows.Forms.Button btn_chiudi;
        private System.Windows.Forms.Label lbl_nameOpPan1;
        private System.Windows.Forms.Panel panel_backupManuale;
        private System.Windows.Forms.Label lbl_nameOpPan2;
        private System.Windows.Forms.Panel panel_caricaDB;
        private System.Windows.Forms.Label lbl_nameOpPan3;
        private System.Windows.Forms.Panel panel_onlineOp;
        private System.Windows.Forms.Label lbl_nameOpPan4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_backupPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_BackupTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_goToBackDir;
        private System.Windows.Forms.Button btn_manualBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_DBlist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_LoadDB;
    }
}