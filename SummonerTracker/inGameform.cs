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

        int timeLeftflashADC = 300;
        int timeLefthealADC = 240;
        int timeLeftbarrierADC = 180;
        int timeLeftexhaustADC = 210;
        int timeLeftcleanseADC = 210;
        int timeLeftghostADC = 180;
        int timeLeftteleportADC = 300;
        int timeLeftigniteADC = 210;

        int timeLeftflashJungle = 300;
        int timeLefthealJungle = 240;
        int timeLeftbarrierJungle = 180;
        int timeLeftexhaustJungle = 210;
        int timeLeftcleanseJungle = 210;
        int timeLeftghostJungle = 180;
        int timeLeftteleportJungle = 300;
        int timeLeftigniteJungle = 210;

        int timeLeftflashSupp = 300;
        int timeLefthealSupp = 240;
        int timeLeftbarrierSupp = 180;
        int timeLeftexhaustSupp = 210;
        int timeLeftcleanseSupp = 210;
        int timeLeftghostSupp = 180;
        int timeLeftteleportSupp = 300;
        int timeLeftigniteSupp = 210;

        int timeLeftflashMid = 300;
        int timeLefthealMid = 240;
        int timeLeftbarrierMid = 180;
        int timeLeftexhaustMid = 210;
        int timeLeftcleanseMid = 210;
        int timeLeftghostMid = 180;
        int timeLeftteleportMid = 300;
        int timeLeftigniteMid = 210;

        int timeLeftflashTop = 300;
        int timeLefthealTop = 240;
        int timeLeftbarrierTop = 180;
        int timeLeftexhaustTop = 210;
        int timeLeftcleanseTop = 210;
        int timeLeftghostTop = 180;
        int timeLeftteleportTop = 300;
        int timeLeftigniteTop = 210;       
        

        public void OnAdcFlashed(object source, EventArgs args)
        {
            if (!timer1.Enabled)
            {
                Invoke(new Action(() =>
                {
                    timer1.Start();
                }));
            }            
        }

        public void OnAdcHealed(object source, EventArgs args)
        {
            if (label7.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer2.Start();
                }));
            }
        }

        public void OnAdcBarriered(object source, EventArgs args)
        {
            if (label7.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer3.Start();
                }));
            }
        }

        public void OnJungleFlashed(object source, EventArgs args)
        {
            if (label4.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer9.Start();
                }));
            }
        }

        public void OnJungleExhausted(object source, EventArgs args)
        {
            if (label3.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer24.Start();
                }));
            }
        }

        public void OnJungleIgnited(object source, EventArgs args)
        {
            if (label3.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer10.Start();
                }));
            }
        }

        public void OnJungleGhosted(object source, EventArgs args)
        {
            if (label3.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer11.Start();
                }));
            }
        }

        public void OnTopFlashed(object source, EventArgs args)
        {
            if (label2.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer4.Start();
                }));
            }
        }

        public void OnTopTeleported(object source, EventArgs args)
        {
            if (label1.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer5.Start();
                }));
            }
        }

        public void OnTopIgnited(object source, EventArgs args)
        {
            if (label1.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer7.Start();
                }));
            }
        }

        public void OnTopExhausted(object source, EventArgs args)
        {
            if (label1.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer6.Start();
                }));
            }
        }

        public void OnTopGhosted(object source, EventArgs args)
        {
            if (label1.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer8.Start();
                }));
            }
        }

        public void OnMidFlashed(object source, EventArgs args)
        {
            if (label6.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer12.Start();
                }));
            }
        }

        public void OnMidIgnited(object source, EventArgs args)
        {
            if (label5.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer15.Start();
                }));
            }
        }

        public void OnMidExhausted(object source, EventArgs args)
        {
            if (label5.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer14.Start();
                }));
            }
        }

        public void OnMidCleansed(object source, EventArgs args)
        {
            if (label5.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer17.Start();
                }));
            }
        }

        public void OnMidTeleported(object source, EventArgs args)
        {
            if (label5.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer19.Start();
                }));
            }
        }

        public void OnMidBarriered(object source, EventArgs args)
        {
            if (label5.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer13.Start();
                }));
            }
        }

        public void OnMidGhosted(object source, EventArgs args)
        {
            if (label5.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer16.Start();
                }));
            }
        }

        public void OnMidHealed(object source, EventArgs args)
        {
            if (label5.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer18.Start();
                }));
            }
        }

        public void OnSupportFlashed(object source, EventArgs args)
        {
            if (label10.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer20.Start();
                }));
            }
        }

        public void OnSupportHealed(object source, EventArgs args)
        {
            if (label9.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer23.Start();
                }));
            }
        }

        public void OnSupportIgnited(object source, EventArgs args)
        {
            if (label9.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer21.Start();
                }));
            }
        }

        public void OnSupportExhausted(object source, EventArgs args)
        {
            if (label9.Text.Length == 0)
            {
                Invoke(new Action(() =>
                {
                    timer22.Start();
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
            timeLeftflashADC--;
            if (timeLeftflashADC == 0)
            {
                timer1.Stop();
                label8.Text = "";
                timeLeftflashADC = 300;
                return;
            }
            label8.Text = "ADC F " + timeLeftflashADC.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeLefthealADC--;
            if (timeLefthealADC == 0)
            {
                timer2.Stop();
                label7.Text = "";
                timeLefthealADC = 240;
                return;
            }
            label7.Text = "ADC H " + timeLefthealADC.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timeLeftbarrierADC--;
            if (timeLeftbarrierADC == 0)
            {
                timer3.Stop();
                label7.Text = "";
                timeLefthealADC = 180;
                return;
            }
            label7.Text = "ADC B " + timeLeftbarrierADC.ToString();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timeLeftflashTop--;
            if (timeLeftflashTop == 0)
            {
                timer4.Stop();
                label2.Text = "";
                timeLeftflashTop = 300;
                return;
            }
            label2.Text = "Top F " + timeLeftflashTop.ToString();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timeLeftteleportTop--;
            if (timeLeftteleportTop == 0)
            {
                timer5.Stop();
                label1.Text = "";
                timeLeftteleportTop = 300;
                return;
            }
            label1.Text = "Top TP " + timeLeftteleportTop.ToString();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            timeLeftexhaustTop--;
            if (timeLeftexhaustTop == 0)
            {
                timer6.Stop();
                label1.Text = "";
                timeLeftexhaustTop = 210;
                return;
            }
            label1.Text = "Top Ex " + timeLeftexhaustTop.ToString();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            timeLeftigniteTop--;
            if (timeLeftigniteTop == 0)
            {
                timer7.Stop();
                label1.Text = "";
                timeLeftigniteTop = 210;
                return;
            }
            label1.Text = "Top Ig " + timeLeftigniteTop.ToString();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            timeLeftghostTop--;
            if (timeLeftghostTop == 0)
            {
                timer8.Stop();
                label1.Text = "";
                timeLeftghostTop = 180;
                return;
            }
            label1.Text = "Top G " + timeLeftghostTop.ToString();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            timeLeftflashJungle--;
            if (timeLeftflashJungle == 0)
            {
                timer9.Stop();
                label4.Text = "";
                timeLeftflashJungle = 300;
                return;
            }
            label4.Text = "Jg F " + timeLeftflashJungle.ToString();
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            timeLeftigniteJungle--;
            if (timeLeftigniteJungle == 0)
            {
                timer10.Stop();
                label3.Text = "";
                timeLeftigniteJungle = 210;
                return;
            }
            label3.Text = "Jg Ig " + timeLeftigniteJungle.ToString();
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            timeLeftghostJungle--;
            if (timeLeftghostJungle == 0)
            {
                timer9.Stop();
                label3.Text = "";
                timeLeftghostJungle = 180;
                return;
            }
            label3.Text = "Jg G " + timeLeftghostJungle.ToString();
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            timeLeftflashMid--;
            if (timeLeftflashMid == 0)
            {
                timer12.Stop();
                label6.Text = "";
                timeLeftflashMid = 300;
                return;
            }
            label6.Text = "Mid F " + timeLeftflashMid.ToString();
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            timeLeftbarrierMid--;
            if (timeLeftbarrierMid == 0)
            {
                timer13.Stop();
                label5.Text = "";
                timeLeftbarrierMid = 180;
                return;
            }
            label5.Text = "Mid B " + timeLeftbarrierMid.ToString();
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            timeLeftexhaustMid--;
            if (timeLeftexhaustMid == 0)
            {
                timer14.Stop();
                label5.Text = "";
                timeLeftexhaustMid = 210;
                return;
            }
            label5.Text = "Mid Ex " + timeLeftexhaustMid.ToString();
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            timeLeftigniteMid--;
            if (timeLeftigniteMid == 0)
            {
                timer15.Stop();
                label5.Text = "";
                timeLeftigniteMid = 210;
                return;
            }
            label5.Text = "Mid Ig " + timeLeftigniteMid.ToString();
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            timeLeftghostMid--;
            if (timeLeftghostMid == 0)
            {
                timer16.Stop();
                label5.Text = "";
                timeLeftghostMid = 180;
                return;
            }
            label5.Text = "Mid G " + timeLeftghostMid.ToString();
        }

        private void timer17_Tick(object sender, EventArgs e)
        {
            timeLeftcleanseMid--;
            if (timeLeftcleanseMid == 0)
            {
                timer17.Stop();
                label5.Text = "";
                timeLeftcleanseMid = 210;
                return;
            }
            label5.Text = "Mid C " + timeLeftcleanseMid.ToString();
        }

        private void timer18_Tick(object sender, EventArgs e)
        {
            timeLefthealMid--;
            if (timeLefthealMid == 0)
            {
                timer18.Stop();
                label5.Text = "";
                timeLefthealMid = 240;
                return;
            }
            label5.Text = "Mid H " + timeLefthealMid.ToString();
        }

        private void timer19_Tick(object sender, EventArgs e)
        {
            timeLeftteleportMid--;
            if (timeLeftteleportMid == 0)
            {
                timer19.Stop();
                label5.Text = "";
                timeLeftteleportMid = 300;
                return;
            }
            label5.Text = "Mid TP " + timeLeftteleportMid.ToString();
        }

        private void timer20_Tick(object sender, EventArgs e)
        {
            timeLeftflashSupp--;
            if (timeLeftflashSupp == 0)
            {
                timer20.Stop();
                label10.Text = "";
                timeLeftflashSupp = 300;
                return;
            }
            label10.Text = "Supp F " + timeLeftflashSupp.ToString();
        }

        private void timer21_Tick(object sender, EventArgs e)
        {
            timeLeftigniteSupp--;
            if (timeLeftigniteSupp == 0)
            {
                timer21.Stop();
                label9.Text = "";
                timeLeftigniteSupp = 210;
                return;
            }
            label9.Text = "Supp Ig " + timeLeftigniteSupp.ToString();
        }

        private void timer22_Tick(object sender, EventArgs e)
        {
            timeLeftexhaustSupp--;
            if (timeLeftexhaustSupp == 0)
            {
                timer22.Stop();
                label9.Text = "";
                timeLeftexhaustSupp = 210;
                return;
            }
            label9.Text = "Supp Ex " + timeLeftexhaustSupp.ToString();
        }

        private void timer23_Tick(object sender, EventArgs e)
        {
            timeLefthealSupp--;
            if (timeLefthealSupp == 0)
            {
                timer23.Stop();
                label9.Text = "";
                timeLefthealSupp = 240;
                return;
            }
            label9.Text = "Supp H " + timeLefthealSupp.ToString();
        }

        private void timer24_Tick(object sender, EventArgs e)
        {
            timeLeftexhaustJungle--;
            if (timeLeftexhaustJungle == 0)
            {
                timer24.Stop();
                label3.Text = "";
                timeLeftexhaustJungle = 210;
                return;
            }
            label3.Text = "Jg Ex " + timeLeftexhaustJungle.ToString();
        }
    }
}
