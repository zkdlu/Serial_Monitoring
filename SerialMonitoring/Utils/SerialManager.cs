using System.Collections.Generic;
using System.IO.Ports;
using System.Windows;

namespace SerialMonitoring.Utils
{
    public class SerialManager
    {
        public static SerialManager Instnace { get; } = new SerialManager();
        
        private static readonly List<byte> list = new List<byte>();
        private static readonly int PacketSize = 0;

        private SerialPort serialPort;
        
        private SerialManager() 
        {
            serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
            serialPort.DataReceived += SerialPort_DataReceived;
            serialPort.ErrorReceived += SerialPort_ErrorReceived;
        }

        private void SerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            if (MessageBox.Show("Serial Port Error",
                "Error",
                MessageBoxButton.OK,
                MessageBoxImage.Error,
                MessageBoxResult.OK) == MessageBoxResult.OK)
            {
                Exit();
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sender is SerialPort serialPort)
            {
                if (!serialPort.IsOpen)
                {
                    Exit();
                    return;
                }

                int bytesToRead = serialPort.BytesToRead;
                byte[] buffer = new byte[bytesToRead];

                serialPort.Read(buffer, 0, bytesToRead);

                list.AddRange(buffer);
            }
        }

        public void Send(byte[] data)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write(data, 0, data.Length);
            }
        }

        public SerialPacket Receive()
        {
            int count = list.Count;

            if (count >= PacketSize)
            {
                byte[] data = new byte[PacketSize];

                list.CopyTo(0, data, 0, PacketSize);
                list.RemoveRange(0, PacketSize);

                return new SerialPacket(data);
            }

            return null;
        }

        private void Exit()
        {
            Application.Current.Shutdown();
        }
    }
}
