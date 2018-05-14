using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ookii.Dialogs;

namespace SummonerTracker
{
    public partial class folderSelectform : Form
    {
        private static string folder = Properties.Settings.Default.MyNotesPath;
        public string Folder { get => folder; set => folder = value; }

        startStopform startStopform;

        public folderSelectform()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog folderBrowser = new VistaFolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.MyNotesPath = folderBrowser.SelectedPath;
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.MyNotesPath != null)
            {
                startStopform = new startStopform();
                startStopform.Show();
                Hide();
            }
        }        
    }
}
