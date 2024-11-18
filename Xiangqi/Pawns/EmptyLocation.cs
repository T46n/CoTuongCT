using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiangqi
{
    public class EmptyLocation:ChessItem
    {
        public EmptyLocation(int img_locX, int img_locY, int type, int side)
        {
            this.type = type;
            this.side = side;
            this.img_locX = img_locX;
            this.img_locY = img_locY;
            bitmap = new Bitmap(Xiangqi.Properties.Resources.empty_Item);
        }
    }
}
