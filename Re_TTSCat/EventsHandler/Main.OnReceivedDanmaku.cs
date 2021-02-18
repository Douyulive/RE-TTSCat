using DouyuDM_PluginFramework;
using Re_TTSCat.Data;

namespace Re_TTSCat
{
    public partial class Main : DMPlugin
    {
        public async void OnReceivedDanmaku(object sender, ReceivedMessageArgs e)
        {
            if (!IsNAudioReady) return;
            switch (e.Message.MsgType)
            {
                case MsgTypeEnum.Comment:
                    await CommentRoute(sender, e);
                    break;
                case MsgTypeEnum.GiftSend:
                    if (Vars.CurrentConf.GiftsThrottle)
                    {
                        ALog($"礼物合并已启用，正在合并礼物: 来自 {e.Message.UserName} ({e.Message.UserID}) 的 {e.Message.GiftCount} 个 {e.Message.GiftName}");
                        Vars.Debouncer.Add(new UserGift
                        (
                            e.Message.UserName,
                            e.Message.UserID,
                            e.Message.GiftName,
                            e.Message.GiftCount
                        ));
                    }
                    else
                        await GiftRoute(sender, e);
                    break;
                case MsgTypeEnum.LiveStatusToggle:
                    if (e.Message.LiveStatus == 1)
                    {
                        await LiveStartRoute(sender, e);
                    }
                    else if (e.Message.LiveStatus == 0)
                    {
                        await LiveEndRoute(sender, e);
                    }
                    break;
                case MsgTypeEnum.UserEnter:
                    await InteractRoute(sender, e);
                    break;
                case MsgTypeEnum.LiveShare:
                    await InteractRoute(sender, e);
                    break;
            }
        }
    }
}
