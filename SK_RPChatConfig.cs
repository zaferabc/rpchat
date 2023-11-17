using Rocket.API;


namespace SK_RPChat
{

    public class SK_RPChatConfig : IRocketPluginConfiguration

    {
        public string MessageColor { get; set; }
        public string anonymousmessages;
        public string anonymousicon;
        public string memessages;
        public string meicon;
        public string domessages;
        public string doicon;
        public string oocmessages;
        public string oocicon;

        public void LoadDefaults()
        {
            MessageColor = "white";
            
            anonymousmessages = "{color=#252525}[ANONYMOUS]{/color}・ ";
            anonymousicon = "https://i.hizliresim.com/6vd2zit.png";
            
            memessages = "{color=#73ff2c}[ME]{/color}・{color=#b9b9b9} !playerName!{/color}: ";
            meicon = "https://i.hizliresim.com/pyvif77.png";
            
            domessages = "{color=#2ca3ff}[DO]{/color}・{color=#b9b9b9} !playerName!{/color}: ";
            doicon = "https://i.hizliresim.com/15qlko9.png";
            
            oocmessages = "{color=#ff2c2c}[OOC]{/color}・{color=#b9b9b9} !playerName!{/color}: ";
            oocicon = "https://i.hizliresim.com/6mfq12x.png";

        }
    }
}


