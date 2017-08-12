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
        //   private CoolDownTime cdTime;
        private double cdTime;//change to this
        private System.Windows.Forms.PictureBox myImg;

        //add this function
        public double getCdTime() { return cdTime; }

        public void setImage(ref System.Windows.Forms.PictureBox img)
        {
            myImg = img;
            myImg.BackgroundImage = Image.FromFile(@"./img/test01.png");
        }

        public void move(int distance)
        {
            /* if (cdTime.isNotCoolDown()) {
                 myImg.Left += distance;
                 cdTime.record();
             }*/

            myImg.Left += distance;
        }

        public Warrior(double cd) {
            //  cdTime = new CoolDownTime(cd);
            cdTime = cd;
        }


       /* public bool attack() {
           if (cdTime.isNotCoolDown())
            {
                cdTime.record();
                return true;
            }
            else
                return false;
        }*/
    }
}
