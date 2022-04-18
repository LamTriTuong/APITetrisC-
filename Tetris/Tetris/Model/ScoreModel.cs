using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Model
{
    internal class ScoreModel
    {
        public string NickName { get; set; }
        public int Score { get; set; }
        public DateTime LastTimePlay { get; set; }
        public ScoreModel()
        {

        }
    }
}
