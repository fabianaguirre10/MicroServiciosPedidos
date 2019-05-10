using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WEBSERVICES.Models;



namespace WEBSERVICES.Controllers
{
    public class geo_manageController : ApiController
    {
        private MardisGEOEntities db = new MardisGEOEntities();
      

        // GET: api/geo_manage
        public IQueryable<geo_manage> Getgeo_manage()
        {
            return db.geo_manage;
        }

        // GET: api/geo_manage/5
        [ResponseType(typeof(geo_manage))]
        public IHttpActionResult Getgeo_manage(int id)
        {
            geo_manage geo_manage = db.geo_manage.Find(id);
            if (geo_manage == null)
            {
                return NotFound();
            }

            return Ok(geo_manage);
        }

        // PUT: api/geo_manage/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putgeo_manage(int id, geo_manage geo_manage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != geo_manage.Id)
            {
                return BadRequest();
            }

            db.Entry(geo_manage).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!geo_manageExists(id))
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

        // POST: api/geo_manage
        [ResponseType(typeof(geo_manage))]
        public IHttpActionResult Postgeo_manage(geo_manage geo_manage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.geo_manage.Add(geo_manage);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = geo_manage.Id }, geo_manage);
        }

        // DELETE: api/geo_manage/5
        [ResponseType(typeof(geo_manage))]
        public IHttpActionResult Deletegeo_manage(int id)
        {
            geo_manage geo_manage = db.geo_manage.Find(id);
            if (geo_manage == null)
            {
                return NotFound();
            }

            db.geo_manage.Remove(geo_manage);
            db.SaveChanges();

            return Ok(geo_manage);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool geo_manageExists(int id)
        {
            return db.geo_manage.Count(e => e.Id == id) > 0;
        }
    }
}