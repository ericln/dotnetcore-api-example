using System;
using System.Collections.Generic;

namespace HWAPP.Services
{
    public class BatchService : IBatchService
    {
        public IEnumerable<Batch> GetAllBatches()
        {
            var batches = new List<Batch>
            {
                new Batch { Id= "1001", ManufacturingLocation= "SD" },
                new Batch { Id= "1002", ManufacturingLocation= "SD" },
                new Batch { Id= "1003", ManufacturingLocation= "SD" }
            };

            return batches;
        }
    }
}