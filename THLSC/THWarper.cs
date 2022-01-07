using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpTori;

namespace THLSC
{
    public class THWarper
    {
        private IntPtr _handle;
        private THBase _game;
        private List<string> _idList = new List<string> { "th06", "th07", "th08", "th10", "th11", "th12", "th128", "th13", "th14", "th15", "th16", "th17", "th18" };
        private Dictionary<string, Type> _thclassTable = new Dictionary<string, Type>
        {
            { "th06", typeof(TH06) },
            { "th07", typeof(TH07) },
            { "th08", typeof(TH08) },
            { "th09", typeof(TH09) },
            { "th10", typeof(TH10) },
            { "th11", typeof(TH11) },
            { "th12", typeof(TH12) },
            { "th128", typeof(TH128) },
            { "th13", typeof(TH13) },
            { "th14", typeof(TH14) },
            { "th15", typeof(TH15) },
            { "th16", typeof(TH16) },
            { "th17", typeof(TH17) },
            { "th18", typeof(TH18) }
        };

        public bool IsRunning { get => MemoryReader.IsProcessAlive(_handle); }
        public THBase Game { get => _game; }

        public string Scan()
        {
            foreach (string id in _idList)
            {
                _handle = MemoryReader.GetHandle(ExeName.ResourceManager.GetString(id));
                if (_handle != IntPtr.Zero)
                {
                    _game = (THBase)Activator.CreateInstance(_thclassTable[id], _handle);
                    return id;
                }
            }
            return "";
        }
    }
}
