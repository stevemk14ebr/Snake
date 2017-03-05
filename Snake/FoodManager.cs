using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    /// <summary>
    /// Manages food pellets, including spawning, destruction, and collision detection
    /// </summary>
    class FoodManager
    {
        private Random r = new Random(); // Used for generating random variables in this class
        private List<FoodPellet> m_FoodPellets = new List<FoodPellet>(); // Collection of all food pellets actively in the game
        private const int m_CircleRadius = 20; // Determines food pellet size
        private int m_GameWidth; // Game window size in pixels to ensure the program draws within the screen
        private int m_GameHeight;

        /// <summary>
        /// Object constructor
        /// </summary>
        /// <param name="GameWidth">Pixel width of the game window</param>
        /// <param name="GameHeight">Pixel height of the game window</param>
        public FoodManager(int GameWidth,int GameHeight)
        {
            m_GameWidth = GameWidth;
            m_GameHeight = GameHeight;
        }

        /// <summary>
        /// Draws the food pellets
        /// </summary>
        /// <param name="Canvas">Canvas object (game screen) to draw on</param>
        public void Draw(Graphics Canvas)
        {
            // Iterate over all food pellets and draw them
            Brush SnakeColor = Brushes.BlueViolet;
            foreach (FoodPellet Pellet in m_FoodPellets)
            {
                Point PartPos = Pellet.GetPosition();
                Canvas.FillEllipse(SnakeColor, new Rectangle(PartPos.X+(m_CircleRadius / 4), PartPos.Y+ (m_CircleRadius / 4), m_CircleRadius/2, m_CircleRadius/2));
            }
        }

        /// <summary>
        /// Adds a food pellet to the game
        /// </summary>
        public void AddRandomFood()
        {
            int X = r.Next(m_GameWidth - m_CircleRadius); // Random x/y positions
            int Y = r.Next(m_GameHeight - m_CircleRadius);
            int ix = (X / m_CircleRadius); //Use truncating to snap to grid
            int iy = Y / m_CircleRadius;
            X = ix * m_CircleRadius; // Grid x/y positions
            Y = iy * m_CircleRadius;
            m_FoodPellets.Add(new FoodPellet(X, Y)); // Save pellet object
        }

        /// <summary>
        /// Override to add food in quantities
        /// </summary>
        /// <param name="Amount">Amount of food to add</param>
        public void AddRandomFood(int Amount)
        {
            for(int i=0;i<Amount;i++)
            {
                AddRandomFood();
            }
        }

        /// <summary>
        /// Determines whether the given rectangle intersects with any existing food pellets
        /// </summary>
        /// <param name="rect">The rectangle to check for collision with food pellets</param>
        /// <param name="RemoveFood">Whether to remove the food pellets intersecting with the rectangle</param>
        /// <returns>Whether there was an intersection</returns>
        public bool IsIntersectingRect(Rectangle rect, bool RemoveFood)
        {
            foreach (FoodPellet Pellet in m_FoodPellets) // Check each food pellet
            {
                Point PartPos = Pellet.GetPosition();

                // Check rectangle intersection with food pellet
                if (rect.IntersectsWith(new Rectangle(PartPos.X, PartPos.Y, m_CircleRadius, m_CircleRadius)))
                {
                    if (RemoveFood) // Remove food pellet if RemoveFood parameter is true
                        m_FoodPellets.Remove(Pellet);
                    return true;
                }
            }
            return false;
        }
    }
}
