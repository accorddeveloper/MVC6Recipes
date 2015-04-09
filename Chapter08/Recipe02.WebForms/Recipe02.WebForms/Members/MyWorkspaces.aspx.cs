using System;
using Mvc6Recipes.Shared.DataAccess.Repository;

namespace Recipe02.WebForms.Members
{
    public partial class MyWorkspaces : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            
            // in order to simplify this example we are hard coding a user name
            var id = 1784;
            using (var workspaceRepo = new CollaborationSpaceRepository())
            {
                var list = workspaceRepo.GetCollaborationSpacesForArtist(id);
                if (list.Count > 0)
                {
                    ProjectsRepeater.DataSource = list;
                    ProjectsRepeater.DataBind();
                }
                else
                {
                    noWorkspaces.Visible = true;
                }
            }
       
        }
    }
}