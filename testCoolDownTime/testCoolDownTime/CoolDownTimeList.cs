using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace testCoolDownTime
{
    class CoolDownTimeList:System.Windows.Forms.Timer
    {
        public class WarriorAndDateTime{
            public Warrior warrior;
            public DateTime unCoolTime;
            public WarriorAndDateTime(Warrior warrior,DateTime unCoolTime)
            {
                this.warrior = warrior;
                this.unCoolTime = unCoolTime;
            }
        }
        public List<WarriorAndDateTime> unCoolTimeList;//***********

        public CoolDownTimeList(int interval)
        {
            this.Interval = interval;
            this.Enabled = true;

            unCoolTimeList = new List<WarriorAndDateTime>();

            //add function to Tick_event
            Tick += removeNotCoolDown;//why can write like this line
        }
        
        private void removeNotCoolDown(Object sender,EventArgs e)
        {
            unCoolTimeList.RemoveAll(X => X.unCoolTime <= DateTime.Now);
        }

        public void record(ref Warrior me,double myCdTime)
        {
            unCoolTimeList.Add(
                new WarriorAndDateTime( me , DateTime.Now.AddSeconds(myCdTime) ) 
            );
        }

        public bool isNotCoolDown(Warrior me)
        {
            //find me in unCoolTimeList
            int myIndex = unCoolTimeList.FindIndex(X => X.warrior == me);

            if(myIndex == -1)return true;//not find
            return unCoolTimeList.ElementAt(myIndex).unCoolTime <= DateTime.Now;
        }
    }
}
