using DouyuDM_PluginFramework;
using Re_TTSCat.Data;

namespace Re_TTSCat
{
    public partial class Main : DMPlugin
    {
        public static string ProcessDanmaku(MessageModel e, string template)
        {
            var rawDanmaku = Preprocess(template, e);
            return rawDanmaku
                .Replace("$USER", e.UserName)
                .Replace("$DM", e.CommentText);
        }
        public static string ProcessDanmaku(MessageModel e) => ProcessDanmaku(e, Vars.CurrentConf.OnDanmaku);
        public static string ProcessDanmaku(ReceivedMessageArgs e) => ProcessDanmaku(e.Message);
        public static string ProcessDanmaku(ReceivedMessageArgs e, string template) => ProcessDanmaku(e.Message, template);
    }
}