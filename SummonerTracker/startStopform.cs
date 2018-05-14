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



namespace SummonerTracker
{
    public partial class startStopform : Form
    {
        inGameform inGameform;
        folderSelectform folderSelectform;

        public startStopform()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(startStopform_Closing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (inGameform == null)
                {
                    inGameform = new inGameform();
                    inGameform.Show();
                }                
            }
            catch
            {
                MessageBox.Show("Please set MyNotes.txt folder path first.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (inGameform != null)
                {
                    inGameform.Close();
                    List<string> folderList = new DirectoryInfo(folderSelectform.Folder).EnumerateFiles("MyNotes.txt", SearchOption.AllDirectories).Select(d => d.FullName).ToList();
                    foreach (string s in folderList)
                    {
                        File.WriteAllText(s, "");
                    }
                }
            }
            catch
            {                
            }                                           
        }        

        private void startStopform_Closing (object sender, FormClosingEventArgs e)
        {
            List<string> folderList = new DirectoryInfo(folderSelectform.Folder).EnumerateFiles("MyNotes.txt", SearchOption.AllDirectories).Select(d => d.FullName).ToList();
            foreach (string s in folderList)
            {
                File.WriteAllText(s, "");
            }
            Application.Exit();
        }        
    }
}
