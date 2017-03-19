using IBatisNet.DataMapper;
using sample_board.Models.board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sample_board.Dao.face.board
{
    public class BoardDao
    {
        public IList<Board> findAll(Board board)
        {
          return Mapper.Instance().QueryForList<Board>("findAll", board);
        }

        public void insertBoard(Board board)
        {
            Mapper.Instance().Insert("insertBoard", board);
        }

        public Board findBoard(Board board)
        {
            return Mapper.Instance().QueryForObject<Board>("findBoard", board);
        }

        public int findAllCount(Board board)
        {
            return Mapper.Instance().QueryForObject<int>("findAllCount", board);
        }
    }
}