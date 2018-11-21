using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contact_app.Models;
using Microsoft.AspNetCore.Mvc;
using TwitchLib.Api;
using TwitchLib.Api.Interfaces;

namespace ColonyGaming_Angular_Web_API.Controllers
{
    // set route attribute to make request as 'api/contact'
    [Route("api/twitch")]
    public class TwitchAPIController : Controller
    {
        //private readonly ContactAppContext _context;
        private readonly ITwitchAPI _api;

        // initiate database context
        public TwitchAPIController(ITwitchAPI api)
        {
            //_context = context;
            _api = api;
        }

        [HttpGet("{id}")]
        [Route("getChannel")]
        public async Task<IActionResult> GetById(string id)
        {
            
            var item = await Task.Run(() => _api.V5.Users.GetUserByNameAsync(id));
            // filter contact records by contact id
            //var item = _context.Contact.FirstOrDefault(t => t.id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpGet("search/{search}")]
        [Route("searchChannels")]
        public async Task<IActionResult> SearchChannels(string search)
        {
            
            var item = await Task.Run(() => _api.V5.Search.SearchStreamsAsync(search));
            // filter contact records by contact id
            //var item = _context.Contact.FirstOrDefault(t => t.id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpGet()]
        [Route("community-followers")]
        public async Task<IActionResult> GetColonyFollowers()
        {
            var channel = await Task.Run(() => _api.V5.Users.GetUserByNameAsync("GeekTekRob"));
            var followers = await Task.Run(() => _api.V5.Users.GetUserFollowsAsync(channel.Matches[0].Id));
            // filter contact records by contact id
            //var item = _context.Contact.FirstOrDefault(t => t.id == id);
            if (followers == null)
            {
                return NotFound();
            }
            return new ObjectResult(followers);
        }
/* 
        [HttpGet]
        [Route("getAllContact")]
        public IEnumerable<Contact> GetAll()
        {
            // fetch all contact records 
            //return _context.Contact.ToList();
        }

        [HttpGet("{id}")]
        [Route("getContact")]
        public IActionResult GetById(long id)
        {
            // filter contact records by contact id
            var item = _context.Contact.FirstOrDefault(t => t.id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPost]
        [Route("addContact")]
        public IActionResult Create([FromBody] Contact item)
        {
            // set bad request if contact data is not provided in body
            if (item == null)
            {
                return BadRequest();
            }
            _context.Contact.Add(new Contact
            {
                name = item.name,
                email = item.email,
                gender = item.gender,
                birth = item.birth,
                techno = item.techno,
                message = item.message
            });
            _context.SaveChanges();

            return Ok( new { message= "Contact is added successfully."});
        }

        [HttpPut("{id}")]
        [Route("updateContact")]
        public IActionResult Update(long id, [FromBody] Contact item)
        {
            // set bad request if contact data is not provided in body
            if (item == null || id == 0)
            {
                return BadRequest();
            }

            var contact = _context.Contact.FirstOrDefault(t => t.id == id);
            if (contact == null)
            {
                return NotFound();
            }

            contact.name = item.name;
            contact.email = item.email;
            contact.gender = item.gender;
            contact.birth = item.birth;
            contact.techno = item.techno;
            contact.message = item.message;

            _context.Contact.Update(contact);
            _context.SaveChanges();
            return Ok( new { message= "Contact is updated successfully."});
        }


        [HttpDelete("{id}")]
        [Route("deleteContact")]
        public IActionResult Delete(long id)
        {
            var contact = _context.Contact.FirstOrDefault(t => t.id == id);
            if (contact == null)
            {
                return NotFound();
            }

            _context.Contact.Remove(contact);
            _context.SaveChanges();
            return Ok( new { message= "Contact is deleted successfully."});
        }
        */
    }
    
}
