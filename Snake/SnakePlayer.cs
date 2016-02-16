using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public enum Direction
    {
        left,
        right,
        up,
        down,
        none
    }

  
    class SnakePlayer
    {
        private List<BodyPart> m_SnakeParts = new List<BodyPart>();
        private const int m_CircleRadius = 20;
        private Direction m_MoveDirection = Direction.none;
        private int m_PendingSegments;
        private SnakeForm GameForm = null;
        public SnakePlayer(SnakeForm Form)
        {
            m_SnakeParts.Add(new BodyPart(100, 0, Direction.right));
            m_SnakeParts.Add(new BodyPart(80, 0, Direction.right));
            m_SnakeParts.Add(new BodyPart(60, 0, Direction.right));
            m_MoveDirection = Direction.right;
            m_PendingSegments = 0;
            GameForm = Form;
        }

        public void AddBodySegments(int Number)
        {
            m_PendingSegments += Number;
        }

        public void MovePlayer()
        {
            if(m_PendingSegments > 0)
            {
                Point LastPos = m_SnakeParts.Last().GetPosition();
                m_SnakeParts.Add(new BodyPart(LastPos.X,LastPos.Y));
                m_PendingSegments--;
            }

            m_SnakeParts[0].m_Dir = m_MoveDirection;
            for (int i = m_SnakeParts.Count-1; i>=0 ;i--)
            {
                switch (m_SnakeParts[i].m_Dir)
                {
                    case Direction.left:
                        m_SnakeParts[i].AddPosition(new Point(-20, 0));
                        break;
                    case Direction.right:
                        m_SnakeParts[i].AddPosition(new Point(20, 0));
                        break;
                    case Direction.down:
                        m_SnakeParts[i].AddPosition(new Point(0, 20));
                        break;
                    case Direction.up:
                        m_SnakeParts[i].AddPosition(new Point(0, -20));
                        break;
                    default:
                        break;
                }
                if (i > 0)
                        m_SnakeParts[i].m_Dir = m_SnakeParts[i - 1].m_Dir;
            }
            if (IsSelfIntersecting())
                OnHitSelf();
        }

        public bool IsSelfIntersecting()
        {
            for(int i=0;i < m_SnakeParts.Count;i++)
            {
                for (int j = 0;j < m_SnakeParts.Count; j++)
                {
                    if(i == j)
                        continue;
                    BodyPart part1 = m_SnakeParts[i];
                    BodyPart part2 = m_SnakeParts[j];
                    if ((new Rectangle(part1.GetPosition().X, part1.GetPosition().Y, m_CircleRadius, m_CircleRadius)).IntersectsWith(
                        new Rectangle(part2.GetPosition().X, part2.GetPosition().Y, m_CircleRadius, m_CircleRadius)))
                        return true;
                }
            }
            return false;
        }

        public void SetDirection(Direction Dir)
        {
            if (m_MoveDirection == Direction.left && Dir == Direction.right)
                return;

            if (m_MoveDirection == Direction.right && Dir == Direction.left)
                return;

            if (m_MoveDirection == Direction.up && Dir == Direction.down)
                return;

            if (m_MoveDirection == Direction.down && Dir == Direction.up)
                return;

            m_MoveDirection = Dir;
        }

        public bool IsIntersectingRect(Rectangle rect)
        {
            foreach(BodyPart Part in m_SnakeParts)
            {
                Point PartPos = Part.GetPosition();
                if (rect.IntersectsWith(new Rectangle(PartPos.X, PartPos.Y, m_CircleRadius, m_CircleRadius)))
                    return true;
            }
            return false;
        }

        public void OnHitWall(Direction WhichWall)
        {
            GameForm.ToggleTimer();
            MessageBox.Show("Hit Wall- GAME OVER");
            GameForm.ResetGame();
        }

        public void Draw(Graphics canvas)
        {
            Brush SnakeColor = Brushes.Black;
            List<Rectangle> Rects = GetRects();
            foreach(Rectangle Part in Rects)
            {
                canvas.FillEllipse(SnakeColor, Part);
            }
        }

        public void OnHitSelf()
        {
            GameForm.ToggleTimer();
            MessageBox.Show("Hit SELF- GAME OVER");
            GameForm.ResetGame();
        }

        public List<Rectangle> GetRects()
        {
            List<Rectangle> Rects = new List<Rectangle>();
            foreach (BodyPart Part in m_SnakeParts)
            {
                Point PartPos = Part.GetPosition();
                Rects.Add(new Rectangle(PartPos.X, PartPos.Y, m_CircleRadius, m_CircleRadius));
            }
            return Rects;
        } 
    }
}
