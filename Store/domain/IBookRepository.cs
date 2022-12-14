using System;
using System.Collections.Generic;
using System.Text;
namespace Store.domain
{
    public interface IBookRepository
    {
        Book[] GetAllByIsbn(string isbn);

        Book[] GetAllByTitleOrAuthor(string titleOrAuthor);

        Book GetById(int id);

        Book[] GetAllByIds(IEnumerable<int> bookIds);
    }
}
