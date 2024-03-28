﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEditor
{
    public enum DataType
    {
        None,
        Image,
        Sound
    }

    internal class NodeData
    {
        public byte[] Data { get; set; }
        public DataType Type { get; set; }
    }
}
