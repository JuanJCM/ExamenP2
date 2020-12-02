using System;
using System.Collections.Generic;
using System.Text;
using ExamenP2.Core.Entities;
namespace ExamenP2.Core.Interfaces
{
    interface ICancionServices
    {
        ServiceResult<IEnumerable<Cancion>> FilterByAlbum(string name);

        ServiceResult<Cancion> GetById(int id);
    }
}
