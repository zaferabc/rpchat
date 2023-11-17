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
    public class DO : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "do";

        public string Help => "";

        public string Syntax => throw new NotImplementedException();

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "sk.do" };

        public void Execute(IRocketPlayer caller, string[] args)
        {
            var player = (UnturnedPlayer)caller;
            var name = player.DisplayName;
            var playername = "!playerName!";
            if (args.Length == 0) return;
            string iconURL = SK_RPChat.Instance.Configuration.Instance.doicon;
            var papa1 = string.Join(" ", args);
            ChatManager.serverSendMessage
                (SK_RPChat.Instance.Configuration.Instance.domessages.Replace('{', '<').Replace('}', '>').Replace(playername, name) + "" + papa1 + "", SK_RPChat.Instance.MessageColor, null, null, EChatMode.GLOBAL, iconURL, true);


        }
    }
}