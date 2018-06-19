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
        private long lastPosition;

        public delegate void AdcFlashEventHandler();
        public event AdcFlashEventHandler AdcFlashed;
        

        public delegate void AdcHealEventHandler();
        public event AdcHealEventHandler AdcHealed;

        public delegate void AdcExhaustEventHandler();
        public event AdcExhaustEventHandler AdcExhausted;

        public delegate void AdcBarrierEventHandler();
        public event AdcBarrierEventHandler AdcBarriered;        

        public delegate void AdcCleanseEventHandler();
        public event AdcCleanseEventHandler AdcCleansed;

        public delegate void AdcTeleportEventHandler();
        public event AdcTeleportEventHandler AdcTeleported;

        public delegate void JungleFlashEventHandler();
        public event JungleFlashEventHandler JungleFlashed;
        
        public delegate void JungleExhaustEventHandler();
        public event JungleExhaustEventHandler JungleExhausted;        

        public delegate void JungleIgniteEventHandler();
        public event JungleIgniteEventHandler JungleIgnited;        

        public delegate void JungleGhostEventHandler();
        public event JungleGhostEventHandler JungleGhosted;
        
        public delegate void TopFlashEventHandler();
        public event TopFlashEventHandler TopFlashed;
        
        public delegate void TopTeleportEventHandler();
        public event TopTeleportEventHandler TopTeleported;
        
        public delegate void TopIgniteEventHandler();
        public event TopIgniteEventHandler TopIgnited;
        
        public delegate void TopExhaustEventHandler();
        public event TopExhaustEventHandler TopExhausted;
       
        public delegate void TopGhostEventHandler();
        public event TopGhostEventHandler TopGhosted;
        
        public delegate void MidFlashEventHandler();
        public event MidFlashEventHandler MidFlashed;
        
        public delegate void MidCleanseEventHandler();
        public event MidCleanseEventHandler MidCleansed;
        
        public delegate void MidBarrierEventHandler();
        public event MidBarrierEventHandler MidBarriered;
        
        public delegate void MidIgniteEventHandler();
        public event MidIgniteEventHandler MidIgnited;
        
        public delegate void MidTeleportEventHandler();
        public event MidTeleportEventHandler MidTeleported;
        
        public delegate void MidHealEventHandler();
        public event MidHealEventHandler MidHealed;
        
        public delegate void MidGhostEventHandler();
        public event MidGhostEventHandler MidGhosted;
        
        public delegate void MidExhaustEventHandler();
        public event MidExhaustEventHandler MidExhausted;
        
        public delegate void SupportFlashEventHandler();
        public event SupportFlashEventHandler SupportFlashed;
        
        public delegate void SupportIgniteEventHandler();
        public event SupportIgniteEventHandler SupportIgnited;
        
        public delegate void SupportExhaustEventHandler();
        public event SupportExhaustEventHandler SupportExhausted;
        
        public delegate void SupportHealEventHandler();
        public event SupportHealEventHandler SupportHealed;
        
        public void watch()
        {
            FileSystemWatcher fileWatcher = new FileSystemWatcher();
            fileWatcher.EnableRaisingEvents = false;
            fileWatcher.Path = folderSelectform.Folder;
            fileWatcher.IncludeSubdirectories = true;
            fileWatcher.NotifyFilter = NotifyFilters.LastWrite;
            fileWatcher.Filter = "MyNotes.txt";
            fileWatcher.Changed += new FileSystemEventHandler(OnChanged);
            fileWatcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            Stream stream = File.Open(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            stream.Seek(lastPosition, SeekOrigin.Begin);
            StreamReader reader = new StreamReader(stream);
            string line = reader.ReadToEnd();

            if (line.Contains("ad f") || line.Contains("a f") || line.Contains("adc f"))
            {
                AdcFlashed();
            }
            if (line.Contains("a h") || line.Contains("ad h") || line.Contains("adc h"))
            {
                AdcHealed();
            }            
            if (line.Contains("a b") || line.Contains("ad b") || line.Contains("adc b"))
            {
                AdcBarriered();
            }
            if (line.Contains("a t") || line.Contains("ad t") || line.Contains("adc t") || line.Contains("a tp") || line.Contains("ad tp") || line.Contains("adc tp"))
            {
                AdcTeleported();
            }
            if (line.Contains("a e") || line.Contains("ad e") || line.Contains("adc e") || line.Contains("a ex") || line.Contains("ad ex") || line.Contains("adc ex"))
            {
                AdcExhausted();
            }
            if (line.Contains("a c") || line.Contains("ad c") || line.Contains("adc c"))
            {
                AdcCleansed();
            }
            if (line.Contains("t f"))
            {
                TopFlashed();
            }
            if (line.Contains("t tp") || line.Contains("t t"))
            {
                TopTeleported();
            }            
            if (line.Contains("t i") || line.Contains("t ig"))
            {
                TopIgnited();
            }            
            if (line.Contains("t e") || line.Contains("t ex"))
            {
                TopExhausted();
            }            
            if (line.Contains("t g"))
            {
                TopGhosted();
            }
            if (line.Contains("j f") || line.Contains("jg f"))
            {
                JungleFlashed();
            }            
            if (line.Contains("j i") || line.Contains("jg i") || line.Contains("j ig") || line.Contains("jg ig"))
            {
                JungleIgnited();
            }
            if (line.Contains("j e") || line.Contains("jg e") || line.Contains("j ex") || line.Contains("jg ex"))
            {
                JungleExhausted();
            }            
            if (line.Contains("j g") || line.Contains("jg g"))
            {
                JungleGhosted();
            }                       
            if (line.Contains("m f"))
            {
                MidFlashed();
            }
            if (line.Contains("m b"))
            {
                MidBarriered();
            }
            if (line.Contains("m i"))
            {
                MidIgnited();
            }
            if (line.Contains("m ig"))
            {
                MidIgnited();
            }
            if (line.Contains("m t") || line.Contains("m tp"))
            {
                MidTeleported();
            }            
            if (line.Contains("m c"))
            {
                MidCleansed();
            }
            if (line.Contains("m e") || line.Contains("m ex"))
            {
                MidExhausted();
            }            
            if (line.Contains("m g"))
            {
                MidGhosted();
            }
            if (line.Contains("m h"))
            {
                MidHealed();
            }
            if (line.Contains("s i"))
            {
                SupportIgnited();
            }
            if (line.Contains("s f"))
            {
                SupportFlashed();
            }
            if (line.Contains("s ig"))
            {
                SupportIgnited();
            }
            if (line.Contains("s e") || line.Contains("s ex"))
            {
                SupportExhausted();
            }            
            if (line.Contains("s h"))
            {
                SupportHealed();
            }
            
            lastPosition = stream.Position;
            stream.Close();
        }

        
    }
}
