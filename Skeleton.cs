using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;
using System.Reflection;

//Namespace of our plugin
namespace Skeleton
{
    //Api tick
    [ApiVersion(1,19)]
    public class ToyBoat : TerrariaPlugin
    {
        
 //Constructor
        public ToyBoat(Terraria.Main game)
            : base(game)
        {

        }
        //Author of the plugin
        public override string Author
        {
            get
            {
                return "ToyBoat";
            }
        }
        //Name of the plugin
        public override string Name
        {
            get
            {
                return "Skeleton";
            }
        }
        //Description of the plugin
        public override string Description
        {
            get
            {
                return "Plugin Skeleton";
            }
        }
        //Version of the plugin. We are fetching it automatically, so no need to worry about changing anything here
        public override Version Version
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version;
            }
        }
        //Initialize function. Executed upon loading the plugin. Most important function out there.
        public override void Initialize()
        {
            //This is where we are going to work at next
             TShockAPI.Commands.ChatCommands.Add(new Command("bert.is.noob", BertIsNoob, "bert"));
        }

        private void BertIsNoob(CommandArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
