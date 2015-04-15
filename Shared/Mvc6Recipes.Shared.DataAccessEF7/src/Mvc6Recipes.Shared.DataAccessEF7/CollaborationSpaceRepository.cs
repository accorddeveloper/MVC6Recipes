using System;
using System.Collections.Generic;
using System.Linq;

namespace Mvc6Recipes.Shared.DataAccess
{
    public class CollaborationSpaceRepository : Repository<CollaborationSpace>
    {
        public CollaborationSpaceRepository(MoBContext context) : base(context)
        {

        }


        public List<CollaborationSpace> GetCollaborationSpacesForArtist(int artistId)
        {
            var query = from e in _context.CollaborationSpaces
                        join a in _context.ArtistCollaborationSpaces
                        on e.CollaborationSpaceId equals a.CollaborationSpaceId
                        where a.ArtistId == artistId
                        select e;
            return query.ToList();

        }
    }
}