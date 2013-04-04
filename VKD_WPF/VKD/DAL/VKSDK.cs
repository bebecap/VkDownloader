using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Xml;

namespace VKD.DAL
{
    class VKSDK
    {
        private int UserID = 0;
        private string AccessToken = "";

        public void SetUserData(int userid, string token)
        {
            this.AccessToken = token;
            this.UserID = userid;
        }
        public IEnumerable<Audio> ParseSongs(XmlDocument res)
        {
            var audio = res.SelectNodes("/response/audio");
            List<Audio> audios = new List<Audio>();
            for (int i = 0; i < audio.Count; i++)
            {
                var elems = audio[i].ChildNodes;
                string artist = "";
                string title = "";
                string url = "";
                for (int j = 0; j < elems.Count; j++)
                {
                    var elem = elems[j];
                    if (elem.Name == "artist") artist = elem.FirstChild.Value;
                    if (elem.Name == "title") title = elem.FirstChild.Value;
                    if (elem.Name == "url")//Clear this thread))
                        url = elem.FirstChild.Value.Replace("vkontakte.ru","vk.com");
                }
                audios.Add(new Audio() { Name = String.Format("{0} - {1}", artist, title), URL = url });
            }
            return audios;
        }

        public IEnumerable<Audio> GetSongs(int offset)
        {
            NameValueCollection qs = new NameValueCollection();
            qs["uid"] = UserID.ToString();
            qs["count"] = ConfigurationSettings.AppSettings["NodeCount"].ToString();
            qs["offset"] = offset.ToString();
            var res = ExecuteCommand("audio.get", qs);
            return ParseSongs(res);
        }
        private XmlDocument ExecuteCommand(string name, NameValueCollection qs)
        {
            XmlDocument result = new XmlDocument();
            result.Load(String.Format("{0}{1}.xml?access_token={2}&{3}",ConfigurationSettings.AppSettings["MethodURL"], name, this.AccessToken, String.Join("&", (from item in qs.AllKeys select item + "=" + qs[item]).ToArray())));
            if (result.SelectSingleNode("error") != null)
            {
                throw new Exception("Error. " + result.SelectSingleNode("error/error_msg"));
            }
            return result;
        }
    }
}
