using AutoMapper;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.UI;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    
    public class EventsController : ApiController
    {
        private ApplicationDbContext _context;
        public EventsController()
        {
            _context = new ApplicationDbContext();
        }


        [Route("api/v3/app/events")]
        public IHttpActionResult GetEvent(int id)
        {
            var e = _context.Events.SingleOrDefault(x => x.Id == id);

            if(e == null)
            {
                return NotFound();
            }

            return Ok(e);
        }


        [Route("api/v3/app/events")]
        public IHttpActionResult GetEvent(string type= null, int? limit = 5, int? page=1 )
        {
            var pageNumber = page ?? 1;
            var pageSize = limit ?? 5;

            pageNumber = pageNumber <= 0 ? 1 : pageNumber;
            pageSize = pageSize <= 0 ? 5 : pageSize;

            var e = _context.Events.ToList().ToPagedList( pageNumber, pageSize);

            if (!String.IsNullOrEmpty(type))
            {
                e = e.Where(x => x.Type.Contains(type)).ToPagedList(pageNumber, pageSize);
            }
            return Ok(e);   
        }


        [HttpPost]
        [Route("api/v3/app/events")]
        public IHttpActionResult CreateEvent(Event e)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Events.Add(e);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + e.Id), e);
        }


        [HttpPut]
        [Route("api/v3/app/events")]
        public IHttpActionResult UpdateEvent(int id, Event e)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var eventInDb = _context.Events.SingleOrDefault(x => x.Id == id);

            if(eventInDb == null)
            {
                return NotFound();
            }

            eventInDb.Type = e.Type;
            eventInDb.Name = e.Name;
            eventInDb.Tagline = e.Tagline;
            eventInDb.Schedule = e.Schedule;
            eventInDb.Description = e.Description;
            eventInDb.Image = e.Image;
            eventInDb.Moderator = e.Moderator;
            eventInDb.Category = e.Category;
            eventInDb.Sub_Category = e.Sub_Category;
            eventInDb.Rigor_Rank = e.Rigor_Rank;
            eventInDb.Attendees = e.Attendees;

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        [Route("api/v3/app/events")]
        public IHttpActionResult DeleteEvent(int id)
        {
            var eventInDb = _context.Events.SingleOrDefault( x => x.Id == id);
            if (eventInDb == null)
            {
                return NotFound();
            }

            _context.Events.Remove(eventInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
