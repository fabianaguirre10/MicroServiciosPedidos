using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.UI.WebControls;
using WEBSERVICES.Models;

namespace WEBSERVICES.Controllers
{
    public class PagosController : ApiController
    {
        private Engine_IndustrialEntities1 db = new Engine_IndustrialEntities1();

        // GET: api/Pagos
        public IQueryable<Pagos> GetPagos()
        {
            return db.Pagos;
        }

        // GET: api/Pagos/5
        [ResponseType(typeof(Pagos))]
        public async Task<IHttpActionResult> GetPagos(int id)
        {
            Pagos pagos = await db.Pagos.FindAsync(id);
            if (pagos == null)
            {
                return NotFound();
            }

            return Ok(pagos);
        }

        // PUT: api/Pagos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPagos(int id, Pagos pagos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pagos.Idpago)
            {
                return BadRequest();
            }

            db.Entry(pagos).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PagosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Pagos
        [ResponseType(typeof(Pagos))]
        public Boolean PostPagos(List<Pagos> pagos)
        {
            try
            {
                foreach (var x in pagos)
                {
                    x.imagen = Base64ToImage(x.foto);
                    db.Pagos.Add(x);
                }
                db.SaveChanges();
                //db.PEDIDOS.Add(pEDIDOS);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public byte[] Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            return imageBytes;
        }

        // DELETE: api/Pagos/5
        [ResponseType(typeof(Pagos))]
        public async Task<IHttpActionResult> DeletePagos(int id)
        {
            Pagos pagos = await db.Pagos.FindAsync(id);
            if (pagos == null)
            {
                return NotFound();
            }

            db.Pagos.Remove(pagos);
            await db.SaveChangesAsync();

            return Ok(pagos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PagosExists(int id)
        {
            return db.Pagos.Count(e => e.Idpago == id) > 0;
        }
    }
}