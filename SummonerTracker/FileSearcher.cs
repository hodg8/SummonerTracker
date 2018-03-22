using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SummonerTracker
{
    
    class FileSearcher
    {
        long lastPosition;
                        
        public delegate void AdcFlashEventHandler(object source, EventArgs args);
        public event AdcFlashEventHandler AdcFlashed;
        protected virtual void OnAdcFlashed()
        {
            if (AdcFlashed != null)
            {
                AdcFlashed(this, EventArgs.Empty);
            }
        }

        public delegate void AdcHealEventHandler(object source, EventArgs args);
        public event AdcHealEventHandler AdcHealed;
        protected virtual void OnAdcHealed()
        {
            if (AdcHealed != null)
            {
                AdcHealed(this, EventArgs.Empty);
            }
        }

        public delegate void AdcBarrierEventHandler(object source, EventArgs args);
        public event AdcBarrierEventHandler AdcBarriered;
        protected virtual void OnAdcBarriered()
        {
            if (AdcBarriered != null)
            {
                AdcBarriered(this, EventArgs.Empty);
            }
        }

        public delegate void AdcCleanseEventHandler(object source, EventArgs args);
        public event AdcCleanseEventHandler AdcCleansed;
        protected virtual void OnAdcCleansed()
        {
            if (AdcCleansed != null)
            {
                AdcCleansed(this, EventArgs.Empty);
            }
        }

        public delegate void JungleFlashEventHandler(object source, EventArgs args);
        public event JungleFlashEventHandler JungleFlashed;
        protected virtual void OnJungleFlashed()
        {
            if (JungleFlashed != null)
            {
                JungleFlashed(this, EventArgs.Empty);
            }
        }

        public delegate void JungleExhaustEventHandler(object source, EventArgs args);
        public event JungleExhaustEventHandler JungleExhausted;
        protected virtual void OnJungleExhausted()
        {
            if (JungleExhausted != null)
            {
                JungleExhausted(this, EventArgs.Empty);
            }
        }

        public delegate void JungleIgniteEventHandler(object source, EventArgs args);
        public event JungleIgniteEventHandler JungleIgnited;
        protected virtual void OnJungleIgnited()
        {
            if (JungleIgnited != null)
            {
                JungleIgnited(this, EventArgs.Empty);
            }
        }

        public delegate void JungleGhostEventHandler(object source, EventArgs args);
        public event JungleGhostEventHandler JungleGhosted;
        protected virtual void OnJungleGhosted()
        {
            if (JungleGhosted != null)
            {
                JungleGhosted(this, EventArgs.Empty);
            }
        }

        public delegate void TopFlashEventHandler(object source, EventArgs args);
        public event TopFlashEventHandler TopFlashed;
        protected virtual void OnTopFlashed()
        {
            if (TopFlashed != null)
            {
                TopFlashed(this, EventArgs.Empty);
            }
        }

        public delegate void TopTeleportEventHandler(object source, EventArgs args);
        public event TopTeleportEventHandler TopTeleported;
        protected virtual void OnTopTeleported()
        {
            if (TopTeleported != null)
            {
                TopTeleported(this, EventArgs.Empty);
            }
        }

        public delegate void TopIgniteEventHandler(object source, EventArgs args);
        public event TopIgniteEventHandler TopIgnited;
        protected virtual void OnTopIgnited()
        {
            if (TopIgnited != null)
            {
                TopIgnited(this, EventArgs.Empty);
            }
        }

        public delegate void TopExhaustEventHandler(object source, EventArgs args);
        public event TopExhaustEventHandler TopExhausted;
        protected virtual void OnTopExhausted()
        {
            if (TopExhausted != null)
            {
                TopExhausted(this, EventArgs.Empty);
            }
        }

        public delegate void TopGhostEventHandler(object source, EventArgs args);
        public event TopGhostEventHandler TopGhosted;
        protected virtual void OnTopGhosted()
        {
            if (TopGhosted != null)
            {
                TopGhosted(this, EventArgs.Empty);
            }
        }

        public delegate void MidFlashEventHandler(object source, EventArgs args);
        public event MidFlashEventHandler MidFlashed;
        protected virtual void OnMidFlashed()
        {
            if (MidFlashed != null)
            {
                MidFlashed(this, EventArgs.Empty);
            }
        }

        public delegate void MidCleanseEventHandler(object source, EventArgs args);
        public event MidCleanseEventHandler MidCleansed;
        protected virtual void OnMidCleansed()
        {
            if (MidCleansed != null)
            {
                MidCleansed(this, EventArgs.Empty);
            }
        }

        public delegate void MidBarrierEventHandler(object source, EventArgs args);
        public event MidBarrierEventHandler MidBarriered;
        protected virtual void OnMidBarriered()
        {
            if (MidBarriered != null)
            {
                MidBarriered(this, EventArgs.Empty);
            }
        }

        public delegate void MidIgniteEventHandler(object source, EventArgs args);
        public event MidIgniteEventHandler MidIgnited;
        protected virtual void OnMidIgnited()
        {
            if (MidIgnited != null)
            {
                MidIgnited(this, EventArgs.Empty);
            }
        }

        public delegate void MidTeleportEventHandler(object source, EventArgs args);
        public event MidTeleportEventHandler MidTeleported;
        protected virtual void OnMidTeleported()
        {
            if (MidTeleported != null)
            {
                MidTeleported(this, EventArgs.Empty);
            }
        }

        public delegate void MidHealEventHandler(object source, EventArgs args);
        public event MidHealEventHandler MidHealed;
        protected virtual void OnMidHealed()
        {
            if (MidHealed != null)
            {
                MidHealed(this, EventArgs.Empty);
            }
        }

        public delegate void MidGhostEventHandler(object source, EventArgs args);
        public event MidGhostEventHandler MidGhosted;
        protected virtual void OnMidGhosted()
        {
            if (MidGhosted != null)
            {
                MidGhosted(this, EventArgs.Empty);
            }
        }

        public delegate void MidExhaustEventHandler(object source, EventArgs args);
        public event MidExhaustEventHandler MidExhausted;
        protected virtual void OnMidExhausted()
        {
            if (MidExhausted != null)
            {
                MidExhausted(this, EventArgs.Empty);
            }
        }

        public delegate void SupportFlashEventHandler(object source, EventArgs args);
        public event SupportFlashEventHandler SupportFlashed;
        protected virtual void OnSupportFlashed()
        {
            if (SupportFlashed != null)
            {
                SupportFlashed(this, EventArgs.Empty);
            }
        }

        public delegate void SupportIgniteEventHandler(object source, EventArgs args);
        public event SupportIgniteEventHandler SupportIgnited;
        protected virtual void OnSupportIgnited()
        {
            if (SupportIgnited != null)
            {
                SupportIgnited(this, EventArgs.Empty);
            }
        }

        public delegate void SupportExhaustEventHandler(object source, EventArgs args);
        public event SupportExhaustEventHandler SupportExhausted;
        protected virtual void OnSupportExhausted()
        {
            if (SupportExhausted != null)
            {
                SupportExhausted(this, EventArgs.Empty);
            }
        }

        public delegate void SupportHealEventHandler(object source, EventArgs args);
        public event SupportHealEventHandler SupportHealed;
        protected virtual void OnSupportHealed()
        {
            if (SupportHealed != null)
            {
                SupportHealed(this, EventArgs.Empty);
            }
        }             

        public void watch()
        {
            FileSystemWatcher fileWatcher = new FileSystemWatcher();
            fileWatcher.EnableRaisingEvents = false;
            fileWatcher.Path = Properties.Settings.Default.MyNotesPath;
            fileWatcher.IncludeSubdirectories = true;
            fileWatcher.NotifyFilter = NotifyFilters.LastWrite;
            fileWatcher.Filter = "MyNotes.txt";
            fileWatcher.Changed += new FileSystemEventHandler (OnChanged);
            fileWatcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            Stream stream = File.Open(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            stream.Seek(lastPosition, SeekOrigin.Begin);
            StreamReader reader = new StreamReader(stream);            
            string line = reader.ReadToEnd();
            
            if (line.Contains("ad f"))
            {
                OnAdcFlashed();
            }
            if (line.Contains("a f"))
            {
                OnAdcFlashed();
            }
            if (line.Contains("a h"))
            {
                OnAdcHealed();
            }
            if (line.Contains("ad h"))
            {
                OnAdcHealed();
            }
            if (line.Contains("a b"))
            {
                OnAdcBarriered();
            }            
            if (line.Contains("ad b"))
            {
                OnAdcBarriered();
            }
            if (line.Contains("t f"))
            {
                OnTopFlashed();
            }
            if (line.Contains("t tp"))
            {
                OnTopTeleported();
            }
            if (line.Contains("t t"))
            {
                OnTopTeleported();
            }
            if (line.Contains("t i"))
            {
                OnTopIgnited();
            }
            if (line.Contains("t ig"))
            {
                OnTopIgnited();
            }
            if (line.Contains("t e"))
            {
                OnTopExhausted();
            }
            if (line.Contains("t ex"))
            {
                OnTopExhausted();
            }
            if (line.Contains("t g"))
            {
                OnTopGhosted();
            }
            if (line.Contains("j f"))
            {
                OnJungleFlashed();
            }
            if (line.Contains("jg f"))
            {
                OnJungleFlashed();
            }
            if (line.Contains("j i"))
            {
                OnJungleIgnited();
            }
            if (line.Contains("jg i"))
            {
                OnJungleIgnited();
            }
            if (line.Contains("j ig"))
            {
                OnJungleIgnited();
            }
            if (line.Contains("jg ig"))
            {
                OnJungleIgnited();
            }
            if (line.Contains("j e"))
            {
                OnJungleExhausted();
            }
            if (line.Contains("jg e"))
            {
                OnJungleExhausted();
            }
            if (line.Contains("j ex"))
            {
                OnJungleExhausted();
            }
            if (line.Contains("jg ex"))
            {
                OnJungleExhausted();
            }
            if (line.Contains("j g"))
            {
                OnJungleGhosted();
            }
            if (line.Contains("jg g"))
            {
                OnJungleGhosted();
            }            
            if (line.Contains("m f"))
            {
                OnMidFlashed();
            }
            if (line.Contains("m b"))
            {
                OnMidBarriered();
            }
            if (line.Contains("m i"))
            {
                OnMidIgnited();
            }
            if (line.Contains("m ig"))
            {
                OnMidIgnited();
            }
            if (line.Contains("m t"))
            {
                OnMidTeleported();
            }
            if (line.Contains("m tp"))
            {
                OnMidTeleported();
            }
            if (line.Contains("m c"))
            {
                OnMidCleansed();
            }
            if (line.Contains("m e"))
            {
                OnMidExhausted();
            }
            if (line.Contains("m ex"))
            {
                OnMidExhausted();
            }
            if (line.Contains("m g"))
            {
                OnMidGhosted();
            }
            if (line.Contains("m h"))
            {
                OnMidHealed();
            }
            if (line.Contains("s i"))
            {
                OnSupportIgnited();
            }
            if (line.Contains("s f"))
            {
                OnSupportFlashed();
            }
            if (line.Contains("s ig"))
            {
                OnSupportIgnited();
            }
            if (line.Contains("s e"))
            {
                OnSupportExhausted();
            }
            if (line.Contains("s ex"))
            {
                OnSupportExhausted();
            }
            if (line.Contains("s h"))
            {
                OnSupportHealed();
            }
            
            lastPosition = stream.Position;
            stream.Close();
        }

        
    }
}
