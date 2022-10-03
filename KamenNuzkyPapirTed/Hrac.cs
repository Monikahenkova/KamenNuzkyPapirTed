using System;
using System.Collections.Generic;
using System.Text;

namespace KamenNuzkyPapirTed
{
    public class Hrac
    {
        private Random random = new Random();
        public int Money { get; internal set; }

        public Hrac (int money)
        {
            Money = money;
        }
        public PlayState GetState()
        {
            int value = random.Next(0, 3);
            return (PlayState)value;
       
        }
        public enum PlayState
        {
            Kámen,
            Nůžky,
            Papír
        }

        public void Win()
        {
            Money++;
        }

        public void Lose()
        {
            Money--;
        }
    
    
    }

    



}
