using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BattleBuddy
{
    public class Creator
    {
        public void CreatePlayer (Player player)
        {
            string output = JsonConvert.SerializeObject(player);
        }
    }
}
