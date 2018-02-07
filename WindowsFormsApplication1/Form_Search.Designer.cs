namespace WindowsFormsApplication1
{
    partial class Form_Search
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
            this.gb_cerca = new System.Windows.Forms.GroupBox();
            this.btn_cerca = new System.Windows.Forms.Button();
            this.tb_cognome = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.btn_elenco = new System.Windows.Forms.Button();
            this.btn_chiudi = new System.Windows.Forms.Button();
            this.cb_order = new System.Windows.Forms.ComboBox();
            this.gb_cerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_cerca
            // 
            this.gb_cerca.Controls.Add(this.btn_cerca);
            this.gb_cerca.Controls.Add(this.tb_cognome);
            this.gb_cerca.Controls.Add(this.tb_nome);
            this.gb_cerca.Controls.Add(this.label2);
            this.gb_cerca.Controls.Add(this.label1);
            this.gb_cerca.Location = new System.Drawing.Point(266, 34);
            this.gb_cerca.Name = "gb_cerca";
            this.gb_cerca.Size = new System.Drawing.Size(200, 119);
            this.gb_cerca.TabIndex = 0;
            this.gb_cerca.TabStop = false;
            this.gb_cerca.Text = "Cerca";
            // 
            // btn_cerca
            // 
            this.btn_cerca.Location = new System.Drawing.Point(99, 90);
            this.btn_cerca.Name = "btn_cerca";
            this.btn_cerca.Size = new System.Drawing.Size(75, 23);
            this.btn_cerca.TabIndex = 4;
            this.btn_cerca.Text = "Cerca";
            this.btn_cerca.UseVisualStyleBackColor = true;
            this.btn_cerca.Click += new System.EventHandler(this.btn_cerca_Click);
            // 
            // tb_cognome
            // 
            this.tb_cognome.Location = new System.Drawing.Point(74, 57);
            this.tb_cognome.Name = "tb_cognome";
            this.tb_cognome.Size = new System.Drawing.Size(100, 20);
            this.tb_cognome.TabIndex = 3;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(74, 28);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // dgv_search
            // 
            this.dgv_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search.Location = new System.Drawing.Point(35, 197);
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.ReadOnly = true;
            this.dgv_search.Size = new System.Drawing.Size(671, 350);
            this.dgv_search.TabIndex = 1;
            this.dgv_search.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_search_CellContentClick);
            // 
            // btn_elenco
            // 
            this.btn_elenco.Location = new System.Drawing.Point(592, 168);
            this.btn_elenco.Name = "btn_elenco";
            this.btn_elenco.Size = new System.Drawing.Size(114, 23);
            this.btn_elenco.TabIndex = 5;
            this.btn_elenco.Text = "Elenco Iscritti";
            this.btn_elenco.UseVisualStyleBackColor = true;
            this.btn_elenco.Click += new System.EventHandler(this.btn_elenco_Click);
            // 
            // btn_chiudi
            // 
            this.btn_chiudi.Location = new System.Drawing.Point(667, 553);
            this.btn_chiudi.Name = "btn_chiudi";
            this.btn_chiudi.Size = new System.Drawing.Size(75, 23);
            this.btn_chiudi.TabIndex = 6;
            this.btn_chiudi.Text = "Chiudi";
            this.btn_chiudi.UseVisualStyleBackColor = true;
            this.btn_chiudi.Click += new System.EventHandler(this.btn_chiudi_Click);
            // 
            // cb_order
            // 
            this.cb_order.FormattingEnabled = true;
            this.cb_order.Items.AddRange(new object[] {
            "Nome",
            "Ntessera",
            "Cognome"});
            this.cb_order.Location = new System.Drawing.Point(35, 168);
            this.cb_order.Name = "cb_order";
            this.cb_order.Size = new System.Drawing.Size(121, 21);
            this.cb_order.TabIndex = 7;
            this.cb_order.Text = "Ordina per:";
            this.cb_order.SelectedIndexChanged += new System.EventHandler(this.cb_order_SelectedIndexChanged);
            // 
            // Form_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.cb_order);
            this.Controls.Add(this.btn_chiudi);
            this.Controls.Add(this.btn_elenco);
            this.Controls.Add(this.dgv_search);
            this.Controls.Add(this.gb_cerca);
            this.Name = "Form_Search";
            this.Text = "Ricerca";
            this.Activated += new System.EventHandler(this.Form_Search_Activated);
            this.Load += new System.EventHandler(this.Form_Search_Load);
            this.gb_cerca.ResumeLayout(false);
            this.gb_cerca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_cerca;
        private System.Windows.Forms.Button btn_cerca;
        private System.Windows.Forms.TextBox tb_cognome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.Button btn_elenco;
        private System.Windows.Forms.Button btn_chiudi;
        private System.Windows.Forms.ComboBox cb_order;
    }
}