using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sample_board.Models.board
{
    public class Board
    {
        public int idx;
        public int masterIdx;
        public String title;
        public String contents;
        public DateTime regDate;
        public String regId;
        public DateTime updateDate;
        public String updateId;
        public List<int> fileIdxs;
    }
}