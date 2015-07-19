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
            if ( (args.Parameters.Count > 1) && (getPlayer(args.Parameters[1]) != null) )
            {
                switch (args.Parameters[0])
                {
                    case "kill":
                        getPlayer(args.Parameters[1]).DamagePlayer(1000);
                        args.Player.SendInfoMessage(String.Format("You killed {0}", getPlayer(args.Parameters[1])));
                        break;
                    case "heal":
                        getPlayer(args.Parameters[1]).Heal(500);
                        args.Player.SendInfoMessage(String.Format("You healed {0}", getPlayer(args.Parameters[1])));
                        break;
                    case "lc":
                        getPlayer(args.Parameters[1]).Disconnect("Respect the Booty");
                        break;
                    case "pvp":
                        if (!Main.player[getPlayer(args.Parameters[1]).Index].hostile)
                        {
                            Main.player[getPlayer(args.Parameters[1]).Index].hostile = true;
                            NetMessage.SendData((int)PacketTypes.TogglePvp, -1, -1, "", args.Player.Index);
                            getPlayer(args.Parameters[1]).SendInfoMessage("Your PvP is now enabled.");
                        }
                        else if (Main.player[getPlayer(args.Parameters[1]).Index].hostile)
                        {
                            Main.player[getPlayer(args.Parameters[1]).Index].hostile = false;
                            NetMessage.SendData((int)PacketTypes.TogglePvp, -1, -1, "", getPlayer(args.Parameters[1]).Index);
                            getPlayer(args.Parameters[1]).SendInfoMessage("Your PvP is now disabled.");
                        }

                        break;
                    default:
                        args.Player.SendInfoMessage("Invalid Subcommand");
                        break;

                }

            }
            else if (args.Parameters.Count > 0)
            {
                switch (args.Parameters[0])
                {
                    case "kill":
                        args.Player.SendInfoMessage(String.Format("Corect use: /bert {0} <player>", args.Parameters[0]));
                        break;
                    case "heal":
                        args.Player.SendInfoMessage(String.Format("Corect use: /bert {0} <player>", args.Parameters[0]));
                        break;
                    case "lc":
                        args.Player.SendInfoMessage(String.Format("Corect use: /bert {0} <player>", args.Parameters[0]));
                        break;
                    case "pvp":
                        args.Player.SendInfoMessage(String.Format("Corect use: /bert {0} <player>", args.Parameters[0]));
                        break;
                    default:
                        args.Player.SendInfoMessage("Invalid Subcommand");
                        break;

                }
            }
            else
            {
                args.Player.SendInfoMessage("Your Doing it Wrong.");
            }
        }

        public TSPlayer getPlayer(string Xname)
        {
            foreach (TSPlayer plr in TShock.Players)
            {
                if (plr.Name == Xname)
                {
                    return plr;
                }
            }
            return null;
        }
    }
}
