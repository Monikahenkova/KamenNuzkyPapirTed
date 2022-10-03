using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace KamenNuzkyPapirTed
{
    public class Hra
    {
        private Timer timer;
        public Hrac Hrac1 { get; }
        public Hrac Hrac2 { get; }

        public Hra(int money)
        {
            Hrac1 = new Hrac(money);
            Hrac2 = new Hrac(money);
            timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;
        }
        
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var p1 = Hrac1.GetState();
            var p2 = Hrac2.GetState();

            if(p1 != p2)
            {
               if (p1 == Hrac.PlayState.Kámen)
               {

               }
               else if (p2 == Hrac.PlayState.Nůžky)
               {

               }
               else
               {

               }     
            }
        }

    }
}
