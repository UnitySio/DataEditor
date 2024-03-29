using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEditor
{
    public enum DataType
    {
        None,
        Group,
        Int,
        Float,
        String,
        Image,
        Sound
    }

    internal class NodeData
    {
        public byte[] Data { get; set; }
        public DataType Type { get; set; }
        public string Value { get; set; }
    }
}
