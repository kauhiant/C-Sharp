using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace testCoolDownTime
{
    class Warrior
    {
        private CoolDownTime cdTime;
        private System.Windows.Forms.PictureBox myImg;

        public void setImage(ref System.Windows.Forms.PictureBox img)
        {
            myImg = img;
            myImg.Image = Image.FromFile(@"./img/test01.png");
        }

        public void move(int distance)
        {
            if (cdTime.isNotCoolDown()) {
                myImg.Left += distance;
                cdTime.record();
            }
        }

        public Warrior(double cd) {
            cdTime = new CoolDownTime(cd);
        }
        public bool attack() {
            if (cdTime.isNotCoolDown())
            {
                cdTime.record();
                return true;
            }
            else
                return false;
        }
    }
}
