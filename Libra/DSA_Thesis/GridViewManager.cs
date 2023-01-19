using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libra_ELMS
{
    internal abstract class GridViewManager
    {
        private string databaseTable { get; set; }
        private SQLQueryManager sqlQueryManager = new SQLQueryManager();

        public GridViewManager(string databaseTable)
        {
            this.databaseTable = databaseTable;
        }
        public abstract void InsertRecord();
        public abstract void UpdateRecord();
        public abstract void DeleteRecord();
        public abstract void SearchRecord();
        public abstract void ClearInputFields();    
        public abstract void RefreshDataGridView();

    }
}
