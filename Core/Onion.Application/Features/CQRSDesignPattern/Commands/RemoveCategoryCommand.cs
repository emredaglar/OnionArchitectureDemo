﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.CQRSDesignPattern.Commands
{
    public class RemoveCategoryCommand
    {
        public int CategoryId { get; set; }

        public RemoveCategoryCommand(int categoryId)
        {
            CategoryId = categoryId;
        }
    }
}