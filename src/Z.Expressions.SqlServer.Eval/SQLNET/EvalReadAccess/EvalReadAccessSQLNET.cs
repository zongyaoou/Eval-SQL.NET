// Description: Evaluate C# code and expression in T-SQL stored procedure, function and trigger.
// Website & Documentation: https://github.com/zzzprojects/Eval-SQL.NET
// Forum & Issues: https://github.com/zzzprojects/Eval-SQL.NET/issues
// License: https://github.com/zzzprojects/Eval-SQL.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using Microsoft.SqlServer.Server;

// ReSharper disable InconsistentNaming

namespace Z.Expressions.SqlServer.Eval
{
    public partial struct SQLNET
    {
        /// <summary>Eval the code or expression and return a SQLNET object value.</summary>
        /// <returns>The SQLNET object value from the evaluated code or expression.</returns>
        [SqlMethod(DataAccess = DataAccessKind.Read, SystemDataAccess = SystemDataAccessKind.Read)]
        public SQLNET EvalReadAccessSQLNET()
        {
            return EvalSQLNET();
        }

        /// <summary>Eval the code or expression and return a SQLNET object value.</summary>
        /// <returns>The SQLNET object value from the evaluated code or expression.</returns>
        [SqlMethod(DataAccess = DataAccessKind.Read, SystemDataAccess = SystemDataAccessKind.Read)]
        public SQLNET evalreadaccesssqlnet()
        {
            return EvalReadAccessSQLNET();
        }

        /// <summary>Eval the code or expression and return a SQLNET object value.</summary>
        /// <returns>The SQLNET object value from the evaluated code or expression.</returns>
        [SqlMethod(DataAccess = DataAccessKind.Read, SystemDataAccess = SystemDataAccessKind.Read)]
        public SQLNET EVALREADACCESSSQLNET()
        {
            return EvalReadAccessSQLNET();
        }
    }
}