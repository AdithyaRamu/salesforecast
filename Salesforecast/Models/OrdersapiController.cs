using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Salesforecast.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersapiController : ControllerBase
    {
        private readonly testContext _context;

        public OrdersapiController(testContext context)
        {
            _context = context;
        }

        // GET: api/Ordersapi
        [HttpGet]
        public IEnumerable<Orders> GetOrders()
        {
            return _context.Orders;
        }

        // GET: api/Ordersapi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrders([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orders = await _context.Orders.FindAsync(id);

            if (orders == null)
            {
                return NotFound();
            }

            return Ok(orders);
        }
        
        [HttpGet("getorderyear")]
        public async Task<IActionResult> GetOrdersyear()
        {
            var year = (from t in _context.Orders
                         
                           select new
                           {
                               t.OrderDate.Year
                           }).ToList().Distinct();

            await _context.SaveChangesAsync();

            return Ok(year);
        }

        [HttpGet("getstate")]
        public async Task<IActionResult> Getstate()
        {
            var state = (from t in _context.Orders

                        select new
                        {
                            t.State
                        }).ToList().Distinct();

            await _context.SaveChangesAsync();

            return Ok(state);
        }
       
        [HttpGet("getstatesales/{year}")]
        public async Task<IActionResult> getstatesales(int year)
        {
            var statesales = (
     from o in _context.Orders
     join od in _context.Orderdetails on o.OrderId equals od.OrderId
     where o.OrderDate.Year == year
         && !_context.Orderreturns.Select(or => or.OrderId).Contains(od.OrderId)
     group od by o.State into g
     select new
     {
         State = g.Key,
         TotalSales = g.Sum(od => od.Sales)
     });

            await _context.SaveChangesAsync();

            return Ok(statesales);
        }


        [HttpGet("getpercentagesales/{orderyear}/{percentageinput}")]
        public async Task<IActionResult> getpercentagesales(int orderyear,decimal percentageinput)
        {
            decimal percent = percentageinput / 100;
            var percentagesales = (
   from o in _context.Orders
   join od in _context.Orderdetails on o.OrderId equals od.OrderId
   where o.OrderDate.Year == orderyear
       && !_context.Orderreturns.Select(or => or.OrderId).Contains(od.OrderId)
   group od by o.State into g
   select new
   {
       State = g.Key,
       ActualSale = g.Sum(od => od.Sales),
       PredictedSale = g.Sum(od => od.Sales) + g.Sum(od => od.Sales) * percent
   }
);

            await _context.SaveChangesAsync();

            return Ok(percentagesales);
        }

        [HttpGet("getstatesales/{orderyear}/{percentageinput}/{state}")]
        public async Task<IActionResult> getstatesales(int orderyear, decimal percentageinput,string state)
        {
            decimal percent = percentageinput / 100;
            var statesales = (
   from o in _context.Orders
   join od in _context.Orderdetails on o.OrderId equals od.OrderId
   where o.OrderDate.Year == orderyear && o.State == state
       && !_context.Orderreturns.Select(or => or.OrderId).Contains(od.OrderId)
   group od by o.State into g
   select new
   {
       State = g.Key,
       ActualSale = g.Sum(od => od.Sales),
       PredictedSale = g.Sum(od => od.Sales) + g.Sum(od => od.Sales) * percent
   }
);

            await _context.SaveChangesAsync();

            return Ok(statesales);
        }

        [HttpGet("gettotalprecentsales/{orderyear}/{percentageinput}")]
        public async Task<IActionResult> gettotalprecentsales(int orderyear, decimal percentageinput)
        {
            decimal percent = percentageinput / 100;
            var totalpercent = (
     from o in _context.Orders
     join od in _context.Orderdetails on o.OrderId equals od.OrderId
     where o.OrderDate.Year == orderyear
         && !_context.Orderreturns.Select(or => or.OrderId).Contains(od.OrderId)
     select od.Sales
 );
            var actualSale = totalpercent.Sum();
            var predictedSale = actualSale+ (actualSale * percent);
            var actualsalesstring = actualSale.ToString();
            var predictedSalestring = predictedSale.ToString();

            string total = "Actual Sale =" + actualsalesstring + " Forcasted Sale =" + predictedSalestring;
            var totaljson = JsonConvert.SerializeObject(
   new[] { JsonConvert.DeserializeObject(actualsalesstring), JsonConvert.DeserializeObject(predictedSalestring) }
);
            await _context.SaveChangesAsync();

 return Ok(totaljson);
        }


        [HttpGet("gettotalsales/{year}")]
        public async Task<IActionResult> gettotalsales(int year)
        {
            var totalsales = _context.Orderdetails
    .Where(a => _context.Orders
        .Where(o => o.OrderDate.Year == year)
        .Select(o => o.OrderId)
        .Contains(a.OrderId)
    )
    .Where(a => !_context.Orderreturns
        .Select(or => or.OrderId)
        .Contains(a.OrderId)
    )
    .Sum(a => a.Sales);

            await _context.SaveChangesAsync();

            return Ok(totalsales);
        }


        // PUT: api/Ordersapi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrders([FromRoute] string id, [FromBody] Orders orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != orders.OrderId)
            {
                return BadRequest();
            }

            _context.Entry(orders).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Ordersapi
        [HttpPost]
        public async Task<IActionResult> PostOrders([FromBody] Orders orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Orders.Add(orders);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OrdersExists(orders.OrderId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOrders", new { id = orders.OrderId }, orders);
        }

        // DELETE: api/Ordersapi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrders([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orders = await _context.Orders.FindAsync(id);
            if (orders == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(orders);
            await _context.SaveChangesAsync();

            return Ok(orders);
        }

        private bool OrdersExists(string id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }
    }
}