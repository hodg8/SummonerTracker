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
    public partial class Form2 : Form
    {
        Form1 form1;
        Form3 form3 = new Form3();

        public Form2()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form2_Closing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (form1 == null)
                {
                    form1 = new Form1();
                    form1.Show();
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
                if (form1 != null)
                {
                    form1.Close();
                    List<string> folderList = new DirectoryInfo(form3.Folder).EnumerateFiles("MyNotes.txt", SearchOption.AllDirectories).Select(d => d.FullName).ToList();
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

        private void Form2_Closing (object sender, FormClosingEventArgs e)
        {
            List<string> folderList = new DirectoryInfo(form3.Folder).EnumerateFiles("MyNotes.txt", SearchOption.AllDirectories).Select(d => d.FullName).ToList();
            foreach (string s in folderList)
            {
                File.WriteAllText(s, "");
            }
            Application.Exit();
        }        
    }
}
