using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        [HttpGet]
        public async Task<List<Quote>> Get()
        {
            using var appContext = new QuotesDBContext();
            var list = await appContext.Quotes.ToListAsync();
            return await Task.FromResult(list);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Quote quote)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            quote.Id = Guid.NewGuid();
            quote.InsertDate = DateTime.Now;
            using var appContext = new QuotesDBContext();
            await appContext.Quotes.AddAsync(quote);
            await appContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromRoute] Guid id, [FromBody] Quote quote)
        {
            using var appContext = new QuotesDBContext();
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var exist = await appContext.Quotes.FindAsync(id);
            if (exist == null)
            {
                return NotFound();
            }
            exist.Text = quote.Text;
            exist.Author = quote.Author;
            exist.InsertDate = DateTime.Now;
            var result = await appContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            using var appContext = new QuotesDBContext();
            var exist = await appContext.Quotes.FindAsync(id);
            if (exist == null)
            {
                return BadRequest();
            }
            appContext.Remove(exist);
            var result = await appContext.SaveChangesAsync();
            return Ok();
        }

      }
}
