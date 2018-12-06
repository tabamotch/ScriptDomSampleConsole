using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace ScriptDomSampleConsole
{
    public class MySampleVisitor : TSqlFragmentVisitor
    {
        private string _sql;

        public MySampleVisitor(string sql) => _sql = sql;

        public override void Visit(QuerySpecification node)
        {

        }

        public override void ExplicitVisit(QuerySpecification node)
        {

        }
    }
}
