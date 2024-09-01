using Archipelago.Core;
using Archipelago.Core.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archipelago.Bizhawk
{
    public class BizhawkClient : IGameClient
    {
        public bool IsConnected { get; set; }
        public int ProcId { get; set; } = Memory.BIZHAWK_PROCESSID;
        public BizhawkClient()
        {

        }
        public bool Connect()
        {
            Console.WriteLine("Connecting to Bizhawk");
            var pid = Memory.BIZHAWK_PROCESSID;
            if (pid == 0)
            {
                Console.WriteLine("Bizhawk not found.");
                return false;
            }
            return true;
        }
    }
}
