using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Libra_ELMS
{
    internal class BookRegistryDGVM : GridViewManager
    {
        private string databaseTable;
        private readonly SQLQueryManager sqlQueryManager = new SQLQueryManager();
        public BookRegistryDGVM(string databaseTable) : base(databaseTable)
        {
            this.databaseTable = databaseTable;
        }

        public void InsertRecord(string title, string author, string publisher, string status)
        {
            sqlQueryManager.executeQuery($"insert into {databaseTable} values ('{title}', '{author}', " +
                $"'{publisher}', '{status}'); ");
            RefreshBook();
        }

        private void RefreshBook()
        {
            throw new NotImplementedException();
        }

        public override void DeleteRecord()
        {
            throw new NotImplementedException();
        }

        public override void UpdateRecord()
        {
            throw new NotImplementedException();
        }
        public override void ClearInputFields()
        {
            throw new NotImplementedException();
        }

        public override void SearchRecord()
        {
            throw new NotImplementedException();
        }

        public override void RefreshDataGridView()
        {
            throw new NotImplementedException();
        }

        public override void InsertRecord()
        {
            throw new NotImplementedException();
        }
    }
}
