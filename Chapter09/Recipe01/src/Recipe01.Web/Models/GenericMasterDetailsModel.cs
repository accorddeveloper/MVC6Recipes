using System.Collections.Generic;

namespace Recipe01.Web.Models
{
    public class GenericMasterDetailsModel<TEntity> where TEntity :class
    {
        public TEntity SelectedItem { get; set; }
        public int SelectedId { get; set; }

        public List<TEntity> ItemList { get; set; }
    }
}