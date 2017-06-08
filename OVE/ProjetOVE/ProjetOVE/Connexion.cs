using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOVE
{
    public class Connexion
    {
        public delegate void ReceptionHandler(object sender, EventArgs e);
        public event ReceptionHandler Reception;
        protected string[] strs;

        protected virtual void Notify(EventArgs e)
        {
            if (Reception != null)
                Reception(this, e);
        }

        public Connexion(int port)
        {
            UDPListener(port);
        }

        public string[] getMsgs()
        {
            return strs;
        }

        public void UDPListener(int port)
        {
            char[] sep = { '\n' };
            Task.Run(async() =>
            {
                using (var udpClient = new UdpClient(port))
                {
                    string msg = "";
                    int t = 0;
                    while (true)
                    {
                        //IPEndPoint object will allow us to read datagrams sent from any source.
                        var receivedResults = await udpClient.ReceiveAsync();
                        msg += Encoding.ASCII.GetString(receivedResults.Buffer);
                        strs = msg.Split(sep);
                        if((t = strs.Length) > 1)
                        {
                            msg = strs[t - 1];
                            strs[t - 1] = "";
                            Notify(EventArgs.Empty);
                        }
                    }
                }
            });
        }
    }
}
