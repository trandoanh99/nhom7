using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro
{
    public class ThongTin
    {
        private Point point;

        public Point Point
        {
            get { return point; }
            set { point = value;}
        }

        private int nguoidangchoi;
        public int Nguoidangchoi
        {
            get { return nguoidangchoi; }
            set { nguoidangchoi = value; }
        }

        public ThongTin(Point point,int nguoidangchoi)
        {
            this.Point = point;
            this.Nguoidangchoi = nguoidangchoi;
        }
    }
}
