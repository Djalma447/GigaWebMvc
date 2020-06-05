﻿using GigaWebMvc.Data;
using GigaWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GigaWebMvc.Services
{
    public class SellerService
    {
        private readonly GigaWebMvcContext _context;

        public SellerService(GigaWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
