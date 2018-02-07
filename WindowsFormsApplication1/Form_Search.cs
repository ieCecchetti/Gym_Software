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
    public partial class Form_Search : Form
    {
        private string formFunction;
        private string order="Nome";
        private int[] CodIscritti;
        public Form_Search()
        {
            InitializeComponent();
        }

        DataTable tableSearch = new DataTable();

        private void Form_Search_Load(object sender, EventArgs e)
        {      
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.UseColumnTextForButtonValue = true;
            button.Text = "Vai";
            button.DefaultCellStyle.BackColor = Color.Red;
            tableSearch.Columns.Add("Ntessera", typeof(string));
            tableSearch.Columns.Add("Nome", typeof(string));
            tableSearch.Columns.Add("Cognome", typeof(string));
            tableSearch.Columns.Add("CodFisc", typeof(string));
            tableSearch.Columns.Add("DataNascita", typeof(string));
            tableSearch.Columns.Add("Residenza", typeof(string));
            dgv_search.DataSource = tableSearch;

            if (formFunction.Equals("payment"))
            {
                button.HeaderText = "Profilo pagamenti";                             
            }
            else
            {
                button.HeaderText = "Profilo iscritto";                
            }
            dgv_search.Columns.Add(button);
            LoadTable();
        }

        public void setFunction(string function)
        {
            formFunction = function;
        }

        private void btn_cerca_Click(object sender, EventArgs e)
        {
            if (!tb_nome.Text.ToString().Equals("") && tb_cognome.Text.ToString().Equals(""))
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        tableSearch.Clear();
                        string command = "Select Ntessera,Nome,Cognome,CodFisc,DataN,Residenza from Iscritto where UPPER(Nome)=UPPER('" + tb_nome.Text.ToString() + "') ORDER BY "+order+";";
                        cmd.CommandText = command;
                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tableSearch.Rows.Add(reader["Ntessera"], reader["Nome"], reader["Cognome"], reader["CodFisc"], reader["DataN"], reader["Residenza"]);
                            }
                        }
                        conn.Close();
                    }
                }
            }

            if (tb_nome.Text.ToString().Equals("") && !tb_cognome.Text.ToString().Equals(""))
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        tableSearch.Clear();
                        string command = "Select Ntessera,Nome,Cognome,CodFisc,DataN,Residenza from Iscritto where UPPER(Cognome)=UPPER('" + tb_cognome.Text.ToString() + "') ORDER BY " + order + ";";
                        cmd.CommandText = command;
                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tableSearch.Rows.Add(reader["Ntessera"], reader["Nome"], reader["Cognome"], reader["CodFisc"], reader["DataN"], reader["Residenza"]);
                            }
                        }
                        conn.Close();
                    }
                }
            }

            if (!tb_nome.Text.ToString().Equals("") && !tb_cognome.Text.ToString().Equals(""))
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        tableSearch.Clear();
                        string command = "Select Ntessera,Nome,Cognome,DataN,CodFisc,Residenza from Iscritto where UPPER(Nome)=UPPER('" + tb_nome.Text.ToString() + "') and UPPER(Cognome)=UPPER('" + tb_cognome.Text.ToString() + "') ORDER BY " + order + ";";
                        cmd.CommandText = command;
                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tableSearch.Rows.Add(reader["Ntessera"], reader["Nome"], reader["Cognome"], reader["CodFisc"], reader["DataN"], reader["Residenza"]);
                            }
                        }
                        conn.Close();
                    }
                }
            }

            if (!tb_nome.Text.ToString().Equals("") && !tb_cognome.Text.ToString().Equals(""))
            {
                LoadTable();
            }


        }

        private void dgv_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int Ntessera = 0;

            if(!dgv_search["Ntessera", e.RowIndex].Value.ToString().Equals(""))
            {
                Ntessera = Int32.Parse(dgv_search["Ntessera", e.RowIndex].Value.ToString());

                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "Select CodIscritto FROM Iscritto Where Ntessera='" + Ntessera + "';";
                        cmd.CommandText = command;
                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Ntessera = int.Parse(reader["CodIscritto"].ToString());
                            }
                        }
                        conn.Close();
                    }
                }

                if (e.ColumnIndex == 5 && e.RowIndex >= 0)
                {
                    if (formFunction.Equals("payment"))
                    {
                        //lunch form Update_Payment
                        Form_updateRata updateRate = new Form_updateRata(Ntessera);
                        updateRate.Show();
                    }
                    else
                    {
                        //lunch form Search_Result
                        Form_displayInfo Result = new Form_displayInfo(Ntessera);
                        Result.Show();
                    }
                }
            }else
            {
                MessageBox.Show("Riga non valida, per favore clicca una riga che non sia vuota!",
                    "Errore Selezione");
            }
            
        }
        private void LoadTable()
        {
            tableSearch.Clear();
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
            {
                using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    conn.Open();
                    string command = "";
                    command = "Select Ntessera,Nome,Cognome,CodFisc,DataN,Residenza from Iscritto ORDER BY " + order + ";";
                    cmd.CommandText = command;
                    using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tableSearch.Rows.Add(reader["Ntessera"], reader["Nome"], reader["Cognome"], reader["CodFisc"], reader["DataN"], reader["Residenza"]);
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void btn_elenco_Click(object sender, EventArgs e)
        {
            tableSearch.Clear();
            LoadTable();
        }

        private void btn_chiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Search_Activated(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void cb_order_SelectedIndexChanged(object sender, EventArgs e)
        {
            order = cb_order.Text;
            btn_cerca_Click(this, e);
        }
    }
}
