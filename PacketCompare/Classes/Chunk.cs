using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketCompare.Classes
{
    class Chunk
    {
        private string _value;
        private int _index;

        public string value
        {
            get { return _value; }
            set { _value = value; }
        }

        public int index
        {
            get { return _index; }
            set { _index = value; }
        }

        public Chunk(string value, int index)
        {
            _value = value;
            _index = index;
        }
        
        /// <summary>
        /// Compares the string values of two chunks
        /// </summary>
        /// <param name="comparisonChunk">Chunk to be compared</param>
        /// <returns>True if string values are identical</returns>
        public bool compareChunk(Chunk comparisonChunk)
        {
            bool sameStr = false;
            if (_value.Equals(comparisonChunk.value))
                sameStr = true;
            return sameStr;
        }
    }
}
