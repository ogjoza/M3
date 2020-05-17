using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Menzy.Dtos;
using Menzy.Models;
using System.Data.Entity;
namespace Menzy.Controllers.Api
{
    public class FoodsController : ApiController
    {
        private ApplicationDbContext _context;

        public FoodsController()
        {
            _context = new ApplicationDbContext();
        }
        //Get /api/foods
        public IEnumerable<FoodDto> GetFoods()
        {
            return _context.Foods
                .ToList().Select(Mapper.Map<Food, FoodDto>);
        }
        //Get /api/foods/1
        public IHttpActionResult GetFood(int id)
        {
            var food = _context.Foods.SingleOrDefault(c => c.Id == id);
            if (food == null)
                return NotFound();
            return Ok(Mapper.Map<Food, FoodDto>(food));
        }
        //post /api/foods
        [HttpPost]
        public IHttpActionResult CreateFood(FoodDto foodDto)
        {
            if (ModelState.IsValid)
                return BadRequest();
            var food = Mapper.Map<FoodDto, Food>(foodDto);
            _context.Foods.Add(food);
            _context.SaveChanges();
            foodDto.Id = food.Id;
            return Created(new Uri(Request.RequestUri + "/" + food.Id), foodDto);
        }
        //PUT /api/foods/1
        [HttpPut]
        public void UpdateFood(int id, FoodDto foodDto)
        {
            if (ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var foodInDb = _context.Foods.SingleOrDefault(c => c.Id == id);
            if (foodInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(foodDto, foodInDb);
            _context.SaveChanges();
        }
        //DELETE /api/foods/1
        [HttpDelete]
        public void DeleteFood(int id)
        {
            var foodInDb = _context.Foods.SingleOrDefault(c => c.Id == id);
            if (foodInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Foods.Remove(foodInDb);
            _context.SaveChanges();
        }
    }
}
