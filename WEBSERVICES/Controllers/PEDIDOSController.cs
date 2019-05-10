using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WEBSERVICES.Models;

namespace WEBSERVICES.Controllers
{
    public class PEDIDOSController : ApiController
    {
        private Engine_IndustrialEntities1 db = new Engine_IndustrialEntities1();

        // GET: api/PEDIDOS
        public IQueryable<PEDIDOS> GetPEDIDOS()
        {
            return db.PEDIDOS;
        }

        // GET: api/PEDIDOS/5
        [ResponseType(typeof(PEDIDOS))]
        public async Task<IHttpActionResult> GetPEDIDOS(int id)
        {
            PEDIDOS pEDIDOS = await db.PEDIDOS.FindAsync(id);
            if (pEDIDOS == null)
            {
                return NotFound();
            }

            return Ok(pEDIDOS);
        }

        // PUT: api/PEDIDOS/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPEDIDOS(int id, PEDIDOS pEDIDOS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pEDIDOS.C_id)
            {
                return BadRequest();
            }

            db.Entry(pEDIDOS).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PEDIDOSExists(id))
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

        // POST: api/PEDIDOS
        [ResponseType(typeof(PEDIDOS))]
        public Boolean PostPEDIDOS(List<PEDIDOS> pEDIDOS)
        {
            try
            {
                foreach (var x in pEDIDOS)
                {
                    db.PEDIDOS.Add(x);
                }
                db.SaveChanges();
                //db.PEDIDOS.Add(pEDIDOS);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        // DELETE: api/PEDIDOS/5
        [ResponseType(typeof(PEDIDOS))]
        public async Task<IHttpActionResult> DeletePEDIDOS(int id)
        {
            PEDIDOS pEDIDOS = await db.PEDIDOS.FindAsync(id);
            if (pEDIDOS == null)
            {
                return NotFound();
            }

            db.PEDIDOS.Remove(pEDIDOS);
            await db.SaveChangesAsync();

            return Ok(pEDIDOS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PEDIDOSExists(int id)
        {
            return db.PEDIDOS.Count(e => e.C_id == id) > 0;
        }
    }
}