using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_finance_app.Data;
using dotnet_finance_app.Dtos;
using dotnet_finance_app.Mappers;
using dotnet_finance_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_finance_app.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController: ControllerBase
    {
        private ApplicationDBContext _context;
        public StockController(ApplicationDBContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult GetAll() {
            var stocks = _context.Stocks.Select(s => s.ToStockDto()).ToList();
            return Ok(stocks);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id) {
            var stock = _context.Stocks.Find(id);
            if (stock == null) {
                return NotFound();
            }
            return Ok(stock.ToStockDto());
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] CreateStockRequestDto stockDto) {
            var stockModel = stockDto.ToStockFromCreateDto();
            _context.Stocks.Add(stockModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new {id = stockModel.id }, stockModel.ToStockDto());
        }
        
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateStockRequestDto updateDto) {
            var stockModel = _context.Stocks.FirstOrDefault(x => x.id == id);
            if (stockModel == null) {
                return NotFound();
            }
            stockModel.Symbol = updateDto.Symbol;
            stockModel.CompanyName = updateDto.CompanyName;
            stockModel.Purchase = updateDto.Purchase;
            stockModel.LastDiv = updateDto.LastDiv;
            stockModel.Industry = updateDto.Industry;
            stockModel.MarketCap = updateDto.MarketCap;

            _context.SaveChanges();
            return Ok(stockModel.ToStockDto());
        }
        
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id) {
            var stockModel = _context.Stocks.FirstOrDefault(x => x.id == id);
            if (stockModel == null) {
                return NotFound();
            }
            _context.Remove(stockModel);
            _context.SaveChanges();
            return Ok(stockModel.ToStockDto());
        }
    }
}