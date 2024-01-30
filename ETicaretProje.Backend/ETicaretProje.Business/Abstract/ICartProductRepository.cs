﻿using EticaretProje.Domain.Entities;
using EticaretProje.Domain.ResponseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretProje.Business.Abstract
{
    public interface ICartProductRepository : IBaseRepository<CartProduct>
    {
        public Task<ResponseObject<CartProduct>> GetByCartId(int id);
    }
}
