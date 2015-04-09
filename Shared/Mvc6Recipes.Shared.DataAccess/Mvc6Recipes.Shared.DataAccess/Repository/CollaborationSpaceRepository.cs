using System;
using System.Collections.Generic;
using System.Linq;

namespace Mvc6Recipes.Shared.DataAccess.Repository
{
    public class CollaborationSpaceRepository : IWorkSpaceRepository, IDisposable
    {
        private IMoBContext _context;

        public CollaborationSpaceRepository(IMoBContext context)
        {
            if (context != null)
                _context = context;
        }
        public CollaborationSpaceRepository()
        {
            _context = new MoBContext();
        }
        /// <summary>
        /// Gets a list of collaboration spaces, filtered and sorted according to the options
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public List<CollaborationSpace> GetCollaborationSpaces(QueryOptions options)
        {
            if (options == null)
                return _context.CollaborationSpaces.Take(20).ToList();

            throw new InvalidOperationException("Query not supported");

            //var positions = from p in m_ent.ProjectOpenPositions.Include("Band")
            //                where p.ProjectOpenPositionId == openPositionId
            //                select p;
        }

        public List<CollaborationSpace> GetCollaborationSpacesForArtist(int artistId)
        {
            var query = from e in _context.CollaborationSpaces
                        join a in _context.ArtistCollaborationSpaces
                        on e.CollaborationSpaceId equals a.CollaborationSpaceId
                        where a.ArtistId ==artistId
                        select e;
            return query.ToList<CollaborationSpace>();

        }

        /// <summary>
        /// Gets a CollaborationSpace based on ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CollaborationSpace GetCollaborationSpace(int id)
        {
            return _context.CollaborationSpaces.Find(id);
        }

        public void CreateCollaborationSpace(CollaborationSpace collaborationSpace)
        {
            throw new NotImplementedException();
        }

        public void UpdateCollaborationSpace(CollaborationSpace collaborationSpace)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void AddComment(CollaborationSpaceComment comment)
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(CollaborationSpaceComment comment)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(int id)
        {
            throw new NotImplementedException();
        }

        public void SubscribeToAlerts(int artistId)
        {
            throw new NotImplementedException();
        }

        public void UnsubscribeSubscribeToAlerts(int artistId)
        {
            throw new NotImplementedException();
        }

        public void SendInvites(List<string> recipients, string message)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool _disposedValue; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                    _context = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                _disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources. 
        // ~CollaborationSpaceRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
