using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Reflection;

namespace WindowsFormsApplication1
{
    public partial class Home : Form
    {
        public static string dbName = "gestionalePalestra";
        public static string path_backupFolder = "";
        public static string lastBackupDBName = "";
        public static string lastBackupData = ""; //	M/d/yyyy
        public static string timeBuckup = "";
        private int currentImg=0;
        private Timer timerLoading;
        private Timer timerImageShow; 
        public static string actualUser;
        public static int actualUserId;
        static int sizeMenuIem = 90;
        static String globalUsername = "Temp";
        static String globalPassword = "QWERT1234";
        public static  Class_utility utils = new Class_utility();
        //variable for pass recovery
        private static string MailAccount = "ienricocecchetti@gmail.com";
        private static string MailPassword = "ingpassword";
        private static string MailReceiverAccount = "cekke93@hotmail.it";

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {            
            init();
            chargeConfig();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void init()
        {
            //the firstrunop execute only if the db is empty! not ever at start (all the op are into one catch) 
            firstRunOperations();
            if (findEvaders() != 0 || findNextToPay() != 0)
            {
                pb_controlNotify.Visible = true;
            }
            sizeMenuIem = pb_setting.Size.Width;
            panelLogin.Visible = true;
            panelMenu.Visible = false;
            panelIntro.Visible = false;
            panelControl.Visible = false;
            StartTimerImage();       
        }
        

        private void btn_entra_Click(object sender, EventArgs e)
        {           
            
            if (checkCredential()||((tb_username.Text.Equals(globalUsername)) && (tb_password.Text.Equals(globalPassword))))
            {
                MessageBox.Show("Benvenuto/a " + tb_username.Text + " nel software Natural Center!", "Benvenuto/a");
                panelLogin.Visible = false;
                panelMenu.Visible = true;
                panelIntro.Visible = true;                                
                lbl_User.Text = tb_username.Text;
            }
            else
                MessageBox.Show("Impossibile riconoscere questo account e questa password! Controlla se sono state ben digiate e riprova.",
                    "Errore Login");
        }

        private void btn_annulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sei sicuro di voler abbandonare la sessione?",
                "Attenzione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                panelLogin.Visible = true;
                panelMenu.Visible = false;
                panelIntro.Visible = false;
                panelControl.Visible = false;
                tb_password.Text = "";
            }
        }

