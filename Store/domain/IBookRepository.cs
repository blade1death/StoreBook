using System;
using System.Collections.Generic;
using System.Text;
namespace Store.domain
{
    public interface IBookRepository
    {
        Book[] GetByIsbn(string isbn);
        Book[] GetAllByTitleorAuthor(string titlePart);
        Book GetById(int id);
    }
}
