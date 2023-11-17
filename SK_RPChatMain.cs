using Rocket.API;
using Rocket.API.Collections;
using Rocket.Core.Commands;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace SK_RPChat
{
    public class SK_RPChat : RocketPlugin<SK_RPChatConfig>

    {
        public static SK_RPChat Instance;

        public UnityEngine.Color MessageColor { get; private set; }
        public string TweetFormat { get; private set; }
        public string TweetIcon { get; private set; }
        protected override void Load()
        {
            {
                SK_RPChat.Instance = this;
                MessageColor = UnturnedChat.GetColorFromName(Configuration.Instance.MessageColor, UnityEngine.Color.white);
                Rocket.Core.Logging.Logger.Log("SK_JoinLeave plugin active!");
                Rocket.Core.Logging.Logger.Log("Would you like more free plugins? Join now: https://discord.gg/y3rYs7ZXFs");

            }
        }

        protected override void Unload()
        {

            Rocket.Core.Logging.Logger.Log("SK_JoinLeave plugin disabled!");
            Rocket.Core.Logging.Logger.Log("Would you like more free plugins? Join now: https://discord.gg/y3rYs7ZXFs");

        }


    }

}
