using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiangqi
{
    public class General : ChessItem
    {
        public General(int locX, int locY, int type, int side)
        {
            this.type = type;
            this.side = side;
            this.img_locX = locX;
            this.img_locY = locY;
            if (side == 0) bitmap = new Bitmap(Xiangqi.Properties.Resources.black_king);
            else bitmap = new Bitmap(Xiangqi.Properties.Resources.red_king);
        }
        public override int CheckRule(int x, int y)
        {
            if(x <5)
            {
                if(x< 3 || x>5)
                {
                    return 0;
                }    
                if(y > 1 )
                {
                    return 0;
                }    
            }
            else if(x> 5)
            {
                if(x < 3 || x > 5)
                {
                    return 0;
                } 
                if(y< 8)
                {
                    return 0;
                }    
                    
            }
            if(x- img_locX == 1 && y == img_locY)
            {
                if (GameManager.KingBlack.Any(point => point.X == x && point.Y == y && point.Z == 1))
                {
                    return 0;
                }
                if(isOpposite(x,y)==0)
                {
                    return 0;
                }    
                if(CheckAvailable(x,y)==0 || CheckAvailable(x,y)==2)
                {
                    return 1;
                }    
            }
            if (x - img_locX == -1 && y == img_locY)
            {
                if (GameManager.KingBlack.Any(point => point.X == x && point.Y == y && point.Z == 1))
                {
                    return 0;
                }
                if (isOpposite(x, y) == 0)
                {
                    return 0;
                }
                if (CheckAvailable(x, y) == 0 || CheckAvailable(x, y) == 2)
                {
                    return 1;
                }
            }
            if (x - img_locX == 1 && y - img_locY == 1)
            {
                if (GameManager.KingBlack.Any(point => point.X == x && point.Y == y && point.Z == 1))
                {
                    return 0;
                }
                if (isOpposite(x, y) == 0)
                {
                    return 0;
                }
                if (CheckAvailable(x, y) == 0 || CheckAvailable(x, y) == 2)
                {
                    return 1;
                }
            }
            if (x - img_locX == 1 && y - img_locY == -1)
            {
                if (GameManager.KingBlack.Any(point => point.X == x && point.Y == y && point.Z == 1))
                {
                    return 0;
                }
                if (isOpposite(x, y) == 0)
                {
                    return 0;
                }
                if (CheckAvailable(x, y) == 0 || CheckAvailable(x, y) == 2)
                {
                    return 1;
                }
            }
            if (x - img_locX == -1 && y - img_locY == 1)
            {
                if (GameManager.KingBlack.Any(point => point.X == x && point.Y == y && point.Z == 1))
                {
                    return 0;
                }
                if (isOpposite(x, y) == 0)
                {
                    return 0;
                }
                if (CheckAvailable(x, y) == 0 || CheckAvailable(x, y) == 2)
                {
                    return 1;
                }
            }
            if (x - img_locX == -1 && y - img_locY == -1)
            {
                if (GameManager.KingBlack.Any(point => point.X == x && point.Y == y && point.Z == 1))
                {
                    return 0;
                }
                if (isOpposite(x, y) == 0)
                {
                    return 0;
                }
                if (CheckAvailable(x, y) == 0 || CheckAvailable(x, y) == 2)
                {
                    return 1;
                }
            }
            if (x - img_locX == 0 && y - img_locY == 1)
            {
                if (GameManager.KingBlack.Any(point => point.X == x && point.Y == y && point.Z == 1))
                {
                    return 0;
                }
                if (isOpposite(x, y) == 0)
                {
                    return 0;
                }
                if (CheckAvailable(x, y) == 0 || CheckAvailable(x, y) == 2)
                {
                    return 1;
                }
            }
            if (x - img_locX == 0 && y - img_locY == -1)
            {
                if (GameManager.KingBlack.Any(point => point.X == x && point.Y == y && point.Z == 1))
                {
                    return 0;
                }
                if (isOpposite(x, y) == 0)
                {
                    return 0;
                }
                if (CheckAvailable(x, y) == 0 || CheckAvailable(x, y) == 2)
                {
                    return 1;
                }
            }
            return -1;
        }
        public int isOpposite(int x, int y)
        {
            if (x >= 5)
            {
                for (int i = x - 1; i >= 0; i--)
                {
                    if (GameManager.GameBoard[i, y].type != 0) //có quân nhưng không phải vua
                    {
                        return 1;
                    }
                    else return 0; //có quân vua
                }
            }
            else
            {
                for (int i = x + 1; i <= 9; i++)
                {
                    if (GameManager.GameBoard[i, y].type != 0) //có quân nhưng không phải vua
                    {
                        return 1;
                    }
                    else return 0; //có quân vua
                }
            }
            return 1; //không có quân nào trên đường thẳng
        }
        public override int GetLoser()
        {
            if(type == 0)
            {
                if(GameManager.countBlack == 5 && ( img_locY == 0 || img_locY ==9 ))
                {
                    return 1;
                } 
                else if (GameManager.countBlack == 9 && img_locY >0)
                {
                    return 1;
                }
            }
            if (type == 1)
            {
                if (GameManager.countRed == 5 && (img_locY == 0 || img_locY == 9))
                {
                    return 1;
                }
                else if (GameManager.countRed == 9 && img_locY <9)
                {
                    return 1;
                }
            }
            return -1;// trả về 1 nếu không còn đường đi
        }
    }
}
