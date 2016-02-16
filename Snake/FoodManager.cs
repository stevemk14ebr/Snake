using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class FoodManager
    {
        private Random r = new Random();
        private List<FoodPellet> m_FoodPellets = new List<FoodPellet>();
        private const int m_CircleRadius = 20;
        private int m_GameWidth;
        private int m_GameHeight;
        public FoodManager(int GameWidth,int GameHeight)
        {
            m_GameWidth = GameWidth;
            m_GameHeight = GameHeight;
        }
        public void Draw(Graphics Canvas)
        {
            Brush SnakeColor = Brushes.BlueViolet;
            foreach (FoodPellet Pellet in m_FoodPellets)
            {
                Point PartPos = Pellet.GetPosition();
                Canvas.FillEllipse(SnakeColor, new Rectangle(PartPos.X+(m_CircleRadius / 4), PartPos.Y+ (m_CircleRadius / 4), m_CircleRadius/2, m_CircleRadius/2));
            }
        }
        public void AddRandomFood()
        {
            int X = r.Next(m_GameWidth - m_CircleRadius);
            int Y = r.Next(m_GameHeight - m_CircleRadius);
            int ix = (X / m_CircleRadius); //Use truncating to snap to grid
            int iy = Y / m_CircleRadius;
            X = ix * m_CircleRadius;
            Y = iy * m_CircleRadius;
            m_FoodPellets.Add(new FoodPellet(X, Y));
        }
        public void AddRandomFood(int Amount)
        {
            for(int i=0;i<Amount;i++)
            {
                int X = r.Next(m_GameWidth - m_CircleRadius);
                int Y = r.Next(m_GameHeight - m_CircleRadius);
                int ix = X / m_CircleRadius; //Use truncating to snap to grid
                int iy = Y / m_CircleRadius;
                X = ix * m_CircleRadius;
                Y = iy * m_CircleRadius;
                m_FoodPellets.Add(new FoodPellet(X, Y));
            }
        }
        public bool IsIntersectingRect(Rectangle rect, bool RemoveFood)
        {
            foreach (FoodPellet Pellet in m_FoodPellets)
            {
                Point PartPos = Pellet.GetPosition();
                if (rect.IntersectsWith(new Rectangle(PartPos.X, PartPos.Y, m_CircleRadius, m_CircleRadius)))
                {
                    if (RemoveFood)
                        m_FoodPellets.Remove(Pellet);
                    return true;
                }
            }
            return false;
        }
    }
}
