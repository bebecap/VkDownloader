using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Xml;

namespace VK_SDK
{
    public class VKController
    {

        public int UserId = 0;
        public string AccessToken = "";
        public string GroupID = "";

        public VKController(int userId, string accessToken, string groupid)
        {
            this.UserId = userId;
            this.AccessToken = accessToken;
            this.GroupID = groupid;
        }
        public bool IsGroup()
        {
            NameValueCollection qs = new NameValueCollection();
            qs["gid"] = GroupID;
            try
            {
                var res = ExecuteCommand("groups.getById", qs);
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public List<Audio> ParseSongs(XmlDocument res)
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
        public List<Audio> SearchSongs(string query)
        {
            NameValueCollection qs = new NameValueCollection();
            qs["q"] = query;
            qs["auto_complete"] = "1";
            qs["sort"] = "2";
            qs["lyrics"] = "0";
            qs["count"] = "50";
            qs["offset"] = "0";
            var res = ExecuteCommand("audio.search", qs);
            return ParseSongs(res);
        }
        public List<Audio> GetSongs()
        {
            NameValueCollection qs = new NameValueCollection();
            if (UserId != 0)
                qs["uid"] = UserId.ToString();
            else
                qs["gid"] = GroupID;
            qs["count"] = "50";
            qs["offset"] = 0.ToString();
            var res = ExecuteCommand("audio.get", qs);
            return ParseSongs(res);
        }
        private XmlDocument ExecuteCommand(string name, NameValueCollection qs)
        {
            XmlDocument result = new XmlDocument();
            result.Load(String.Format("https://api.vk.com/method/{0}.xml?access_token={1}&{2}", name, this.AccessToken, String.Join("&", (from item in qs.AllKeys select item + "=" + qs[item]).ToArray())));
            if (result.SelectSingleNode("error") != null)
            {
                throw new Exception("Error. " + result.SelectSingleNode("error/error_msg"));
            }
            return result;
        }
    }
}
