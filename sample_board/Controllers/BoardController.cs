using sample_board.Dao.face.board;
using sample_board.Models.board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sample_board.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        public ActionResult Index(Board board)
        {
            BoardDao dao = new BoardDao();
            ViewBag.list = dao.findAll(board);
            return View();
        }
    }
}