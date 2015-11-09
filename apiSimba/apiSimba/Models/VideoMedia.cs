﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiSimba.Models
{
    public class VideoMedia
    {
        public string videoCodec { get; set; }
        public float videoBitRate { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public float frameRate { get; set; }
        public string audioCodec { get; set; }
        public string audioBitRate { get; set; }
        public int channels { get; set; }
        public float samplingRate { get; set; }
    }
}