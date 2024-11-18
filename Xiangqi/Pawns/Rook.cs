using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiangqi
{
    public class Rook:ChessItem
    {
        public Rook(int locX, int locY, int type, int side)
        {
            this.type = type;
            this.side = side;
            this.img_locX = locX;
            this.img_locY = locY;
            if (side == 0) bitmap = new Bitmap(Xiangqi.Properties.Resources.black_rook);
            else bitmap = new Bitmap(Xiangqi.Properties.Resources.red_rook);
        }
        public override int CheckRule(int x, int y)
        {
            if((x== img_locX && y!= img_locY) || (x!=img_locX && y ==img_locY))
            {
                if(x== img_locX)
                {
                    if(y>img_locY)
                    {
                        for(int i= img_locY;i<y;i++)
                        {
                            if (GameManager.GameBoard[x,i].side ==1)
                            {
                                return 0;
                            }    
                        }
                        if (CheckAvailable(x, y) == 0 )
                        {
                            
                            return 1;
                        }  
                        else
                        {
                            return 0;
                        }                               
                    }
                    if (y < img_locY)
                    {
                        for (int i = img_locY; i > y; i--)
                        {
                            if (GameManager.GameBoard[x, i].side == 1)
                            {
                                return 0;
                            }
                        }
                        if (CheckAvailable(x, y) == 0 || CheckAvailable(x, y) == 2)
                        {
                            
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                if (y == img_locY)
                {
                    if (x > img_locX)
                    {
                        for (int i = img_locX; i < x; i++)
                        {
                            if (GameManager.GameBoard[i, y].side == 1)
                            {
                                return 0;
                            }
                        }
                        if (CheckAvailable(x, y) == 0 || CheckAvailable(x, y) == 2)
                        {
                            
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    if (x < img_locX)
                    {
                        for (int i = img_locX; i > x; i--)
                        {
                            if (GameManager.GameBoard[i, y].side == 1)
                            {
                                return 0;
                            }
                        }
                        if (CheckAvailable(x, y) == 0 || CheckAvailable(x, y) == 2)
                        {
                            
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            return 0;
        }
        public int CheckAvailable(int x,int y)
        {
            return 1;
        }
    }
}
