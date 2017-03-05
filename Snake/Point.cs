using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// An x-y coordinate pair representing a location point
    /// </summary>
    class Point
    {
        public int X
        {
            get;
            set;
        }
        public int Y
        {
            get;
            set;
        }

        /// <summary>
        /// Object constructor
        /// </summary>
        /// <param name="X">X coordinate of the point</param>
        /// <param name="Y">Y coordinate of the point</param>
        public Point(int X,int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
