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
    public class BreedsController : ApiController
    {
        private CatDBEntities db = new CatDBEntities();

        // GET: api/Breeds
        public IQueryable<Breed> GetBreeds()
        {
            return db.Breeds;
        }

        // GET: api/Breeds/5
        [ResponseType(typeof(Breed))]
        public IHttpActionResult GetBreed(int id)
        {
            Breed breed = db.Breeds.Find(id);
            if (breed == null)
            {
                return NotFound();
            }

            return Ok(breed);
        }

        // PUT: api/Breeds/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBreed(int id, Breed breed)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != breed.BreedId)
            {
                return BadRequest();
            }

            db.Entry(breed).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BreedExists(id))
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

        // POST: api/Breeds
        [ResponseType(typeof(Breed))]
        public IHttpActionResult PostBreed(Breed breed)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Breeds.Add(breed);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = breed.BreedId }, breed);
        }

        // DELETE: api/Breeds/5
        [ResponseType(typeof(Breed))]
        public IHttpActionResult DeleteBreed(int id)
        {
            Breed breed = db.Breeds.Find(id);
            if (breed == null)
            {
                return NotFound();
            }

            db.Breeds.Remove(breed);
            db.SaveChanges();

            return Ok(breed);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BreedExists(int id)
        {
            return db.Breeds.Count(e => e.BreedId == id) > 0;
        }
    }
}