using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowbooks_Server.Models
{
    public class Packet
    {
        public PacketType PacketType { get; set; }
        public byte[] Data { get; set; }

        public Packet(PacketType type, byte[] data)
        {
            PacketType = type;
            Data = data;
        }
    }

    public enum PacketType
    {
        INVALID = -1, LOGIN = 0
    }
}
