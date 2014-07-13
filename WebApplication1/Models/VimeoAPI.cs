using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Privacy
    {
        public string view { get; set; }
        public string embed { get; set; }
        public bool download { get; set; }
        public bool add { get; set; }
        public string comments { get; set; }
    }

    public class Picture
    {
        public string type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string link { get; set; }
    }

    public class Stats
    {
        public int plays { get; set; }
        public int likes { get; set; }
        public int comments { get; set; }
    }

    public class Connections
    {
        public string credits { get; set; }
        public string likes { get; set; }
    }

    public class Watchlater
    {
        public bool added { get; set; }
        public object added_time { get; set; }
        public string uri { get; set; }
    }

    public class Interactions
    {
        public Watchlater watchlater { get; set; }
    }

    public class Metadata
    {
        public Connections connections { get; set; }
        public Interactions interactions { get; set; }
    }

    public class Buttons
    {
        public bool like { get; set; }
        public bool watchlater { get; set; }
        public bool share { get; set; }
        public bool embed { get; set; }
        public bool vote { get; set; }
        public bool hd { get; set; }
    }

    public class Logos
    {
        public bool vimeo { get; set; }
        public bool custom { get; set; }
        public bool sticky_custom { get; set; }
    }

    public class Settings
    {
        public Buttons buttons { get; set; }
        public Logos logos { get; set; }
        public string outro { get; set; }
        public string portrait { get; set; }
        public string title { get; set; }
        public string byline { get; set; }
        public bool badge { get; set; }
        public bool byline_badge { get; set; }
        public bool playbar { get; set; }
        public bool volume { get; set; }
        public bool fullscreen_button { get; set; }
        public bool scaling_button { get; set; }
        public bool autoplay { get; set; }
        public bool autopause { get; set; }
        public bool loop { get; set; }
        public string color { get; set; }
        public bool link { get; set; }
        public string custom_logo_url { get; set; }
        public string custom_logo_link_url { get; set; }
        public bool custom_logo_use_link { get; set; }
        public bool logo_width { get; set; }
        public bool logo_height { get; set; }
        public object color_original { get; set; }
    }

    public class EmbedPresets
    {
        public string uri { get; set; }
        public string name { get; set; }
        public Settings settings { get; set; }
    }

    public class Picture2
    {
        public string type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string link { get; set; }
    }

    public class Website
    {
        public string name { get; set; }
        public string link { get; set; }
        public object description { get; set; }
    }

    public class Connections2
    {
        public string activities { get; set; }
        public string albums { get; set; }
        public string channels { get; set; }
        public string feed { get; set; }
        public string followers { get; set; }
        public string following { get; set; }
        public string groups { get; set; }
        public string likes { get; set; }
        public string portfolios { get; set; }
        public string videos { get; set; }
        public string watchlater { get; set; }
        public string shared { get; set; }
    }

    public class Metadata2
    {
        public Connections2 connections { get; set; }
    }

    public class Stats2
    {
    }

    public class User
    {
        public string uri { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string location { get; set; }
        public string bio { get; set; }
        public string created_time { get; set; }
        public string account { get; set; }
        public List<Picture2> pictures { get; set; }
        public List<Website> websites { get; set; }
        public Metadata2 metadata { get; set; }
        public Stats2 stats { get; set; }
        public List<string> content_filter { get; set; }
    }

    public class File
    {
        public string quality { get; set; }
        public string type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string link { get; set; }
        public string link_secure { get; set; }
    }

    public class Download
    {
        public string quality { get; set; }
        public string type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string expires { get; set; }
        public string link { get; set; }
    }

    public class Video
    {
        public string uri { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public string link { get; set; }
        public int duration { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string created_time { get; set; }
        public string modified_time { get; set; }
        public List<string> content_rating { get; set; }
        public object license { get; set; }
        public Privacy privacy { get; set; }
        public List<Picture> pictures { get; set; }
        public List<object> tags { get; set; }
        public Stats stats { get; set; }
        public Metadata metadata { get; set; }
        public string review_link { get; set; }
        public EmbedPresets embed_presets { get; set; }
        public User user { get; set; }
        public List<File> files { get; set; }
        public List<Download> download { get; set; }
        public string status { get; set; }
    }
}