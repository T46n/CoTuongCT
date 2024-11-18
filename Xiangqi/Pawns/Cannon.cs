using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiangqi
{
    public class Cannon : ChessItem
    {
        public Cannon(int locX, int locY, int type, int side)
        {
            this.type = type;
            this.side = side;
            this.img_locX = locX;
            this.img_locY = locY;
            if (side == 0) bitmap = new Bitmap(Xiangqi.Properties.Resources.black_cannon);
            else bitmap = new Bitmap(Xiangqi.Properties.Resources.red_cannon);
        }
        public override int CheckRule(int x, int y)
        {
            int p=-1;
            if ((x == img_locX && y != img_locY) || (x != img_locX && y == img_locY))
            {
                if (x == img_locX)
                {
                    if (y > img_locY)
                    {
                        for (int i = img_locY; i < y; i++)
                        {
                            if (GameManager.GameBoard[x, i].side == 1)
                            {
                                p = 0;
                            }
                        }
                        if (CheckAvailable(x, y) == 0)
                        {
                            
                            return 1;
                        }
                        else
                        {
                            p= 0;
                        }
                    }
                    if (y < img_locY)
                    {
                        for (int i = img_locY; i > y; i--)
                        {
                            if (GameManager.GameBoard[x, i].side == 1)
                            {
                                p= 0;
                            }
                        }
                        if (CheckAvailable(x, y) == 0)
                        {
                            
                            return 1;
                        }
                        else
                        {
                            p= 0;
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
                                p= 0;
                            }
                        }
                        if (CheckAvailable(x, y) == 0)
                        {
                            
                            return 1;
                        }
                        else
                        {
                            p = 0;
                        }
                    }
                    if (x < img_locX)
                    {
                        for (int i = img_locX; i > x; i--)
                        {
                            if (GameManager.GameBoard[i, y].side == 1)
                            {
                                p= 0;
                            }
                        }
                        if (CheckAvailable(x, y) == 0)
                        {
                            
                            return 1;
                        }
                        else
                        {
                            p= 0;
                        }
                    }
                }
            }
            if ((x == img_locX && y != img_locY) || (x != img_locX && y == img_locY))
            {
                int count = 0;
                if (x == img_locX)
                {
                    if(CheckAvailable(x,y) == 2)
                    {
                        if (y > img_locY)
                        {
                            for (int i = img_locY; i < y; i++)
                            {
                                if (CheckAvailable(x,i) == 2 )        
                                {
                                    count++;
                                }
                            }   
                            if(count!=1)
                            {
                                p = 0;
                            }
                            else
                            {
                                img_locX = x;
                                img_locY = y;
                                return 1;
                            }
                        }
                        if (y < img_locY)
                        {
                            for (int i = img_locY; i > y; i--)
                            {
                                if (CheckAvailable(x, i) == 2)
                                {
                                    count++;
                                }
                            }
                            if (count != 1)
                            {
                                p = 0;
                            }
                            else
                            {
                                
                                return 1;
                            }
                        }
                    }    
                }
                if (y == img_locY)
                {
                    if (CheckAvailable(x, y) == 2)
                    {
                        if (x > img_locX)
                        {
                            for (int i = img_locX; i < x; i++)
                            {
                                if (CheckAvailable(x, i) == 2)
                                {
                                    count++;
                                }
                            }
                            if (count != 1)
                            {
                                p = 0;
                            }
                            else
                            {
                                
                                return 1;
                            }
                        }
                        if (x < img_locX)
                        {
                            for (int i = img_locX; i > x; i--)
                            {
                                if (CheckAvailable(x, i) == 2)
                                {
                                    count++;
                                }
                            }
                            if (count != 1)
                            {
                                p = 0;
                            }
                            else
                            {
                               
                                return 1;
                            }
                        }
                    }
                }
            }
            return p;
        }
    }
}
