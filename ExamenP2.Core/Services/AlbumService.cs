using System;
using System.Collections.Generic;
using System.Text;
using ExamenP2.Core.Entities;
using ExamenP2.Core.Interfaces;
namespace ExamenP2.Core.Services
{
    class AlbumService : IAlbumService
    {
        private readonly IRepository<Album> _albumRepository;
        private readonly ICancionRepository _cancionRepository;

        public AlbumService(IRepository<Album> albumrepository, ICancionRepository cancionRepository)
        {
            _albumRepository = albumrepository;
            _cancionRepository = cancionRepository;
        }
        public ServiceResult<IEnumerable<Album>> GetAlbums()
        {
            return ServiceResult<IEnumerable<Album>>.SuccessResult(_albumRepository.GetAll());
        }

        public ServiceResult<IEnumerable<Cancion>> GetCancionesnyAlbums(int albumId)
        {
            var cancions = _cancionRepository.FilterIncludingDependencies(p => p.Id == albumId);
            return cancions.Any()
                ? ServiceResult<IEnumerable<Cancion>>.SuccessResult(cancions)
                : ServiceResult<IEnumerable<Cancion>>.NotFoundResult(
                    $"No se encontraron canciones al album {albumId}");
        }
    }
}
