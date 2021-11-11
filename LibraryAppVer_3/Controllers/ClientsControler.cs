using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataContext;
using LibraryAppVer_3.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace LibraryAppVer_3.Controllers
{
    public class ClientsControler : Controller
    {
        private readonly LibraryDB _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ClientsControler(LibraryDB context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        // GET: ClientsControler
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clients.ToListAsync());
        }

        // GET: ClientsControler/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: ClientsControler/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClientsControler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClientsModel clientsModel)
        {
            if (ModelState.IsValid)
            {
                Client client = new Client
                {
                    NameOfClient = clientsModel.NameOfClient,
                    Age = clientsModel.Age,
                    LibraryId = clientsModel.LibraryId,
                    RentedBook = clientsModel.RentedBook,
                    Photo = GetByteArrayFromImage(clientsModel.ImageFile)
                };
                _context.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        private byte[] GetByteArrayFromImage(IFormFile formFile)
        {
            using (var target = new MemoryStream())
            {
                formFile.CopyTo(target);
                return target.ToArray();
            }
            
        }

        // GET: ClientsControler/Edit/5
        public async Task<IActionResult> Edit(long? id)
      {
          if (id == null)
          {
              return NotFound();
          }

          var client = await _context.Clients.FindAsync(id);
          if (client == null)
          {
              return NotFound();
          }
          return View(client);
      }

      // POST: ClientsControler/Edit/5
      // To protect from overposting attacks, enable the specific properties you want to bind to.
      // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public async Task<IActionResult> Edit(long id, [Bind("NameOfClient,Age,LibraryId,Id,RentedBook,Photo")] Client client)
      {
          if (id != client.Id)
          {
              return NotFound();
          }

          if (ModelState.IsValid)
          {
              try
              {
                  _context.Update(client);
                  await _context.SaveChangesAsync();
              }
              catch (DbUpdateConcurrencyException)
              {
                  if (!ClientExists(client.Id))
                  {
                      return NotFound();
                  }
                  else
                  {
                      throw;
                  }
              }
              return RedirectToAction(nameof(Index));
          }
          return View(client);
      }

      // GET: ClientsControler/Delete/5
      public async Task<IActionResult> Delete(long? id)
      {
          if (id == null)
          {
              return NotFound();
          }

          var client = await _context.Clients
              .FirstOrDefaultAsync(m => m.Id == id);
          if (client == null)
          {
              return NotFound();
          }

          return View(client);
      }

      // POST: ClientsControler/Delete/5
      [HttpPost, ActionName("Delete")]
      [ValidateAntiForgeryToken]
      public async Task<IActionResult> DeleteConfirmed(long id)
      {
          var client = await _context.Clients.FindAsync(id);
          _context.Clients.Remove(client);
          await _context.SaveChangesAsync();
          return RedirectToAction(nameof(Index));
      }

      private bool ClientExists(long id)
      {
          return _context.Clients.Any(e => e.Id == id);
      }
  }
}
