using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace UnfuckMyHeadset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding headset!");
            BluetoothClient btc = new BluetoothClient();
            foreach(var d in btc.PairedDevices)
            {
                Console.WriteLine("Checking {0}", d.DeviceName);

                if(
                    d.ClassOfDevice.Device == DeviceClass.AudioVideoHeadphones || 
                    d.ClassOfDevice.Device == DeviceClass.AudioVideoHandsFree || 
                    d.ClassOfDevice.Device == DeviceClass.AudioVideoHeadset 
                )
                {
                    Console.WriteLine("Headset found.");

					if (d.InstalledServices.Contains(BluetoothService.Handsfree))
                    {
						Console.WriteLine("Unfucking headset!");
					    d.SetServiceState(BluetoothService.Handsfree, false);
				    }
				}
			}

            Console.WriteLine("Headset unfucked!");
		}
    }
}
