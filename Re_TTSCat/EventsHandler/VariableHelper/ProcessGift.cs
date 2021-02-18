using DouyuDM_PluginFramework;
using Re_TTSCat.Data;

namespace Re_TTSCat
{
    public partial class Main : DMPlugin
    {
        public static string ProcessGift(MessageModel e, string template)
        {
            var rawDanmaku = Preprocess(template, e);
            return rawDanmaku
                .Replace("$GIFT", e.GiftName)
                .Replace("$COUNT", e.GiftCount.ToString())
                .Replace("$USER", e.UserName);
        }
        public static string ProcessGift(MessageModel e) => ProcessGift(e, Vars.CurrentConf.OnGift);
        public static string ProcessGift(ReceivedMessageArgs e) => ProcessGift(e.Message, Vars.CurrentConf.OnGift);
        public static string ProcessGift(ReceivedMessageArgs e, string template) => ProcessGift(e.Message, template);
    }
}