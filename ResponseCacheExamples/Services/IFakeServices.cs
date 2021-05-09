using ResponseCacheExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResponseCacheExamples.Services
{
    public interface IFakeServices
    {
        List<BookModel> GetBookList();
    }
}
