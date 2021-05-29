using System;
using System.Runtime.Serialization;

namespace Analisis.Web.Controllers
{
    [Serializable]
    internal class DbUpdateConcurrencyExeption : Exception
    {
        public DbUpdateConcurrencyExeption()
        {
        }

        public DbUpdateConcurrencyExeption(string message) : base(message)
        {
        }

        public DbUpdateConcurrencyExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DbUpdateConcurrencyExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}