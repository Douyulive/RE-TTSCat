﻿using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace Re_TTSCat
{
    public partial class KruinUpdates
    {
        public partial class Update
        {
            public static async Task<Update> GetLatestUpdAsync()
            {
                string gottenResult;
                gottenResult = await HttpGet(new Uri("https://www.dydmj.org/api/v2/Re-TTSCat"));
                var jsonObj = JObject.Parse(gottenResult);
                var latestVer = new Version(jsonObj["version"].ToString());
                var updDesc = jsonObj["update_desc"].ToString();
                var updTime = DateTimeOffset.Parse(jsonObj["update_datetime"].ToString(), null).DateTime;
                var dlLink = jsonObj["dl_url"].ToString();
                return new Update(latestVer, updTime, updDesc, dlLink);
            }
        }
    }
}
