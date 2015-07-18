using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;
using System.Reflection;

namespace Skeleton
{
    [ApiVersion(1,19)]
    public class ToyBoat : TerrariaPlugin
    {
        public ToyBoat(Main game)
            : base(game)
        {

        }
        public override string Author
        {
            get
            {
                return "ToyBoat";
            }
        }
        public override string Name
        {
            get
            {
                return "Skeleton";
            }
        }
        public override string Description
        {
            get
            {
                return "Plugin Skeleton";
            }
        }
        public override Version Version
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version;
            }
        }
        public override void Initialize()
        {
            
        }
    }
}
