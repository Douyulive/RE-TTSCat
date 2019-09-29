﻿using BilibiliDM_PluginFramework;

namespace Re_TTSCat
{
    public partial class Main : DMPlugin
    {
        public Main()
        {
            PluginAuth = "Elepover";
            PluginCont = "elepover@outlook.com";
            PluginDesc = "直接读出你收到的弹幕和礼物！（高考后更新版）";
            PluginName = "Re: TTSCat";
            PluginVer = Data.Vars.currentVersion.ToString();
            Connected += OnConnected;
            Disconnected += OnDisconnected;
            ReceivedRoomCount += OnReceivedRoomCount;
            ReceivedDanmaku += OnReceivedDanmaku;
        }
    }
}