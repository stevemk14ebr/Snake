using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// Represents a graphical unit of the game
    /// </summary>
    class GamePart
    {
        private Point Position;

        /// <summary>
        /// Gets the position of the point
        /// </summary>
        /// <returns>Position of the point</returns>
        public Point GetPosition()
        {
            return Position;
        }

        /// <summary>
        /// Moves the game part by adding the current position with the point's position
        /// </summary>
        /// <param name="point">Point to add</param>
        public void AddPosition(Point point)
        {
   
            Position.X += point.X;
            Position.Y += point.Y;
        }

        /// <summary>
        /// Sets the position of the part
        /// </summary>
        /// <param name="point">Point to set</param>
        public void SetPosition(Point point)
        {
    
            Position = point;
        }

        /// <summary>
        /// Object constructor
        /// </summary>
        /// <param name="X">X coordinate of the part</param>
        /// <param name="Y">Y coordinate of the part</param>
        public GamePart(int X,int Y)
        {
            Position = new Point(X,Y);
        }
    }
}
