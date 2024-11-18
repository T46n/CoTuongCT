using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiangqi
{
    public class Advisor:ChessItem
    {
        public Advisor(int locX, int locY, int type, int side)
        {
            this.type = type;
            this.side = side;
            this.img_locX = locX;
            this.img_locY = locY;
            if (side == 0) bitmap = new Bitmap(Xiangqi.Properties.Resources.black_advisor);
            else bitmap = new Bitmap(Xiangqi.Properties.Resources.red_advisor);
        }
        public override int CheckRule(int x, int y)
        {
            if (x < 5)
            {
                if (x < 3 || x > 5)
                {
                    return 0;
                }
                if (y > 1)
                {
                    return 0;
                }
            }
            else if (x > 5)
            {
                if (x < 3 || x > 5)
                {
                    return 0;
                }
                if (y < 8)
                {
                    return 0;
                }

            }
            if (x - img_locX == 1 && y - img_locY == 1)
            {
                int p = CheckAvailable(this.img_locX +1, this.img_locY + 1);
                if(p ==0 || p ==2)
                {
                    return 0;
                }

            }
            if (x - img_locX == 1 && y - img_locY == -1)
            {
                int p = CheckAvailable(this.img_locX + 1, this.img_locY - 1);
                if (p == 0 || p == 2)
                {
                    return 0;
                }
            }
            if (x - img_locX == -1 && y - img_locY == 1)
            {
                int p = CheckAvailable(this.img_locX - 1, this.img_locY + 1);
                if (p == 0 || p == 2)
                {
                    return 0;
                }
            }
            if (x - img_locX == -1 && y - img_locY == -1)
            {
                int p = CheckAvailable(this.img_locX - 1, this.img_locY - 1);
                if (p == 0 || p == 2)
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}
