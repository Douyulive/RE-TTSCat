using DouyuDM_PluginFramework;
using Re_TTSCat.Data;

namespace Re_TTSCat
{
    public partial class Main : DMPlugin
    {
        private async void GiftDebouncedEvent(object sender, UserGift e)
        {
            ALog($"合并礼物: 来自 {e.User} ({e.UserId}) 的 {e.Qty} 个 {e.Gift}，直接路由到礼物路线...");
            var constructedArgs = new ReceivedMessageArgs();
            constructedArgs.Message = new MessageModel();
            constructedArgs.Message.GiftName = e.Gift;
            constructedArgs.Message.GiftCount = e.Qty;
            constructedArgs.Message.UserName = e.User;
            constructedArgs.Message.UserID = e.UserId;
            constructedArgs.Message.MsgType = MsgTypeEnum.GiftSend;
            await GiftRoute(null, constructedArgs);
        }
    }
}
