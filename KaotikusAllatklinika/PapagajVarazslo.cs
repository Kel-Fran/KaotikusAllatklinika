using System;

namespace KaotikusAllatklinika
{
    public class PapagajVarazslo : Kisallat
    {

        public const int MMIN = 0;
        public const int MMAX = 50;
        int m_ManaSzint;
        public int ManaSzint {get => m_ManaSzint; set => m_ManaSzint = Math.Clamp(value, MMIN, MMAX);}

        public PapagajVarazslo(string nev, int kor, int egeszsegSzint, int mana) : base(nev,kor,egeszsegSzint) {
            ManaSzint = mana;
        }

        public override void HangotAd() {
            if (ManaSzint >=  10) {
                Console.WriteLine($"{Nev} used fireball");
                ManaSzint-=10;
            } else Console.WriteLine($"{Nev} OOM (out of mana, not memory)");
        }

        public void VarázsolGyogyitas() {
            if (ManaSzint >= 15) {
                EgeszsegSzint += 20;
                ManaSzint -= 15;
            }
        }
    }
}
