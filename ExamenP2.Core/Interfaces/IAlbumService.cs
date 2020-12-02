using System;
using System.Collections.Generic;
using System.Text;
using ExamenP2.Core.Entities;
namespace ExamenP2.Core.Interfaces
{
    public interface IAlbumService
    {
        ServiceResult<IEnumerable<Album>> GetAlbums();
        ServiceResult<IEnumerable<Cancion>> GetCancionesnyAlbums(int albumId);
    }
}
