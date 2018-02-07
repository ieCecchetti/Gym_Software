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
    public partial class Form_NewUser : Form
    {
        public Form_NewUser()
        {
            InitializeComponent();
        }

        private void Form_NewUser_Load(object sender, EventArgs e)
        {
            gb_modify.Enabled = false;
            gb_delete.Enabled = false;
            gb_add.Enabled = false;
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            cb_selUserMod.Items.Clear();
            cb_selUserDel.Items.Clear();
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
            {
                using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    conn.Open();
                    string command = "SELECT Username From User";
                    cmd.CommandText = command;
                    using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cb_selUserMod.Items.Add(reader["Username"]);
                            cb_selUserDel.Items.Add(reader["Username"]);
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void cb_selUserMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cb_selUserMod.SelectedItem.ToString();            
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
            {
                using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    conn.Open();
                    string command = "SELECT * From User where Username='" + selectedItem + "'";
                    cmd.CommandText = command;
                    using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tb_NomeMod.Text = reader["Username"].ToString();
                            tb_pswMod.Text = reader["Password"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void cb_selUserDel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cb_selUserDel.SelectedItem.ToString();
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
            {
                using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    conn.Open();
                    string command = "SELECT * From User where Username='" + selectedItem + "'";
                    cmd.CommandText = command;
                    using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tb_NomeDel.Text = reader["Username"].ToString();
                            tb_pswDel.Text = reader["Password"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
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

        private void cleanOpStory()
        {
            cb_selOp.Text = "";

            cb_selUserMod.Text = "";
            tb_NomeMod.Text = "";
            tb_pswMod.Text = "";

            cb_selUserDel.Text = "";
            tb_NomeDel.Text = "";
            tb_pswDel.Text = "";

            tb_nomeAdd.Text = "";
            tb_pswAdd.Text = "";
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            if (!tb_NomeMod.Text.Equals("") && !tb_pswMod.Equals(""))
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "UPDATE User SET Username='" + tb_NomeMod.Text + "', Password='" + tb_pswMod.Text + "' WHERE Username='" + cb_selUserMod.Text + "'";
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

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            if (!tb_NomeDel.Text.Equals("") && !tb_pswDel.Equals(""))
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "DELETE FROM User WHERE Username='"+cb_selUserDel.Text+"'";
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
                PrintError(1);
            }
        }

        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            if (!tb_nomeAdd.Text.Equals("") && !tb_pswAdd.Equals(""))
            {
                if (tb_pswAdd.Text.Equals(tb_pswReAdd.Text))
                {
                    using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                    {
                        using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                        {
                            conn.Open();
                            string command = "INSERT INTO User(Username,Password) VALUES ('" + tb_nomeAdd.Text + "','" + tb_pswAdd.Text + "');";
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
                    PrintError(2);
                }
                
            }
            else
            {
                PrintError(0);
            }
        }


        private void PrintError(int error)
        {
            string descrizione = "";
            switch (error)
            {
                case 0:
                    descrizione = "Alcuni campi necessari non sono stati compilati, perfavore ricontrolla e aggiungi i dati necessari";
                    break;
                case 1:
                    descrizione = "Per favore Seleziona lo user da cancellare!";
                    break;
                case 2:
                    descrizione = "La password scritta e quella reinserita per il controllo non coincidono! Per favore ridigita la giusta password";
                    break;
            }

            MessageBox.Show(descrizione, "Errore Inserimento");
        }

        private void lockGroupBox()
        {
            gb_modify.Enabled = false;
            gb_delete.Enabled = false;
            gb_add.Enabled = false;
            cleanOpStory();
        }

        private void btn_chiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
