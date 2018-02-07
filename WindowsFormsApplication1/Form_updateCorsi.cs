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
    public partial class Form_updateCorsi : Form
    {
        public Form_updateCorsi()
        {
            InitializeComponent();
        }

        DataTable tableCorsi = new DataTable();

        private void Form_updateCorsi_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
            checkbox.HeaderText = "Seleziona";
            dgv_selCorsi.Columns.Add(checkbox);
            tableCorsi.Columns.Add("Corso", typeof(string));
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
                            tableCorsi.Rows.Add(reader["Nome"]);
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void btn_salva_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow row in dgv_selCorsi.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == false)
                {
                    tableCorsi.Rows.RemoveAt(i);
                }
                i++;
            }
            this.Close();
        }


        public DataTable exportDatagrid()
        {
            int i = 0;
            foreach (DataGridViewRow row in dgv_selCorsi.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == false)
                {
                    tableCorsi.Rows.RemoveAt(i);
                }
                i++;
            }
            return tableCorsi;
        }

        private void btn_annulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
