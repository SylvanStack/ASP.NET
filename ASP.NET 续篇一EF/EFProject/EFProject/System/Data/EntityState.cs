using System.Data.Entity;

namespace System.Data
{
    internal class EntityState
    {
        public static Entity.EntityState Deleted { get; internal set; }
        public static Entity.EntityState Modified { get; internal set; }
    }
}