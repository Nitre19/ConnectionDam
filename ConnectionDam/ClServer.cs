using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quobject.SocketIoClientDotNet.Client;

namespace ConnectionDam
{
    class ClServer
    {
        public Quobject.SocketIoClientDotNet.Client.Socket socketServer;

        public Boolean connectSocketServer(String host)
        {
            Boolean done = false;

            if (host != "")
            {
                try
                {
                    socketServer = IO.Socket(host);
                    done = true;


                    socketServer.On("gameInfo", (infoPartida) =>
                    {
                        Console.WriteLine("gameInfo");
                    });

                    socketServer.On("neighborChange", (data) =>
                    {
                        Console.WriteLine("neighborChange");
                    });

                    socketServer.On("positionConfirmed", (data) =>
                    {
                        Console.WriteLine("positionConfirmed");
                    });            
                    

                }
                catch (Exception e)
                {
                    ClErrors.reportError(e.Message);
                }
            }
            else ClErrors.reportError("Can't connect socket is empty!");

            return done;
        }

        public void disconnectSocketServer()
        {
            socketServer.Disconnect();
        }

        public void selectPosition()
        {

            socketServer.Emit("selectPosition", "datos");
        }


        /*
         ClSocket.connectSocketServer("");

            ClSocket.socketServer.On(Socket.EVENT_CONNECT, () =>
            {
                Console.WriteLine("Connected to the socket");
                var text = new { text = "Hello World Server" };
                string json = JsonConvert.SerializeObject(text);
                ClSocket.socketServer.Emit("helloServer", json);
            });

            ClSocket.socketServer.On("helloClient", (data) =>
            {
                var text = new { text = "" };
                var t = JsonConvert.DeserializeAnonymousType((string)data, text);
                Console.WriteLine(t.text);
            });

            Console.ReadLine();
         */

    }
}
