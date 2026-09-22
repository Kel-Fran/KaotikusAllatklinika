using System;

namespace KaotikusAllatklinika
{
    public class KiborgKutya : Kisallat
    {
        public const int AMIN = 0;
        public const int AMAX = 100;
        int m_AkkumlatorToltottseg;
        public int AkkumlatorToltottseg {get => m_AkkumlatorToltottseg; set => m_AkkumlatorToltottseg = Math.Clamp(value, AMIN, AMAX);}

        public KiborgKutya(string nev, int kor, int egeszsegSzint, int akku) : base(nev,kor,egeszsegSzint) {
            AkkumlatorToltottseg = akku;
        }

        public override void HangotAd() {
            if (AkkumlatorToltottseg > 10) {
                Console.WriteLine($"{Nev} BARK BARK BARK");
                AkkumlatorToltottseg -= 5;
            }
            else Console.WriteLine($"{Nev} out of juice");
        }
    }
}
