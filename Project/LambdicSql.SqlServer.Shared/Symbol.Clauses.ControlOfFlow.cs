﻿using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

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
        /// CASE clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Case() { throw new InvalitContextException(nameof(Case)); }

        /// <summary>
        /// CASE clause.
        /// </summary>
        /// <param name="target">It's target of CASE branch.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Case(object target) { throw new InvalitContextException(nameof(Case)); }

        /// <summary>
        /// CASE clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Case<T>() { throw new InvalitContextException(nameof(Case)); }

        /// <summary>
        /// CASE clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="target">It's target of CASE branch.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Case<T>(object target) { throw new InvalitContextException(nameof(Case)); }
        
        /// <summary>
        /// WHEN clause.
        /// </summary>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="expression">It is a conditional expression of the WHEN clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<Non> When(this Clause<Non> before, object expression) { throw new InvalitContextException(nameof(When)); }

        /// <summary>
        /// WHEN clause.
        /// </summary>
        /// <param name="expression">It is a conditional expression of the WHEN clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<Non> When(object expression) { throw new InvalitContextException(nameof(When)); }

        /// <summary>
        /// WHEN clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="expression">It is a conditional expression of the WHEN clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<T> When<T>(this Clause<T> before, object expression) { throw new InvalitContextException(nameof(When)); }

        /// <summary>
        /// THEN clause's value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface IThenValue<T> { }

        /// <summary>
        /// THEN clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="result">It is an item to return to when the THEN clause is valid.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<IThenValue<T>> Then<T>(this Clause<Non> before, T result) { throw new InvalitContextException(nameof(Then)); }

        /// <summary>
        /// THEN clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="result">It is an item to return to when the THEN clause is valid.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<IThenValue<T>> Then<T>(T result) { throw new InvalitContextException(nameof(Then)); }

        /// <summary>
        /// THEN clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="result">It is an item to return to when the THEN clause is valid.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<IThenValue<T>> Then<T>(this Clause<T> before, T result) { throw new InvalitContextException(nameof(Then)); }

        /// <summary>
        /// THEN clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="result">It is an item to return to when the THEN clause is valid.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<IThenValue<T>> Then<T>(this Clause<IThenValue<T>> before, T result) { throw new InvalitContextException(nameof(Then)); }

        /// <summary>
        /// ELSE clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="result">It is an item to return to when the ELSE clause is valid.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<IThenValue<T>> Else<T>(this Clause<IThenValue<T>> before, T result) { throw new InvalitContextException(nameof(Then)); }

        /// <summary>
        /// ELSE clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="result">It is an item to return to when the ELSE clause is valid.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<T> Else<T>(T result) { throw new InvalitContextException(nameof(Then)); }

        /// <summary>
        /// END clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <returns>It is the result of CASE expression.</returns>
        [ClauseStyleConverter]
        public static T End<T>(this Clause<IThenValue<T>> before) { throw new InvalitContextException(nameof(End)); }

        /// <summary>
        /// END clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <returns>It is the result of CASE expression.</returns>
        [ClauseStyleConverter]
        public static Clause<T> End<T>(this Clause<T> before) { throw new InvalitContextException(nameof(End)); }

        /// <summary>
        /// END clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> End() { throw new InvalitContextException(nameof(End)); }
        
        /// <summary>
        /// IF clause.
        /// </summary>
        /// <param name="condition">condition.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> If(bool condition) { throw new InvalitContextException(nameof(If)); }

        /// <summary>
        /// IF clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="condition">condition.</param>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> If<T>(this Clause<T> before, bool condition) { throw new InvalitContextException(nameof(If)); }
        
        /// <summary>
        /// Else clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Else() { throw new InvalitContextException(nameof(Else)); }

        /// <summary>
        /// Else clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Else<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Else)); }

        /// <summary>
        /// BEGIN.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/begin-end-transact-sql
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Begin() { throw new InvalitContextException(nameof(Begin)); }

        /// <summary>
        /// BEGIN.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/begin-end-transact-sql
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Begin<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Begin)); }

        /// <summary>
        /// WHILE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/while-transact-sql
        /// </summary>
        /// <param name="condition">condition.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> While(bool condition) { throw new InvalitContextException(nameof(While)); }
        
        /// <summary>
        /// WHILE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/while-transact-sql
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="condition">condition.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> While<T>(this Clause<T> before, bool condition) { throw new InvalitContextException(nameof(While)); }
        
        /// <summary>
        /// BREAK.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/break-transact-sql
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Break() { throw new InvalitContextException(nameof(Break)); }

        /// <summary>
        /// BREAK.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/break-transact-sql
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Break<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Break)); }
        
        /// <summary>
        /// CONTINUE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/continue-transact-sql
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Continue() { throw new InvalitContextException(nameof(Continue)); }

        /// <summary>
        /// CONTINUE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/continue-transact-sql
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Continue<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Continue)); }

        /// <summary>
        /// :
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/goto-transact-sql
        /// </summary>
        /// <param name="name">name.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "[!0]:")]
        public static Clause<Non> Label(string name) { throw new InvalitContextException(nameof(Label)); }

        /// <summary>
        /// :
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/goto-transact-sql
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="name">name.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "[!1]:")]
        public static Clause<T> Label<T>(this Clause<T> before, string name) { throw new InvalitContextException(nameof(Label)); }
        
        /// <summary>
        /// GOTO.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/goto-transact-sql
        /// </summary>
        /// <param name="name">name.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "GOTO [!0]")]
        public static Clause<Non> GoTo(string name) { throw new InvalitContextException(nameof(GoTo)); }

        /// <summary>
        /// GOTO.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/goto-transact-sql
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="name">name.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "GOTO [!1]")]
        public static Clause<T> GoTo<T>(this Clause<T> before, string name) { throw new InvalitContextException(nameof(GoTo)); }
        
        /// <summary>
        /// RETURN.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/return-transact-sql
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Return() { throw new InvalitContextException(nameof(Return)); }

        /// <summary>
        /// RETURN.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/return-transact-sql
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Return<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Return)); }
        
        /// <summary>
        /// TRY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/try-catch-transact-sql
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Try() { throw new InvalitContextException(nameof(Try)); }

        /// <summary>
        /// TRY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/try-catch-transact-sql
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Try<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Try)); }
        
        /// <summary>
        /// CATCH.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/try-catch-transact-sql
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Catch() { throw new InvalitContextException(nameof(Catch)); }

        /// <summary>
        /// CATCH.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/try-catch-transact-sql
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Catch<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Catch)); }
        
        /// <summary>
        /// THROW.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/throw-transact-sql
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="message">message.</param>
        /// <param name="state">state.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Throw(int number, string message, byte state) { throw new InvalitContextException(nameof(Throw)); }

        /// <summary>
        /// THROW.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/throw-transact-sql
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="number">number.</param>
        /// <param name="message">message.</param>
        /// <param name="state">state.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Throw<T>(this Clause<T> before, int number, string message, byte state) { throw new InvalitContextException(nameof(Throw)); }
        
        /// <summary>
        /// WAITFOR DELAY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/waitfor-transact-sql
        /// </summary>
        /// <param name="time">time.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "WAITFOR DELAY")]
        public static Clause<Non> WaitForDelay(string time) { throw new InvalitContextException(nameof(WaitForDelay)); }

        /// <summary>
        /// WAITFOR DELAY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/waitfor-transact-sql
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="time">time.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "WAITFOR DELAY")]
        public static Clause<T> WaitForDelay<T>(this Clause<T> before, string time) { throw new InvalitContextException(nameof(WaitForDelay)); }
        
        /// <summary>
        /// WAITFOR TIME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/waitfor-transact-sql
        /// </summary>
        /// <param name="time">time.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "WAITFOR TIME")]
        public static Clause<Non> WaitForTime(string time) { throw new InvalitContextException(nameof(WaitForDelay)); }

        /// <summary>
        /// WAITFOR TIME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/waitfor-transact-sql
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="time">time.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "WAITFOR TIME")]
        public static Clause<T> WaitForTime<T>(this Clause<T> before, string time) { throw new InvalitContextException(nameof(WaitForDelay)); }
    }
}
