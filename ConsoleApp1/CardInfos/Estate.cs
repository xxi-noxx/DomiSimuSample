using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CardInfos
{
    /// <summary>
    /// 屋敷
    /// </summary>
    public class Estate : ICardInfo
    {
        public string Name => "屋敷";

        public CardTypeAttr CardType => CardTypeAttr.Victory;

    }
}
