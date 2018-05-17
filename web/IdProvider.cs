using System;

namespace web
{
    public class IdProvider
    {
        public Guid NewId()
        {
            return Guid.NewGuid();
        }
    }
}