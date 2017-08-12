using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testCoolDownTime
{
    public partial class Form1 : Form
    {
        private CoolDownTimeList test;//test 
       

        public Form1()
        {
            InitializeComponent();
            test = new CoolDownTimeList(10);

            PictureBox tmpImg = new PictureBox();
            me.setImage(ref tmpImg);
            this.Controls.Add(tmpImg);

            PictureBox tmpImg2 = new PictureBox();
            you.setImage(ref tmpImg2);
            this.Controls.Add(tmpImg2);

        }
        
        private Warrior me = new Warrior(2);
        private Warrior you = new Warrior(1.5);

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.Up:
                    break;
                case Keys.Down:
                    break;
                case Keys.Left:
                    if (test.isNotCoolDown(me))
                    {
                        me.move(-10);
                        test.record(ref me, me.getCdTime());
                    }
                    
                    break;
                case Keys.Right:
                    if (test.isNotCoolDown(me))
                    {
                        me.move(10);
                        test.record(ref me, me.getCdTime());
                    }
                    break;
                case Keys.Space:
                    label1.Text = test.unCoolTimeList.Count.ToString();
                //    me.attack();
                    break;
                case Keys.W:
                    break;
                case Keys.A:
                    if (test.isNotCoolDown(you))
                    {
                        you.move(-10);
                        test.record(ref you, you.getCdTime());
                    }
                    break;
                case Keys.S:
                    break;
                case Keys.D:
                    if (test.isNotCoolDown(you))
                    {
                        you.move(10);
                        test.record(ref you, you.getCdTime());
                    }
                    break;
            }
        }
    }
}
