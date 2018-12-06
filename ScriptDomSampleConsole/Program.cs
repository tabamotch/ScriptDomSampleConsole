using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace ScriptDomSampleConsole
{
    public class Program
    {
        private const string SQL = @"SELECT
    a.*,
    e.column_c
FROM
    TableA AS a
    INNER JOIN
    TableB AS b ON
        b.column_a = a.column_a
    AND b.b = a.column_b
    AND b.c = a.column_c
    AND b.column_d = a.column_d
    AND b.column_e = a.column_e
    INNER JOIN
    (
    SELECT
        c.column_a,
        c.column_b,
        d.column_c
    FROM
        TableC AS c
        LEFT OUTER JOIN
        TableD AS d ON
            d.column_a = c.column_a
        AND d.column_b = c.column_b
        AND d.column_f <> '3'
    ) AS e ON
        e.column_a = a.column_a
    AND e.column_b = a.column_b
WHERE
        a.column_a = @column_a
    AND (a.column_f < '3' OR a.column_f > '3')
ORDER BY a.column_a, e.column_b desc";

        public static void Main(string[] args)
        {
            TSqlFragment parseResult;
            IList<ParseError> errors;

            TSql100Parser parser = new TSql100Parser(true);
            using (TextReader reader = new StringReader(SQL))
            {
                parseResult = parser.Parse(reader, out errors);
            }

            if (errors.Count > 0)
            {
                Console.Error.WriteLine("===== Parse Error =====");
                foreach (ParseError errorItem in errors)
                {
                    Console.Error.WriteLine(errorItem.Message);
                }
                return;
            }

            Console.WriteLine("===== Parse Success =====");
            MySampleVisitor visitor = new MySampleVisitor(SQL);
            parseResult.Accept(visitor);
        }
    }
}
