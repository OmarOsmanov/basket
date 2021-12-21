using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication35.ViewModels;

namespace WebApplication2.Controllers
{
    public class OurproductController : Controller
    {

        private readonly AppDbContext _context;

        public OurproductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmProducts model = new VmProducts()
            {

                About = _context.Abouts.FirstOrDefault(),
                Product = _context.Prodcts.ToList()
            };
                return View();
            }
        }
    }
