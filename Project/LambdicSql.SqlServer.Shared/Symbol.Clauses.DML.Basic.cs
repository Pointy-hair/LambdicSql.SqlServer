using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using LambdicSql.Specialized.SymbolConverters;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// SQL Symbol.
    /// It can only be used within methods of the LambdicSql.Db class.
    /// Use[using static LambdicSql.SqlServer.Symbol;], you can use to write natural SQL.
    /// </summary>
    public static partial class Symbol
    {
        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc"></typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="top">TOP keyword.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(TopElement top, T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, TopElement top, T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select(AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select<TSrc>(this Clause<TSrc> before, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select(TopElement top, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select<TSrc>(this Clause<TSrc> before, TopElement top, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(TopElement top, AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, TopElement top, AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(AggregatePredicateElement predicate, T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, AggregatePredicateElement predicate, T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(AggregatePredicateElement predicate, TopElement top, T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, AggregatePredicateElement predicate, TopElement top, T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select(AggregatePredicateElement predicate, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select<TSrc>(this Clause<TSrc> before, AggregatePredicateElement predicate, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(AggregatePredicateElement predicate, AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, AggregatePredicateElement predicate, AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select(AggregatePredicateElement predicate, TopElement top, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select<TSrc>(this Clause<TSrc> before, AggregatePredicateElement predicate, TopElement top, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(AggregatePredicateElement predicate, TopElement top, AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, AggregatePredicateElement predicate, TopElement top, AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// FROM clause.
        /// </summary>
        /// <param name="expressions">Table or subquery.</param>
        /// <returns>Clause.</returns>
        [FromConverter]
        public static Clause<Non> From(params object[] expressions) { throw new InvalitContextException(nameof(From)); }

        /// <summary>
        /// FROM clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="tables">Table or subquery.</param>
        /// <returns>Clause.</returns>
        [FromConverter]
        public static Clause<T> From<T>(this Clause<T> before, params object[] tables) { throw new InvalitContextException(nameof(From)); }

        /// <summary>
        /// JOIN clause.
        /// </summary>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "JOIN")]
        public static Clause<Non> Join(object table, bool condition) { throw new InvalitContextException(nameof(Join)); }

        /// <summary>
        /// JOIN clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "JOIN")]
        public static Clause<T> Join<T>(this Clause<T> before, object table, bool condition) { throw new InvalitContextException(nameof(Join)); }

        /// <summary>
        /// JOIN clause.
        /// </summary>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of LEFT JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "LEFT JOIN")]
        public static Clause<Non> LeftJoin(object table, bool condition) { throw new InvalitContextException(nameof(LeftJoin)); }

        /// <summary>
        /// LEFT JOIN clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of LEFT JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "LEFT JOIN")]
        public static Clause<T> LeftJoin<T>(this Clause<T> before, object table, bool condition) { throw new InvalitContextException(nameof(LeftJoin)); }

        /// <summary>
        /// RIGHT JOIN clause.
        /// </summary>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of RIGHT JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "RIGHT JOIN")]
        public static Clause<Non> RightJoin(object table, bool condition) { throw new InvalitContextException(nameof(RightJoin)); }

        /// <summary>
        /// RIGHT JOIN clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table or subquery.</param>>
        /// <param name="condition">It is a condition of RIGHT JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "RIGHT JOIN")]
        public static Clause<T> RightJoin<T>(this Clause<T> before, object table, bool condition) { throw new InvalitContextException(nameof(RightJoin)); }

        /// <summary>
        /// FULL JOIN clause.
        /// </summary>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of RIGHT JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "FULL JOIN")]
        public static Clause<Non> FullJoin(object table, bool condition) { throw new InvalitContextException(nameof(FullJoin)); }

        /// <summary>
        /// FULL JOIN clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table or subquery.</param>>
        /// <param name="condition">It is a condition of RIGHT JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "FULL JOIN")]
        public static Clause<T> FullJoin<T>(this Clause<T> before, object table, bool condition) { throw new InvalitContextException(nameof(FullJoin)); }

        /// <summary>
        /// CROSS JOIN clause.
        /// </summary>
        /// <param name="expression">Table or subquery.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "CROSS JOIN")]
        public static Clause<Non> CrossJoin(object expression) { throw new InvalitContextException(nameof(CrossJoin)); }

        /// <summary>
        /// CROSS JOIN clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table or subquery.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "CROSS JOIN")]
        public static Clause<T> CrossJoin<T>(this Clause<T> before, object table) { throw new InvalitContextException(nameof(CrossJoin)); }

        /// <summary>
        /// WHERE clause.
        /// </summary>
        /// <param name="condition">It is a conditional expression of WHERE.</param>
        /// <returns>Clause.</returns>
        [ConditionClauseConverter(Name = "WHERE")]
        public static Clause<Non> Where(bool condition) { throw new InvalitContextException(nameof(Where)); }

        /// <summary>
        /// WHERE clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="condition">It is a conditional expression of WHERE.</param>
        /// <returns>Clause.</returns>
        [ConditionClauseConverter(Name = "WHERE")]
        public static Clause<T> Where<T>(this Clause<T> before, bool condition) { throw new InvalitContextException(nameof(Where)); }

        /// <summary>
        /// GROUP BY clause.
        /// </summary>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "GROUP BY")]
        public static Clause<Non> GroupBy(params object[] columns) { throw new InvalitContextException(nameof(GroupBy)); }

        /// <summary>
        /// GROUP BY clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "GROUP BY")]
        public static Clause<T> GroupBy<T>(this Clause<T> before, params object[] columns) { throw new InvalitContextException(nameof(GroupBy)); }

        /// <summary>
        /// GROUP BY ROLLUP clause.
        /// </summary>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "GROUP BY ROLLUP")]
        public static Clause<Non> GroupByRollup(params object[] columns) { throw new InvalitContextException(nameof(GroupByRollup)); }

        /// <summary>
        /// GROUP BY ROLLUP clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "GROUP BY ROLLUP")]
        public static Clause<T> GroupByRollup<T>(this Clause<T> before, params object[] columns) { throw new InvalitContextException(nameof(GroupByRollup)); }

        /// <summary>
        /// GROUP BY CUBE clause.
        /// </summary>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "GROUP BY CUBE")]
        public static Clause<Non> GroupByCube(params object[] columns) { throw new InvalitContextException(nameof(GroupByCube)); }

        /// <summary>
        /// GROUP BY CUBE clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "GROUP BY CUBE")]
        public static Clause<T> GroupByCube<T>(this Clause<T> before, params object[] columns) { throw new InvalitContextException(nameof(GroupByCube)); }

        /// <summary>
        /// GROUP BY GROUPING SETS clause.
        /// </summary>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "GROUP BY GROUPING SETS")]
        public static Clause<Non> GroupByGroupingSets(params object[] columns) { throw new InvalitContextException(nameof(GroupByGroupingSets)); }

        /// <summary>
        /// GROUP BY GROUPING SETS clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "GROUP BY GROUPING SETS")]
        public static Clause<T> GroupByGroupingSets<T>(this Clause<T> before, params object[] columns) { throw new InvalitContextException(nameof(GroupByGroupingSets)); }

        /// <summary>
        /// HAVING clause.
        /// </summary>
        /// <param name="condition">It is a conditional expression of HAVING.</param>
        /// <returns>Clause.</returns>
        [ConditionClauseConverter(Name = "HAVING")]
        public static Clause<Non> Having(bool condition) { throw new InvalitContextException(nameof(Having)); }

        /// <summary>
        /// HAVING clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="condition">It is a conditional expression of HAVING.</param>
        /// <returns>Clause.</returns>
        [ConditionClauseConverter(Name = "HAVING")]
        public static Clause<T> Having<T>(this Clause<T> before, bool condition) { throw new InvalitContextException(nameof(Having)); }

        /// <summary>
        /// ORDER BY clause.
        /// </summary>
        /// <param name="elements">Specify column and sort order. Asc(column) or Desc(column).</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "ORDER BY |[<, >0]", FormatDirection = FormatDirection.Vertical, VanishIfEmptyParams = true)]
        public static Clause<OverElement> OrderBy(params OrderByElement[] elements) { throw new InvalitContextException(nameof(OrderBy)); }

        /// <summary>
        /// ORDER BY clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="elements">Specify column and sort order. Asc(column) or Desc(column).</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "ORDER BY |[<, >1]", FormatDirection = FormatDirection.Vertical, VanishIfEmptyParams = true)]
        public static Clause<T> OrderBy<T>(this Clause<T> before, params OrderByElement[] elements) { throw new InvalitContextException(nameof(OrderBy)); }

        /// <summary>
        /// OFFSET count ROWS clause.
        /// </summary>
        /// <param name="count">Number of rows to acquire.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "OFFSET |[0] ROWS")]
        public static Clause<Non> OffsetRows(object count) { throw new InvalitContextException(nameof(OffsetRows)); }

        /// <summary>
        /// OFFSET count ROWS clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="count">Number of rows to acquire.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "OFFSET |[1] ROWS")]
        public static Clause<T> OffsetRows<T>(this Clause<T> before, object count) { throw new InvalitContextException(nameof(OffsetRows)); }

        /// <summary>
        /// FETCH NEXT count ROWS ONLY clause.
        /// </summary>
        /// <param name="count">Number of rows to acquire.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "FETCH NEXT |[0] ROWS ONLY")]
        public static Clause<Non> FetchNextRowsOnly(object count) { throw new InvalitContextException(nameof(FetchNextRowsOnly)); }

        /// <summary>
        /// FETCH NEXT count ROWS ONLY clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="count">Number of rows to acquire.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "FETCH NEXT |[1] ROWS ONLY")]
        public static Clause<T> FetchNextRowsOnly<T>(this Clause<T> before, object count) { throw new InvalitContextException(nameof(FetchNextRowsOnly)); }

        /// <summary>
        /// UNION clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Union() { throw new InvalitContextException(nameof(Union)); }

        /// <summary>
        /// UNION clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Union<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Union)); }

        /// <summary>
        /// UNION clause.
        /// </summary>
        /// <param name="all">If isAll is true, add an ALL predicate.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Union(AggregatePredicateAllElement all) { throw new InvalitContextException(nameof(Union)); }

        /// <summary>
        /// UNION clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="all">If isAll is true, add an ALL predicate.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Union<T>(this Clause<T> before, AggregatePredicateAllElement all) { throw new InvalitContextException(nameof(Union)); }

        /// <summary>
        /// INTERSECT clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Intersect() { throw new InvalitContextException(nameof(Intersect)); }

        /// <summary>
        /// INTERSECT clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Intersect<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Intersect)); }

        /// <summary>
        /// INTERSECT clause.
        /// </summary>
        /// <param name="all">If isAll is true, add an ALL predicate.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Intersect(AggregatePredicateAllElement all) { throw new InvalitContextException(nameof(Intersect)); }

        /// <summary>
        /// INTERSECT clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="all">If isAll is true, add an ALL predicate.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Intersect<T>(this Clause<T> before, AggregatePredicateAllElement all) { throw new InvalitContextException(nameof(Intersect)); }

        /// <summary>
        /// EXCEPT clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Except() { throw new InvalitContextException(nameof(Except)); }

        /// <summary>
        /// EXCEPT clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Except<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Except)); }

        /// <summary>
        /// EXCEPT clause.
        /// </summary>
        /// <param name="all">If isAll is true, add an ALL predicate.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Except(AggregatePredicateAllElement all) { throw new InvalitContextException(nameof(Except)); }

        /// <summary>
        /// EXCEPT clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="all">If isAll is true, add an ALL predicate.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Except<T>(this Clause<T> before, AggregatePredicateAllElement all) { throw new InvalitContextException(nameof(Except)); }

        /// <summary>
        /// MINUS clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Minus() { throw new InvalitContextException(nameof(Minus)); }

        /// <summary>
        /// MINUS clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Minus<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Minus)); }

        /// <summary>
        /// UPDATE clause.
        /// </summary>
        /// <param name="table">Table for UPDATE.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Update(object table) { throw new InvalitContextException(nameof(Update)); }

        /// <summary>
        /// SET clause.
        /// </summary>
        /// <param name="assigns">Assignment in the SET clause.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "SET |[<,>0]", FormatDirection = FormatDirection.Vertical)]
        public static Clause<Non> Set(params Assign[] assigns) { throw new InvalitContextException(nameof(Set)); }

        /// <summary>
        /// SET clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="assigns">Assignment in the SET clause.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "SET |[<,>1]", FormatDirection = FormatDirection.Vertical)]
        public static Clause<T> Set<T>(this Clause<T> before, params Assign[] assigns) { throw new InvalitContextException(nameof(Set)); }

        /// <summary>
        /// DELETE clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Delete() { throw new InvalitContextException(nameof(Delete)); }

        /// <summary>
        /// INSERT INTO clause.
        /// </summary>
        /// <param name="table">Table for INSERT.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "INSERT INTO")]
        public static Clause<Non> InsertInto(object table) { throw new InvalitContextException(nameof(InsertInto)); }

        /// <summary>
        /// INSERT INTO clause.
        /// </summary>
        /// <param name="table">Table for INSERT.</param>
        /// <param name="columns">It is a column that performs INSERT.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "INSERT INTO [0](|[#<, >1])")]
        public static Clause<Non> InsertInto(object table, params object[] columns) { throw new InvalitContextException(nameof(InsertInto)); }

        /// <summary>
        /// INSERT INTO clause.
        /// </summary>
        /// <param name="values">It is the value to be Inserted.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Indent = 1)]
        public static Clause<Non> Values(params object[] values) { throw new InvalitContextException(nameof(Values)); }

        /// <summary>
        /// INSERT INTO clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="values">It is the value to be Inserted.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Indent = 1)]
        public static Clause<T> Values<T>(this Clause<T> before, params object[] values) { throw new InvalitContextException(nameof(Values)); }

        /// <summary>
        /// LIKE keyword.
        /// </summary>
        /// <param name="target">Target text.</param>
        /// <param name="pattern">Text that represents pattern matching.</param>
        /// <returns>If target matches the specified pattern, LIKE returns TRUE.</returns>
        [MethodFormatConverter(Format = "[0] LIKE |[1]")]
        public static bool Like(object target, object pattern) { throw new InvalitContextException(nameof(Like)); }

        /// <summary>
        /// BETWEEN keyword.
        /// </summary>
        /// <param name="target">Target of range check.</param>
        /// <param name="min">Minimum value.</param>
        /// <param name="max">Maxmum value.</param>
        /// <returns>Returns TRUE if target is included in the range of min and max.</returns>
        [MethodFormatConverter(Format = "[0] BETWEEN |[1] AND [2]")]
        public static bool Between(object target, object min, object max) { throw new InvalitContextException(nameof(Between)); }

        /// <summary>
        /// IN keyword.
        /// </summary>
        /// <param name="target">Target of IN check.</param>
        /// <param name="canditates">Canditates.</param>
        /// <returns>Returns TRUE if target is included in the canditates represented by expression.</returns>
        [MethodFormatConverter(Format = "[0] IN(|[<, >1])")]
        public static bool In<T>(T target, params T[] canditates) { throw new InvalitContextException(nameof(In)); }

        /// <summary>
        /// ALL Keyword
        /// </summary>
        /// <typeparam name="T">Retunn type.</typeparam>
        /// <param name="sub">Sub query.</param>
        /// <returns>Sub query's selected value.</returns>
        [AllConverter]
        public static T All<T>(Clause<T> sub) { throw new InvalitContextException(nameof(All)); }

        /// <summary>
        /// ALL Keyword
        /// </summary>
        /// <typeparam name="T">Retunn type.</typeparam>
        /// <param name="sub">Sub query.</param>
        /// <returns>Sub query's selected value.</returns>
        [AllConverter]
        public static T All<T>(Sql<T> sub) { throw new InvalitContextException(nameof(All)); }

        /// <summary>
        /// EXISTS keyword.
        /// </summary>
        /// <param name="expression">Sub query.</param>
        /// <returns>Returns TRUE if there is at least one record returned by expression, FALSE otherwise.</returns>
        [ClauseStyleConverter]
        public static bool Exists(object expression) { throw new InvalitContextException(nameof(Exists)); }

        /// <summary>
        /// IS NULL clause.
        /// </summary>
        /// <param name="target"></param>
        /// <returns>IS NULL</returns>
        [MethodFormatConverter(Format = "[0] IS NULL|")]
        public static bool IsNull(object target) { throw new InvalitContextException(nameof(IsNull)); }

        /// <summary>
        /// IS NOT NULL clause.
        /// </summary>
        /// <param name="target">target.</param>
        /// <returns>IS NOT NULL</returns>
        [MethodFormatConverter(Format = "[0] IS NOT NULL|")]
        public static bool IsNotNull(object target) { throw new InvalitContextException(nameof(IsNull)); }

        //TODO test.
        /// <summary>
        /// WITH clause.
        /// </summary>
        /// <param name="subQuerys">sub querys.</param>
        /// <returns></returns>
        [WithConverter]
        public static Clause<Non> With(params Sql[] subQuerys) { throw new InvalitContextException(nameof(With)); }

        /// <summary>
        /// WITH clause.
        /// </summary>
        /// <typeparam name="T">Type representing argument of recursive part.</typeparam>
        /// <param name="args">Argument of recursive part.</param>
        /// <param name="subQuery">sub query.</param>
        /// <returns>Clause.</returns>
        [WithConverter]
        public static Clause<T> With<T>(SqlRecursiveArguments<T> args, Sql subQuery) { throw new InvalitContextException(nameof(With)); }

        /// <summary>
        /// RECURSIVE clause.
        /// </summary>
        /// <typeparam name="T">Type representing argument of recursive part.</typeparam>
        /// <param name="args">Argument of recursive part.</param>
        /// <returns>Class representing argument of recursive part.</returns>
        [RecursiveConverter]
        public static RecursiveArguments<T> Recursive<T>(T args) { throw new InvalitContextException(nameof(Recursive)); }

        /// <summary>
        /// ROWS.
        /// </summary>
        /// <param name="preceding">Preceding row count.</param>
        [MethodFormatConverter(Format = "ROWS [$0] PRECEDING")]
        public static OverElement Rows(long preceding) { throw new InvalitContextException(nameof(Rows)); }

        /// <summary>
        /// ROWS.
        /// </summary>
        /// <param name="preceding">Preceding row count.</param>
        /// <param name="following">Following row count.</param>
        [MethodFormatConverter(Format = "ROWS BETWEEN [$0] PRECEDING AND [$1] FOLLOWING")]
        public static OverElement Rows(long preceding, long following) { throw new InvalitContextException(nameof(Rows)); }

        /// <summary>
        /// PARTITION BY.
        /// </summary>
        /// <param name="columns">Specify column or expression.</param>
        [MethodFormatConverter(Format = "PARTITION BY|[<,>0]", FormatDirection = FormatDirection.Vertical)]
        public static OverElement PartitionBy(params object[] columns) { throw new InvalitContextException(nameof(PartitionBy)); }

        /// <summary>
        /// OVER
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "OVER(|[< >1])", FormatDirection = FormatDirection.Vertical)]
        public static T Over<T>(this T before, params OverElement[] args) { throw new InvalitContextException(nameof(Over)); }

        /// <summary>
        /// OVER
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "OVER(|[< >0])", FormatDirection = FormatDirection.Vertical)]
        public static OverReturnValue Over(params OverElement[] args) { throw new InvalitContextException(nameof(Over)); }

        /// <summary>
        /// COALESCE function.
        /// </summary>
        /// <typeparam name="T">Type of parameter</typeparam>
        /// <param name="parameter">Parameter.</param>
        /// <returns>The first non-null value in the parameter.</returns>
        [MethodFormatConverter(Format = "COALESCE(|[<, >0])")]
        public static T Coalesce<T>(params T[] parameter) { throw new InvalitContextException(nameof(Coalesce)); }


        /*
         * https://msdn.microsoft.com/en-us/library/ff848766.aspx
        Aliasing (Azure SQL Data Warehouse, Parallel Data Warehouse)
        BULK INSERT
        EXPLAIN
        Hints
        MERGE
        OPTION Clause
        OUTPUT Clause
        READTEXT
        Search Condition
        Subqueries (Azure SQL Data Warehouse, Parallel Data Warehouse)
        Table Value Constructor
        UPDATETEXT
        WRITETEXT
        */

        //https://msdn.microsoft.com/en-us/library/ms188332.aspx
        //Execute
    }
}


//--------------Confirmation------------------
//https://msdn.microsoft.com/en-us/library/ms189523.aspx
/*
Predicates
CONTAINS
FREETEXT
IS NULL*/

/*https://msdn.microsoft.com/en-us/library/ff848807.aspx
    Language Elements
    -- (Comment)
    Slash Star Comment
    CREATE DIAGNOSTICS SESSION
    NULL and UNKNOWN
    Transactions
    USE
     */

//https://msdn.microsoft.com/en-us/library/ms174986.aspx
/*
Operators
Arithmetic Operators
Assignment Operator
Bitwise Operators
Comparison Operators
Compound Operators
Logical Operators
Scope Resolution Operator
Set Operators
String Operators
Unary Operators
Operator Precedence*/

//https://msdn.microsoft.com/en-us/library/dbba47d7-e08e-4435-b876-35dced1f325d
/*
 * System Views
Catalog Views
Compatibility Views
Data-tier Application Views
Dynamic Management Views and Functions
Information Schema Views
Querying the SQL Server System Catalog FAQ
Metadata Access, Isolation Levels, and Lock Hints*/
