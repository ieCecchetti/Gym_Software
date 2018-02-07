using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_Backup : Form
    {
        public Form_Backup()
        {
            InitializeComponent();
        }


        private void btn_chiudi_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void pb_choice1_MouseMove(object sender, MouseEventArgs e)
        {
            pb_choice1.BackColor = Color.IndianRed;
            lbl_choice1.BackColor = Color.IndianRed;
            lbl_choice1.ForeColor = Color.White;
        }

        private void pb_choice1_MouseLeave(object sender, EventArgs e)
        {
            pb_choice1.BackColor = Color.Transparent;
            lbl_choice1.BackColor = Color.Transparent;
            lbl_choice1.ForeColor = Color.Black;
        }

        private void pb_choice1_Click(object sender, EventArgs e)
        {
            panel_opzioniBackup.Visible = true;
            panel_backupManuale.Visible = false;
            panel_caricaDB.Visible = false;
            panel_onlineOp.Visible = false;
        }

        private void lbl_choice1_Click(object sender, EventArgs e)
        {
            pb_choice1_Click(sender, e);
        }

        private void pb_choice2_MouseMove(object sender, MouseEventArgs e)
        {
            pb_choice2.BackColor = Color.IndianRed;
            lbl_choice2.BackColor = Color.IndianRed;
            lbl_choice2.ForeColor = Color.White;
        }

        private void pb_choice2_MouseLeave(object sender, EventArgs e)
        {
            pb_choice2.BackColor = Color.Transparent;
            lbl_choice2.BackColor = Color.Transparent;
            lbl_choice2.ForeColor = Color.Black;
        }

        private void pb_choice2_Click(object sender, EventArgs e)
        {
            panel_opzioniBackup.Visible = false;
            panel_backupManuale.Visible = true;
            panel_caricaDB.Visible = false;
            panel_onlineOp.Visible = false;
        }

        private void lbl_choice2_Click(object sender, EventArgs e)
        {
            pb_choice2_Click(sender, e);
        }

        private void pb_choice3_MouseMove(object sender, MouseEventArgs e)
        {
            pb_choice3.BackColor = Color.IndianRed;
            lbl_choice3.BackColor = Color.IndianRed;
            lbl_choice3.ForeColor = Color.White;
        }

        private void pb_choice3_MouseLeave(object sender, EventArgs e)
        {
            pb_choice3.BackColor = Color.Transparent;
            lbl_choice3.BackColor = Color.Transparent;
            lbl_choice3.ForeColor = Color.Black;
        }

        private void pb_choice3_Click(object sender, EventArgs e)
        {
            panel_opzioniBackup.Visible = false;
            panel_backupManuale.Visible = false;
            panel_caricaDB.Visible = true;
            panel_onlineOp.Visible = false;
        }

        private void lbl_choice3_Click(object sender, EventArgs e)
        {
            pb_choice3_Click(sender, e);
        }

        private void pb_choice4_MouseMove(object sender, MouseEventArgs e)
        {
            pb_choice4.BackColor = Color.IndianRed;
            lbl_choice4.BackColor = Color.IndianRed;
            lbl_choice4.ForeColor = Color.White;
        }

        private void pb_choice4_MouseLeave(object sender, EventArgs e)
        {
            pb_choice4.BackColor = Color.Transparent;
            lbl_choice4.BackColor = Color.Transparent;
            lbl_choice4.ForeColor = Color.Black;
        }

        private void pb_choice4_Click(object sender, EventArgs e)
        {
            panel_opzioniBackup.Visible = false;
            panel_backupManuale.Visible = false;
            panel_caricaDB.Visible = false;
            panel_onlineOp.Visible = true;
        }

        private void lbl_choice4_Click(object sender, EventArgs e)
        {
            pb_choice4_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_backupPath.Text= Home.utils.selectFolder();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //save in config.txt
            string tempBackupPath = Home.path_backupFolder;
            string tempBackTime = Home.lastBackupData;
            if(!tb_backupPath.Text.Equals(""))
            {
                tempBackupPath = tb_backupPath.Text;
            }
            if (!cb_BackupTime.Text.Equals(""))
            {
                tempBackTime = cb_BackupTime.Text;
            }
            string[] lines = { @"PATH=" + tempBackupPath, "LAST_DB_NAME=" + Home.lastBackupDBName, "BACKUP_TIME=" + tempBackTime };

            // Set a variable to the My Documents path.
            string mydocpath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\config.txt"))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
            Home.utils.createFolderBackupDB(@tb_backupPath.Text);
            Home.path_backupFolder = @tb_backupPath.Text;
            Home.timeBuckup = cb_BackupTime.SelectedText;
            this.Close();
            

        }

        private void Form_Backup_Load(object sender, EventArgs e)
        {
            panel_opzioniBackup.Visible = true;
            panel_backupManuale.Visible = false;
            panel_caricaDB.Visible = false;
            panel_onlineOp.Visible = false;            
        }
        private void LoadCB() //load combobox
        {
            DirectoryInfo d = new DirectoryInfo(@Home.path_backupFolder);
            FileInfo[] Files = d.GetFiles("*.db"); //Getting Text files            
            foreach (FileInfo file in Files)
            {
                cb_DBlist.Items.Add(file.Name);
            }
        }

        private void btn_manualBack_Click(object sender, EventArgs e)
        {
            //Home.utils.BackupDB(Home.dbName, (Home.dbName + "[" + DateTime.Now + "]"), Home.path_backupFolder);
            Home.utils.BackupDB((Home.dbName + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".db"), Home.path_backupFolder);
            MessageBox.Show("Backup eseguito correttamente!",
                    "Backup");
            //Home.utils.renameFile(Home.dbName + ".db", (Home.dbName + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".db"),Home.path_backupFolder);
        }

        private void btn_goToBackDir_Click(object sender, EventArgs e)
        {
            Home.utils.openSelectedFolder(Home.path_backupFolder,1);
        }

        private void Form_Backup_Activated(object sender, EventArgs e)
        {
            LoadCB();
        }

        private void btn_ripristina_Click(object sender, EventArgs e)
        {

        }

        private void btn_LoadDB_Click(object sender, EventArgs e)
        {
            //utils.BackupDB(dbName + ".db", @"C:\backupDBgymSoftware");
            Home.utils.LoadBackup(cb_DBlist.Text,@Home.path_backupFolder);
            MessageBox.Show("Backup caricato correttamente!",
                    "Backup");
        }
    }
}
