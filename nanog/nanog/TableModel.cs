using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nanog
{
    class TableModel : DataTable
    {
        private const string VALUES = "Values";
        private const string PARAMETER = "Parameter";

        public TableModel(string tableName = "") 
            : base(tableName)
        {
            this.Columns.Add(PARAMETER);
            this.Columns.Add(VALUES);
        }
    }
}
