using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Festival.Models;

namespace Festival.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IMusicFestivalRepository _musicRepository;

        public HomeController(IMusicFestivalRepository musicRepository)
        {
              _musicRepository=musicRepository;  
        }

        public ViewResult Index()
        {
            var model= _musicRepository.GetMusicFestivals();
            return View(model);
        }

    }
}
