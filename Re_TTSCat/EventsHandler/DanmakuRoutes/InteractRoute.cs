using DouyuDM_PluginFramework;
using Re_TTSCat.Data;
using System.Threading.Tasks;

namespace Re_TTSCat
{
    public partial class Main : DMPlugin
    {
        public async Task InteractRoute(object sender, ReceivedMessageArgs e)
        {
            // check user eligibility
            if (!Conf.CheckUserEligibility(e)) return;
            Bridge.ALog("规则检查通过，正在朗读用户交互事件");

            string result;

            switch (e.Message.MsgType)
            {
                case MsgTypeEnum.UserEnter:
                    result = ProcessInteract(e.Message, Vars.CurrentConf.OnInteractEnter);
                    break;
                case MsgTypeEnum.LiveShare:
                    result = ProcessInteract(e.Message, Vars.CurrentConf.OnInteractShare);
                    break;
                default: return;
            }

            await TTSPlayer.UnifiedPlay(result);
        }
    }
}