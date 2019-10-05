﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace MArchiveBatchTool.Psb
{
    public class JStream : JValue
    {
        public byte[] BinaryData { get; set; }
        public uint Index { get; private set; }
        public bool IsBStream { get; private set; }

        public JStream(uint index, bool isBStream) : base(string.Empty)
        {
            Value = string.Format("_{0}stream:{1}", IsBStream ? "b" : "", index);
        }
    }
}
