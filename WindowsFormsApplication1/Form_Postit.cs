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
    public partial class Form_Postit : Form
    {
        private List<Tuple<int,String, String, String>> messageList = new List<Tuple<int, String, String, String>>();
        private int maxMessCharge = 10;        
        public Form_Postit()
        {
            InitializeComponent();
        }        

        private void Form_Postit_Load(object sender, EventArgs e)
        {
            chargeMessages();
            printMessages();
        }

        private void pb_message1_MouseMove(object sender, MouseEventArgs e)
        {
            pb_message1.BackColor = Color.IndianRed;
            lbl_oggetto1.BackColor = Color.IndianRed;
            lbl_destinatario1.BackColor = Color.IndianRed;
            lbl_messageObj1.BackColor = Color.IndianRed;
            lbl_messageFrom1.BackColor = Color.IndianRed;
            pb_goToMessage1.BackColor = Color.IndianRed;
        }

        private void pb_message1_MouseLeave(object sender, EventArgs e)
        {
            pb_message1.BackColor = SystemColors.Control;
            lbl_oggetto1.BackColor = SystemColors.Control;
            lbl_destinatario1.BackColor = SystemColors.Control;
            lbl_messageObj1.BackColor = SystemColors.Control;
            lbl_messageFrom1.BackColor = SystemColors.Control;
            pb_goToMessage1.BackColor = SystemColors.Control;
        }

        private void pb_message1_Click(object sender, EventArgs e)
        {
            pb_goToMessage1_Click(sender, e);
        }

        private void pb_message2_MouseMove(object sender, MouseEventArgs e)
        {
            pb_message2.BackColor = Color.IndianRed;
            lbl_oggetto2.BackColor = Color.IndianRed;
            lbl_destinatario2.BackColor = Color.IndianRed;
            lbl_messageObj2.BackColor = Color.IndianRed;
            lbl_messageFrom2.BackColor = Color.IndianRed;
            pb_goToMessage2.BackColor = Color.IndianRed;

        }

        private void pb_message2_MouseLeave(object sender, EventArgs e)
        {
            pb_message2.BackColor = SystemColors.Control;
            lbl_oggetto2.BackColor = SystemColors.Control;
            lbl_destinatario2.BackColor = SystemColors.Control;
            lbl_messageObj2.BackColor = SystemColors.Control;
            lbl_messageFrom2.BackColor = SystemColors.Control;
            pb_goToMessage2.BackColor = SystemColors.Control;
        }

        private void pb_message2_Click(object sender, EventArgs e)
        {
            pb_goToMessage2_Click(sender, e);
        }

        private void pb_message3_MouseMove(object sender, MouseEventArgs e)
        {
            pb_message3.BackColor = Color.IndianRed;
            lbl_oggetto3.BackColor = Color.IndianRed;
            lbl_destinatario3.BackColor = Color.IndianRed;
            lbl_messageObj3.BackColor = Color.IndianRed;
            lbl_messageFrom3.BackColor = Color.IndianRed;
            pb_goToMessage3.BackColor = Color.IndianRed;
        }

        private void pb_message3_MouseLeave(object sender, EventArgs e)
        {
            pb_message3.BackColor = SystemColors.Control;
            lbl_oggetto3.BackColor = SystemColors.Control;
            lbl_destinatario3.BackColor = SystemColors.Control;
            lbl_messageObj3.BackColor = SystemColors.Control;
            lbl_messageFrom3.BackColor = SystemColors.Control;
            pb_goToMessage3.BackColor = SystemColors.Control;
        }

        private void pb_message3_Click(object sender, EventArgs e)
        {
            pb_goToMessage3_Click(sender, e);
        }

        private void pb_message4_MouseMove(object sender, MouseEventArgs e)
        {
            pb_message4.BackColor = Color.IndianRed;
            lbl_oggetto4.BackColor = Color.IndianRed;
            lbl_destinatario4.BackColor = Color.IndianRed;
            lbl_messageObj4.BackColor = Color.IndianRed;
            lbl_messageFrom4.BackColor = Color.IndianRed;
            pb_goToMessage4.BackColor = Color.IndianRed;
        }

        private void pb_message4_MouseLeave(object sender, EventArgs e)
        {
            pb_message4.BackColor = SystemColors.Control;
            lbl_oggetto4.BackColor = SystemColors.Control;
            lbl_destinatario4.BackColor = SystemColors.Control;
            lbl_messageObj4.BackColor = SystemColors.Control;
            lbl_messageFrom4.BackColor = SystemColors.Control;
            pb_goToMessage4.BackColor = SystemColors.Control;
        }

        private void pb_message4_Click(object sender, EventArgs e)
        {
            pb_goToMessage4_Click(sender, e);
        }

        private void pb_message5_MouseMove(object sender, MouseEventArgs e)
        {
            pb_message5.BackColor = Color.IndianRed;
            lbl_oggetto5.BackColor = Color.IndianRed;
            lbl_destinatario5.BackColor = Color.IndianRed;
            lbl_messageObj5.BackColor = Color.IndianRed;
            lbl_messageFrom5.BackColor = Color.IndianRed;
            pb_goToMessage5.BackColor = Color.IndianRed;
        }

        private void pb_message5_MouseLeave(object sender, EventArgs e)
        {
            pb_message5.BackColor = SystemColors.Control;
            lbl_oggetto5.BackColor = SystemColors.Control;
            lbl_destinatario5.BackColor = SystemColors.Control;
            lbl_messageObj5.BackColor = SystemColors.Control;
            lbl_messageFrom5.BackColor = SystemColors.Control;
            pb_goToMessage5.BackColor = SystemColors.Control;
        }

        private void pb_message5_Click(object sender, EventArgs e)
        {
            pb_goToMessage4_Click(sender, e);
        }

        private void pb_goToMessage1_Click(object sender, EventArgs e)
        {
            LoadMessage(0);
        }

        private void pb_goToMessage2_Click(object sender, EventArgs e)
        {
            LoadMessage(1);
        }

        private void pb_goToMessage3_Click(object sender, EventArgs e)
        {
            LoadMessage(2);
        }

        private void pb_goToMessage4_Click(object sender, EventArgs e)
        {
            LoadMessage(3);
        }

        private void pb_goToMessage5_Click(object sender, EventArgs e)
        {
            LoadMessage(4);
        }

        private void pb_goToMessage1_MouseMove(object sender, MouseEventArgs e)
        {
            pb_message1_MouseMove(sender, e);
        }

        private void pb_goToMessage1_MouseLeave(object sender, EventArgs e)
        {
            pb_message1_MouseLeave(sender, e);
        }

        private void pb_goToMessage2_MouseMove(object sender, MouseEventArgs e)
        {
            pb_message2_MouseMove(sender, e);
        }

        private void pb_goToMessage2_MouseLeave(object sender, EventArgs e)
        {
            pb_message2_MouseLeave(sender, e);
        }

        private void pb_goToMessage3_MouseMove(object sender, MouseEventArgs e)
        {
            pb_message3_MouseMove(sender, e);
        }

        private void pb_goToMessage3_MouseLeave(object sender, EventArgs e)
        {
            pb_message3_MouseLeave(sender, e);
        }

        private void pb_goToMessage4_MouseMove(object sender, MouseEventArgs e)
        {
            pb_message4_MouseMove(sender, e);
        }

        private void pb_goToMessage4_MouseLeave(object sender, EventArgs e)
        {
            pb_message4_MouseLeave(sender, e);
        }

        private void pb_goToMessage5_MouseMove(object sender, MouseEventArgs e)
        {
            pb_message5_MouseMove(sender, e);
        }

        private void pb_goToMessage5_MouseLeave(object sender, EventArgs e)
        {
            pb_message5_MouseLeave(sender, e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pb_loadOther.BackColor = Color.IndianRed;            
            lbl_loadOther.BackColor = Color.IndianRed;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pb_loadOther.BackColor = SystemColors.Control;
            lbl_loadOther.BackColor = SystemColors.Control;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lbl_loadOther.Text.Equals("carica successivi..."))
            {
                lbl_loadOther.Text = "carica precedenti...";
            }
            else
            {
                lbl_loadOther.Text = "carica successivi...";
            }
            clearStrings();
            printMessages();


        }

        private void lbl_loadOther_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        private void chargeMessages()
        {
            int i = 0;
            messageList.Clear();
            clearStrings();
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
            {
                using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    conn.Open();
                    string command = "SELECT * FROM Messaggio JOIN User ON Messaggio.Id=User.Id ORDER BY Messaggio.Cod DESC";
                    cmd.CommandText = command;
                    using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (i==10)
                            {
                                break;                                
                            }
                            messageList.Add(new Tuple<int, string, string, string>(Int16.Parse(reader["Cod"].ToString()), reader["Username"].ToString(), reader["Oggetto"].ToString(), reader["Text"].ToString()));
                            i++;
                        }
                        while (i<10)
                        {                            
                            messageList.Add(new Tuple<int, string, string, string>(0, "Nessuno", "Nessuno", "Vuoto"));
                            i++;
                        }

                    }
                    conn.Close();
                }
            }
        }

        private void pb_create_Click(object sender, EventArgs e)
        {
            Form_newMessage archivio = new Form_newMessage();
            archivio.Show();
        }

        private void lbl_create_Click(object sender, EventArgs e)
        {
            pb_create_Click(sender, e);
        }

        private void printMessages()
        {
            int i = 0;
            int j = 0;
            int cont = 0;          
            if (lbl_loadOther.Text.Equals("carica successivi..."))
            {
                i = 0;
            }
            else
            {
                i = 5;
            }
            foreach (var element in messageList)
            {
                if (j>=i)
                {
                    if(cont<5)
                    {
                        switch (j)
                        {
                            case 0:
                                lbl_messageObj1.Text = element.Item2.ToString();
                                lbl_messageFrom1.Text = element.Item3.ToString();
                                break;
                            case 1:
                                lbl_messageObj2.Text = element.Item2.ToString();
                                lbl_messageFrom2.Text = element.Item3.ToString();
                                break;
                            case 2:
                                lbl_messageObj3.Text = element.Item2.ToString();
                                lbl_messageFrom3.Text = element.Item3.ToString();
                                break;
                            case 3:
                                lbl_messageObj4.Text = element.Item2.ToString();
                                lbl_messageFrom4.Text = element.Item3.ToString();
                                break;
                            case 4:
                                lbl_messageObj5.Text = element.Item2.ToString();
                                lbl_messageFrom5.Text = element.Item3.ToString();
                                break;
                            case 5:
                                lbl_messageObj1.Text = element.Item2.ToString();
                                lbl_messageFrom1.Text = element.Item3.ToString();
                                break;
                            case 6:
                                lbl_messageObj2.Text = element.Item2.ToString();
                                lbl_messageFrom2.Text = element.Item3.ToString();
                                break;
                            case 7:
                                lbl_messageObj3.Text = element.Item2.ToString();
                                lbl_messageFrom3.Text = element.Item3.ToString();
                                break;
                            case 8:
                                lbl_messageObj4.Text = element.Item2.ToString();
                                lbl_messageFrom4.Text = element.Item3.ToString();
                                break;
                            case 9:
                                lbl_messageObj5.Text = element.Item2.ToString();
                                lbl_messageFrom5.Text = element.Item3.ToString();
                                break;
                        }
                        
                    }
                    cont++;

                }
                j++;

            }
        }

        private void LoadMessage(int n)
        {
            int i = 0;
            if (lbl_loadOther.Text.Equals("carica successivi..."))
            {
                i = 0;
            }
            else
            {
                i = 5;
            }

            if(!messageList.ElementAt(n + i).Item4.Equals(""))
            {
                rtb_text.Text = messageList.ElementAt(n + i).Item4;
            }else
            {
                rtb_text.Text = "vuoto";
            }
            


        }

        private void Form_Postit_Activated(object sender, EventArgs e)
        {
            chargeMessages();
            printMessages();
        }

        private void clearStrings()
        {
            lbl_messageObj1.Text = "Nessuno";
            lbl_messageFrom1.Text = "Nessuno";
            lbl_messageObj2.Text = "Nessuno";
            lbl_messageFrom2.Text = "Nessuno";
            lbl_messageObj3.Text = "Nessuno";
            lbl_messageFrom3.Text = "Nessuno";
            lbl_messageObj4.Text = "Nessuno";
            lbl_messageFrom4.Text = "Nessuno";
            lbl_messageObj5.Text = "Nessuno";
            lbl_messageFrom5.Text = "Nessuno";
        }

        private void btn_chiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_svuota_Click(object sender, EventArgs e)
        {            
            DialogResult result = MessageBox.Show("Tutti i messaggi nell'archivio verranno eliminati, sei sicuro di voler procedere? ",
                "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "DELETE FROM Messaggio";
                        cmd.CommandText = command;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            chargeMessages();
            printMessages();

        }
    }
}
