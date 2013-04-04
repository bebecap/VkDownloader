using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VKD.DAL;

namespace VKD.BL
{
    public class Library
    {
        public IEnumerable<Artist> Artists;
        private IStorage _storage;
        private VKSDK _vk;
        public Library()
        {
            _storage = new XMLStorage();
            Artists = _storage.Load();
            _vk = new VKSDK();
        }
        public void SetAccountData(int userId, string accessToken)
        {
            _vk.SetUserData(userId, accessToken);
        }
        public IEnumerable<Audio> LoadSongListFromVK(int offset)
        {
            return _vk.GetSongs(offset);
        }
        public bool LoadSongsToLibrary(IEnumerable<Audio> songs)
        {
            return true;
        }
    }
}
