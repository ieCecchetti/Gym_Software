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
    public partial class Form_addNew : Form
    {
        private bool hasRated = false;
        public Form_addNew()
        {
            InitializeComponent();            
        }

        DataTable tableCorsi = new DataTable();
        Form_rate addNewRata = new Form_rate();

        private void Form_addNew_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
            checkbox.HeaderText = "Seleziona";
            dgv_selCorsi.Columns.Add(checkbox);
            tableCorsi.Columns.Add("Corso", typeof(string));
            tableCorsi.Columns.Add("Cod", typeof(string));
            dgv_selCorsi.DataSource = tableCorsi;
            LoadTableCorsi();
        }

        private void LoadTableCorsi()
        {            
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
            {
                using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    conn.Open();                                      
                    string command = "Select * from Corso";
                    cmd.CommandText = command;
                    using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {                            
                            tableCorsi.Rows.Add(reader["Nome"],reader["Id"]);
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(!tb_costo.Text.Equals(""))
            {
                int lastNTess;
                addNewRata.setCosto(tb_costo.Text);
                int tipoAbb = 0;
                if (nud_Ningressi.Value != 0)
                {
                    tipoAbb = 1; //abbonameno a  ingressi
                }
                else { tipoAbb = 0; }//abbonamento std

                //if (checkUsefulFields() && checkCorsi() && DateTime.Compare(dtp_dataIn.Value, dtp_dataFin.Value) != -1 && DateTime.Compare(dtp_dataIn.Value, dtp_dataFin.Value) != 0)
                if (checkUsefulFields() && checkCorsi())
                {
                    using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                    {
                        using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                        {
                            conn.Open();

                            //-------------------------------------------------------------------QUERY INSERT ISCRITTI
                            string command = @"INSERT into Iscritto(Nome,Cognome,DataN,CodFisc,Residenza,Via,Recapito,Email,Ntessera,DataIn,DataFine,NIngressi,TipoAbb,Costo) 
                                            values ('" + tb_nome.Text.ToString() + "','" + tb_cognome.Text.ToString() + "','" + dtp_dataN.Value.ToString("yyyy-MM-dd")
                                            + "','" +tb_codFisc.Text.ToString() + "','"+ tb_residenza.Text.ToString() + "','" + tb_via.Text.ToString() + "','" + tb_recapito.Text.ToString() + "','"
                                            +tb_mail.Text.ToString() + "','"+tb_nTessera.Text.ToString()+"','" + dtp_dataIn.Value.ToString("yyyy-MM-dd") + "','" + dtp_dataFin.Value.ToString("yyyy-MM-dd") + "','" + nud_Ningressi.Value
                                            + "','" + tipoAbb + "','" + sqliteRealTypeconversion(tb_costo.Text.ToString()) + "');";
                            cmd.CommandText = command;
                            cmd.ExecuteNonQuery();
                            //MessageBox.Show(command);

                            //-------------------------------------------------------------------QUERY INSERT FREQUENTA
                            cmd.CommandText = "SELECT CodIscritto FROM Iscritto WHERE CodIscritto = (SELECT MAX(CodIscritto)  FROM Iscritto);";
                            cmd.ExecuteNonQuery();                            
                            using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                reader.Read();
                                lastNTess = reader.GetInt32(0);
                            }

                            foreach (DataGridViewRow row in dgv_selCorsi.Rows)
                            {
                                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                                {
                                    command = "INSERT INTO Frequenta values ('" + lastNTess + "','" + row.Cells[2].Value + "')";
                                    cmd.CommandText = command;
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            //-------------------------------------------------------------------QUERY INSERT RATE
                            cmd.CommandText = addNewRata.getRateQuery();
                            cmd.ExecuteNonQuery();

                            //-------------------------------------------------------------------QUERY INSERT CERTIFICATO
                            if (cb_certificato.Checked)
                            {
                                command = "INSERT INTO Certificato values('" + lastNTess + "','SI','" + dtp_scadenzaCert.Value.ToString("yyyy-MM-dd") + "')";
                            }
                            else
                            {
                                command = "INSERT INTO Certificato(CodIscritto,Presente) values('" + lastNTess + "','NO')";
                            }

                            cmd.CommandText = command;
                            cmd.ExecuteNonQuery();

                            conn.Close();
                        }
                    }

                    MessageBox.Show("Inserimento avvenuto con successo!", "Inserimento");
                    this.Close();
                    addNewRata.Close();
                }
                else
                {
                    MessageBox.Show("Alcuni campi necessari non sono stati compilati oppure per favore ricontrolla se hai inserito correttamente i corsi."
                        +"Ricorda che tutti devono essere iscritti a GENERALE!",
                        "Errore Inserimento");
                }
            }
            else
            {
                MessageBox.Show("Alcuni campi necessari non sono stati compilati, per  favore inserisci un costo abbonameno non nullo",
                        "Errore Inserimento");
            }
        }

        private void btn_annulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkUsefulFields()
        {
            if(tb_nome.Text.Equals("")|| tb_cognome.Text.Equals("")|| tb_nTessera.Text.Equals("")|| dtp_dataFin.Value.Equals(dtp_dataIn.Value))
            {
                MessageBox.Show("Alcuni campi necessari non sono stati compilati, perfavore ricontrolla e aggiungi i dati necessari",
                    "Errore Inserimento");
                return false;
            }
            return true;
        }

        private bool checkCorsi()
        {
            CheckBox temp = new CheckBox();
            temp.Checked = true;
            temp.Hide();
            bool generalpresent = false;
            int cont = 0;
            foreach (DataGridViewRow row in dgv_selCorsi.Rows)
            {
                if(row.Cells["Corso"].Value.ToString().Equals("generale")&& Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    generalpresent = true;
                }
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    cont++;
                }
            }
            if(!generalpresent)
            {
                MessageBox.Show("'General' è l'abbonamento standard alla palestra, è quindi un campo necessario in ogni inserimento. \rPer favore inseriscilo tra i corsi!",
                    "Errore Inserimento");
            }
            if (cont!=0 && generalpresent)
            {
                return true;
            }
            return false;            
        }

        private void btn_rate_Click(object sender, EventArgs e)
        {
            if(tb_costo.Text.ToString().Equals(""))
            {
                MessageBox.Show("Per favore inserire il costo dell'abbonamento",
                   "Errore Inserimento");
            }
            else
            {
                if(hasRated ==false)
                {
                    
                    addNewRata.setCosto(tb_costo.Text.ToString());
                    addNewRata.Show();
                    hasRated = true;
                }else
                {
                    DialogResult result = MessageBox.Show("Hai gia stabilito una rateizzazione per questo utente sei sicuro di volerne creare una nuova?",
                            "Attenzione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Form_rate addNewRata = new Form_rate();
                        addNewRata.setCosto(tb_costo.Text.ToString());
                        addNewRata.Show();
                    }
                }               
                
            }                     
        }

        private string sqliteRealTypeconversion(string valuewihsemicolon)
        {
            return valuewihsemicolon.Replace(",", ".");
        }


    }
}
