using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ExamenP2.Core.Entities;
using ExamenP2.Core.Interfaces;
namespace ExamenP2.Core.Services
{
    class CancionService : ICancionService
    {
        private readonly ICancionRepository _cancionRepository;

        public CancionService(ICancionRepository cancionRepository)
        {
            _cancionRepository = cancionRepository;
        }

        public ServiceResult<IEnumerable<Cancion>> FilterByAlbum(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return ServiceResult<IEnumerable<Cancion>>.SuccessResult(_cancionRepository.GetAllIncludingDependencies());

            }
            var cancions = _cancionRepository.FilterIncludingDependencies(p => p.Nombre.Contains(name));
            //var cancions = _cancionRepository.FilterIncludingDependencies(p => p.Nombre.Contains(name));
            return cancions.Any()
                ? ServiceResult<IEnumerable<Cancion>>.SuccessResult(cancions)
                : ServiceResult<IEnumerable<Cancion>>.NotFoundResult(
                    $"No se encontraron canciones con el nombre {name}");
        }

        public ServiceResult<Cancion> GetById(int id)
        {
            var cancion = _cancionRepository.GetAllIncludingDependencies();
            return cancion != null
                ? ServiceResult<Cancion>.SuccessResult(cancion)
                : ServiceResult<Cancion>.NotFoundResult(
                    $"Cancion no encontrada");

        }
    }
}
