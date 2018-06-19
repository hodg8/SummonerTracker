using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SummonerTracker
{
    public partial class inGameform : Form
    {
        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        static extern int GetWindowLong(IntPtr hWnd, int iIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        FileSearcher fileSearcher = new FileSearcher();

        //Hide form from taskbar/alt-tab
        protected override CreateParams CreateParams
        {
            get
            {                
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        int timeLeftFlashADC = 300;
        int timeLeftHealADC = 270;
        int timeLeftBarrierADC = 180;
        int timeLeftExhaustADC = 210;
        int timeLeftCleanseADC = 210;
        int timeLeftGhostADC = 180;
        int timeLeftTeleportADC = 300;
        int timeLeftIgniteADC = 210;

        int timeLeftFlashJungle = 300;
        int timeLeftHealJungle = 270;
        int timeLeftBarrierJungle = 180;
        int timeLeftExhaustJungle = 210;
        int timeLeftCleanseJungle = 210;
        int timeLeftGhostJungle = 180;
        int timeLeftTeleportJungle = 300;
        int timeLeftIgniteJungle = 210;

        int timeLeftFlashSupp = 300;
        int timeLeftHealSupp = 270;
        int timeLeftBarrierSupp = 180;
        int timeLeftExhaustSupp = 210;
        int timeLeftCleanseSupp = 210;
        int timeLeftGhostSupp = 180;
        int timeLeftTeleportSupp = 300;
        int timeLeftIgniteSupp = 210;

        int timeLeftFlashMid = 300;
        int timeLeftHealMid = 270;
        int timeLeftBarrierMid = 180;
        int timeLeftExhaustMid = 210;
        int timeLeftCleanseMid = 210;
        int timeLeftGhostMid = 180;
        int timeLeftTeleportMid = 300;
        int timeLeftIgniteMid = 210;

        int timeLeftFlashTop = 300;
        int timeLeftHealTop = 270;
        int timeLeftBarrierTop = 180;
        int timeLeftExhaustTop = 210;
        int timeLeftCleanseTop = 210;
        int timeLeftGhostTop = 180;
        int timeLeftTeleportTop = 300;
        int timeLeftIgniteTop = 210;     

        public void OnAdcFlashed()
        {
            if (!tmrAdcFlash.Enabled)
            {
                Invoke(new Action(() =>
                {
                    tmrAdcFlash.Start();
                }));
            }            
        }

        public void OnAdcHealed()
        {
            if (lblAdcSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrAdcHeal.Start();
                }));
            }
        }

        public void OnAdcCleansed()
        {
            if (lblAdcSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrAdcCleanse.Start();
                }));
            }
        }

        public void OnAdcTeleported()
        {
            if (lblAdcSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrAdcTp.Start();
                }));
            }
        }

        public void OnAdcExhausted()
        {
            if (lblAdcSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrAdcExhaust.Start();
                }));
            }
        }

        public void OnAdcBarriered()
        {
            if (lblAdcSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrAdcBarrier.Start();
                }));
            }
        }

        public void OnJungleFlashed()
        {
            if (lblJgSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrJgFlash.Start();
                }));
            }
        }

        public void OnJungleExhausted()
        {
            if (lblJgSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrJgEx.Start();
                }));
            }
        }

        public void OnJungleIgnited()
        {
            if (lblJgSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrJgIg.Start();
                }));
            }
        }

        public void OnJungleGhosted()
        {
            if (lblJgSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrJgGhost.Start();
                }));
            }
        }

        public void OnTopFlashed()
        {
            if (lblTopFlash.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrTopFlash.Start();
                }));
            }
        }

        public void OnTopTeleported()
        {
            if (lblTopSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrTopTP.Start();
                }));
            }
        }

        public void OnTopIgnited()
        {
            if (lblTopSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrTopIg.Start();
                }));
            }
        }

        public void OnTopExhausted()
        {
            if (lblTopSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrTopEx.Start();
                }));
            }
        }

        public void OnTopGhosted()
        {
            if (lblTopSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrTopGhost.Start();
                }));
            }
        }

        public void OnMidFlashed()
        {
            if (lblMidFlash.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrMidFlash.Start();
                }));
            }
        }

        public void OnMidIgnited()
        {
            if (lblMidSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrMidIg.Start();
                }));
            }
        }

        public void OnMidExhausted()
        {
            if (lblMidSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrMidEx.Start();
                }));
            }
        }

        public void OnMidCleansed()
        {
            if (lblMidSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrMidCleanse.Start();
                }));
            }
        }

        public void OnMidTeleported()
        {
            if (lblMidSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrMidTP.Start();
                }));
            }
        }

        public void OnMidBarriered()
        {
            if (lblMidSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrMidBarrier.Start();
                }));
            }
        }

        public void OnMidGhosted()
        {
            if (lblMidSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrMidGhost.Start();
                }));
            }
        }

        public void OnMidHealed()
        {
            if (lblMidSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrMidHeal.Start();
                }));
            }
        }

        public void OnSupportFlashed()
        {
            if (lblSuppFlash.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrSuppFlash.Start();
                }));
            }
        }

        public void OnSupportHealed()
        {
            if (lblSuppSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrSuppHeal.Start();
                }));
            }
        }

        public void OnSupportIgnited()
        {
            if (lblSuppSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrSuppIg.Start();
                }));
            }
        }

        public void OnSupportExhausted()
        {
            if (lblSuppSecondary.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    tmrSuppEx.Start();
                }));
            }
        }

        public inGameform()
        {
            this.TransparencyKey = Color.Black;            
            InitializeComponent();
            //0x80000 = layered window, 0x20 = transparent
            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
        }        
        
        private void Form1_Load(object sender, EventArgs e)
        {            
            fileSearcher.AdcFlashed += OnAdcFlashed;
            fileSearcher.AdcHealed += OnAdcHealed;
            fileSearcher.AdcTeleported += OnAdcTeleported;
            fileSearcher.AdcExhausted += OnAdcExhausted;
            fileSearcher.AdcCleansed += OnAdcCleansed;
            fileSearcher.AdcBarriered += OnAdcBarriered;
            fileSearcher.JungleExhausted += OnJungleExhausted;
            fileSearcher.JungleGhosted += OnJungleGhosted;
            fileSearcher.JungleIgnited += OnJungleIgnited;
            fileSearcher.JungleFlashed += OnJungleFlashed;
            fileSearcher.TopExhausted += OnTopExhausted;
            fileSearcher.TopFlashed += OnTopFlashed;
            fileSearcher.TopGhosted += OnTopGhosted;
            fileSearcher.TopIgnited += OnTopIgnited;
            fileSearcher.TopTeleported += OnTopTeleported;
            fileSearcher.MidBarriered += OnMidBarriered;
            fileSearcher.MidCleansed += OnMidCleansed;
            fileSearcher.MidExhausted += OnMidExhausted;
            fileSearcher.MidFlashed += OnMidFlashed;
            fileSearcher.MidGhosted += OnMidGhosted;
            fileSearcher.MidHealed += OnMidHealed;
            fileSearcher.MidIgnited += OnMidIgnited;
            fileSearcher.MidTeleported += OnMidTeleported;
            fileSearcher.SupportExhausted += OnSupportExhausted;
            fileSearcher.SupportFlashed += OnSupportFlashed;
            fileSearcher.SupportHealed += OnSupportHealed;
            fileSearcher.SupportIgnited += OnSupportIgnited;

            fileSearcher.watch();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeftFlashADC--;
            if (timeLeftFlashADC == 0)
            {
                tmrAdcFlash.Stop();
                lblAdcFlash.Text = "";
                timeLeftFlashADC = 300;
                return;
            }
            lblAdcFlash.Text = "ADC F " + timeLeftFlashADC.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeLeftHealADC--;
            if (timeLeftHealADC == 0)
            {
                tmrAdcHeal.Stop();
                lblAdcSecondary.Text = "";
                timeLeftHealADC = 240;
                return;
            }
            lblAdcSecondary.Text = "ADC H " + timeLeftHealADC.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timeLeftBarrierADC--;
            if (timeLeftBarrierADC == 0)
            {
                tmrAdcBarrier.Stop();
                lblAdcSecondary.Text = "";
                timeLeftHealADC = 180;
                return;
            }
            lblAdcSecondary.Text = "ADC B " + timeLeftBarrierADC.ToString();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timeLeftFlashTop--;
            if (timeLeftFlashTop == 0)
            {
                tmrTopFlash.Stop();
                lblTopFlash.Text = "";
                timeLeftFlashTop = 300;
                return;
            }
            lblTopFlash.Text = "Top F " + timeLeftFlashTop.ToString();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timeLeftTeleportTop--;
            if (timeLeftTeleportTop == 0)
            {
                tmrTopTP.Stop();
                lblTopSecondary.Text = "";
                timeLeftTeleportTop = 300;
                return;
            }
            lblTopSecondary.Text = "Top TP " + timeLeftTeleportTop.ToString();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            timeLeftExhaustTop--;
            if (timeLeftExhaustTop == 0)
            {
                tmrTopEx.Stop();
                lblTopSecondary.Text = "";
                timeLeftExhaustTop = 210;
                return;
            }
            lblTopSecondary.Text = "Top Ex " + timeLeftExhaustTop.ToString();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            timeLeftIgniteTop--;
            if (timeLeftIgniteTop == 0)
            {
                tmrTopIg.Stop();
                lblTopSecondary.Text = "";
                timeLeftIgniteTop = 210;
                return;
            }
            lblTopSecondary.Text = "Top Ig " + timeLeftIgniteTop.ToString();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            timeLeftGhostTop--;
            if (timeLeftGhostTop == 0)
            {
                tmrTopGhost.Stop();
                lblTopSecondary.Text = "";
                timeLeftGhostTop = 180;
                return;
            }
            lblTopSecondary.Text = "Top G " + timeLeftGhostTop.ToString();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            timeLeftFlashJungle--;
            if (timeLeftFlashJungle == 0)
            {
                tmrJgFlash.Stop();
                lblJgFlash.Text = "";
                timeLeftFlashJungle = 300;
                return;
            }
            lblJgFlash.Text = "Jg F " + timeLeftFlashJungle.ToString();
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            timeLeftIgniteJungle--;
            if (timeLeftIgniteJungle == 0)
            {
                tmrJgIg.Stop();
                lblJgSecondary.Text = "";
                timeLeftIgniteJungle = 210;
                return;
            }
            lblJgSecondary.Text = "Jg Ig " + timeLeftIgniteJungle.ToString();
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            timeLeftGhostJungle--;
            if (timeLeftGhostJungle == 0)
            {
                tmrJgFlash.Stop();
                lblJgSecondary.Text = "";
                timeLeftGhostJungle = 180;
                return;
            }
            lblJgSecondary.Text = "Jg G " + timeLeftGhostJungle.ToString();
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            timeLeftFlashMid--;
            if (timeLeftFlashMid == 0)
            {
                tmrMidFlash.Stop();
                lblMidFlash.Text = "";
                timeLeftFlashMid = 300;
                return;
            }
            lblMidFlash.Text = "Mid F " + timeLeftFlashMid.ToString();
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            timeLeftBarrierMid--;
            if (timeLeftBarrierMid == 0)
            {
                tmrMidBarrier.Stop();
                lblMidSecondary.Text = "";
                timeLeftBarrierMid = 180;
                return;
            }
            lblMidSecondary.Text = "Mid B " + timeLeftBarrierMid.ToString();
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            timeLeftExhaustMid--;
            if (timeLeftExhaustMid == 0)
            {
                tmrMidEx.Stop();
                lblMidSecondary.Text = "";
                timeLeftExhaustMid = 210;
                return;
            }
            lblMidSecondary.Text = "Mid Ex " + timeLeftExhaustMid.ToString();
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            timeLeftIgniteMid--;
            if (timeLeftIgniteMid == 0)
            {
                tmrMidIg.Stop();
                lblMidSecondary.Text = "";
                timeLeftIgniteMid = 210;
                return;
            }
            lblMidSecondary.Text = "Mid Ig " + timeLeftIgniteMid.ToString();
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            timeLeftGhostMid--;
            if (timeLeftGhostMid == 0)
            {
                tmrMidGhost.Stop();
                lblMidSecondary.Text = "";
                timeLeftGhostMid = 180;
                return;
            }
            lblMidSecondary.Text = "Mid G " + timeLeftGhostMid.ToString();
        }

        private void timer17_Tick(object sender, EventArgs e)
        {
            timeLeftCleanseMid--;
            if (timeLeftCleanseMid == 0)
            {
                tmrMidCleanse.Stop();
                lblMidSecondary.Text = "";
                timeLeftCleanseMid = 210;
                return;
            }
            lblMidSecondary.Text = "Mid C " + timeLeftCleanseMid.ToString();
        }

        private void timer18_Tick(object sender, EventArgs e)
        {
            timeLeftHealMid--;
            if (timeLeftHealMid == 0)
            {
                tmrMidHeal.Stop();
                lblMidSecondary.Text = "";
                timeLeftHealMid = 240;
                return;
            }
            lblMidSecondary.Text = "Mid H " + timeLeftHealMid.ToString();
        }

        private void timer19_Tick(object sender, EventArgs e)
        {
            timeLeftTeleportMid--;
            if (timeLeftTeleportMid == 0)
            {
                tmrMidTP.Stop();
                lblMidSecondary.Text = "";
                timeLeftTeleportMid = 300;
                return;
            }
            lblMidSecondary.Text = "Mid TP " + timeLeftTeleportMid.ToString();
        }

        private void timer20_Tick(object sender, EventArgs e)
        {
            timeLeftFlashSupp--;
            if (timeLeftFlashSupp == 0)
            {
                tmrSuppFlash.Stop();
                lblSuppFlash.Text = "";
                timeLeftFlashSupp = 300;
                return;
            }
            lblSuppFlash.Text = "Supp F " + timeLeftFlashSupp.ToString();
        }

        private void timer21_Tick(object sender, EventArgs e)
        {
            timeLeftIgniteSupp--;
            if (timeLeftIgniteSupp == 0)
            {
                tmrSuppIg.Stop();
                lblSuppSecondary.Text = "";
                timeLeftIgniteSupp = 210;
                return;
            }
            lblSuppSecondary.Text = "Supp Ig " + timeLeftIgniteSupp.ToString();
        }

        private void timer22_Tick(object sender, EventArgs e)
        {
            timeLeftExhaustSupp--;
            if (timeLeftExhaustSupp == 0)
            {
                tmrSuppEx.Stop();
                lblSuppSecondary.Text = "";
                timeLeftExhaustSupp = 210;
                return;
            }
            lblSuppSecondary.Text = "Supp Ex " + timeLeftExhaustSupp.ToString();
        }

        private void timer23_Tick(object sender, EventArgs e)
        {
            timeLeftHealSupp--;
            if (timeLeftHealSupp == 0)
            {
                tmrSuppHeal.Stop();
                lblSuppSecondary.Text = "";
                timeLeftHealSupp = 240;
                return;
            }
            lblSuppSecondary.Text = "Supp H " + timeLeftHealSupp.ToString();
        }

        private void timer24_Tick(object sender, EventArgs e)
        {
            timeLeftExhaustJungle--;
            if (timeLeftExhaustJungle == 0)
            {
                tmrJgEx.Stop();
                lblJgSecondary.Text = "";
                timeLeftExhaustJungle = 210;
                return;
            }
            lblJgSecondary.Text = "Jg Ex " + timeLeftExhaustJungle.ToString();
        }

        private void tmrAdcCleanse_Tick(object sender, EventArgs e)
        {
            timeLeftCleanseADC--;
            if (timeLeftCleanseADC == 0)
            {
                tmrAdcCleanse.Stop();
                lblAdcSecondary.Text = "";
                timeLeftCleanseADC = 210;
                return;
            }
            lblAdcSecondary.Text = "ADC C " + timeLeftCleanseADC.ToString();
        }

        private void tmrAdcTp_Tick(object sender, EventArgs e)
        {
            timeLeftTeleportADC--;
            if (timeLeftTeleportADC == 0)
            {
                tmrAdcTp.Stop();
                lblAdcSecondary.Text = "";
                timeLeftTeleportADC = 300;
                return;
            }
            lblAdcSecondary.Text = "ADC TP " + timeLeftTeleportADC.ToString();
        }

        private void tmrAdcExhaust_Tick(object sender, EventArgs e)
        {
            timeLeftExhaustADC--;
            if (timeLeftExhaustADC == 0)
            {
                tmrAdcExhaust.Stop();
                lblAdcSecondary.Text = "";
                timeLeftTeleportADC = 210;
                return;
            }
            lblAdcSecondary.Text = "ADC Ex " + timeLeftExhaustADC.ToString();
        }
    }
}
