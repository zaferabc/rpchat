using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;

namespace SK_RPChat.Commands
{
    public class Command : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "anonymous";

        public string Help => "";

        public string Syntax => throw new NotImplementedException();

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "sk.anonymous" };

        public void Execute(IRocketPlayer caller, string[] args)
        {
                        if (args.Length == 0) return;
                        string iconURL = SK_RPChat.Instance.Configuration.Instance.anonymousicon;
                        var papa1 = string.Join(" ", args);
                        ChatManager.serverSendMessage(SK_RPChat.Instance.Configuration.Instance.anonymousmessages.Replace('{', '<').Replace('}', '>') + papa1, SK_RPChat.Instance.MessageColor, null, null, EChatMode.GLOBAL, iconURL, true);


        }
    }
}

    



