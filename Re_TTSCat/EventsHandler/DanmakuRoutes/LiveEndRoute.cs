using DouyuDM_PluginFramework;
using Re_TTSCat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_TTSCat
{
    public partial class Main : DMPlugin
    {
        public async Task LiveEndRoute(object sender, ReceivedMessageArgs e)
        {
            await TTSPlayer.UnifiedPlay(Vars.CurrentConf.OnLiveEnd, true);
        }
    }
}
