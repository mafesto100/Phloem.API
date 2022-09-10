using Phloem.Core.Interfaces.Repository;
using Phloem.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phloem.Infrastructure.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly DapperContext _dapperContext;

        public ProductRepository(DapperContext dapperContext) => _dapperContext = dapperContext;


    }
}
