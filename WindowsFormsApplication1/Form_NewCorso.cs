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
    public partial class Form_NewCorso : Form
    {
        public Form_NewCorso()
        {
            InitializeComponent();
        }

        private void btn_chiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_selOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanOpStory();
            switch (cb_selOp.SelectedIndex)
            {
                case 0:
                    gb_modify.Enabled = true;
                    gb_delete.Enabled = false;
                    gb_add.Enabled = false;
                    break;
                case 1:
                    gb_modify.Enabled = false;
                    gb_delete.Enabled = true;
                    gb_add.Enabled = false;
                    break;
                case 2:
                    gb_modify.Enabled = false;
                    gb_delete.Enabled = false;
                    gb_add.Enabled = true;
                    break;               
                

            }
        }

        private void Form_NewCorso_Load(object sender, EventArgs e)
        {
            gb_modify.Enabled = false;
            gb_delete.Enabled = false;
            gb_add.Enabled = false;
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            cb_selCorsoMod.Items.Clear();
            cb_selCorsoDel.Items.Clear();
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
            {
                using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    conn.Open();
                    string command = "SELECT Nome,Id From Corso";
                    cmd.CommandText = command;
                    using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {                           
                            cb_selCorsoDel.Items.Add(reader["Nome"]+ " [cod: "+reader["Id"]+"]");
                            cb_selCorsoMod.Items.Add(reader["Nome"] + " [cod: " + reader["Id"] + "]");
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void cb_selCorsoMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cb_selCorsoMod.SelectedItem.ToString();
            string codSelected = cb_selCorsoMod.SelectedItem.ToString().Split(':')[1].Substring(0, 2);
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
            {
                using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    conn.Open();
                    string command = "SELECT * From Corso where Id='"+codSelected+"'";
                    cmd.CommandText = command;
                    using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tb_NomeMod.Text = reader["Nome"].ToString();
                            tb_dataInMod.Text = reader["DataIn"].ToString();
                            tb_dataFineMod.Text = reader["DataFin"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void cb_selCorsoDel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cb_selCorsoDel.SelectedItem.ToString();
            string codSelected = cb_selCorsoDel.SelectedItem.ToString().Split(':')[1].Substring(0, 2);
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
            {
                using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    conn.Open();
                    string command = "SELECT * From Corso where Id='" + codSelected + "'";
                    cmd.CommandText = command;
                    using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tb_NomeDel.Text = reader["Nome"].ToString();
                            tb_dataInDel.Text = reader["DataIn"].ToString();
                            tb_dataFineDel.Text = reader["DataFin"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void cleanOpStory()
        {
            cb_selCorsoMod.Text = "";
            tb_NomeMod.Text = "";
            tb_dataInMod.Text = "";
            tb_dataFineMod.Text = "";

            cb_selCorsoDel.Text = "";
            tb_NomeDel.Text = "";
            tb_dataInDel.Text = "";
            tb_dataFineDel.Text = "";

            tb_NomeAdd.Text = "";
            dtp_dataInAdd.Text = "";
            dtp_dataFineAdd.Text = "";

        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            if (!tb_NomeMod.Text.Equals("") && !tb_dataInMod.Equals("") && !tb_dataFineMod.Text.Equals(""))
            {
                string codSelected = cb_selCorsoMod.SelectedItem.ToString().Split(':')[1].Substring(0, 2);
                if (DateChecker(tb_dataInMod.Text) && DateChecker(tb_dataFineMod.Text))
                {
                    using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                    {
                        using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                        {
                            conn.Open();
                            string command = "UPDATE Corso SET Nome='" + tb_NomeMod.Text + "', DataIn='" + tb_dataInMod.Text + "', DataFin='" + tb_dataFineMod.Text + "'" +
                                " WHERE Id='" + codSelected + "'";
                            cmd.CommandText = command;
                            cmd.ExecuteNonQuery();
                            //MessageBox.Show(command);
                            MessageBox.Show("Elemento modificato con successo!", "Modifica avvenuta");
                            conn.Close();
                        }
                    }
                    LoadComboBox();
                    lockGroupBox();
                }
                else
                {
                    PrintError(0);
                }
            }
            else
            {
                PrintError(1);
            }            
        }

        

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            if (!cb_selCorsoDel.Text.Equals(""))
            {
                string codSelected = cb_selCorsoDel.SelectedItem.ToString().Split(':')[1].Substring(0, 2);
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "DELETE FROM Corso WHERE Id='" + codSelected + "'";
                        cmd.CommandText = command;
                        cmd.ExecuteNonQuery();
                        command = "DELETE FROM Frequenta WHERE Id='" + codSelected + "'";
                        cmd.CommandText = command;
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show(command);
                        MessageBox.Show("Elemento eliminato con successo!", "Eliminazione avvenuta");
                        conn.Close();
                    }
                }
                LoadComboBox();
                lockGroupBox();
            }
            else
            {
                PrintError(3);
            }            
        }

        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            if(!tb_NomeAdd.Text.Equals("") && !dtp_dataInAdd.Equals("") && !dtp_dataFineAdd.Text.Equals(""))
            {
                if(DateTime.Compare(dtp_dataInAdd.Value,dtp_dataFineAdd.Value)==-1)
                {
                    if (DateChecker(dtp_dataInAdd.Value.ToString("yyyy-MM-dd")) && DateChecker(dtp_dataFineAdd.Value.ToString("yyyy-MM-dd")))
                    {
                        using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                        {
                            using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                            {
                                conn.Open();
                                string command = "INSERT INTO Corso(Nome,DataIn,DataFin) VALUES('" + tb_NomeAdd.Text + "', " +
                                    "'" + dtp_dataInAdd.Value.ToString("yyyy-MM-dd") + "','" + dtp_dataFineAdd.Value.ToString("yyyy-MM-dd") + "')";
                                cmd.CommandText = command;
                                cmd.ExecuteNonQuery();
                                //MessageBox.Show(command);
                                MessageBox.Show("Inserimento avvenuto con successo!", "Inserimento avvenuto");
                                conn.Close();
                            }
                        }
                        LoadComboBox();
                        lockGroupBox();
                    }
                    else
                    {
                        PrintError(0);
                    }
                }
                else
                {
                    PrintError(4);
                }
            }
            else
            {
                PrintError(1);
            }            
        }

        private bool DateChecker(string date)
        {
            bool firstStep = false;
            bool secondStep = false;
            bool thirdStep = false;
            string part = string.Empty;
            //check the date model (AAAA-MM-DD) from the position of '-'
            if (date[4] == '-' && date[7] == '-')
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

        private void PrintError(int error)
        {
            string descrizione = "";
            switch(error)
            {
                case 0:
                    descrizione = "Alcune date sono state compilate in modo non corretto, perfavore assicurati di aver rispettato il formato AAAA-MM-GG";
                    break;
                case 1:
                    descrizione = "Alcuni campi necessari non sono stati compilati, perfavore ricontrolla e aggiungi i dati necessari";
                    break;
                case 3:
                    descrizione = "Per favore Seleziona il corso da cancellare!";
                    break;
                case 4:
                    descrizione = "La data di inizio corso non può essere maggiore o uguale alla data di fine!";
                    break;
            }
                
            MessageBox.Show(descrizione,"Errore Inserimento");
        }

        private void lockGroupBox()
        {
            gb_modify.Enabled = false;
            gb_delete.Enabled = false;
            gb_add.Enabled = false;
            cleanOpStory();
        }


    }
}