        private void btn_temp_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelMenu.Visible = true;
            panelIntro.Visible = true;
        }

        private bool checkCredential()
        {        
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
            {
                using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    conn.Open();
                    string command = "Select * from User where username= '" + tb_username.Text + "' and password='" + tb_password.Text + "'";
                    cmd.CommandText = command;
                    using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            actualUser= reader["Username"].ToString();
                            actualUserId = Int16.Parse(reader["Id"].ToString());
                            return true;
                        }
                    }
                    conn.Close();
                }
            }
            return false;
        }

      
        private void hoverAnimation(int menuIem,int increaseSize)
        {
            switch (menuIem)
            {
                case 1:
                    if (!(pb_newSub.Size.Width > sizeMenuIem))
                    {
                        pb_newSub.Width = sizeMenuIem + increaseSize;
                        pb_newSub.Height = sizeMenuIem + increaseSize;                 
                        pb_newSub.Location = new Point(pb_newSub.Location.X - increaseSize, pb_newSub.Location.Y - increaseSize);
                    }
                    break;
                case 2:
                    if (!(pb_payment.Size.Width > sizeMenuIem))
                    {
                        pb_payment.Width = sizeMenuIem + increaseSize;
                        pb_payment.Height = sizeMenuIem + increaseSize;                       
                        pb_payment.Location = new Point(pb_payment.Location.X - increaseSize, pb_payment.Location.Y - increaseSize);
                    }
                    break;
                case 3:
                    if (!(pb_paymenyAllert.Size.Width > sizeMenuIem))
                    {
                        pb_paymenyAllert.Width = sizeMenuIem + increaseSize;
                        pb_paymenyAllert.Height = sizeMenuIem + increaseSize;                     
                        pb_paymenyAllert.Location = new Point(pb_paymenyAllert.Location.X - increaseSize, pb_paymenyAllert.Location.Y - increaseSize);
                    }
                    break;
                case 4:
                    if (!(pb_research.Size.Width > sizeMenuIem))
                    {
                        pb_research.Width = sizeMenuIem + increaseSize;
                        pb_research.Height = sizeMenuIem + increaseSize;                        
                        pb_research.Location = new Point(pb_research.Location.X - increaseSize, pb_research.Location.Y - increaseSize);
                    }
                    break;
                case 5:
                    if (!(pb_setting.Size.Width > sizeMenuIem))
                    {
                        pb_setting.Width = sizeMenuIem + increaseSize;
                        pb_setting.Height = sizeMenuIem + increaseSize;                        
                        pb_setting.Location = new Point(pb_setting.Location.X - increaseSize, pb_setting.Location.Y - increaseSize);
                    }
                    break;

            }        

        }
        private void leaveAnimation(int menuIem, int decreaseSize)
        {
            switch (menuIem)
            {
                case 1:                    
                       pb_newSub.Width = sizeMenuIem;
                       pb_newSub.Height = sizeMenuIem;
                       pb_newSub.Location = new Point(pb_newSub.Location.X + decreaseSize, pb_newSub.Location.Y + decreaseSize);
                                                         
                    break;
                case 2:                    
                       pb_payment.Width = sizeMenuIem;
                       pb_payment.Height = sizeMenuIem;
                       pb_payment.Location = new Point(pb_payment.Location.X + decreaseSize, pb_payment.Location.Y + decreaseSize);
                    
                    break;
                case 3:                    
                       pb_paymenyAllert.Width = sizeMenuIem;
                       pb_paymenyAllert.Height = sizeMenuIem;
                       pb_paymenyAllert.Location = new Point(pb_paymenyAllert.Location.X + decreaseSize, pb_paymenyAllert.Location.Y + decreaseSize);
                    
                    break;
                case 4:                    
                       pb_research.Width = sizeMenuIem;
                       pb_research.Height = sizeMenuIem;
                       pb_research.Location = new Point(pb_research.Location.X + decreaseSize, pb_research.Location.Y + decreaseSize);
               
                    break;
                case 5:                    
                       pb_setting.Width = sizeMenuIem;
                       pb_setting.Height = sizeMenuIem;
                       pb_setting.Location = new Point(pb_setting.Location.X + decreaseSize, pb_setting.Location.Y + decreaseSize);
                    
                    break;
            }
        }

        private void pb_newSub_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_addNewTip.Visible = true;
            hoverAnimation(1, 10);            
        }

        private void pb_newSub_MouseLeave(object sender, EventArgs e)
        {
            lbl_addNewTip.Visible = false;
            leaveAnimation(1, 10);
        }

        private void pb_newSub_Click(object sender, EventArgs e)
        {
            new Form_addNew().Show();
            panelIntro.Visible = true;
            panelControl.Visible = false;
            panelSettings.Visible = false;           
        }      

        private void pb_payment_MouseLeave(object sender, EventArgs e)
        {
            lbl_payementTip.Visible = false;
            leaveAnimation(2, 10);            
        }

        private void pb_payment_MouseMove(object sender, MouseEventArgs e)
        {
            hoverAnimation(2, 10);
            lbl_payementTip.Visible = true;
        }

        private void pb_payment_Click(object sender, EventArgs e)
        {
            panelIntro.Visible = true;
            panelControl.Visible = false;
            panelSettings.Visible = false;
            Form_Search Search = new Form_Search();
            Search.setFunction("payment");
            Search.Show();
        }        

        private void pb_paymenyAllert_MouseLeave(object sender, EventArgs e)
        {
            lbl_controlTip.Visible = false;
            leaveAnimation(3, 10);
        }


        private void pb_paymenyAllert_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_controlTip.Visible = true;
            hoverAnimation(3, 10);
        }

        private void pb_paymenyAllert_Click(object sender, EventArgs e)  
        {
            pb_controlNotify.Visible = false;           
            panelIntro.Visible = false;
            panelSettings.Visible = false;
            panelControl.Visible = true;            
            if(pb_load.Visible==true)
            {
                pb_load.Visible = true;
            }
            StartTimerLoading();
        }
        
        private void pb_research_MouseLeave(object sender, EventArgs e)
        {
            lbl_searchTip.Visible = false;
            leaveAnimation(4, 10);
        }

        private void pb_research_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_searchTip.Visible = true;
            hoverAnimation(4, 10);
        }

        private void pb_research_Click(object sender, EventArgs e)
        {
            panelIntro.Visible = true;
            panelControl.Visible = false;
            panelSettings.Visible = false;
            Form_Search Search = new Form_Search();
            Search.setFunction("search");
            Search.Show();
        }

        private void pb_setting_MouseLeave(object sender, EventArgs e)
        {
            lbl_settingsTip.Visible = false;
            leaveAnimation(5, 10);
        }

        private void pb_setting_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_settingsTip.Visible = true;
            hoverAnimation(5, 10);
        }

        private void pb_setting_Click(object sender, EventArgs e)
        {
            panelIntro.Visible = false;            
            panelControl.Visible = false;
            panelSettings.Visible = true;
        }

        private void pb_back_addNew_Click(object sender, EventArgs e)
        {
            panelIntro.Visible = true;
        }

        private void pb_back_payment_Click(object sender, EventArgs e)
        {
            panelIntro.Visible = true;
        }

        private void pb_back_research_Click(object sender, EventArgs e)
        {
            lbl_control.Visible = true;
            lbl_result.Visible = false;
            lbl_controlNextPay.Visible = false;
            btn_details.Visible = false;
            btn_detailsNext.Visible = false;
            panelControl.Visible = false;
            panelIntro.Visible = true;
            panelSettings.Visible = false;
        }

        public void StartTimerLoading()
        {
            timerLoading = new Timer();
            timerLoading.Tick += new EventHandler(StopTimer);
            timerLoading.Interval = 3000; // in miliseconds
            timerLoading.Start();            
        }

        private void StopTimer(object sender, EventArgs e)
        {
            timerLoading.Stop();
            lbl_control.Visible = false;
            lbl_result.Visible = true;        
            if (findEvaders()!=-1)
            {
                lbl_controlNextPay.Visible = true;
                btn_details.Visible = true;
                lbl_controlNextPay.Text ="           Ho riscontrato "+ findNextToPay() + " iscritti che devono venire a pagare le rate da adesso a 2 settimane,\r"
                    +"                                   Clicca su dettagli per informazioni aggiuntive!";
                btn_detailsNext.Visible = true;
                lbl_result.Text = "                              Ho riscontrato " + findEvaders() + " iscritti che non hanno pagato la/e rata/e \r" 
                    +"                                    Clicca su dettagli per informazioni aggiuntive!";
                pb_load.Visible = false;
                btn_details.Visible = true;
                lbl_Certificati.Text = "             Ho riscontrato " + findCertScad() + " iscritti a qui è scaduto il certificato medico o che lo devono rinnovare a breve, \r"
                    +"                                    Clicca su dettagli per informazioni aggiuntive!";
                btn_detailsCert.Visible = true;
                lbl_Certificati.Visible = true;
                lbl_CertificatoNO.Text = "                               Ho riscontrato " + findNOCert() + " iscritti senza il certificato medico \r"
                    + "                                   Clicca su dettagli per informazioni aggiuntive!";
                btn_detailsCertNO.Visible = true;
                lbl_CertificatoNO.Visible = true;
            }
            else
            {
                MessageBox.Show("Connessione al DB assente, impossibile eseguire operazioni sui dati! Riavvia il programma e riprova.",
                   "Errore Connessione DB");
            }    
            
        }

        public void StartTimerImage()
        {
            timerLoading = new Timer();
            timerLoading.Tick += new EventHandler(Timer_ChangeImage);
            timerLoading.Interval = 15000; // in miliseconds
            timerLoading.Start();
        }

        private void Timer_ChangeImage(object sender, EventArgs e)
        {
            if (currentImg==4)
            {
                currentImg = -1;                
            }
            currentImg++;
            selectBackroundImg();
        }


        private void btn_nextImage_Click(object sender, EventArgs e)
        {
            if (currentImg <= 4)
            {
                currentImg++;
                selectBackroundImg();
            }
            else
            {
                currentImg = 0;
                selectBackroundImg();
            }                
        }

        private void btn_previousImage_Click_1(object sender, EventArgs e)
        {
            if (currentImg >= 0)
            {
                currentImg--;
                selectBackroundImg();
            }
            else
            {
                currentImg = 4;
                selectBackroundImg();
            }
        }

        private void selectBackroundImg()
        {
            switch (currentImg)
            {
                case 0:
                    pb_backgroundImg.Image = Properties.Resources.home;
                    break;
                case 1:
                    pb_backgroundImg.Image = Properties.Resources.crossfit;
                    break;
                case 2:
                    pb_backgroundImg.Image = Properties.Resources.entrata;
                    break;
                case 3:
                    pb_backgroundImg.Image = Properties.Resources.parete;
                    break;
                case 4:
                    pb_backgroundImg.Image = Properties.Resources.boxe;
                    break;
                default:
                    pb_backgroundImg.Image = Properties.Resources.home;
                    break;

            }        

        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            Form_controlDetail results = new Form_controlDetail("Retro");
            results.Show();
        }

        private int findEvaders()
        {
            try
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "SELECT count(*) FROM Rata WHERE DATE(DataPagam) < DATE('now') and (PagamentoAvv='NO')";
                        cmd.CommandText = command;
                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader.GetInt32(0); //ritorna la prima colonna, quella avente il count
                            }
                        }
                        conn.Close();
                    }
                }
                return 0;
            }
            catch (SQLiteException e)
            {
                return -1;
            }
            
        }

        private int findNextToPay()
        {
            try
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "SELECT count(*) FROM Rata WHERE DATE(DataPagam) <= DATE('now','+'||14||' days') and DATE(DataPagam) >= DATE('now') and (PagamentoAvv='NO')";
                        cmd.CommandText = command;
                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader.GetInt32(0); //ritorna la prima colonna, quella avente il count
                            }
                        }
                        conn.Close();
                    }
                }
                return 0;
            }
            catch
            {
                return -1;
            }
           
        }

        private int findCertScad()
        {
            try
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "SELECT count(*) FROM Certificato WHERE DATE(DataScadenza) <= DATE('now','+'||14||' days') ";
                        cmd.CommandText = command;
                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader.GetInt32(0); //ritorna la prima colonna, quella avente il count
                            }
                        }
                        conn.Close();
                    }
                }
                return 0;
            }
            catch
            {
                return -1;
            }

        }

        private int findNOCert()
        {
            try
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command = "SELECT count(*) FROM Certificato WHERE Presente='NO';";
                        cmd.CommandText = command;
                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader.GetInt32(0); //ritorna la prima colonna, quella avente il count
                            }
                        }
                        conn.Close();
                    }
                }
                return 0;
            }
            catch
            {
                return -1;
            }

        }

        private void btn_detailsNext_Click(object sender, EventArgs e)
        {
            Form_controlDetail results = new Form_controlDetail("Next");
            results.Show();
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

        private void pb_choice5_MouseMove(object sender, MouseEventArgs e)
        {
            pb_choice5.BackColor = Color.IndianRed;
            lbl_choice5.BackColor = Color.IndianRed;
            lbl_choice5.ForeColor = Color.White;
        }

        private void pb_choice5_MouseLeave(object sender, EventArgs e)
        {
            pb_choice5.BackColor = Color.Transparent;
            lbl_choice5.BackColor = Color.Transparent;
            lbl_choice5.ForeColor = Color.Black;
        }

        private void pb_choice1_Click(object sender, EventArgs e)
        {
            Form_NewCorso updateCorsi = new Form_NewCorso();
            updateCorsi.Show();
        }

        private void pb_choice2_Click(object sender, EventArgs e)
        {
            Form_NewUser updateUsers = new Form_NewUser();
            updateUsers.Show();
        }

        private void pb_choice3_Click(object sender, EventArgs e)
        {

        }

        private void pb_choice4_Click(object sender, EventArgs e)
        {
            Form_Backup backup = new Form_Backup();
            backup.Show();
        }

        private void pb_choice5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panelControl.Visible = false;
            panelIntro.Visible = true;
            panelSettings.Visible = false;
        }

        private void pb_messages_Click(object sender, EventArgs e)
        {
            Form_Postit post_it = new Form_Postit();
            post_it.Show();
        }

        private void pb_control_Click(object sender, EventArgs e)
        {
            pb_paymenyAllert_Click(sender, e);
        }

        private void firstRunOperations()
        {
            try //if i get error in this line its only cause the not existance of the db, so we could consider that this is the first run!
            {
                
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        cmd.CommandText = "SELECT * FROM ISCRITTO";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

            }
            catch (SQLiteException e)
            {
                string command = @"CREATE TABLE `Iscritto` (
	                                                `CodIscritto`	INTEGER PRIMARY KEY AUTOINCREMENT,
	                                                `Nome`	TEXT NOT NULL,
	                                                `Cognome`	TEXT NOT NULL,
	                                                `DataN`	TEXT,
	                                                `Residenza`	TEXT,
	                                                `Via`	TEXT,
	                                                `Recapito`	TEXT,
	                                                `DataIn`	TEXT NOT NULL,
	                                                `DataFine`	TEXT NOT NULL,
	                                                `NIngressi`	INTEGER,
	                                                `TipoAbb`	INTEGER NOT NULL,
	                                                `Costo`	REAL NOT NULL,
	                                                `Email`	TEXT,
	                                                `CodFisc`	TEXT,
	                                                `Ntessera`	TEXT NOT NULL
                                                );

                                            CREATE TABLE `Certificato` (
	                                            `CodIscritto`	INTEGER,
	                                            `Presente`	TEXT NOT NULL,
	                                            `DataScadenza`	TEXT,
	                                            FOREIGN KEY(`CodIscritto`) REFERENCES `Iscritto`(`CodIscritto`));
                                            CREATE TABLE `Rata` (
	                                            `CodIscritto`	INTEGER,
	                                            `Costo`	REAL NOT NULL,
	                                            `PagamentoAvv`	TEXT NOT NULL DEFAULT -1,
	                                            `DataPagam`	TEXT,
	                                            FOREIGN KEY(`CodIscritto`) REFERENCES `Iscritto`(`CodIscritto`));
                                            
                                            CREATE TABLE `Corso` (
	                                            `Id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	                                            `Nome`	TEXT NOT NULL,
	                                            `DataIn`	TEXT NOT NULL,
	                                            `DataFin`	TEXT NOT NULL);
                                            CREATE TABLE `Frequenta` (
	                                            `CodIscritto`	INTEGER,
	                                            `Id`	INTEGER,
	                                            FOREIGN KEY(`Id`) REFERENCES `Corso`(`Id`),
	                                            FOREIGN KEY(`CodIscritto`) REFERENCES `Iscritto`(`CodIscritto`));
                                            CREATE TABLE `User` (
	                                            `Id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	                                            `Username`	TEXT NOT NULL UNIQUE,
	                                            `Password`	TEXT NOT NULL
                                            );
                                            CREATE TABLE `Messaggio` (
	                                            `Cod`	INTEGER PRIMARY KEY AUTOINCREMENT,
	                                            `Id`	INTEGER,
	                                            `Oggetto`	TEXT NOT NULL,
	                                            `Text`	TEXT,
	                                            FOREIGN KEY(`Id`) REFERENCES `User`(`Id`)
                                            );
                                            
                                            INSERT INTO User(Username,Password) VALUES ('Admin', 'Password');
                                            INSERT INTO Corso(Nome,DataIn,Datafin) VALUES('generale',date('now'),'2030-03-14');
                                         ";
                utils.createDB(command);
                utils.createFolderBackupDB(@"C:\backupDBgymSoftware");
                utils.BackupDB(dbName+".db", @"C:\backupDBgymSoftware");
                createConfigFile();
            }

        }
        private void createConfigFile()
        {
            // Create a string array with the lines of text
            string[] lines = { @"PATH=C:\backupDBgymSoftware", "LAST_DB_NAME=gestionalePalestra.db", "BACKUP_TIME=mai" };

            // Set a variable to the My Documents path.
            string mydocpath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\config.txt"))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }

        private void chargeConfig()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            StreamReader file = new StreamReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\config.txt");
            while ((line = file.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                switch (counter)
                {
                    case 0:
                        path_backupFolder = @line.Split('=')[1];
                        break;
                    case 1:
                        if(!line.Split('=')[1].Equals("gestionalePalestra.db"))
                        {                            
                            lastBackupData = (line.Split('=')[1]).Split('.')[0];
                        }
                        lastBackupDBName = line.Split('=')[1];
                        //MessageBox.Show("LastDataBakup= "+lastBackupData);
                        break;
                    case 2:
                        timeBuckup = @line.Split('=')[1];
                        break;
                }
                counter++;
            }

            file.Close();
        }

        private void btn_detailsCert_Click(object sender, EventArgs e)
        {
            Form_controlDetail results = new Form_controlDetail("Cert");
            results.Show();
        }

        private void btn_detailsCertNO_Click(object sender, EventArgs e)
        {
            Form_controlDetail results = new Form_controlDetail("CertNO");
            results.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            string binPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string pathFile = System.IO.Path.Combine(binPath, "config.txt");
            String secondLine = "";
            int lineCount = 0;
            using (StreamReader sr = File.OpenText(pathFile))
            {
                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    lineCount++;
                    if (lineCount==2)
                    {
                        secondLine = s;
                    }                    
                    //do minimal amount of work here
                }
            }
            if (!secondLine.Equals(""))
            {
                if (!secondLine.Split('=')[1].Equals("gestionalePalestra.db"))
                {
                    lastBackupData = ((secondLine.Split('=')[1]).Split('_')[1]).Split('.')[0];
                    DateTime lastbacktemp = new DateTime(int.Parse(lastBackupData.Split('-')[0]), int.Parse(lastBackupData.Split('-')[1]), int.Parse(lastBackupData.Split('-')[2]));

                    if (lastbacktemp.Month<=DateTime.Now.Month)
                    {
                        if (lastbacktemp.AddDays(14)< DateTime.Now)
                        {
                            DialogResult result = MessageBox.Show("Ho riscontrato che non ci sono backup recenti, eseguirlo ora?",
                            "Attenzione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {

                                Home.utils.BackupDB((Home.dbName + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".db"), Home.path_backupFolder);
                                MessageBox.Show("Backup eseguito correttamente!",
                                        "Backup");
                                updateConfigFile("", "LAST_DB_NAME="+ Home.dbName + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".db", "");

                            }
                        }
                    }

                }
                else
                {
                    DialogResult result = MessageBox.Show("Ho riscontrato che non non sono stati eseguiti Backup, eseguirlo ora?",
                            "Attenzione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        Home.utils.BackupDB((Home.dbName + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".db"), Home.path_backupFolder);
                        MessageBox.Show("Backup eseguito correttamente!",
                                "Backup");
                        updateConfigFile("", "LAST_DB_NAME=" + Home.dbName + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".db", "");

                    }
                }


            

                
            }
            
        }

        private void updateConfigFile(string path,string lastName,string backTime)
        {
            string[] lines= new string[3];
            string binPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string pathFile = System.IO.Path.Combine(binPath, "config.txt");
            String secondLine = "";
            int lineCount = 0;
            using (StreamReader sr = File.OpenText(pathFile))
            {
                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    lines[lineCount] = s;
                    lineCount++;                   
                    //do minimal amount of work here
                }
            }

            if(!path.Equals(""))
            {
                lines[0] = path;
            }

            if (!lastName.Equals(""))
            {
                lines[1] = lastName;
            }

            if (!backTime.Equals(""))
            {
                lines[2] = backTime;
            }

            // Set a variable to the My Documents path.
            string mydocpath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\config.txt"))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }

        private void lbl_pswDimenticata_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Per il recupero manderemo una mail all'indirizzo gnigna. \n"+
                        "Nella mail ci saranno il contatto dell'admin con il quale entrare temporaneamente",
                            "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string mailObject="Recupero Credenziali";
                string mailText = "Queste sono le credenziali per l'accesso temporaneo \n"+
                    "            User = Temp                 Pass = QWERT1234          \n"+
                    "Perfavore appena acceduto modifica la tua password e riaccedi con il tuo account, non usare MAI questo utente per le normali operazioni!";


                utils.MailRecoveryPass(MailAccount, MailPassword, MailReceiverAccount,mailObject,mailText);
            }
        }
    }

}
