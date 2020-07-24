using System;

namespace EDI2020.Services
{
    public class RandomService
    {
        public Guid RandomId { get; } = Guid.NewGuid();
    }
}