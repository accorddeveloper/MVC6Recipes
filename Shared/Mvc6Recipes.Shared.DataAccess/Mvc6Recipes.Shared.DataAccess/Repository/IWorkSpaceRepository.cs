using System.Collections.Generic;

namespace Mvc6Recipes.Shared.DataAccess.Repository
{
    public interface IWorkSpaceRepository
    {
        List<CollaborationSpace> GetCollaborationSpaces(QueryOptions options);
        CollaborationSpace GetCollaborationSpace(int id);
        void CreateCollaborationSpace(CollaborationSpace collaborationSpace);
        void UpdateCollaborationSpace(CollaborationSpace collaborationSpace);
        void Delete(int id);

        void AddComment(CollaborationSpaceComment comment);
        void UpdateComment(CollaborationSpaceComment comment);
        void DeleteComment(int id);

        void SubscribeToAlerts(int artistId);
        void UnsubscribeSubscribeToAlerts(int artistId);

        void SendInvites(List<string> recipients, string message);
    }
}
