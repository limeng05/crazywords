using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordPuzzle
{
    /// <summary>
    /// 一个词条
    /// </summary>
    class Item
    {
        /// <summary>
        /// 答案
        /// </summary>
        public String Word { get; set; }

        /// <summary>
        /// 提示
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// 答案的拼音首字母
        /// </summary>
        public String PinYin { get; set; }

        /// <summary>
        /// 第indexer个字的拼音首字母
        /// </summary>
        /// <param name="indexer">索引</param>
        /// <returns>第indexer个字的拼音首字母</returns>
        public char this[int indexer]
        {
            get
            {
                return Word[indexer];
            }
        }

        /// <summary>
        /// 被多少个Puzzle使用
        /// </summary>
        public int Used { get; set; }

        /// <summary>
        /// 难度级别
        /// </summary>
        public int Level { get; set; }
    }
}
