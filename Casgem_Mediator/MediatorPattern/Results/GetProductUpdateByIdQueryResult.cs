﻿namespace Casgem_Mediator.MediatorPattern.Results
{
    public class GetProductUpdateByIdQueryResult
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Stock { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
