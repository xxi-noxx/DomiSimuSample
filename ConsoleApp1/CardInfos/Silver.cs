using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CardInfos
{
    /// <summary>
    /// 銀貨
    /// </summary>
    public class Silver : ICardInfo, ITresureCard
    {
        public string Name => "銀貨";

        public CardTypeAttr CardType => CardTypeAttr.Treasure;

        public void DoTreasure(PlayerStatus ps)
        {
            ps.Coin += 2;
        }
    }
}
