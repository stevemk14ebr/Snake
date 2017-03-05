using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Snake
{
    /// <summary>
    /// Represents a snake body part, Derived from GamePart
    /// </summary>
    class BodyPart : GamePart
    {
        public Direction m_Dir
        {
            get;
            set;
        }

        /// <summary>
        /// Object constructor
        /// </summary>
        /// <param name="X">X coordinate of the body part</param>
        /// <param name="Y">Y coordinate of the body part</param>
        /// <param name="Dir">Direction the body part is travelling</param>
        public BodyPart(int X,int Y,Direction Dir) : base(X,Y)
        {
            m_Dir = Dir;
        }
        /// <summary>
        /// Object constructor that sets direction to none by default
        /// </summary>
        /// <param name="X">X coordinate of the body part</param>
        /// <param name="Y">Y coordinate of the body part</param>
        public BodyPart(int X, int Y):base(X,Y)
        {
            m_Dir = Direction.none;
        }
    }
}
