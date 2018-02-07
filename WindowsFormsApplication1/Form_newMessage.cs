using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_newMessage : Form
    {
        public Form_newMessage()
        {
            InitializeComponent();
        }
        private void Form_newMessage_Load(object sender, EventArgs e)
        {
            tb_user.Text = Home.actualUser;
        }

        private void btn_invia_Click(object sender, EventArgs e)
        {
            if (!tb_object.Text.Equals(""))
            {
                if (!rtb_text.Text.Equals(""))
                {
                    using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                    {
                        using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                        {
                            conn.Open();
                            string command = "INSERT INTO Messaggio(Id,Oggetto,Text) VALUES ('"+Home.actualUserId+ "','" + tb_object.Text + "','" + rtb_text.Text + "')";
                            cmd.CommandText = command;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Il messaggio è stato inviato agli altri utenti, sarà ora visibile nalla bacheca.",
                                "Invio Riuscito");
                            this.Close();
                            conn.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Impossibile spedire un messaggio vuoto agli utenti, perfavore digita qualcosa!",
                    "Errore Login");
                }
            }
            else
            {
                MessageBox.Show("Inserire il campo ''Oggetto'' del messaggio e riprovare. ",
                    "Errore Login");
            }
        }

        private void btn_cancella_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
