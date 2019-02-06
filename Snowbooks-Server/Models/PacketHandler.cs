using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowbooks_Server.Models
{
    public static class PacketHandler
    {

        public static Dictionary<int, PacketType> PacketTypes;

        public static void InitiatePacketTypes()
        {
            PacketTypes = new Dictionary<int, PacketType>();
            int index = 0;

            foreach (PacketType type in Enum.GetValues(typeof(PacketType)))
            {
                PacketTypes.Add(index, type);
                index++;
            }
        }

        public static Packet GetPacket(byte[] data)
        {
            int packetId = data[0];
            PacketType type;

            try
            {
               type = PacketTypes[packetId];
            }
            catch (Exception e)
            {
                type = PacketType.INVALID;
                Console.WriteLine($"Invalid Packet! ID: {packetId}, Exception: {e.Message}");
            }

            return new Packet(type, data);
        }

    }
}
