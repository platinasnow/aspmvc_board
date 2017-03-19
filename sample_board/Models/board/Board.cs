using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sample_board.Models.board
{
    public class Board
    {
        public int idx { get; set; }
        public int masterIdx { get; set; }
        public String title { get; set; }
        public String contents { get; set; }
        public DateTime regDate { get; set; }
        public String regId { get; set; }
        public DateTime updateDate { get; set; }
        public String updateId { get; set; }
        public List<int> fileIdxs;
    }
}