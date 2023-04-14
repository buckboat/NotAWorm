using System;
using System.Net.NetworkInformation;
using System.Text;
//banana
namespace NotAWorm
{
    class Program
    {
        static void Main(string[] args)
        {

            //parse command line argument maybe get router name. Or use a file to get routers to test and loop threw them all.

            int MaxListSize = 50;

            string readFile = "/here";
            string writeFile = "/here";




            Device[] Devicelist = new Device[MaxListSize];

            // Start with command line argument with 1st address to test, write to file



            // after intial ping method start loop to ping rest of router network, write to file
            using (FileStream fileStreamIn = new FileStream(readFile, FileMode.Open))
            {

                //PingAddress(args);

                byte[] line = new byte[1024];
                UTF8Encoding read = new UTF8Encoding(true);

                while (fileStreamIn.Read(line, 0, line.Length) > 0)
                {

                   //PingAddress(read);

                    using (FileStream fileStreamOut = new FileStream(writeFile, FileMode.Open))
                    {



                    }


                }
            }



            //after checking all router address, save file 



        }

        public void PingAddress(string address)
        {


            //pings address waits for response
            //pings again if no response
            //if response save address to device
            //try  commands to try to get a device type or name

        }

    }

    class Device
    {
        public string IpAddress { get; set; } = "Unknown";

        public string DeviceName { get; set; } = "Unknown";

        public string DeviceType { get; set; } = "Unknown";

    }



}
