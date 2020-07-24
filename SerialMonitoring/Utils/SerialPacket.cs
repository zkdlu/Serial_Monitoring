namespace SerialMonitoring.Utils
{
    public class SerialPacket
    {
        /*
         * Packet Structure
         * | Data | 
         */

        public byte[] Data
        {
            get;
            private set;
        }

        public SerialPacket(byte[] data)
        {
            Data = data;
        }
    }
}
