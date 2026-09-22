using System;

namespace KaotikusAllatklinika
{
    public class HipnoMacska : Kisallat
    {
        public const int HMIN = 1;
        public const int HMAX = 10;
        int m_HipnoEro;
        public int HipnoEro {get => m_HipnoEro; set => m_HipnoEro = Math.Clamp(value, HMIN, HMAX);}

        public HipnoMacska(string nev, int kor, int egeszsegSzint, int hipnoEro) : base(nev, kor,egeszsegSzint) {
            HipnoEro = hipnoEro;
        }

        public override void HangotAd() => Console.WriteLine($"{Nev} hypnotizes you");

        public override void KezelestKapot(int gyogyitasMertek) {
            gyogyitasMertek -= HipnoEro;
            EgeszsegSzint += gyogyitasMertek;
            AggodalomSzint += 5;
        }
    }
}
