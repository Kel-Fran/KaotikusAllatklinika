using System;
using System.Collections.Generic;

namespace KaotikusAllatklinika
{
    public class Klinika
    {
        public List<Kisallat> Paciensek {get;}=[];

        public void BetegFelvétele(Kisallat allat) {
            Paciensek.Add(allat);
            Console.WriteLine($"{allat.Nev} megerkezett");
        }

        public void VaroTerHangzavar() => Paciensek.ForEach(it => it.HangotAd());

        public void CsoportosKezeles(int alapGyogyitasDozis) => Paciensek.ForEach(it => {
            if (it is PapagajVarazslo p) p.VarázsolGyogyitas();
            else if (it.Veszelyes) Console.WriteLine($"{it.Nev} too dangerous to be treated");
            else it.KezelestKapot(alapGyogyitasDozis);
        });
    }
}
