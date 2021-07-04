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
        private List<FoodPellet> m_FoodPellets; // Collection of all food pellets actively in the game
        private const int CIRCLE_RADIUS = 20; // Determines food pellet size
        private int m_GameWidth; // Game window size in pixels to ensure the program draws within the screen
        private int m_GameHeight;

        /// <summary>
        /// Object constructor
        /// </summary>
        /// <param name="GameWidth">Pixel width of the game window</param>
        /// <param name="GameHeight">Pixel height of the game window</param>
        public FoodManager(int GameWidth,int GameHeight)
        {
            m_FoodPellets = new List<FoodPellet>(20);
            m_GameWidth = GameWidth;
            m_GameHeight = GameHeight;
        }

        /// <summary>
        /// Draws the food pellets
        /// </summary>
        /// <param name="canvas">Canvas object (game screen) to draw on</param>
        public void Draw(Graphics canvas)
        {
            // Iterate over all food pellets and draw them
            Brush SnakeColor = Brushes.BlueViolet;
            foreach (FoodPellet pellet in m_FoodPellets)
            {
                Point PartPos = pellet.GetPosition();
                canvas.FillEllipse(SnakeColor, new Rectangle(PartPos.X+(CIRCLE_RADIUS / 4), PartPos.Y + (CIRCLE_RADIUS / 4), CIRCLE_RADIUS/2, CIRCLE_RADIUS/2));
            }
        }

        /// <summary>
        /// Adds a food pellet to the game
        /// </summary>
        public void AddRandomFood()
        {
            int X = r.Next(m_GameWidth - CIRCLE_RADIUS); // Random x/y positions
            int Y = r.Next(m_GameHeight - CIRCLE_RADIUS);
            int ix = (X / CIRCLE_RADIUS); //Use truncating to snap to grid
            int iy = Y / CIRCLE_RADIUS;
            X = ix * CIRCLE_RADIUS; // Grid x/y positions
            Y = iy * CIRCLE_RADIUS;
            m_FoodPellets.Add(new FoodPellet(X, Y)); // Save pellet object
        }

        /// <summary>
        /// Override to add food in quantities
        /// </summary>
        /// <param name="Amount">Amount of food to add</param>
        public void AddRandomFood(int Amount)
        {
            for(int i = 0; i < Amount; i++)
            {
                AddRandomFood();
            }
        }

        /// <summary>
        /// Determines whether the given rectangle intersects with any existing food pellets
        /// </summary>
        /// <param name="rect">The rectangle to check for collision with food pellets</param>
        /// <param name="removeFood">Whether to remove the food pellets intersecting with the rectangle</param>
        /// <returns>Whether there was an intersection</returns>
        public bool IsIntersectingRect(Rectangle rect, bool removeFood)
        {
            foreach (FoodPellet Pellet in m_FoodPellets) // Check each food pellet
            {
                Point PartPos = Pellet.GetPosition();

                // Check rectangle intersection with food pellet
                if (rect.IntersectsWith(new Rectangle(PartPos.X, PartPos.Y, CIRCLE_RADIUS, CIRCLE_RADIUS)))
                {
                    if (removeFood) // Remove food pellet if RemoveFood parameter is true
                    { 
                        m_FoodPellets.Remove(Pellet);
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
