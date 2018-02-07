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
    public partial class Form_rate : Form
    {
        public bool hasSaved=false;
        private bool preChargeNeed = false;
        private static double costo;
        private int selectedRow=-1;
        private int nRate = 0;
        private string sql_rateQuery;
        private int Ntess;
        private bool isLoad=false;
        public Form_rate()
        {           
            InitializeComponent();
        }

        DataTable tableRate = new DataTable();

        private void Form_rate_Load(object sender, EventArgs e)
        {
            lbl_tip.Text = "*Nel caso di costo decimale mettere \r    la virgola e NON il punto";
            tb_costo.Text = costo.ToString();
            sql_rateQuery = "";
            Ntess = getNtess();
            isLoad = true;           

            tableRate.Columns.Add("Costo", typeof(string));
            tableRate.Columns.Add("Data Pagamento", typeof(string));
            tableRate.Columns.Add("Avventuto?", typeof(string));           
            dgv_rate.DataSource = tableRate;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tableRate.Rows.Add(tb_newRowCosto.Text.ToString(), dtp_newRowData.Value.ToString("yyyy-MM-dd"), cb_newRowPagato.Text.ToString());
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_newRowCosto.Text = "";
            dtp_newRowData.Value = DateTime.Now;
            cb_newRowPagato.Text = "";
        }


        private void dgv_rate_SelectionChanged(object sender, EventArgs e)
        {
            selectedRow = dgv_rate.SelectedRows.Count;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(selectedRow!=-1)
            {
                dgv_rate.Rows.RemoveAt(selectedRow - 1);
            }            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cashControl())
            {
                hasSaved = true;
                //query dynamic gen
                sql_rateQuery = "";
                generateRate();
                MessageBox.Show("Creazione delle rate avvenuta con successo!",
                    "Rateizzazione avvenuta");
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
            if(costo==tot)
            {
                return true;
            }
            return false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sei sicuro di voler uscire? Le modifiche apportatate non verranno salvate",
                "Attenzione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //return to stored data
                if (preChargeNeed)
                {
                    tableRate.Clear();
                    using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                    {
                        using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                        {
                            conn.Open();
                            string command = "Select * from Rata where CodIscritto='" + (Ntess) + "'";
                            cmd.CommandText = command;
                            using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    tableRate.Rows.Add(reader["Costo"], reader["PagamentoAvv"], reader["DataPagam"]);

                                }
                            }
                            conn.Close();
                        }
                    }
                }
                this.Close();
            }
        }

        public void generateRate()
        {                        
            if (hasSaved)  //getNRate() > 1
            {                               
                foreach (DataGridViewRow row in dgv_rate.Rows)
                {
                    if (row.Cells[0].Value!=null)
                    {
                        sql_rateQuery += "INSERT INTO Rata values('" + (Ntess+1) + "','" + sqliteRealTypeconversion(row.Cells[0].Value.ToString()) + "','" + row.Cells[2].Value.ToString() + "','" + row.Cells[1].Value.ToString() + "'); ";
                    }
                }
            }
            else
            {
                Ntess = getNtess();
                sql_rateQuery = "INSERT INTO Rata values('" + (Ntess) + "','" +sqliteRealTypeconversion(costo.ToString())+ "','NO',DATE('now')); ";
                MessageBox.Show("Non sono state stabilite rate per questo iscritto, è stata aggiunta un unica rata da pagare pari al costo dell'abbonamento!",
                       "Info Rateizzazione");
            }         
           
        }

        public string getRateQuery()
        {
            generateRate();
            return sql_rateQuery;    
        }

        public int getNtess()
        {
            if (!preChargeNeed)
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        cmd.CommandText = "SELECT CodIscritto FROM Iscritto WHERE   CodIscritto = (SELECT MAX(CodIscritto)  FROM Iscritto);";
                        cmd.ExecuteNonQuery();
                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader.GetInt32(0);
                            }
                            
                        }
                        conn.Close();
                    }
                }
            }
            return Ntess;
            
        }

        private int getNRate()
        {
            return dgv_rate.RowCount;
        }

        public void setCosto(string temp)
        {
            costo = Double.Parse(temp);

        }

        private string sqliteRealTypeconversion(string valuewihsemicolon)
        {
            return valuewihsemicolon.Replace(",", ".");
        }

        public DataTable exportDatagrid()           
        {
            return tableRate;
        }

        public void SetPreCharge(int Ntessera)
        {
            preChargeNeed = true;
            Ntess = Ntessera;
        }

        private void Form_rate_Shown(object sender, EventArgs e)
        {
            if(preChargeNeed)
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "Select * from Rata where CodIscritto='" + (Ntess) + "'";
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
            
        }
    }
}
