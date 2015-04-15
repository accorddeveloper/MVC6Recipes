using System;

namespace Mvc6Recipes.Shared.DataAccess
{
    public class UnitOfWork : IDisposable
    {
        private MoBContext _context = new MoBContext();
        private Repository<Artist> _ArtistRepository;
        private CollaborationSpaceRepository _CollaborationSpaceRepository;

        public Repository<Artist> ArtistRepository
        {
            get
            {
                if (_ArtistRepository == null)
                {
                    _ArtistRepository = new Repository<Artist>(_context);
                }
                return _ArtistRepository;
            }
        }

        public CollaborationSpaceRepository CollaborationSpaceRepository
        {
            get
            {
                if (_CollaborationSpaceRepository == null)
                {
                    _CollaborationSpaceRepository = new CollaborationSpaceRepository(_context);
                }
                return _CollaborationSpaceRepository;
            }
        }




        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}