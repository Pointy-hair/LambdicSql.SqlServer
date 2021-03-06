﻿using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    //TODO add abstract to name.
    /// <summary>
    /// TOP keyword.
    /// </summary>
    public abstract class TopBase { }

    /// <summary>
    /// Data type.
    /// </summary>
    public abstract class DataTypeBase { }

    /// <summary>
    /// It's *.
    /// Used in Select clause and Count function.
    /// </summary>
    public abstract class AsteriskBase { }

    /// <summary>
    /// It's *.
    /// Used in Select clause and Count function.
    /// </summary>
    /// <typeparam name="T">It represents the type to select when used in the Select clause.</typeparam>
    public abstract class AsteriskBase<T> : AsteriskBase { }

    /// <summary>
    /// It is an object representing the sort order
    /// Implemented classes include Asc and Desc.
    /// </summary>
    public abstract class OrderByElementBase { }

    /// <summary>
    /// Aggregation predicate.
    /// ALL or DISTINCT.
    /// </summary>
    public abstract class AggregatePredicateBase { }

    /// <summary>
    /// Aggregation predicate.
    /// ALL
    /// </summary>
    public abstract class AggregatePredicateAllBase : AggregatePredicateBase { }

    /// <summary>
    /// OVER clause argument.
    /// </summary>
    public abstract class OverElementBase { }

    /// <summary>
    /// OVER clause result.
    /// </summary>
    public abstract class OverReturnValueBase : SqlExpression
    {
        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static object operator +(object value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static string operator +(string value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static bool operator +(bool value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static bool? operator +(bool? value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static byte operator +(byte value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static byte? operator +(byte? value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static short operator +(short value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static short? operator +(short? value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static int operator +(int value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static int? operator +(int? value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static long operator +(long value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static long? operator +(long? value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static float operator +(float value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static float? operator +(float? value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static double operator +(double value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static double? operator +(double? value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static decimal operator +(decimal value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static decimal? operator +(decimal? value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static DateTime operator +(DateTime value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static DateTime? operator +(DateTime? value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static DateTimeOffset operator +(DateTimeOffset value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static DateTimeOffset? operator +(DateTimeOffset? value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static TimeSpan operator +(TimeSpan value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static TimeSpan? operator +(TimeSpan? value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static byte[] operator +(byte[] value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static char[] operator +(char[] value, OverReturnValueBase returnValue) { throw new InvalitContextException("additional operator"); }
    }

    /// <summary>
    /// Table definition item.
    /// </summary>
    public abstract class TableDefinitionBase { }

    /// <summary>
    /// Constraint object.
    /// </summary>
    public abstract class ConstraintBase : TableDefinitionBase { }

    /// <summary>
    /// Column definition.
    /// It can only be used within lambda of the LambdicSql.
    /// </summary>
    public class Column : TableDefinitionBase
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="column">Column.</param>
        /// <param name="type">Type.</param>
        [NewFormatConverter(Format = "[0] [1]")]
        public Column(object column, DataTypeBase type) { throw new InvalitContextException("new " + nameof(Column)); }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="column">Column.</param>
        /// <param name="type">Type.</param>
        /// <param name="constraints">Constraints.</param>
        [NewFormatConverter(Format = "[0] [1] [< >2]")]
        public Column(object column, DataTypeBase type, params ConstraintBase[] constraints) { throw new InvalitContextException("new " + nameof(Column)); }
    }

    /// <summary>
    /// It represents assignment. It is used in the Set clause.
    /// new Assign(db.tbl_staff.name, name) -> tbl_staff.name = "@name"
    /// It can only be used within lambda of the LambdicSql.
    /// </summary>
    public class Assign
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="rhs">Rvalue</param>
        /// <param name="lhs">Lvalue</param>
        [NewFormatConverter(Format = "[#0] = [1]")]
        public Assign(object rhs, object lhs) { throw new InvalitContextException("new " + nameof(Assign)); }
    }

    /// <summary>
    /// ExpandArguments's result value.
    /// </summary>
    public abstract class ArgumentsExpandedObjectBase { }

    /// <summary>
    /// The type of the element in the WITH clause of BULKINSERT.
    /// </summary>
    public abstract class BulkInsertWithElementBase { }

    /// <summary>
    /// DELAYED_DURABILITY's result value.展開するパラメータのインデックス
    /// </summary>
    public abstract class DelayedDurabilityBase { }

    /// <summary>
    /// Object when targeting non-table with CREATE TRIGGER.
    /// </summary>
    public abstract class TriggerTargetBase { }

    /// <summary>
    /// DDL trigger option.
    /// </summary>
    public abstract class DDLTriggerOptionBase { }

    /// <summary>
    /// Query hint.
    /// </summary>
    public abstract class QueryHintBase { }

    /// <summary>
    /// Table hint.
    /// </summary>
    public abstract class TableHintBase
    {
        /// <summary>
        /// cast from ConstraintBase at implicit.
        /// </summary>
        /// <param name="src"></param>
        public static implicit operator TableHintBase(ConstraintBase src) => throw new InvalitContextException("operator TableHintBase");

        /// <summary>
        /// cast from Clause&lt;ConstraintBase&gt; at implicit.
        /// </summary>
        /// <param name="src"></param>
        public static implicit operator TableHintBase(Clause<ConstraintBase> src) => throw new InvalitContextException("operator TableHintBase");

        /// <summary>
        /// cast from BulkInsertWithElementBase at implicit.
        /// </summary>
        /// <param name="src"></param>
        public static implicit operator TableHintBase(BulkInsertWithElementBase src) => throw new InvalitContextException("operator TableHintBase");

        /// <summary>
        /// cast from (Clause&lt;BulkInsertWithElementBase&gt; at implicit.
        /// </summary>
        /// <param name="src"></param>
        public static implicit operator TableHintBase(Clause<BulkInsertWithElementBase> src) => throw new InvalitContextException("operator TableHintBase");
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-aggregate-transact-sql
    /// </summary>
    public class AggregateArgument
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="variable"></param>
        /// <param name="type"></param>
        [NewFormatConverter(Format = "[!0] [1]")]
        public AggregateArgument(string variable, DataTypeBase type) => throw new InvalitContextException(nameof(AggregateArgument));
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-application-role-transact-sql
    /// </summary>
    public abstract class CreateApplicationRoleBase { }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-assembly-transact-sql
    /// </summary>
    public abstract class CreateAssemblyBase { }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-assembly-transact-sql
    /// </summary>
    [EnumToStringConverter]
    public enum PermissionSetElement
    {
        /// <summary>
        /// 
        /// </summary>
        Safe,

        /// <summary>
        /// 
        /// </summary>
        External_Access,

        /// <summary>
        /// 
        /// </summary>
        Unsafe
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
    /// </summary>
    public abstract class AsymKeySourceBase { }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
    /// </summary>
    public abstract class KeyOptionBase { }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
    /// </summary>
    [EnumToStringConverter]
    public enum AlgorithmElement
    {
        /// <summary>
        /// 
        /// </summary>
        RSA_4096,

        /// <summary>
        /// 
        /// </summary>
        RSA_3072,

        /// <summary>
        /// 
        /// </summary>
        RSA_2048,

        /// <summary>
        /// 
        /// </summary>
        RSA_1024,

        /// <summary>
        /// 
        /// </summary>
        RSA_512
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
    /// </summary>
    [EnumToStringConverter]
    public enum CreationDispositionElement
    {
        /// <summary>
        /// 
        /// </summary>
        Create_New,

        /// <summary>
        /// 
        /// </summary>
        Open_Existing
    }


    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-availability-group-transact-sql
    /// </summary>
    public abstract class WithOptionSpecBase { }


    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-availability-group-transact-sql
    /// </summary>
    [EnumToStringConverter]
    public enum AutomatedBackupPreferenceElement
    {
        /// <summary>
        /// PRIMARY 
        /// </summary>
        Primary,

        /// <summary>
        /// SECONDARY_ONLY
        /// </summary>
        Secondary_Only,

        /// <summary>
        /// SECONDARY 
        /// </summary>
        Secondary,

        /// <summary>
        /// NONE 
        /// </summary>
        None
    }


    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-availability-group-transact-sql
    /// </summary>
    [EnumToStringConverter]
    public enum OnOff
    {
        /// <summary>
        /// ON
        /// </summary>
        On,

        /// <summary>
        /// OFF
        /// </summary>
        Off
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-availability-group-transact-sql
    /// </summary>
    [EnumToStringConverter]
    public enum DtcSupportElement
    {
        /// <summary>
        /// PER_DB 
        /// </summary>
        Per_DB,

        /// <summary>
        /// NONE 
        /// </summary>
        None,
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-availability-group-transact-sql
    /// </summary>
    [EnumToStringConverter]
    public enum ClusterTypeElement
    {
        /// <summary>
        /// WSFC 
        /// </summary>
        Wsfc,

        /// <summary>
        /// EXTERNAL 
        /// </summary>
        External,

        /// <summary>
        /// NONE 
        /// </summary>
        None,
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-availability-group-transact-sql
    /// </summary>
    public abstract class AddReplicaOptionBase { }


    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-availability-group-transact-sql
    /// </summary>
    public abstract class AddReplicaSpecBase { }

    /// <summary>
    /// add_availability_group_spec
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-availability-group-transact-sql
    /// </summary>
    public abstract class AddAvailabilityGroupSpecBase
    {
        /// <summary>
        /// cast from AddReplicaSpecBase at implicit.
        /// </summary>
        /// <param name="src"></param>
        public static implicit operator AddAvailabilityGroupSpecBase(AddReplicaSpecBase src) => throw new InvalitContextException("operator AddAvailabilityGroupSpecBase");
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-availability-group-transact-sql
    /// </summary>
    public abstract class ListenerOptionBase { }


    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-availability-group-transact-sql
    /// </summary>
    [EnumToStringConverter]
    public enum AvailabilityModeElement
    {
        /// <summary>
        /// SYNCHRONOUS_COMMIT 
        /// </summary>
        Synchronous_Commit,

        /// <summary>
        /// ASYNCHRONOUS_COMMIT
        /// </summary>
        Asynchronous_Commit
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-availability-group-transact-sql
    /// </summary>
    [EnumToStringConverter]
    public enum OperationMode
    {
        /// <summary>
        /// 
        /// </summary>
        Automatic,

        /// <summary>
        /// 
        /// </summary>
        Manual,
    }
    
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-availability-group-transact-sql
    /// </summary>
    public abstract class RoleBase { }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-availability-group-transact-sql
    /// </summary>
    [EnumToStringConverter]
    public enum AllowConnectionsElement
    {
        /// <summary>
        /// 
        /// </summary>
        Non,

        /// <summary>
        /// 
        /// </summary>
        Read_Only,

        /// <summary>
        /// 
        /// </summary>
        All
    }
}
