using System;
namespace Technology
{
    public abstract class AbstractEntity
    {
        public int Id { get; }
        private static int nextId = 1;

        public AbstractEntity()
        {
            Id = nextId;
            nextId++;
        }
    }
}
