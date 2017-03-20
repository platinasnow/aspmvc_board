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
        BoardDao boardDao = new BoardDao();

        // GET: Board
        public ActionResult list(Board board)
        {
            board.itemPerPage = 10;
            board.totalItemCount = boardDao.findAllCount(board);

            ViewBag.list = boardDao.findAll(board);
            ViewBag.pagination = board;
            return View();
        }


        public ActionResult register()
        {
            return View();
        }

        public RedirectToRouteResult registerProc(Board board)
        {
            board.regId = "testasp";
            boardDao.insertBoard(board);

            return RedirectToAction("list");
        }

        public ActionResult view(Board board)
        {
            Board item = boardDao.findBoard(board);
            ViewBag.item = item;
            return View();
        }

        public ActionResult modify(Board board)
        {
            Board item = boardDao.findBoard(board);
            ViewBag.item = item;
            return View();
        }

        public RedirectToRouteResult modifyProc(Board board)
        {
            boardDao.updateBoard(board);
            return RedirectToAction("list");
        }

        public RedirectToRouteResult delete(Board board)
        {
            boardDao.deleteBoard(board);
            return RedirectToAction("list");
        }
    }
}