﻿namespace VKD.DAL
{
    public class Audio
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
