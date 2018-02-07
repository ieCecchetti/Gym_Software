namespace WindowsFormsApplication1
{
    partial class Form_NewUser
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
            this.gb_delete = new System.Windows.Forms.GroupBox();
            this.lbl_pswDel = new System.Windows.Forms.Label();
            this.tb_pswDel = new System.Windows.Forms.TextBox();
            this.lbl_nomeDel = new System.Windows.Forms.Label();
            this.tb_NomeDel = new System.Windows.Forms.TextBox();
            this.btn_elimina = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_selUserDel = new System.Windows.Forms.ComboBox();
            this.gb_add = new System.Windows.Forms.GroupBox();
            this.lbl_pswReAdd = new System.Windows.Forms.Label();
            this.tb_pswReAdd = new System.Windows.Forms.TextBox();
            this.lbl_pswAdd = new System.Windows.Forms.Label();
            this.tb_pswAdd = new System.Windows.Forms.TextBox();
            this.lbl_nomeAdd = new System.Windows.Forms.Label();
            this.tb_nomeAdd = new System.Windows.Forms.TextBox();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.btn_chiudi = new System.Windows.Forms.Button();
            this.gb_modify = new System.Windows.Forms.GroupBox();
            this.btn_modify = new System.Windows.Forms.Button();
            this.lbl_pswMod = new System.Windows.Forms.Label();
            this.tb_pswMod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NomeMod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_selUserMod = new System.Windows.Forms.ComboBox();
            this.cb_selOp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_delete.SuspendLayout();
            this.gb_add.SuspendLayout();
            this.gb_modify.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_delete
            // 
            this.gb_delete.Controls.Add(this.lbl_pswDel);
            this.gb_delete.Controls.Add(this.tb_pswDel);
            this.gb_delete.Controls.Add(this.lbl_nomeDel);
            this.gb_delete.Controls.Add(this.tb_NomeDel);
            this.gb_delete.Controls.Add(this.btn_elimina);
            this.gb_delete.Controls.Add(this.label13);
            this.gb_delete.Controls.Add(this.cb_selUserDel);
            this.gb_delete.Location = new System.Drawing.Point(259, 88);
            this.gb_delete.Margin = new System.Windows.Forms.Padding(2);
            this.gb_delete.Name = "gb_delete";
            this.gb_delete.Padding = new System.Windows.Forms.Padding(2);
            this.gb_delete.Size = new System.Drawing.Size(210, 200);
            this.gb_delete.TabIndex = 15;
            this.gb_delete.TabStop = false;
            this.gb_delete.Text = "Elimina User";
            // 
            // lbl_pswDel
            // 
            this.lbl_pswDel.AutoSize = true;
            this.lbl_pswDel.Location = new System.Drawing.Point(22, 117);
            this.lbl_pswDel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pswDel.Name = "lbl_pswDel";
            this.lbl_pswDel.Size = new System.Drawing.Size(53, 13);
            this.lbl_pswDel.TabIndex = 12;
            this.lbl_pswDel.Text = "Password";
            // 
            // tb_pswDel
            // 
            this.tb_pswDel.Location = new System.Drawing.Point(112, 117);
            this.tb_pswDel.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pswDel.Name = "tb_pswDel";
            this.tb_pswDel.ReadOnly = true;
            this.tb_pswDel.Size = new System.Drawing.Size(76, 20);
            this.tb_pswDel.TabIndex = 11;
            // 
            // lbl_nomeDel
            // 
            this.lbl_nomeDel.AutoSize = true;
            this.lbl_nomeDel.Location = new System.Drawing.Point(22, 92);
            this.lbl_nomeDel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nomeDel.Name = "lbl_nomeDel";
            this.lbl_nomeDel.Size = new System.Drawing.Size(35, 13);
            this.lbl_nomeDel.TabIndex = 10;
            this.lbl_nomeDel.Text = "Nome";
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
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Seleziona User";
            // 
            // cb_selUserDel
            // 
            this.cb_selUserDel.FormattingEnabled = true;
            this.cb_selUserDel.Location = new System.Drawing.Point(24, 50);
            this.cb_selUserDel.Margin = new System.Windows.Forms.Padding(2);
            this.cb_selUserDel.Name = "cb_selUserDel";
            this.cb_selUserDel.Size = new System.Drawing.Size(144, 21);
            this.cb_selUserDel.TabIndex = 0;
            this.cb_selUserDel.SelectedIndexChanged += new System.EventHandler(this.cb_selUserDel_SelectedIndexChanged);
            // 
            // gb_add
            // 
            this.gb_add.Controls.Add(this.lbl_pswReAdd);
            this.gb_add.Controls.Add(this.tb_pswReAdd);
            this.gb_add.Controls.Add(this.lbl_pswAdd);
            this.gb_add.Controls.Add(this.tb_pswAdd);
            this.gb_add.Controls.Add(this.lbl_nomeAdd);
            this.gb_add.Controls.Add(this.tb_nomeAdd);
            this.gb_add.Controls.Add(this.btn_aggiungi);
            this.gb_add.Location = new System.Drawing.Point(30, 299);
            this.gb_add.Margin = new System.Windows.Forms.Padding(2);
            this.gb_add.Name = "gb_add";
            this.gb_add.Padding = new System.Windows.Forms.Padding(2);
            this.gb_add.Size = new System.Drawing.Size(439, 132);
            this.gb_add.TabIndex = 16;
            this.gb_add.TabStop = false;
            this.gb_add.Text = "Aggiungi User";
            // 
            // lbl_pswReAdd
            // 
            this.lbl_pswReAdd.AutoSize = true;
            this.lbl_pswReAdd.Location = new System.Drawing.Point(31, 89);
            this.lbl_pswReAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pswReAdd.Name = "lbl_pswReAdd";
            this.lbl_pswReAdd.Size = new System.Drawing.Size(91, 13);
            this.lbl_pswReAdd.TabIndex = 14;
            this.lbl_pswReAdd.Text = "Ridigita Password";
            // 
            // tb_pswReAdd
            // 
            this.tb_pswReAdd.Location = new System.Drawing.Point(152, 86);
            this.tb_pswReAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pswReAdd.Name = "tb_pswReAdd";
            this.tb_pswReAdd.Size = new System.Drawing.Size(76, 20);
            this.tb_pswReAdd.TabIndex = 13;
            // 
            // lbl_pswAdd
            // 
            this.lbl_pswAdd.AutoSize = true;
            this.lbl_pswAdd.Location = new System.Drawing.Point(31, 61);
            this.lbl_pswAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pswAdd.Name = "lbl_pswAdd";
            this.lbl_pswAdd.Size = new System.Drawing.Size(53, 13);
            this.lbl_pswAdd.TabIndex = 12;
            this.lbl_pswAdd.Text = "Password";
            // 
            // tb_pswAdd
            // 
            this.tb_pswAdd.Location = new System.Drawing.Point(152, 58);
            this.tb_pswAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pswAdd.Name = "tb_pswAdd";
            this.tb_pswAdd.Size = new System.Drawing.Size(76, 20);
            this.tb_pswAdd.TabIndex = 11;
            // 
            // lbl_nomeAdd
            // 
            this.lbl_nomeAdd.AutoSize = true;
            this.lbl_nomeAdd.Location = new System.Drawing.Point(31, 33);
            this.lbl_nomeAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nomeAdd.Name = "lbl_nomeAdd";
            this.lbl_nomeAdd.Size = new System.Drawing.Size(35, 13);
            this.lbl_nomeAdd.TabIndex = 10;
            this.lbl_nomeAdd.Text = "Nome";
            // 
            // tb_nomeAdd
            // 
            this.tb_nomeAdd.Location = new System.Drawing.Point(152, 30);
            this.tb_nomeAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nomeAdd.Name = "tb_nomeAdd";
            this.tb_nomeAdd.Size = new System.Drawing.Size(76, 20);
            this.tb_nomeAdd.TabIndex = 9;
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
            // btn_chiudi
            // 
            this.btn_chiudi.Location = new System.Drawing.Point(422, 453);
            this.btn_chiudi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_chiudi.Name = "btn_chiudi";
            this.btn_chiudi.Size = new System.Drawing.Size(56, 19);
            this.btn_chiudi.TabIndex = 14;
            this.btn_chiudi.Text = "Chiudi";
            this.btn_chiudi.UseVisualStyleBackColor = true;
            this.btn_chiudi.Click += new System.EventHandler(this.btn_chiudi_Click);
            // 
            // gb_modify
            // 
            this.gb_modify.Controls.Add(this.btn_modify);
            this.gb_modify.Controls.Add(this.lbl_pswMod);
            this.gb_modify.Controls.Add(this.tb_pswMod);
            this.gb_modify.Controls.Add(this.label3);
            this.gb_modify.Controls.Add(this.tb_NomeMod);
            this.gb_modify.Controls.Add(this.label2);
            this.gb_modify.Controls.Add(this.cb_selUserMod);
            this.gb_modify.Location = new System.Drawing.Point(30, 88);
            this.gb_modify.Margin = new System.Windows.Forms.Padding(2);
            this.gb_modify.Name = "gb_modify";
            this.gb_modify.Padding = new System.Windows.Forms.Padding(2);
            this.gb_modify.Size = new System.Drawing.Size(210, 200);
            this.gb_modify.TabIndex = 13;
            this.gb_modify.TabStop = false;
            this.gb_modify.Text = "Modifica User";
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
            // lbl_pswMod
            // 
            this.lbl_pswMod.AutoSize = true;
            this.lbl_pswMod.Location = new System.Drawing.Point(22, 115);
            this.lbl_pswMod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pswMod.Name = "lbl_pswMod";
            this.lbl_pswMod.Size = new System.Drawing.Size(53, 13);
            this.lbl_pswMod.TabIndex = 5;
            this.lbl_pswMod.Text = "Password";
            // 
            // tb_pswMod
            // 
            this.tb_pswMod.Location = new System.Drawing.Point(112, 115);
            this.tb_pswMod.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pswMod.Name = "tb_pswMod";
            this.tb_pswMod.Size = new System.Drawing.Size(76, 20);
            this.tb_pswMod.TabIndex = 4;
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
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleziona User";
            // 
            // cb_selUserMod
            // 
            this.cb_selUserMod.FormattingEnabled = true;
            this.cb_selUserMod.Location = new System.Drawing.Point(24, 50);
            this.cb_selUserMod.Margin = new System.Windows.Forms.Padding(2);
            this.cb_selUserMod.Name = "cb_selUserMod";
            this.cb_selUserMod.Size = new System.Drawing.Size(144, 21);
            this.cb_selUserMod.TabIndex = 0;
            this.cb_selUserMod.SelectedIndexChanged += new System.EventHandler(this.cb_selUserMod_SelectedIndexChanged);
            // 
            // cb_selOp
            // 
            this.cb_selOp.FormattingEnabled = true;
            this.cb_selOp.Items.AddRange(new object[] {
            "Modifica User",
            "Elimina User",
            "Aggiungi User"});
            this.cb_selOp.Location = new System.Drawing.Point(54, 44);
            this.cb_selOp.Margin = new System.Windows.Forms.Padding(2);
            this.cb_selOp.Name = "cb_selOp";
            this.cb_selOp.Size = new System.Drawing.Size(135, 21);
            this.cb_selOp.TabIndex = 12;
            this.cb_selOp.SelectedIndexChanged += new System.EventHandler(this.cb_selOp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleziona operazione";
            // 
            // Form_NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 491);
            this.Controls.Add(this.gb_delete);
            this.Controls.Add(this.gb_add);
            this.Controls.Add(this.btn_chiudi);
            this.Controls.Add(this.gb_modify);
            this.Controls.Add(this.cb_selOp);
            this.Controls.Add(this.label1);
            this.Name = "Form_NewUser";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Form_NewUser_Load);
            this.gb_delete.ResumeLayout(false);
            this.gb_delete.PerformLayout();
            this.gb_add.ResumeLayout(false);
            this.gb_add.PerformLayout();
            this.gb_modify.ResumeLayout(false);
            this.gb_modify.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_delete;
        private System.Windows.Forms.Label lbl_pswDel;
        private System.Windows.Forms.TextBox tb_pswDel;
        private System.Windows.Forms.Label lbl_nomeDel;
        private System.Windows.Forms.TextBox tb_NomeDel;
        private System.Windows.Forms.Button btn_elimina;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_selUserDel;
        private System.Windows.Forms.GroupBox gb_add;
        private System.Windows.Forms.Label lbl_pswAdd;
        private System.Windows.Forms.TextBox tb_pswAdd;
        private System.Windows.Forms.Label lbl_nomeAdd;
        private System.Windows.Forms.TextBox tb_nomeAdd;
        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.Button btn_chiudi;
        private System.Windows.Forms.GroupBox gb_modify;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Label lbl_pswMod;
        private System.Windows.Forms.TextBox tb_pswMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_NomeMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_selUserMod;
        private System.Windows.Forms.ComboBox cb_selOp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pswReAdd;
        private System.Windows.Forms.TextBox tb_pswReAdd;
    }
}