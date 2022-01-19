using HostelListing.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelListing.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public Task Delete(int id)
        {

        }
    }
}
