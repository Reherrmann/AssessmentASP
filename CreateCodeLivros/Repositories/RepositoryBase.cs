using CreateCodeLivros.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateCodeLivros.Repositories
{
    public class RepositoryBase<T> : RepositoryModel where T : class
    {
    }
}