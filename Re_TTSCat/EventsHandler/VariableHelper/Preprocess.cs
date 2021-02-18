using DouyuDM_PluginFramework;
using Re_TTSCat.Data;

namespace Re_TTSCat
{
    public partial class Main : DMPlugin
    {
        /// <summary>
        /// 将 $$, $!, $VIP 和 $GUARD 预处理
        /// </summary>
        /// <param name="format">原始模板</param>
        /// <param name="e">原始事件</param>
        /// <returns></returns>
        public static string Preprocess(string format, MessageModel e)
        {
            return format;
        }

        public static string Preprocess(string format, ReceivedMessageArgs e) => Preprocess(format, e.Message);
    }
}