using ResponseCacheExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResponseCacheExamples.Services
{
    public class FakeServices : IFakeServices
    {
        public List<BookModel> GetBookList()
        {
            return new List<BookModel>()
            {
                new BookModel()
                {
                    ID = 1,
                    Title = "Şeker Portakalı",
                    Writer = "José Mauro de Vasconcelos"
                },
                new BookModel()
                {
                    ID = 2,
                    Title = "Yabancı",
                    Writer = "Albert Camus"
                },
                new BookModel()
                {
                    ID = 3,
                    Title = "Fareler ve İnsanlar",
                    Writer = "John Steinbeck"
                },
                new BookModel()
                {
                    ID = 4,
                    Title = "1984",
                    Writer = "George Orwell"
                },
                new BookModel()
                {
                    ID = 42,
                    Title = "Otostopçunun Galaksi Rehberi",
                    Writer = "Douglas Adams"
                }
            };
        }
    }
}
