using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiangqi
{
    public class Soldier : ChessItem
    {
        public Soldier(int locX, int locY, int type, int side)
        {
            this.type = type;
            this.side = side;
            this.img_locX = locX;
            this.img_locY = locY;
            if (side == 0) bitmap = new Bitmap(Xiangqi.Properties.Resources.black_pawn);
            else bitmap = new Bitmap(Xiangqi.Properties.Resources.red_pawn);
        }
        public override int CheckRule(int x, int y)
        {
            if (type == 0)
            {
                if (y <= 4)
                {
                    if (x == img_locX && y - img_locY == 1)
                    {
                        {
                            int p = CheckAvailable(this.img_locX, this.img_locY + 1);
                            if (p == 0 || p == 2)
                            {
                                return 0;
                            }
                        }
                    }
                }
                else if(x> 4)
                {
                    if (x == img_locX && y - img_locY == 1)
                    {
                        {
                            int p = CheckAvailable(this.img_locX, this.img_locY + 1);
                            if (p == 0 || p == 2)
                            {
                                return 0;
                            }
                        }
                    }
                    if (x - img_locX == 1 && y - img_locY == 0)
                    {
                        {
                            int p = CheckAvailable(this.img_locX+1, this.img_locY );
                            if (p == 0 || p == 2)
                            {
                                return 0;
                            }
                        }

                    }
                    if (x - img_locX == -1 && y - img_locY == 0)
                    {
                        {
                            int p = CheckAvailable(this.img_locX - 1, this.img_locY);
                            if (p == 0 || p == 2)
                            {
                                return 0;
                            }
                        }
                    }
                }    
               
            }
            else if (type == 0)
            {
                if (y >= 5)
                {
                    if (x == img_locX && y - img_locY == -1)
                    {
                        {
                            int p = CheckAvailable(this.img_locX, this.img_locY - 1);
                            if (p == 0 || p == 2)
                            {
                                return 0;
                            }
                        }
                    }
                }
                else if (x < 5)
                {
                    if (x == img_locX && y - img_locY == -1)
                    {
                        {
                            int p = CheckAvailable(this.img_locX, this.img_locY - 1);
                            if (p == 0 || p == 2)
                            {
                                return 0;
                            }
                        }
                    }
                    if (x - img_locX == 1 && y - img_locY == 0)
                    {
                        {
                            int p = CheckAvailable(this.img_locX + 1, this.img_locY);
                            if (p == 0 || p == 2)
                            {
                                return 0;
                            }
                        }
                    }
                    if (x - img_locX == -1 && y - img_locY == 0)
                    {
                        {
                            int p = CheckAvailable(this.img_locX - 1, this.img_locY);
                            if (p == 0 || p == 2)
                            {
                                return 0;
                            }
                        }
                    }
                }

            }
            return 0;
        }
    }
}
