using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using RPC.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace RPC.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
           private readonly ILogger<IndexModel> _logger;

        /**
           public IndexModel(ILogger<IndexModel> logger)
           {
               _logger = logger;
           }
        **/

        public IEnumerable<RPCUser> RPCUsers { get; set; }

        private readonly Data.AuthDBContext _context;
        public IndexModel(Data.AuthDBContext _context, ILogger<IndexModel> logger)
        {
            this._context = _context;
            _logger = logger;
        }

        /**
        public IActionResult User()
        {
            return View(_context.Users.ToList());
        }

       **/

        public void OnGet()
        {
            RPCUsers = _context.User.ToList();
       }
    }
}
