using System.Collections.Generic;
using HWAPP.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HWAPP.Controllers
{
    [Route("api/v1/batches")]
    public class BatchContoller: Controller
    {
        public ILogger Logger {get;}
        public IBatchService BatchService {get;}

        public BatchContoller(
            ILogger<Batch> logger, 
            IBatchService batchService)
        {
            Logger = logger;
            BatchService = batchService;
        }

        [HttpGet]
        public IEnumerable<Batch> GetAll() 
        {
            Logger.LogInformation("Batch GetAll Called");

            var results = BatchService.GetAllBatches();

            return results;
        }
    }   
}