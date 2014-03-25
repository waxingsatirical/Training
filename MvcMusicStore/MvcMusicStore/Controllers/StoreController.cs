using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Disco" },
                new Genre { Name = "Jazz" },
                new Genre { Name = "Rock"}
            };

            return View(genres);
        }

        //
        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {
            return View(new Genre { Name = genre });
        }

        //
        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            return View(new Album { Title = "Album " + id });
        }

    }
}
