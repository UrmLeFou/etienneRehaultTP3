using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP.Models;

namespace WebApplication1.Controllers
{
    public class ChatController : Controller
    {
        private static readonly List<Chat> chats = Chat.GetMeuteDeChats();

        // GET: Chat
        public ActionResult Index()
        {
            return View(chats);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            var chat = chats.SingleOrDefault(c => c.Id.Equals(id));
            return View(chat);
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            var chat = chats.SingleOrDefault(c => c.Id.Equals(id));
            return View(chat);
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var chat = chats.SingleOrDefault(c => c.Id.Equals(id));
                chats.Remove(chat);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
