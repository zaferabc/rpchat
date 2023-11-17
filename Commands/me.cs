using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using SK_RPChat;
using System;
using System.Collections.Generic;

namespace SK_RPChat.Commands
{
    public class ME : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "me";

        public string Help => "";

        public string Syntax => throw new NotImplementedException();

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "sk.me" };

        public void Execute(IRocketPlayer caller, string[] args)
        {
            var player = (UnturnedPlayer)caller;
            var name = player.DisplayName;
            var playername = "!playerName!";
            if (args.Length == 0) return;
            string iconURL = SK_RPChat.Instance.Configuration.Instance.meicon;
            var papa1 = string.Join(" ", args);
            ChatManager.serverSendMessage
                (SK_RPChat.Instance.Configuration.Instance.memessages.Replace('{', '<').Replace('}', '>').Replace(playername, name) + "" + papa1 + "", SK_RPChat.Instance.MessageColor, null, null, EChatMode.GLOBAL, iconURL, true);


        }
    }
}