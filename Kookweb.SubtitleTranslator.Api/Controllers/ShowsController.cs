using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kookweb.SubtitleTranslator.Domain.Models;
using Kookweb.SubtitleTranslator.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kookweb.SubtitleTranslator.Api.Controllers {

    [Route ("api/[controller]")]
    [ApiController]
    public class ShowsController : ControllerBase {
        private readonly ITVShowService _tvShowService;
        public ShowsController (ITVShowService tvShowService) {
            _tvShowService = tvShowService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TVShow>>> Get () {

            IEnumerable<TVShow> shows = await _tvShowService.ListAsync ();
            return Ok (shows);
        }
    }
}