using System;
using System.Collections.Generic;
using System.Text;

namespace HarbleNet.Updater
{
    class RevisionInfo
    {
        public string Tag { get; set; }
        public DateTime FirstSeen { get; set; }
        public Dictionary<ushort, MessageInfo> IncomingMessages = new Dictionary<ushort, MessageInfo>();
        public Dictionary<ushort, MessageInfo> OutgoingMessages = new Dictionary<ushort, MessageInfo>();
    }
}
