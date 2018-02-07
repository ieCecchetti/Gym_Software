using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public class Class_utility
    {
        public void createDB(string createQuery)
        {
            try
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=gestionalePalestra.db"))
                {
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        conn.Open();
                        cmd.CommandText = createQuery;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Prima connessione al database stabilita, per favore entra con le credenziali Username: Admin e Password: Password" +
                            " e aggiungi un account utente per iniziare ad utilizzare questo software!",
                                    "Prima connessione stabilita!");
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show("Impossibile connettersi al database! contattare l'amministratore del sistema.",
                    "Errore Connessione DB");
            }

        }

        public void createFolderBackupDB(string pathBackupFolder)
        {
            string path = @pathBackupFolder;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

        }

        public void BackupDB(string fileName,string pathBackupFolder) //if i want the same name over files the first 2 camps must be equal
        {
            // string fileName = "gestionalePalestra.db";
            string sourcePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string targetPath = pathBackupFolder;

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, "gestionalePalestra.db");
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
        }

        public void LoadBackup(string fileName, string pathBackupFolder)
        {
            //string fileName = fileNameLong.Split('-')[0];
            string sourcePath = pathBackupFolder;
            string targetPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            //MessageBox.Show(fileName);
            if(fileName.Equals("gestionalePalestra.db"))
            {
                fileName=fileName.Split('.')[0];
            }
            string destFile = System.IO.Path.Combine(targetPath, fileName.Split('_')[0] + ".db");
            //MessageBox.Show(destFile);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
        }

        public string selectFolder()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath.ToString();

                    //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
            return "";
        }

        public void getNFileFromFolder()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }

        public void openSelectedFolder(string path,int method)
        {
            try
            {
                //method=1 open without explorer, method =0 open with explorer
                if (method == 1)
                {
                    Process.Start(@path);
                }
                else
                {
                    Process.Start("explorer.exe", @path);
                }
            }catch(FileNotFoundException e)
            {
                MessageBox.Show("Impossibile trovare il percorso specificato",
                    "Percorso Inesistente");
            }                   
            
        }

        public void renameFile(string oldName, string newName,string path)
        {
            string oldFilePath = path + @"\" + oldName; // Full path of old file
            //MessageBox.Show(oldFilePath);

            string newFilePath = path + @"\" + newName; // Full path of new file
            //MessageBox.Show(newFilePath);

            if (File.Exists(newFilePath))
            {
                File.Delete(newFilePath);
            }

            File.Move(oldFilePath, newFilePath);
        }

        public void MailRecoveryPass(string SenderMailAccount, string SenderMailAccountPassword, string ReceiverMailAccount, string MailObject, string MailText)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(SenderMailAccount, SenderMailAccountPassword);
            MailMessage mm = new MailMessage("donotreply@domain.com", ReceiverMailAccount, MailObject, MailText);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            try
            {
                client.Send(mm);
                MessageBox.Show("Mail Inviata, controlla la tua casella e riprova con le credenziali fornite!", "Recupero Credenziali");
            }
            catch
            {
                MessageBox.Show("Errore nell'invio della mail credenziali, sicuramente è dovuto alla sicurezza del tuo account! \n"+
                    "Permetti l'accesso alle ''app meno'' sicure e riprova!", "Errore Recupero Credenziali");
            }
            
            
        }


    }
}
