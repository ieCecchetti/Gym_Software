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
    public partial class Form_displayInfo : Form
    {
        private Form_rate addNewRata;
        private Form_updateCorsi addNewCorsi;
        private bool hasRated, hasCurse = false;
        private int nTessera;
        DataTable tableRate = new DataTable();
        DataTable tableIscrizioni = new DataTable();

        public Form_displayInfo(int tessera)
        {
            InitializeComponent();
            nTessera = tessera;
        }

        private void Form_displayInfo_Load(object sender, EventArgs e)
        {
            tableRate.Columns.Add("Costo", typeof(double));
            tableRate.Columns.Add("Data", typeof(string));
            tableRate.Columns.Add("Pagato?", typeof(string));
            dgv_rate.DataSource = tableRate;
            LoadTable("Rate");

            tableIscrizioni.Columns.Add("Corso", typeof(string));
            dgv_corsi.DataSource = tableIscrizioni;
            LoadTable("Corso");

            loadInfo();

        }

        private void LoadTable(string tipo)
        {           
            if (tipo.Equals("Rate"))
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "Select * from Rata where CodIscritto='" + nTessera + "'";
                        cmd.CommandText = command;
                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tableRate.Rows.Add(reader["Costo"], reader["DataPagam"], reader["PagamentoAvv"]);
                            }
                        }
                        conn.Close();
                    }
                }
            }
            else
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "Select Nome from Frequenta join Corso on Frequenta.Id=Corso.Id  where CodIscritto='" + nTessera + "'";
                        cmd.CommandText = command;
                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tableIscrizioni.Rows.Add(reader["Nome"]);
                            }
                        }
                        conn.Close();
                    }
                }
            }
        }

        private void loadInfo()
        {
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
            {
                using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    conn.Open();
                    string command = "Select * from Iscritto left join Certificato on Iscritto.CodIscritto = Certificato.CodIscritto where Iscritto.CodIscritto = '" + nTessera + "'";
                    cmd.CommandText = command;
                    using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tb_nome.Text = reader["Nome"].ToString();
                            tb_cognome.Text = reader["Cognome"].ToString();
                            tb_dataN.Text = reader["DataN"].ToString();
                            tb_residenza.Text = reader["Residenza"].ToString();
                            tb_via.Text = reader["Via"].ToString();
                            tb_recapito.Text = reader["Recapito"].ToString();
                            tb_nTessera.Text = reader["Ntessera"].ToString();
                            tb_dataIn.Text = reader["DataIn"].ToString();
                            tb_dataFine.Text = reader["DataFine"].ToString();
                            tb_costo.Text = reader["Costo"].ToString();
                            tb_ingressi.Text = reader["NIngressi"].ToString();

                            tb_pres.Text = reader["Presente"].ToString();
                            tb_dataScad.Text = reader["DataScadenza"].ToString();

                        }
                    }
                    conn.Close();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            tb_cognome.Enabled = false;
            tb_nome.Enabled = false;
            tb_dataN.Enabled = false;
            tb_recapito.Enabled = false;
            tb_residenza.Enabled = false;
            tb_via.Enabled = false;
            tb_pres.Enabled = false;
            tb_dataIn.Enabled = false;
            tb_dataFine.Enabled = false;
            tb_ingressi.Enabled = false;
            tb_costo.Enabled = false;
            tb_dataScad.Enabled = false;
            //ricordo controllo date ben immesse
            btn_saveMod.Enabled = false;
            btn_saveMod.Visible = false;
            btn_annulla.Enabled = false;
            btn_annulla.Visible = false;
            btn_corsoMod.Enabled = false;
            btn_corsoMod.Visible = false;
            btn_rateMod.Enabled = false;
            btn_rateMod.Visible = false;
            btn_refreshCorsi.Enabled = false;
            btn_refreshCorsi.Visible = false;
            btn_refreshRate.Enabled = false;
            btn_refreshRate.Visible = false;

        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            tb_cognome.Enabled = true;
            tb_nome.Enabled = true;
            tb_dataN.Enabled = true;
            tb_recapito.Enabled = true;
            tb_residenza.Enabled = true;
            tb_via.Enabled = true;
            tb_pres.Enabled = true;
            tb_nTessera.Enabled = true;
            tb_dataIn.Enabled = true;
            tb_dataFine.Enabled = true;
            tb_ingressi.Enabled = true;
            tb_costo.Enabled = true;
            tb_dataScad.Enabled = true;
            //ricordo controllo date ben immesse
            btn_saveMod.Enabled = true;
            btn_saveMod.Visible = true;
            btn_annulla.Enabled = true;
            btn_annulla.Visible = true;
            btn_corsoMod.Enabled = true;
            btn_corsoMod.Visible = true;
            btn_rateMod.Enabled = true;
            btn_rateMod.Visible = true;
            //btn_refreshCorsi.Enabled = true;
            //btn_refreshCorsi.Visible = true;
            //btn_refreshRate.Enabled = true;
            //btn_refreshRate.Visible = true;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sei sicuro di voler eliminare questo contatto? Tutti i dati riguardanti questo iscritto verranno persi",
               "Attenzione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //sql elimina

                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "DELETE FROM Certificato WHERE CodIscritto = '" + nTessera+"';"+
                            " DELETE FROM Frequenta WHERE CodIscritto = '" + nTessera + "';" +
                            " DELETE FROM Rata WHERE CodIscritto = '" + nTessera + "';" +
                            " DELETE FROM Iscritto WHERE CodIscritto = '" + nTessera + "';";
                        cmd.CommandText = command;
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show(command);
                    }
                }

                this.Close();
            }
        }

        private void btn_saveMod_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sei sicuro di voler salvare le modifiche? Tutte le vecchie informazioni verranno sovrascritte",
               "Attenzione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (checkValidationCert() && cashControl() && checkValidationDate())
                {
                    //sql update
                    int tipoAbb = 0;
                    if (!tb_ingressi.Text.ToString().Equals("0") || !tb_ingressi.Text.ToString().Equals(""))
                    {
                        tipoAbb = 1; //abbonameno a  ingressi
                    }
                    else { tipoAbb = 0; }//abonameno std

                    if (checkUsefulFields() && checkCorsi())
                    {
                        using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                        {
                            using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                            {
                                conn.Open();

                                //controllo costo rispettato e date inserite bene

                                //-------------------------------------------------------------------QUERY INSERT ISCRITTI
                                string command = "UPDATE Iscritto SET Nome='" + tb_nome.Text + "', Cognome='" + tb_cognome.Text + "', DataN='" + tb_dataN.Text + "',  " +
                                    "Residenza='" + tb_residenza.Text + "', Via='" + tb_via.Text + "', Recapito='" + tb_recapito.Text + "', Ntessera='"+ tb_nTessera.Text +
                                    "', DataIn='" + tb_dataIn.Text + "', " + "DataFine='" + tb_dataFine.Text + "', NIngressi='" + tb_ingressi.Text + "', TipoAbb='" + tipoAbb 
                                    + "', Costo='" + tb_costo.Text + "' " +"WHERE CodIscritto='" + nTessera + "'";
                                cmd.CommandText = command;
                                cmd.ExecuteNonQuery();
                                //MessageBox.Show(command);

                                //-------------------------------------------------------------------QUERY INSERT FREQUENTA  (eliminare tutte quelle esistenti e rifarla)
                                command = "DELETE FROM Frequenta WHERE CodIscritto='" + nTessera + "'";
                                cmd.CommandText = command;
                                cmd.ExecuteNonQuery();

                                int IdCorso = 0;
                                foreach (DataGridViewRow row in dgv_corsi.Rows)
                                {

                                    command = "SELECT Id FROM Corso WHERE Nome='" + row.Cells[0].Value + "'";
                                    cmd.CommandText = command;
                                    cmd.ExecuteNonQuery();
                                    using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                                    {
                                        reader.Read();
                                        IdCorso = reader.GetInt32(0);
                                    }
                                    command = "INSERT INTO Frequenta values ('" + nTessera + "','" + IdCorso + "')";
                                    cmd.CommandText = command;
                                    cmd.ExecuteNonQuery();
                                    //MessageBox.Show(command);
                                }
                                //-------------------------------------------------------------------QUERY INSERT RATE
                                command = "DELETE FROM Rata WHERE CodIscritto='" + nTessera + "'";
                                cmd.CommandText = command;
                                cmd.ExecuteNonQuery();

                                foreach (DataGridViewRow row in dgv_rate.Rows)
                                {
                                    command = "INSERT INTO Rata values ('" + nTessera + "','" + row.Cells[0].Value + "','" + row.Cells[2].Value + "','" + row.Cells[1].Value + "')";
                                    cmd.CommandText = command;
                                    cmd.ExecuteNonQuery();
                                    //MessageBox.Show(command);
                                }

                                //-------------------------------------------------------------------QUERY INSERT CERTIFICATO
                                if (tb_pres.Text.ToUpper().Equals("SI"))
                                {
                                    command = "UPDATE Certificato SET Presente='SI', DataScadenza='" + tb_dataScad.Text + "' WHERE CodIscritto='" + nTessera + "'";
                                }
                                else
                                {
                                    command = "UPDATE Certificato SET Presente='NO', DataScadenza='" + tb_dataScad.Text + "' WHERE CodIscritto='" + nTessera + "'";
                                }

                                cmd.CommandText = command;
                                cmd.ExecuteNonQuery();
                                //MessageBox.Show(command);

                                conn.Close();
                            }
                        }

                        MessageBox.Show("Inserimento avvenuto con successo!", "Inserimento");
                        this.Close();
                    }
                }
                

            }
        }

        private void btn_rateMod_Click(object sender, EventArgs e)
        {
            if (!hasRated)
            {
                if (!tb_costo.Text.ToString().Equals(""))
                {
                    addNewRata = new Form_rate();
                    hasRated = true;
                    addNewRata.setCosto(tb_costo.Text.ToString());
                    addNewRata.SetPreCharge(nTessera);
                    addNewRata.Show();
                }
                else
                {
                    MessageBox.Show("Per favore inserire il costo dell'abbonamento",
                    "Errore Inserimento");

                }
            }else
            {
                DialogResult result = MessageBox.Show("Hai gia eseguito delle modifiche sulle date, continuando riappariranno i "+
                    "dati iniziali dell'abbonamento e le modifiche saranno perse",
               "Attenzione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    addNewRata = new Form_rate();
                    hasRated = true;
                    addNewRata.setCosto(tb_costo.Text.ToString());
                    addNewRata.SetPreCharge(nTessera);
                    addNewRata.Show();
                }
            }

        }


        private void btn_refreshRate_Click(object sender, EventArgs e)
        {
            tableRate.Clear();
            dgv_rate.DataSource = addNewRata.exportDatagrid();
        }

        private void btn_corsoMod_Click(object sender, EventArgs e)
        {
            addNewCorsi = new Form_updateCorsi();
            addNewCorsi.Show();
            hasCurse = true;
        }

        private void btn_refreshCorsi_Click(object sender, EventArgs e)
        {
            tableIscrizioni.Clear();
            dgv_corsi.DataSource = addNewCorsi.exportDatagrid();
        }

        private bool checkCorsi()
        {
            CheckBox temp = new CheckBox();
            temp.Checked = true;
            temp.Hide();
            int cont = 0;
            foreach (DataGridViewRow row in dgv_corsi.Rows)
            {
                cont++;
            }
            if (cont != 0)
            {
                return true;
            }
            return false;
        }

        private bool checkUsefulFields()
        {
            if (tb_nome.Text.Equals("") || tb_cognome.Text.Equals("") || tb_nome.Text.Equals("") || tb_dataFine.Text.Equals(tb_dataIn.Text))
            {
                MessageBox.Show("Alcuni campi necessari non sono stati compilati, perfavore ricontrolla e aggiungi i dati necessari",
                    "Errore Inserimento");
                return false;
            }
            return true;
        }

        private string sqliteRealTypeconversion(string valuewihsemicolon)
        {
            return valuewihsemicolon.Replace(",", ".");
        }

        private void Form_displayInfo_Activated(object sender, EventArgs e)
        {
            if(hasRated)
            {
                btn_refreshRate_Click(sender, e);
            }
            if (hasCurse)
            {
                btn_refreshCorsi_Click(sender, e);
            }           
            
        }

        private bool checkValidationCert()
        {
            if (tb_pres.Text.ToUpper().Equals("SI")|| tb_pres.Text.ToUpper().Equals("NO"))
            {
                return true;
            }
            MessageBox.Show("Perfavore indicare correttamente la presenza del certificato! (SI/NO) Nessuna altra opzione è utilizzabile",
                    "Errore Inserimento");
            return false;
        }

        private bool cashControl()
        {
            double tot = 0;
            foreach (DataGridViewRow row in dgv_rate.Rows)
            {
                tot += Convert.ToDouble(row.Cells[0].Value);
            }
            if (Double.Parse(tb_costo.Text.ToString()) == tot)
            {
                return true;
            }
            MessageBox.Show("Impossibile creare queste rate visto che il costo totale delle rate è maggiore o minore del costo dell'abbonamento!",
                    "Errore Rateizzazione");
            return false;
        }

        private bool checkValidationDate()
        {
            if (!tb_dataScad.Text.Equals(""))
            {
                if (DateChecker(tb_dataIn.Text) && DateChecker(tb_dataN.Text) && DateChecker(tb_dataFine.Text) && DateChecker(tb_dataScad.Text))
                {
                    return true;
                }
            }
            if (DateChecker(tb_dataIn.Text) && DateChecker(tb_dataN.Text) && DateChecker(tb_dataFine.Text))
            {
                return true;
            }
            MessageBox.Show("Alcune date sono state compilate in modo non corretto, perfavore assicurati di aver rispettato il formato AAAA-MM-GG",
                    "Errore Inserimento");
            return false;
        }

        private bool DateChecker(string date)
        {
            bool firstStep = false;
            bool secondStep = false;
            bool thirdStep = false;
            string part = string.Empty;
            //check the date model (AAAA-MM-DD) from the position of '-'
            if (date[4]=='-' && date[7] == '-')
            {               
                //check the values
                for (int i = 0; i < 3; i++)
                {
                    if (!string.IsNullOrEmpty(date))
                    {
                        part = date.Split('-')[i];
                        switch (i)
                        {
                            case 0:
                                if (int.Parse(part) > 1900)
                                {
                                    firstStep = true;
                                }
                                break;
                            case 1:
                                if (int.Parse(part) <= 12)
                                {
                                    secondStep = true;
                                }
                                break;
                            case 2:
                                if (int.Parse(part) <= 31)
                                {
                                    thirdStep = true;
                                }
                                break;
                        }
                    }
                }
                if (firstStep && secondStep && thirdStep)
                {
                    return true;
                }
            }            
            return false;
        }
    }
}
