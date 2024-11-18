using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Xiangqi.ChessTable;

namespace Xiangqi
{
    public abstract class ChessItem
    {
            //INT SIDE : BLACK = 0  ;  RED = 1
            //INT TYPE
            public int img_locX {  get; set; }
            public int img_locY { get; set; }
            public int type { get; set; }
            public int side { get; set; }
            public Bitmap bitmap {  get; set; }
            public static Point IMG_TO_FORM(int img_locX, int img_locY)
            {
                Point temp=new Point();
                temp.X =(int)(253 + (8-img_locX) * 399 / 8 - 419 / 16);
                temp.Y = (int)(527 - (9-img_locY) * 449 / 9 - 469 / 18);
                return temp;
            }

        public int CheckAvailable(int y,int x)
        {
            if (x < 0 || y < 0 || x > 8 || y > 9)
            {
                return -1;
            }

            if (GameManager.GameBoard[y, x].type == -1)
            {
                return 0;
            }
            else if (GameManager.GameBoard[y, x].side == side)
            {
                return 1;
            }
            else if (GameManager.GameBoard[y, x].side != side)
            {
                return 2;
            }
            return -1;
        }
        public void Move(int x,int y)
        {
            if(CheckRule(x,y)== 1)
            {
                this.img_locX = x;
                this.img_locY = y;
            }    
            else
            {
                return;
            }    
        }
        public virtual int CheckKingMove()
        {
            GameManager.countBlack = 0;
            GameManager.countRed = 0;
            if (side == 1)
            {
                for (int i = 0; i < GameManager.KingBlack.Count; i++)
                {
                    var p = GameManager.KingBlack[i]; 
                    if (CheckRule(p.X, p.Y) == 1)
                    {
                        p.Z = 1; 
                        GameManager.KingBlack[i] = p;
                        GameManager.countBlack++;
                    }
                    else
                    {
                        p.Z = 0;
                        GameManager.KingBlack[i] = p;
                    }    
                }
            }
            if (side == 0)
            {
                for (int i = 0; i < GameManager.KingRed.Count; i++)
                {
                    var p = GameManager.KingRed[i];
                    if (CheckRule(p.X, p.Y) == 1)
                    {
                        p.Z = 1;
                        GameManager.KingRed[i] = p;
                        GameManager.countRed++;
                    }
                    else
                    {
                        p.Z = 0;
                        GameManager.KingRed[i] = p;
                    }
                }
            }
            return -1;

        }
        public void Paint(int type, int side, PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                Point temp = new Point();
                temp = IMG_TO_FORM(img_locX, img_locY);
                g.DrawImage(bitmap, temp.X, temp.Y, 50, 50);
            
            }
            public virtual int CheckRule(int x, int y)
            {
                return -1;
            }

            public int GetType() { return type; }
            public int GetSide() { return side; }
        public virtual int GetLoser()
        {
            return -1;
        }

    }
}
