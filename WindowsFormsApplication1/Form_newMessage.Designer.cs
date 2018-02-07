namespace WindowsFormsApplication1
{
    partial class Form_newMessage
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_object = new System.Windows.Forms.TextBox();
            this.rtb_text = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_invia = new System.Windows.Forms.Button();
            this.btn_cancella = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Da :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oggetto :";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(139, 22);
            this.tb_user.Name = "tb_user";
            this.tb_user.ReadOnly = true;
            this.tb_user.Size = new System.Drawing.Size(194, 20);
            this.tb_user.TabIndex = 3;
            // 
            // tb_object
            // 
            this.tb_object.Location = new System.Drawing.Point(139, 55);
            this.tb_object.Name = "tb_object";
            this.tb_object.Size = new System.Drawing.Size(194, 20);
            this.tb_object.TabIndex = 4;
            // 
            // rtb_text
            // 
            this.rtb_text.Location = new System.Drawing.Point(40, 126);
            this.rtb_text.Name = "rtb_text";
            this.rtb_text.Size = new System.Drawing.Size(363, 162);
            this.rtb_text.TabIndex = 5;
            this.rtb_text.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Messaggio :";
            // 
            // btn_invia
            // 
            this.btn_invia.Location = new System.Drawing.Point(327, 299);
            this.btn_invia.Name = "btn_invia";
            this.btn_invia.Size = new System.Drawing.Size(75, 23);
            this.btn_invia.TabIndex = 7;
            this.btn_invia.Text = "Invia";
            this.btn_invia.UseVisualStyleBackColor = true;
            this.btn_invia.Click += new System.EventHandler(this.btn_invia_Click);
            // 
            // btn_cancella
            // 
            this.btn_cancella.Location = new System.Drawing.Point(234, 299);
            this.btn_cancella.Name = "btn_cancella";
            this.btn_cancella.Size = new System.Drawing.Size(75, 23);
            this.btn_cancella.TabIndex = 8;
            this.btn_cancella.Text = "Cancella";
            this.btn_cancella.UseVisualStyleBackColor = true;
            this.btn_cancella.Click += new System.EventHandler(this.btn_cancella_Click);
            // 
            // Form_newMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 334);
            this.Controls.Add(this.btn_cancella);
            this.Controls.Add(this.btn_invia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb_text);
            this.Controls.Add(this.tb_object);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_newMessage";
            this.Text = "Nuovo Messaggio";
            this.Load += new System.EventHandler(this.Form_newMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_object;
        private System.Windows.Forms.RichTextBox rtb_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_invia;
        private System.Windows.Forms.Button btn_cancella;
    }
}