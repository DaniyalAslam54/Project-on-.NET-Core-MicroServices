﻿using Microsoft.AspNetCore.Mvc;
using MyRestaurant.Web.Models;
using MyRestaurant.Web.Services.IServices;
using Newtonsoft.Json;

namespace MyRestaurant.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService; 
        }
        public async Task<IActionResult> ProductIndex()
        {
            List<ProductDTO> list = new();
            var response = await _productService.GetAllProductsAsync<ResponseDTO>();
            if(response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject <List<ProductDTO>>(Convert.ToString(response.Result));
            }
            return View(list);
        }

		public async Task<IActionResult> ProductCreate()
		{
			return View();
		}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductCreate(ProductDTO productDTO)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.CreateProductAsync<ResponseDTO>(productDTO);
                if (response != null && response.IsSuccess)
                {
                    RedirectToAction(nameof(ProductIndex));
                }
                
            }
            return View(productDTO);
        }

        public async Task<IActionResult> ProductEdit(int ProductId)
        {
            var response = await _productService.GetProductByIdAsync<ResponseDTO>(ProductId);
            if (response != null && response.IsSuccess)
            {
                ProductDTO productDTO = JsonConvert.DeserializeObject<ProductDTO>(Convert.ToString(response.Result));
                return View(productDTO);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductEdit(ProductDTO productDTO)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.UpdateProductAsync<ResponseDTO>(productDTO);
                if (response != null && response.IsSuccess)
                {
					return RedirectToAction(nameof(ProductIndex));
                }

            }
            return View(productDTO);
        }

		public async Task<IActionResult> ProductDelete(int ProductId)
		{
			var response = await _productService.GetProductByIdAsync<ResponseDTO>(ProductId);
			if (response != null && response.IsSuccess)
			{
				ProductDTO productDTO = JsonConvert.DeserializeObject<ProductDTO>(Convert.ToString(response.Result));
				return View(productDTO);
			}
			return NotFound();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> ProductDelete(ProductDTO productDTO)
		{
			 
				var response = await _productService.DeleteProductAsync<ResponseDTO>(productDTO.ProductId);
				if (response != null && response.IsSuccess)
				{
					return RedirectToAction(nameof(ProductIndex));
				}
                return RedirectToAction(nameof(ProductIndex));

        }


	}
}


