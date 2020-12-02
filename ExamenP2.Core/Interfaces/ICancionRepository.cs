using System;
using System.Collections.Generic;
using System.Text;
using ExamenP2.Core.Entities;
using System.Linq.Expressions;
namespace ExamenP2.Core.Interfaces
{
    public interface ICancionRepository
    {
        IEnumerable<Cancion> GetAllIncludingDependencies();

        Cancion GetByIncludingDependencies(int id);

        IEnumerable<Cancion> FilterIncludingDependencies(Expression<Func<Cancion, bool>> listc);
    }
}
