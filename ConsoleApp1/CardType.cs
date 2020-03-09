using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// カード属性
    /// </summary>
    [Flags]
    public enum CardTypeAttr
    {
        /// <summary>財宝</summary>
        Treasure = 1,
        /// <summary>勝利点</summary>
        Victory = 1 << 1,
        /// <summary>呪い</summary>
        Curse = 1 << 2,
        /// <summary>アクション</summary>
        Action = 1 << 3,
        /// <summary>夜行</summary>
        Night = 1 << 4
    }
}
