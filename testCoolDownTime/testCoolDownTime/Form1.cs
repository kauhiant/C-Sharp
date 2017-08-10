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
        private CoolDownTime test;

        public Form1()
        {
            InitializeComponent();
            test = new CoolDownTime(2);

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
                    test.record();
                    break;
                case Keys.Down:
                    label1.Text = test.isCoolDown().ToString();
                    break;
                case Keys.Left:
                    label1.Text = test.isNotCoolDown().ToString();
                    me.move(-10);
                    break;
                case Keys.Right:
                    label1.Text = "null";
                    me.move(10);
                    break;
                case Keys.Space:
                    me.attack();
                    break;
                case Keys.W:
                    break;
                case Keys.A:
                    you.move(-10);
                    break;
                case Keys.S:
                    break;
                case Keys.D:
                    you.move(10);
                    break;
            }
        }
    }
}
