﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Re_TTSCat.Data
{
    public partial class Conf
    {
        public Conf()
        {
            AutoUpdate = true;
            BlackList = "";
            WhiteList = "";
            BlockMode = 0;
            GiftBlockMode = 0;
            KeywordBlockMode = 0;
            BlockUID = true;
            DebugMode = false;
            DownloadFailRetryCount = 5;
            DoNotKeepCache = false;
            Engine = 0;
            GiftBlackList = "";
            GiftWhiteList = "";
            KeywordBlackList = "";
            KeywordWhiteList = "";
            MinimumDanmakuLength = 0;
            MaximumDanmakuLength = 50;
            ReadInQueue = true;
            ReadPossibility = 100;
            TTSVolume = 100;
            ReadSpeed = 0;
            try
            {
                using (var synth = new SpeechSynthesizer())
                {
                    Vars.SystemSpeechAvailable = true;
                    var voice = synth.GetInstalledVoices().FirstOrDefault(x => x.Enabled);
                    if (voice == default) VoiceName = "(无可用语音包)";
                    VoiceName = voice.VoiceInfo.Name;
                }
            }
            catch (Exception ex)
            {
                Vars.SystemSpeechAvailable = false;
                Vars.SpeechUnavailableString = ex.ToString();
            }
            UseGoogleGlobal = false;
            AllowDownloadMessage = true;
            AllowConnectEvents = true;
            ClearQueueAfterDisconnect = true;
            CatchGlobalError = true;
            SuperChatIgnoreRandomDitch = true;
            SaveCacheInTempDir = true;
            SuppressLogOutput = false;
            ClearCacheOnStartup = true;
            OverrideToLogsTabOnStartup = false;
            AutoStartOnLoad = false;
            SpeechPerson = 0;
            EnableVoiceReply = false;
            InstantVoiceReply = false;
            MinifyJson = true;
            SpeechPitch = 0;
            GiftsThrottle = true;
            GiftsThrottleDuration = 3;
            EnableUrlEncode = true;
            VoiceReplyFirst = false;
            IgnoreIfHitVoiceReply = false;
            DeviceGuid = DefaultDeviceGuid;
            AutoFallback = true;
            FullyAutomaticUpdate = true;
            HttpAuth = false;
            HttpAuthPassword = "";
            HttpAuthUsername = "";
            Headers = new List<Header>();
            ReqType = RequestType.JustGet;
            PostData = "";

            CustomEngineURL = "https://tts.example.com/?text=$TTSTEXT";
            OnConnected = "已成功连接至房间: $ROOM";
            OnDisconnected = "已断开连接: $ERROR";
            OnDanmaku = "$USER 说: $DM";
            OnGift = "收到来自 $USER 的 $COUNT 个 $GIFT";
            OnLiveStart = "直播已开始";
            OnLiveEnd = "直播已结束";
            OnInteractEnter = "欢迎 $USER 进入直播间";
            OnInteractShare = "感谢 $USER 分享直播间";
            VoiceReplyRules = new List<VoiceReplyRule>();
        }
    }
}
