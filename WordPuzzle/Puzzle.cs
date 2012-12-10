using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordPuzzle
{
    public class Puzzle
    {
        private KeyValuePair<int, Item>[,] _map;

        Puzzle(int width, int height)
        {
            _map = new KeyValuePair<int, Item>[width, height];
        }

        public bool IsValidateGrid(int i, int j)
        {
            return _map[i, j].Value != null;
        }

        public String VerticalHint(int i, int j)
        {
            throw new NotImplementedException();
        }

        public String HorizontalHint(int i, int j)
        {
            throw new NotImplementedException();
        }

        public bool ValidateResult(Char userInput, int i, int j)
        {
            throw new NotImplementedException();
        }
    }
}