using System.Collections.Generic;

public interface IBatchService 
{
    IEnumerable<Batch> GetAllBatches();
}