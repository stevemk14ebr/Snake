using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    /// <summary>
    /// Directional representation of player
    /// </summary>
    public enum Direction
    {
        Left,
        Right,
        Up,
        Down,
        None
    }

    /// <summary>
    /// Class containing the controller logic for the player
    /// </summary>
    class SnakePlayer
    {
        private List<BodyPart> m_SnakeParts = new List<BodyPart>(); // Collection of current snake body parts
        private const int m_CircleRadius = 20; // Determines body part size
        private Direction m_MoveDirection = Direction.None; // Direction of the head
        private int m_PendingSegments; // Number of body parts in queue to be added to the snake
        private readonly Snake GameForm = null; // Stores the GUI form

        /// <summary>
        /// Object constructor
        /// </summary>
        /// <param name="Form">GUI form for the game</param>
        public SnakePlayer(Snake Form)
        {
            const int START_SNAKE_BODYPART_COUNT = 5;
            // Add 3 body parts to the snake because the snake begins small
            for (int i = 0; i < START_SNAKE_BODYPART_COUNT; i++)
            {
                m_SnakeParts.Add(new BodyPart(100 - i * 20, 200, Direction.Right));
            }

            // Need to give an initial direction
            m_MoveDirection = Direction.Right;

            // Currently no body parts queued to be added
            m_PendingSegments = 0;
            GameForm = Form;
        }

        /// <summary>
        /// Adds snake body parts
        /// </summary>
        /// <param name="Number">Number of body parts to add</param>
        public void AddBodySegments(int Number)
        {
            // Increments m_PendingSegments as it will be processed and the parts added in the next call to MovePlayer()
            m_PendingSegments += Number;
        }

        /// <summary>
        /// Moves the snake and processes any pending body segments to be created. Called every frame.
        /// </summary>
        public void MovePlayer()
        {
            // Adds any pending body parts. Note that this processes one body part at a time;
            // if m_PendingSegments > 0, it will require more than one frame to process completely.
            if (m_PendingSegments > 0)
            {
                Point LastPos = m_SnakeParts[m_SnakeParts.Count - 1].GetPosition(); // Adds the body part to the tail
                m_SnakeParts.Add(new BodyPart(LastPos.X, LastPos.Y));
                m_PendingSegments--;
            }

            m_SnakeParts[0].m_Dir = m_MoveDirection; // Set the head direction

            // Moves each snake body part
            for (int i = m_SnakeParts.Count - 1; i >= 0; i--)
            {
                // Translates the body part in accordance with its direction
                switch (m_SnakeParts[i].m_Dir)
                {
                    case Direction.Left:
                        m_SnakeParts[i].AddPosition(new Point(-20, 0));
                        break;
                    case Direction.Right:
                        m_SnakeParts[i].AddPosition(new Point(20, 0));
                        break;
                    case Direction.Down:
                        m_SnakeParts[i].AddPosition(new Point(0, 20));
                        break;
                    case Direction.Up:
                        m_SnakeParts[i].AddPosition(new Point(0, -20));
                        break;
                    default:
                        break;
                }

                // Set the direction of the next part to be the direction of the previous
                // for snake-like movement
                if (i > 0)
                    m_SnakeParts[i].m_Dir = m_SnakeParts[i - 1].m_Dir;
            }
            if (IsSelfIntersecting()) // Check for collisions with itself
                OnHitSelf(); // If so, trigger the game-over screen
        }

        /// <summary>
        /// Determines whether the snake is intersecting with itself
        /// </summary>
        /// <returns>Whether the snake is intersecting with itself</returns>
        public bool IsSelfIntersecting()
        {
            // Check each snake body part with every other snake body part
            for (int i = 0; i < m_SnakeParts.Count; i++)
            {
                for (int j = i + 1; j < m_SnakeParts.Count; j++)
                {
                    BodyPart part1 = m_SnakeParts[i];
                    BodyPart part2 = m_SnakeParts[j];

                    // Collision check logic
                    if ((new Rectangle(part1.GetPosition().X, part1.GetPosition().Y, m_CircleRadius, m_CircleRadius)).IntersectsWith(
                        new Rectangle(part2.GetPosition().X, part2.GetPosition().Y, m_CircleRadius, m_CircleRadius)))
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sets the direction of the snake head
        /// </summary>
        /// <param name="direction">Direction to set the head to</param>
        public void SetDirection(Direction direction)
        {
            // Forbid 180 degree turns
            if (m_MoveDirection == Direction.Left && direction == Direction.Right)
                return;

            if (m_MoveDirection == Direction.Right && direction == Direction.Left)
                return;

            if (m_MoveDirection == Direction.Up && direction == Direction.Down)
                return;

            if (m_MoveDirection == Direction.Down && direction == Direction.Up)
                return;

            // Set the direction if the direction change is legal
            m_MoveDirection = direction;
        }

        /// <summary>
        /// Determines whether any body part is intersecting with the given rectangle
        /// </summary>
        /// <param name="rect">The rectangle to check intsections with</param>
        /// <returns>Whether there was an intersection</returns>
        public bool IsIntersectingRect(Rectangle rect)
        {
            foreach (BodyPart Part in m_SnakeParts) // Check each snake body part
            {
                Point PartPos = Part.GetPosition();

                // Check rectangle intersection with body part
                if (rect.IntersectsWith(new Rectangle(PartPos.X, PartPos.Y, m_CircleRadius, m_CircleRadius)))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Displays the game-over screen in the case that the player hits the wall
        /// </summary>
        /// <param name="WhichWall">The direction of the wall that the player hit</param>
        public void OnHitWall(Direction WhichWall)
        {
            GameForm.ToggleTimer(); // No timer visible on game-over screen
            //MessageBox.Show("Hit Wall- GAME OVER"); // Display game-over message
            GameForm.ResetGame();
        }

        /// <summary>
        /// Called per frame to render the snake body parts
        /// </summary>
        /// <param name="canvas">The graphics object to render on</param>
        public void Draw(Graphics canvas)
        {
            Random _rand = new Random();
            SolidBrush SnakeColor = new SolidBrush(Color.FromArgb(_rand.Next(100, 256), 0, 0));
            List<Rectangle> Rects = GetRects(); // Get the snake body parts, represented as rectangles
            foreach (Rectangle Part in Rects) // Draw each snake body part
            {
                canvas.FillEllipse(SnakeColor, Part); // Draw the snake parts as ellipses
            }
        }

        /// <summary>
        /// Displays the game-over screen in the case that the player hits themself
        /// </summary>
        public void OnHitSelf()
        {
            GameForm.ToggleTimer(); // No timer visible on game-over screen
            //MessageBox.Show("Hit SELF- GAME OVER"); // Display game-over message
            GameForm.ResetGame();
        }

        /// <summary>
        /// Gets the snake body parts, represented as rectangles
        /// </summary>
        /// <returns>A list of snake body parts represented as rectangles</returns>
        public List<Rectangle> GetRects()
        {
            List<Rectangle> Rects = new List<Rectangle>();
            foreach (BodyPart Part in m_SnakeParts) // Return all body parts
            {
                Point PartPos = Part.GetPosition();

                // Every iteration, add a rectangle to the ongoing list representing the body part
                Rects.Add(new Rectangle(PartPos.X, PartPos.Y, m_CircleRadius, m_CircleRadius));
            }
            return Rects;
        }
    }
}
