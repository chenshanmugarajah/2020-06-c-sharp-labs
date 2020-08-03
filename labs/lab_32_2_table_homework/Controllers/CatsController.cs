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
using lab_32_2_table_homework;

namespace lab_32_2_table_homework.Controllers
{
    public class CatsController : ApiController
    {
        private CatDBEntities db = new CatDBEntities();

        // GET: api/Cats
        public IQueryable<Cat> GetCats()
        {
            return db.Cats;
        }

        // GET: api/Cats/5
        [ResponseType(typeof(Cat))]
        public IHttpActionResult GetCat(int id)
        {
            Cat cat = db.Cats.Find(id);
            if (cat == null)
            {
                return NotFound();
            }

            return Ok(cat);
        }

        // PUT: api/Cats/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCat(int id, Cat cat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cat.CatId)
            {
                return BadRequest();
            }

            db.Entry(cat).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CatExists(id))
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

        // POST: api/Cats
        [ResponseType(typeof(Cat))]
        public IHttpActionResult PostCat(Cat cat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cats.Add(cat);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cat.CatId }, cat);
        }

        // DELETE: api/Cats/5
        [ResponseType(typeof(Cat))]
        public IHttpActionResult DeleteCat(int id)
        {
            Cat cat = db.Cats.Find(id);
            if (cat == null)
            {
                return NotFound();
            }

            db.Cats.Remove(cat);
            db.SaveChanges();

            return Ok(cat);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CatExists(int id)
        {
            return db.Cats.Count(e => e.CatId == id) > 0;
        }
    }
}