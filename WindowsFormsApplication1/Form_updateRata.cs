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
    public partial class Form_updateRata : Form
    {
        private bool isModSel, isAddSel = false;
        private int nTessera;
        DataTable tableRate = new DataTable();
        private int selectedRow = -1;
        private string sql_rateQuery;
        public Form_updateRata(int tessera)
        {
            InitializeComponent();
            nTessera = tessera;
        }

        private void Form_updateRata_Load(object sender, EventArgs e)
        {
            tableRate.Columns.Add("Costo", typeof(string));
            tableRate.Columns.Add("Data", typeof(string));
            tableRate.Columns.Add("Pagato?", typeof(string));
            dgv_rate.DataSource = tableRate;
            LoadProfile();
            LoadTable();
        }

        private void LoadTable()
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
                            tableRate.Rows.Add(reader["Costo"], reader["DataPagam"],reader["PagamentoAvv"]);
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void LoadProfile()
        {
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
            {
                using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    conn.Open();
                    string command = "Select * from Iscritto where CodIscritto='" + nTessera + "'";
                    cmd.CommandText = command;
                    using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lbl_nome.Text = reader["Nome"].ToString() + " " + reader["Cognome"].ToString();
                            tb_costoTot.Text = reader["Costo"].ToString();
                            tb_dataIn.Text = reader["DataIn"].ToString();
                            tb_dataFine.Text = reader["DataFine"].ToString();
                        }                        
                    }
                    conn.Close();
                }
            }
        }

        private void btn_cancella_Click(object sender, EventArgs e)
        {
            if(isModSel||isAddSel)
            {
                MessageBox.Show("Impossibile selezionare più operazioni allo stesso tempo, concludere quella di aggiunta o modifica attiva e riprovare!",
                       "Troppe operazioni selezionate");
            }
            else
            {
                if (selectedRow != -1)
                {
                    dgv_rate.Rows.RemoveAt(selectedRow);
                }
                else
                {
                    MessageBox.Show("Nessuna riga selezionata, perfavore seleziona e riprova",
                        "Errore Selezione");
                }
            }         
            
        }

        private void btn_modifica_Click(object sender, EventArgs e)
        {
            if (!isAddSel)
            {                
                isModSel = true;
                gb_dettagli.Enabled = true;
                if (selectedRow != -1)
                {
                    if (!dgv_rate.Rows[selectedRow].Cells[2].Value.ToString().Equals("SI"))
                    {
                        tb_costo.Text = dgv_rate.Rows[selectedRow].Cells[0].Value.ToString();
                        dtp_dataPagam.Value = DateTime.Parse(dgv_rate.Rows[selectedRow].Cells[1].Value.ToString());
                        if (dgv_rate.Rows[selectedRow].Cells[2].Value.ToString().Equals("SI"))
                        {
                            cb_scelta.SelectedIndex = 0;
                        }
                        else
                        {
                            cb_scelta.SelectedIndex = 1;
                        }
                        lbl_costo.ForeColor = lbl_modTip.ForeColor;
                        lbl_data.ForeColor = lbl_modTip.ForeColor;
                        lbl_pagato.ForeColor = lbl_modTip.ForeColor;
                    }
                    else
                    {
                        MessageBox.Show("La rata è gia stata pagata e non è possibile modificarla, eliminarla e reinserirla se la si vuole cambiare ",
                        "Rata non modificabile");
                        btn_annullaOP_Click(sender, e);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Nessuna riga selezionata, per favore seleziona e riprova",
                        "Errore Selezione");
                }
            }else
            {
                MessageBox.Show("Impossibile selezionare più operazioni allo stesso tempo, concludere quella di aggiunta e riprovare!",
                       "Troppe operazioni selezionate");
            }
        }

        private void dgv_rate_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                selectedRow = dgv_rate.CurrentCell.RowIndex;
            }
            catch(Exception ex)
            {

            }
            
        }

        private void btn_applica_Click(object sender, EventArgs e)
        {
            gb_dettagli.Enabled = false;
            if (lbl_costo.ForeColor == lbl_aggTip.ForeColor)  //significa che ho seguito la proc di aggiunta
            {
                tableRate.Rows.Add(tb_costo.Text.ToString(), dtp_dataPagam.Value.ToString("yyyy-MM-dd"), cb_scelta.Text.ToString());
                isAddSel = false;
            }
            else   //significa che ho seguito la proc di modifica
            {
                tableRate.Rows.RemoveAt(selectedRow);
                tableRate.Rows.Add(tb_costo.Text.ToString(), dtp_dataPagam.Value.ToString("yyyy-MM-dd"), cb_scelta.Text.ToString());
                isModSel = false;
            }
            lbl_costo.ForeColor = lbl_delTip.ForeColor;
            lbl_data.ForeColor = lbl_delTip.ForeColor;
            lbl_pagato.ForeColor = lbl_delTip.ForeColor;
            tb_costo.Text = "";
            dtp_dataPagam.Text = "";
            cb_scelta.Text = "";

        }

        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            if (!isModSel)
            {
                isAddSel = true;
                gb_dettagli.Enabled = true;
                lbl_costo.ForeColor = lbl_aggTip.ForeColor;
                lbl_data.ForeColor = lbl_aggTip.ForeColor;
                lbl_pagato.ForeColor = lbl_aggTip.ForeColor;
            }else
            {
                MessageBox.Show("Impossibile selezionare più operazioni allo stesso tempo, concludere quella di modifica e  riprovare!",
                       "Troppe operazioni selezionate");
            }
            
        }

        private void btn_annullaOP_Click(object sender, EventArgs e)
        {
            gb_dettagli.Enabled = false;
            isAddSel = false;
            isModSel = false;
        }

        private void btn_salva_Click(object sender, EventArgs e)
        {
            if (cashControl())
            {
                //query dynamic ggen
                foreach (DataGridViewRow row in dgv_rate.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        sql_rateQuery += "INSERT INTO Rata values('" + (nTessera) + "','" + row.Cells[0].Value.ToString() + "','" + row.Cells[2].Value.ToString() + "','" + row.Cells[1].Value.ToString() + "'); ";
                    }
                }
                MessageBox.Show("Modifica/Aggiunta/Cancellazione delle rate avenuta con successo!",
                    "Rateizzazione riuscita");

                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        cmd.CommandText = "DELETE FROM Rata WHERE CodIscritto='" + nTessera+"'";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = sql_rateQuery;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }


                this.Close();
            }
            else
            {
                MessageBox.Show("Impossibile creare queste rate visto che il costo totale delle rate è maggiore o minore del costo dell'abbonamento!",
                    "Errore Rateizzazione");
            }
        }

        private bool cashControl()
        {
            double tot = 0;
            foreach (DataGridViewRow row in dgv_rate.Rows)
            {
                tot += Convert.ToDouble(row.Cells[0].Value);
            }
            if (double.Parse(tb_costoTot.Text.ToString()) == tot)
            {
                return true;
            }
            return false;
        }

        private void btn_annulla_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sei sicuro di voler uscire? Le modifiche apportatate non verranno salvate",
                "Attenzione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }            
        }
    }
}



//ricordo di mettere tutta la combobox not enable fino a che non premo uno dei tasti delle operazioni, e  disabilito i tasti una volta premuto uno!!