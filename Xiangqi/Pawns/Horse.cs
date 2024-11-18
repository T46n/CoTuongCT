using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiangqi
{
    public class Horse : ChessItem
    {
        public Horse(int locX, int locY, int type, int side)
        {
            this.type = type;
            this.side = side;
            this.img_locX = locX;
            this.img_locY = locY;
            if (side == 0) bitmap = new Bitmap(Xiangqi.Properties.Resources.black_knight);
            else bitmap = new Bitmap(Xiangqi.Properties.Resources.red_knight);
        }
        public override int CheckRule(int x, int y)
        {
            int p;
            if (x - this.img_locX == 2 &&  y - this.img_locY == 1)
            {
                p = CheckAvailable(this.img_locX + 2, this.img_locY + 1);
                if (GameManager.GameBoard[img_locX + 1,img_locY ].side == -1
                   || GameManager.GameBoard[img_locX + 2, img_locY].side == -1)
                {
                    if (p == 0|| p == 2)
                    {
                        
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }    
                }
                else
                {
                    return 0;
                }
            }
            if (x - this.img_locX == 2 && y - this.img_locY == -1)
            {
                p = CheckAvailable(this.img_locX + 2, this.img_locY - 1);
                if (GameManager.GameBoard[img_locX + 1, img_locY].side == -1
                   || GameManager.GameBoard[img_locX + 2, img_locY].side == -1)
                {
                    if (p == 0 || p == 2)
                    {
                        
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            if (x - this.img_locX == -2 && y - this.img_locY == 1)
            {
                p = CheckAvailable(this.img_locX - 2, this.img_locY + 1);
                if (GameManager.GameBoard[img_locX - 1, img_locY].side == -1
                   || GameManager.GameBoard[img_locX - 2, img_locY].side == -1)
                {
                    if (p == 0 || p == 2)
                    {
                        
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            if (x - this.img_locX == 2 && y - this.img_locY == -1)
            {
                p = CheckAvailable(this.img_locX + 2, this.img_locY + 1);
                if (GameManager.GameBoard[img_locX + 1, img_locY].side == -1
                   || GameManager.GameBoard[img_locX + 2, img_locY].side == -1)
                {
                    if (p == 0 || p == 2)
                    {
                        
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            if (x - this.img_locX == -2 && y - this.img_locY == -1)
            {
                p = CheckAvailable(this.img_locX - 2, this.img_locY - 1);
                if (GameManager.GameBoard[img_locX - 1, img_locY].side == -1
                   || GameManager.GameBoard[img_locX - 2, img_locY].side == -1)
                {
                    if (p == 0 || p == 2)
                    {
                        
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            if (x - this.img_locX == 1 && y - this.img_locY == 2)
            {
                p = CheckAvailable(this.img_locX + 1, this.img_locY + 2);
                if (GameManager.GameBoard[img_locX , img_locY+1].side == -1
                   || GameManager.GameBoard[img_locX , img_locY+2].side == -1)
                {
                    if (p == 0 || p == 2)
                    {
                        
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            if (x - this.img_locX == 1 && y - this.img_locY == -2)
            {
                p = CheckAvailable(this.img_locX +1, this.img_locY - 2);
                if (GameManager.GameBoard[img_locX , img_locY-1].side == -1
                   || GameManager.GameBoard[img_locX , img_locY-2].side == -1)
                {
                    if (p == 0 || p == 2)
                    {
                        
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            if (x - this.img_locX == -1 && y - this.img_locY == 2)
            {
                p = CheckAvailable(this.img_locX - 1, this.img_locY + 2);
                if (GameManager.GameBoard[img_locX, img_locY + 1].side == -1
                   || GameManager.GameBoard[img_locX, img_locY + 2].side == -1)
                {
                    if (p == 0 || p == 2)
                    {
                        
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            if (x - this.img_locX == -1 && y - this.img_locY == -2)
            {
                p = CheckAvailable(this.img_locX - 1, this.img_locY - 2);
                if (GameManager.GameBoard[img_locX, img_locY - 1].side == -1
                   || GameManager.GameBoard[img_locX, img_locY - 2].side == -1)
                {
                    if (p == 0 || p == 2)
                    {
                        
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        

    }
}
