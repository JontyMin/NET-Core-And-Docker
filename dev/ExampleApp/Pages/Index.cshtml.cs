using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ExampleApp.Pages {
    public class IndexModel : PageModel {

        public string Message { get; set; }
        public List<Product> Products { get; set; }
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _config;
        public IProductRepository _productRepository { get; }
        public IndexModel (ILogger<IndexModel> logger,
            IProductRepository productRepository,
            IConfiguration config) {
            _logger = logger;
            _productRepository = productRepository;
            _config = config;
        }

        public void OnGet () {
            Message = _config["MESSAGE"] ?? "NET Core And Docker";
            Products = _productRepository.Products.ToList();
        }
    }
}