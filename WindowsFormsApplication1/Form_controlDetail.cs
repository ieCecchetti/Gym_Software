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
    public partial class Form_controlDetail : Form
    {
        DataTable tableResultRate = new DataTable();
        DataTable tableResultCert = new DataTable();
        private string openType;
        public Form_controlDetail(string type)
        {
            InitializeComponent();
            openType = type;
        }

        private void Form_controlDetail_Load(object sender, EventArgs e)
        {
            tableResultRate.Columns.Add("Ntessera", typeof(string));
            tableResultRate.Columns.Add("Nome", typeof(string));
            tableResultRate.Columns.Add("Cognome", typeof(string));
            tableResultRate.Columns.Add("CodFisc", typeof(string));
            tableResultRate.Columns.Add("Recapito", typeof(string));
            tableResultRate.Columns.Add("Costo", typeof(string));
            tableResultRate.Columns.Add("Scadenza", typeof(string));
            dgv_resultRate.DataSource = tableResultRate;

            tableResultCert.Columns.Add("Ntessera", typeof(string));
            tableResultCert.Columns.Add("Nome", typeof(string));
            tableResultCert.Columns.Add("Cognome", typeof(string));
            tableResultCert.Columns.Add("CodFisc", typeof(string));
            tableResultCert.Columns.Add("Recapito", typeof(string));
            tableResultCert.Columns.Add("Pres", typeof(string));
            tableResultCert.Columns.Add("DataScad", typeof(string));
            dgv_resultCert.DataSource = tableResultCert;

            LoadTable();
        }

        private void LoadTable()
        {
            if(openType.Equals("Retro"))
            {
                dgv_resultRate.Visible = true;
                dgv_resultCert.Visible = false;
                lbl_typeOpDescr.Text = "Di seguito, nella tabella, sono riporati tutti gli iscritti che hanno delle rate da pagare arretrate";
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "SELECT Iscritto.CodIscritto,Iscritto.Nome,Iscritto.Cognome,Iscritto.CodFisc,Iscritto.Recapito,Iscritto.Ntessera,Rata.Costo,Rata.DataPagam "
                            + "FROM Rata join Iscritto on Rata.CodIscritto=Iscritto.CodIscritto "
                            + "WHERE DATE(DataPagam) < DATE('now') and (PagamentoAvv='NO') ";
                        cmd.CommandText = command;
                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tableResultRate.Rows.Add(reader["Ntessera"], reader["Nome"], reader["Cognome"], reader["CodFisc"], reader["Recapito"], reader["Costo"], reader["DataPagam"]);
                            }
                        }
                        conn.Close();
                    }
                }
            }
            if (openType.Equals("Next"))
            {
                dgv_resultRate.Visible = true;
                dgv_resultCert.Visible = false;
                lbl_typeOpDescr.Text = "Di seguito, nella tabella, sono riporati tutti gli iscritti che dovranno versare il pagamento della prossima rata da adesso a 2 settimane ";
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "SELECT Iscritto.CodIscritto,Iscritto.Nome,Iscritto.Cognome,Iscritto.CodFisc,Iscritto.Recapito,Iscritto.Ntessera,Rata.Costo,Rata.DataPagam "
                            + "FROM Rata join Iscritto on Rata.CodIscritto=Iscritto.CodIscritto "
                            + "WHERE DATE(DataPagam) <= DATE('now','+'||14||' days') and DATE(DataPagam) >= DATE('now') and (PagamentoAvv='NO') ";
                        cmd.CommandText = command;
                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tableResultRate.Rows.Add(reader["Ntessera"], reader["Nome"], reader["Cognome"], reader["CodFisc"], reader["Recapito"], reader["Costo"], reader["DataPagam"]);
                            }
                        }
                        conn.Close();
                    }
                }
            }
            if (openType.Equals("Cert"))
            {
                dgv_resultCert.Visible = true;
                dgv_resultRate.Visible = false;
                lbl_typeOpDescr.Text = "Di seguito, nella tabella, sono riporati tutti gli iscritti a cui è scaduto il certificato o a cui scadrà da adesso a 2 settimane ";
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "SELECT Iscritto.CodIscritto,Iscritto.Nome,Iscritto.Cognome,Iscritto.CodFisc,Iscritto.Recapito,Iscritto.Ntessera,Certificato.Presente, Certificato.DataScadenza "
                            + "FROM Certificato join Iscritto on Certificato.CodIscritto=Iscritto.CodIscritto "
                            + "WHERE DATE(DataScadenza) <= DATE('now','+'||14||' days') ";
                        cmd.CommandText = command;
                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tableResultCert.Rows.Add(reader["Ntessera"], reader["Nome"], reader["Cognome"], reader["CodFisc"], reader["Recapito"], reader["Presente"], reader["DataScadenza"]);
                            }
                        }
                        conn.Close();
                    }
                }
            }
            if (openType.Equals("CertNO"))
            {
                dgv_resultCert.Visible = true;
                dgv_resultRate.Visible = false;
                lbl_typeOpDescr.Text = "Di seguito, nella tabella, sono riporati tutti gli iscritti che non hanno presentato il certificato ";
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "SELECT Iscritto.CodIscritto,Iscritto.Nome,Iscritto.Cognome,Iscritto.CodFisc,Iscritto.Recapito,Iscritto.Ntessera,Certificato.Presente, Certificato.DataScadenza "
                            + "FROM Certificato join Iscritto on Certificato.CodIscritto=Iscritto.CodIscritto "
                            + "WHERE Certificato.Presente='NO'";
                        cmd.CommandText = command;
                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tableResultCert.Rows.Add(reader["Ntessera"], reader["Nome"], reader["Cognome"], reader["CodFisc"], reader["Recapito"], reader["Presente"], "NULL");
                            }
                        }
                        conn.Close();
                    }
                }
            }

        }

        private void btn_chiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_controlDetail_Activated(object sender, EventArgs e)
        {
            tableResultRate.Clear();
            tableResultCert.Clear();
            LoadTable();
        }
    }
}
