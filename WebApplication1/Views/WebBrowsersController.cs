using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Views
{
    public class WebBrowsersController : Controller
    {
        

        public WebBrowsersController(ApplicationDbContext context)
        {
            
        }

        // GET: WebBrowsers
        public async Task<IActionResult> Index()
        {

            return View();
                       
        }

        // GET: WebBrowsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            

          
                
            

            return View();
        }

        // GET: WebBrowsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WebBrowsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,URL")] WebBrowser webBrowser)
        {

            CountHelp.History.Add(webBrowser.URL);
            CountHelp.index++;



            return View(webBrowser);
        }


        [HttpPost]
       
        public async Task<IActionResult> Back()
        {

            CountHelp.index--;

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Forward()
        {

            CountHelp.index++;

            return View();
        }




        // GET: WebBrowsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            
            return View();
        }

        // POST: WebBrowsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,URL")] WebBrowser webBrowser)
        {
            
            return View();
        }

        // GET: WebBrowsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            return View();
        }

        // POST: WebBrowsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            
            return RedirectToAction(nameof(Index));
        }

        
    }
}
