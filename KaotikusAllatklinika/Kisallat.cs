using System;

namespace KaotikusAllatklinika
{
    public class Kisallat
    {
        public const string DNAME = "Névtelen Páciens";
        public const int KMIN = 0;
        public const int KMAX = 30;
        public const int HMIN = 0;
        public const int HMAX = 100;
        public const int AMIN = 0;
        public const int AMAX = 100;
        public const int DTRESH = 80;
        public const int DA = 20;

        private string m_Nev = DNAME;
        public string Nev {get => m_Nev ; set => m_Nev  = String.IsNullOrEmpty(value) ? DNAME : value;}
        private int m_Kor;
        public int Kor{get => m_Kor; set => m_Kor = Math.Clamp(value, KMIN, KMAX);}
        private int m_EgeszsegSzint;
        public int EgeszsegSzint{get => m_EgeszsegSzint; set => m_EgeszsegSzint = Math.Clamp(value, HMIN, HMAX);}
        private int m_AggodalomSzint;
        public int AggodalomSzint{get => m_AggodalomSzint; set => m_AggodalomSzint = Math.Clamp(value, AMIN, AMAX);}
        public bool Veszelyes => AggodalomSzint >= DTRESH;

        public Kisallat(string nev, int kor, int egeszsegSzint) {
            Nev = nev;
            Kor = kor;
            EgeszsegSzint = egeszsegSzint;
            AggodalomSzint = DA;
        }

        public virtual void HangotAd() => Console.WriteLine($"{Nev} érthetetlen állati hangokat ad ki.");

        public virtual void KezelestKapot(int gyogyitasMerteke) {
            EgeszsegSzint += gyogyitasMerteke;
            AggodalomSzint -= 10;
            Console.WriteLine($"{Nev} megkapta a kezelést.");
            }
    }
}
