﻿using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// SQL Server provides the following groups of system functions.
    /// </summary>
    public partial class SysSymbol
    {
        //--------------------------
        //Always On Availability Groups Functions
        //--------------------------

        /// <summary>
        /// sys.fn_hadr_is_primary_replica
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-hadr-is-primary-replica-transact-sql
        /// </summary>
        /// <param name="dbname">db name</param>
        /// <returns>1 or 0.</returns>
        [FuncStyleConverter(Name = "sys.fn_hadr_is_primary_replica")]
        public int fn_hadr_is_primary_replica(string dbname) => throw new InvalitContextException(nameof(fn_hadr_is_primary_replica));

        /// <summary>
        /// sys.fn_hadr_backup_is_preferred_replica
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-hadr-backup-is-preferred-replica-transact-sql
        /// </summary>
        /// <param name="dbname">db name</param>
        /// <returns>1 or 0.</returns>
        [FuncStyleConverter(Name = "sys.fn_hadr_backup_is_preferred_replica")]
        public int fn_hadr_backup_is_preferred_replica(string dbname) => throw new InvalitContextException(nameof(fn_hadr_backup_is_preferred_replica));

        /// <summary>
        /// sys.fn_hadr_distributed_ag_replica 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-hadr-backup-is-preferred-replica-transact-sql
        /// </summary>
        /// <param name="lag_Id">Is the identifier of the distributed availability group. lag_Id is type uniqueidentifier.</param>
        /// <param name="replica_id">Is the identifier of a replica in the distributed availability group. replica_id is type uniqueidentifier.</param>
        /// <returns>Returns the following information.</returns>
        [FuncStyleConverter(Name = "sys.fn_hadr_backup_is_preferred_replica")]
        public object fn_hadr_distributed_ag_replica(string lag_Id, string replica_id) => throw new InvalitContextException(nameof(fn_hadr_distributed_ag_replica));

        /// <summary>
        /// sys.fn_hadr_distributed_ag_database_replica  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-hadr-distributed-ag-database-replica-transact-sql
        /// </summary>
        /// <param name="lag_Id">Is the identifier of the distributed availability group. lag_Id is type uniqueidentifier.</param>
        /// <param name="replica_id">Is the identifier of the database in a distributed availability group. database_id is type uniqueidentifier.</param>
        /// <returns>ID of the database in the local availability group.</returns>
        [FuncStyleConverter(Name = "sys.fn_hadr_distributed_ag_database_replica")]
        public object fn_hadr_distributed_ag_database_replica(string lag_Id, string replica_id) => throw new InvalitContextException(nameof(fn_hadr_distributed_ag_database_replica));

        //--------------------------
        //Change Data Capture Functions
        //--------------------------
        /// <summary>
        /// sys.fn_cdc_decrement_lsn
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-decrement-lsn-transact-sql
        /// </summary>
        /// <param name="lsn_value">LSN value. lsn_value is binary(10).</param>
        /// <returns>binary(10).</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_decrement_lsn")]
        public byte[] fn_cdc_decrement_lsn(byte[] lsn_value) => throw new InvalitContextException(nameof(fn_cdc_decrement_lsn));

        /// <summary>
        /// sys.fn_cdc_get_column_ordinal 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-decrement-lsn-transact-sql
        /// </summary>
        /// <param name="capture_instance">Is the name of the capture instance in which the specified column is identified as a captured column. capture_instance is sysname.</param>
        /// <param name="column_name">Is the column to report on. column_name is sysname.</param>
        /// <returns>int</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_decrement_lsn")]
        public int fn_cdc_get_column_ordinal(string capture_instance, string column_name) => throw new InvalitContextException(nameof(fn_cdc_get_column_ordinal));

        /// <summary>
        /// sys.fn_cdc_get_max_lsn 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-get-max-lsn-transact-sql
        /// </summary>
        /// <returns>binary(10)</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_get_max_lsn")]
        public byte[] fn_cdc_get_max_lsn() => throw new InvalitContextException(nameof(fn_cdc_get_max_lsn));

        /// <summary>
        /// sys.fn_cdc_get_min_lsn 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-get-min-lsn-transact-sql
        /// </summary>
        /// <param name="capture_instance_name">Is the name of the capture instance. capture_instance_name is sysname.</param>
        /// <returns>binary(10)</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_get_min_lsn")]
        public byte[] fn_cdc_get_min_lsn(string capture_instance_name) => throw new InvalitContextException(nameof(fn_cdc_get_min_lsn));

        /// <summary>
        /// sys.fn_cdc_has_column_changed 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-has-column-changed-transact-sql
        /// </summary>
        /// <param name="capture_instance">Is the name of the capture instance. capture_instance is sysname.</param>
        /// <param name="column_name">Is the captured column of the specified capture instance to report on. column_name is sysname.</param>
        /// <param name="update_mask">Is the mask identifying updated columns in any associated change row. update_mask is varbinary(128).</param>
        /// <returns>bit(An integer data type that can take a value of 1, 0, or NULL.)</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_has_column_changed")]
        public int? fn_cdc_has_column_changed(string capture_instance, string column_name, byte[] update_mask) => throw new InvalitContextException(nameof(fn_cdc_has_column_changed));

        /// <summary>
        /// sys.fn_cdc_increment_lsn 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-increment-lsn-transact-sql
        /// </summary>
        /// <param name="lsn_value ">LSN value. lsn_value is binary(10).</param>
        /// <returns>binary(10)</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_increment_lsn")]
        public byte[] fn_cdc_increment_lsn(byte[] lsn_value) => throw new InvalitContextException(nameof(fn_cdc_increment_lsn));

        /// <summary>
        /// sys.fn_cdc_is_bit_set  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-is-bit-set-transact-sql
        /// </summary>
        /// <param name="position">Is the ordinal position in the mask to check. position is int.</param>
        /// <param name="update_mask">Is the mask identifying updated columns. update_mask is varbinary(128).</param>
        /// <returns>bit</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_is_bit_set")]
        public int? fn_cdc_is_bit_set(int position, byte[] update_mask) => throw new InvalitContextException(nameof(fn_cdc_is_bit_set));

        /// <summary>
        /// sys.fn_cdc_map_lsn_to_time  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-map-lsn-to-time-transact-sql
        /// </summary>
        /// <param name="lsn_value">Is the LSN value to match against. lsn_value is binary(10).</param>
        /// <returns>datetime</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_map_lsn_to_time")]
        public DateTime fn_cdc_map_lsn_to_time(byte[] lsn_value) => throw new InvalitContextException(nameof(fn_cdc_map_lsn_to_time));

        /// <summary>
        /// sys.fn_cdc_map_time_to_lsn  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-map-time-to-lsn-transact-sql
        /// </summary>
        /// <param name="relational_operator">Is used to identify a distinct LSN value in within the cdc.lsn_time_mapping table with an associated tran_end_time that satisfies the relation when compared to the tracking_time value.</param>
        /// <param name="tracking_time">Is the datetime value to match against. tracking_time is datetime.</param>
        /// <returns>binary(10)</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_map_time_to_lsn")]
        public byte[] fn_cdc_map_time_to_lsn(string relational_operator, DateTime tracking_time) => throw new InvalitContextException(nameof(fn_cdc_map_time_to_lsn));

        /// <summary>
        /// sys.fn_all_changes_capture_instance  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-all-changes-capture-instance-transact-sql
        /// </summary>
        /// <param name="capture_instance_name">capture instance name.</param>
        /// <param name="start_time">The datetime value that represents the low endpoint of the range of change table entries to include in the result set.</param>
        /// <param name="end_time">The datetime value that represents the high endpoint of the range of change table entries to include in the result set.</param>
        /// <param name="row_filter_option">This parameter can take on one of two possible meanings depending on the value chosen for @closed_high_end_point when sys.sp_cdc_generate_wrapper_function is called to generate the create script for the wrapper function.</param>
        /// <returns>Type of destination</returns>
        [MethodFormatConverter(Format = "sys.fn_all_changes_[0]([1], [2], [3])")]
        public object fn_all_changes_capture_instance(string capture_instance_name, DateTime start_time, DateTime end_time, string row_filter_option) => throw new InvalitContextException(nameof(fn_all_changes_capture_instance));

        /// <summary>
        /// sys.fn_net_changes_capture_instance  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-net-changes-capture-instance-transact-sql
        /// </summary>
        /// <param name="capture_instance_name">capture instance name.</param>
        /// <param name="start_time">The datetime value that represents the low endpoint of the range of change table entries to include in the result set.</param>
        /// <param name="end_time">The datetime value that represents the high endpoint of the range of change table entries to include in the result set.</param>
        /// <param name="row_filter_option">This parameter can take on one of two meanings, depending on the value chosen for @closed_high_end_point when sys.sp_cdc_generate_wrapper_function is called to generate the script to create the wrapper function.</param>
        /// <returns>Table Returned</returns>
        [MethodFormatConverter(Format = "sys.fn_net_changes_[0]([1], [2], [3])")]
        public object fn_net_changes_capture_instance(string capture_instance_name, DateTime start_time, DateTime end_time, string row_filter_option) => throw new InvalitContextException(nameof(fn_net_changes_capture_instance));

        /// <summary>
        /// sys.fn_get_sql  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-get-sql-transact-sql
        /// </summary>
        /// <param name="SqlHandle">Is the handle value. SqlHandle is varbinary(64) with no default.</param>
        /// <returns>binary(10)</returns>
        [FuncStyleConverter(Name = "sys.fn_get_sql")]
        public object fn_get_sql(byte[] SqlHandle) => throw new InvalitContextException(nameof(fn_get_sql));

        /// <summary>
        /// sys.fn_MSxe_read_event_stream  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-msxe-read-event-stream-transact-sql
        /// </summary>
        /// <param name="session_name">The name of a session that is running on the server.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_MSxe_read_event_stream")]
        public object fn_MSxe_read_event_stream(string session_name) => throw new InvalitContextException(nameof(fn_MSxe_read_event_stream));

        /// <summary>
        /// sys.fn_stmt_sql_handle_from_sql_stmt  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-stmt-sql-handle-from-sql-stmt-transact-sql
        /// </summary>
        /// <param name="query_sql_text">Is the text of the query in the query store that you want the handle of.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_stmt_sql_handle_from_sql_stmt")]
        public object fn_stmt_sql_handle_from_sql_stmt(string query_sql_text) => throw new InvalitContextException(nameof(fn_stmt_sql_handle_from_sql_stmt));

        /// <summary>
        /// sys.fn_stmt_sql_handle_from_sql_stmt  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-stmt-sql-handle-from-sql-stmt-transact-sql
        /// </summary>
        /// <param name="query_sql_text">Is the text of the query in the query store that you want the handle of.</param>
        /// <param name="query_param_type">Is the parameter type of the query. query_param_type is a tinyint.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_stmt_sql_handle_from_sql_stmt")]
        public object fn_stmt_sql_handle_from_sql_stmt(string query_sql_text, byte? query_param_type) => throw new InvalitContextException(nameof(fn_stmt_sql_handle_from_sql_stmt));

        /// <summary>
        /// sys.fn_validate_plan_guide  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-validate-plan-guide-transact-sql
        /// </summary>
        /// <param name="plan_guide_id">Is the ID of the plan guide as reported in the sys.plan_guides catalog view. plan_guide_id is int with no default.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_validate_plan_guide")]
        public object fn_validate_plan_guide(int plan_guide_id) => throw new InvalitContextException(nameof(fn_validate_plan_guide));

        /// <summary>
        /// sys.fn_xe_file_target_read_file  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-xe-file-target-read-file-transact-sql
        /// </summary>
        /// <param name="path">The path to the files to read. path can contain wildcards and include the name of a file.</param>
        /// <param name="mdpath">The path to the metadata file that corresponds to the file or files specified by the path argument.</param>
        /// <param name="initial_file_name">The first file to read from path.</param>
        /// <param name="initial_offset">Used to specify last offset read previously and skips all events up to the offset (inclusive)..</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_xe_file_target_read_file")]
        public object fn_xe_file_target_read_file(string path, string mdpath, string initial_file_name, int? initial_offset) => throw new InvalitContextException(nameof(fn_xe_file_target_read_file));

        /// <summary>
        /// sys.fn_db_backup_file_snapshots  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-db-backup-file-snapshots-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_db_backup_file_snapshots")]
        public object fn_db_backup_file_snapshots() => throw new InvalitContextException(nameof(fn_db_backup_file_snapshots));

        /// <summary>
        /// sys.fn_db_backup_file_snapshots  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-db-backup-file-snapshots-transact-sql
        /// </summary>
        /// <param name="database_name">The name of the database being queried.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_db_backup_file_snapshots")]
        public object fn_db_backup_file_snapshots(string database_name) => throw new InvalitContextException(nameof(fn_db_backup_file_snapshots));

        //--------------------------
        //System Metadata Functions
        //--------------------------
        /// <summary>
        /// sys.fn_helpcollations  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-helpcollations-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_helpcollations")]
        public object fn_helpcollations() => throw new InvalitContextException(nameof(fn_helpcollations));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty() => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <param name="property_name">Is the name of the property.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty(object property_name) => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <param name="property_name">Is the name of the property.</param>
        /// <param name="level0_object_type">Is the user or user-defined type.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty(object property_name, object level0_object_type) => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <param name="property_name">Is the name of the property.</param>
        /// <param name="level0_object_type">Is the user or user-defined type.</param>
        /// <param name="level0_object_name">Is the name of the level 0 object type specified.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty(object property_name, object level0_object_type, object level0_object_name) => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <param name="property_name">Is the name of the property.</param>
        /// <param name="level0_object_type">Is the user or user-defined type.</param>
        /// <param name="level0_object_name">Is the name of the level 0 object type specified.</param>
        /// <param name="level1_object_type">Is the type of level 1 object.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty(object property_name, object level0_object_type, object level0_object_name, object level1_object_type) => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <param name="property_name">Is the name of the property.</param>
        /// <param name="level0_object_type">Is the user or user-defined type.</param>
        /// <param name="level0_object_name">Is the name of the level 0 object type specified.</param>
        /// <param name="level1_object_type">Is the type of level 1 object.</param>
        /// <param name="level1_object_name">Is the name of the level 1 object type specified.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty(object property_name, object level0_object_type, object level0_object_name, object level1_object_type, object level1_object_name) => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <param name="property_name">Is the name of the property.</param>
        /// <param name="level0_object_type">Is the user or user-defined type.</param>
        /// <param name="level0_object_name">Is the name of the level 0 object type specified.</param>
        /// <param name="level1_object_type">Is the type of level 1 object.</param>
        /// <param name="level1_object_name">Is the name of the level 1 object type specified.</param>
        /// <param name="level2_object_type">Is the type of level 2 object.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty(object property_name, object level0_object_type, object level0_object_name, object level1_object_type, object level1_object_name, object level2_object_type) => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <param name="property_name">Is the name of the property.</param>
        /// <param name="level0_object_type">Is the user or user-defined type.</param>
        /// <param name="level0_object_name">Is the name of the level 0 object type specified.</param>
        /// <param name="level1_object_type">Is the type of level 1 object.</param>
        /// <param name="level1_object_name">Is the name of the level 1 object type specified.</param>
        /// <param name="level2_object_type">Is the type of level 2 object.</param>
        /// <param name="level2_object_name">Is the name of the level 2 object type specified.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty(object property_name, object level0_object_type, object level0_object_name, object level1_object_type, object level1_object_name, object level2_object_type, object level2_object_name) => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_servershareddrives  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-servershareddrives-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_servershareddrives")]
        public object fn_servershareddrives() => throw new InvalitContextException(nameof(fn_servershareddrives));

        /// <summary>
        /// sys.fn_virtualfilestats  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-virtualfilestats-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_virtualfilestats")]
        public object fn_virtualfilestats() => throw new InvalitContextException(nameof(fn_virtualfilestats));

        /// <summary>
        /// sys.fn_virtualfilestats  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-virtualfilestats-transact-sql
        /// </summary>
        /// <param name="database_id">Is the ID of the database.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_virtualfilestats")]
        public object fn_virtualfilestats(int? database_id) => throw new InvalitContextException(nameof(fn_virtualfilestats));

        /// <summary>
        /// sys.fn_virtualfilestats  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-virtualfilestats-transact-sql
        /// </summary>
        /// <param name="database_id">Is the ID of the database.</param>
        /// <param name="file_id">Is the ID of the file.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_virtualfilestats")]
        public object fn_virtualfilestats(int? database_id, int? file_id) => throw new InvalitContextException(nameof(fn_virtualfilestats));

        /// <summary>
        /// sys.fn_virtualservernodes  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-virtualservernodes-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_virtualservernodes")]
        public object fn_virtualservernodes() => throw new InvalitContextException(nameof(fn_virtualservernodes));

        //--------------------------
        //System Security Functions
        //--------------------------
        /// <summary>
        /// sys.fn_builtin_permissions  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-builtin-permissions-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_builtin_permissions")]
        public object fn_builtin_permissions() => throw new InvalitContextException(nameof(fn_builtin_permissions));

        /// <summary>
        /// sys.fn_builtin_permissions  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-builtin-permissions-transact-sql
        /// </summary>
        /// <param name="default">When it is called with the DEFAULT option (without quotes), the function will return a complete list of built in permissions.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_builtin_permissions")]
        public object fn_builtin_permissions<T>(T @default) => throw new InvalitContextException(nameof(fn_builtin_permissions));

        /// <summary>
        /// sys.fn_builtin_permissions  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-builtin-permissions-transact-sql
        /// </summary>
        /// <param name="default">When it is called with the DEFAULT option (without quotes), the function will return a complete list of built in permissions.</param>
        /// <param name="empty_string">Equivalent to DEFAULT.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_builtin_permissions")]
        public object fn_builtin_permissions<T>(T @default, T empty_string) => throw new InvalitContextException(nameof(fn_builtin_permissions));

        /// <summary>
        /// sys.fn_builtin_permissions  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-builtin-permissions-transact-sql
        /// </summary>
        /// <param name="default">When it is called with the DEFAULT option (without quotes), the function will return a complete list of built in permissions.</param>
        /// <param name="empty_string">Equivalent to DEFAULT.</param>
        /// <param name="securable_class">When it is called with the name of one securable class, sys.fn_builtin_permissions will return all permissions that apply to the class.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_builtin_permissions")]
        public object fn_builtin_permissions<T>(T @default, T empty_string, string securable_class) => throw new InvalitContextException(nameof(fn_builtin_permissions));

        /// <summary>
        /// sys.fn_check_object_signatures  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-check-object-signatures-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_check_object_signatures")]
        public object fn_check_object_signatures() => throw new InvalitContextException(nameof(fn_check_object_signatures));

        /// <summary>
        /// sys.fn_check_object_signatures  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-check-object-signatures-transact-sql
        /// </summary>
        /// <param name="class">Identifies the type of thumbprint being provided.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_check_object_signatures")]
        public object fn_check_object_signatures(string @class) => throw new InvalitContextException(nameof(fn_check_object_signatures));

        /// <summary>
        /// sys.fn_check_object_signatures  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-check-object-signatures-transact-sql
        /// </summary>
        /// <param name="class">Identifies the type of thumbprint being provided.</param>
        /// <param name="thumbprint">SHA-1 hash of the certificate with which the key is encrypted, or the GUID of the asymmetric key with which the key is encrypted.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_check_object_signatures")]
        public object fn_check_object_signatures(string @class, string thumbprint) => throw new InvalitContextException(nameof(fn_check_object_signatures));

        /// <summary>
        /// sys.fn_get_audit_file  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-get-audit-file-transact-sql
        /// </summary>
        /// <param name="file_pattern">Specifies the directory or path and file name for the audit file set to be read.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_get_audit_file")]
        public object fn_get_audit_file(string file_pattern) => throw new InvalitContextException(nameof(fn_get_audit_file));

        /// <summary>
        /// sys.fn_get_audit_file  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-get-audit-file-transact-sql
        /// </summary>
        /// <param name="file_pattern">Specifies the directory or path and file name for the audit file set to be read.</param>
        /// <param name="initial_file_name">Specifies the path and name of a specific file in the audit file set to start reading audit records from.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_get_audit_file")]
        public object fn_get_audit_file(string file_pattern, string initial_file_name) => throw new InvalitContextException(nameof(fn_get_audit_file));

        /// <summary>
        /// sys.fn_get_audit_file  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-get-audit-file-transact-sql
        /// </summary>
        /// <param name="file_pattern">Specifies the directory or path and file name for the audit file set to be read.</param>
        /// <param name="initial_file_name">Specifies the path and name of a specific file in the audit file set to start reading audit records from.</param>
        /// <param name="audit_record_offset">Specifies a known location with the file specified for the initial_file_name.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_get_audit_file")]
        public object fn_get_audit_file(string file_pattern, string initial_file_name, string audit_record_offset) => throw new InvalitContextException(nameof(fn_get_audit_file));

        /// <summary>
        /// sys.fn_my_permissions  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-my-permissions-transact-sql
        /// </summary>
        /// <param name="securable">Is the name of the securable. If the securable is the server or a database, this value should be set to NULL.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_my_permissions")]
        public object fn_my_permissions(string securable) => throw new InvalitContextException(nameof(fn_my_permissions));

        //--------------------------
        //System Trace Functions
        //--------------------------
        /// <summary>
        /// sys.fn_trace_geteventinfo  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-trace-geteventinfo-transact-sql
        /// </summary>
        /// <param name="trace_id">Is the ID of the trace.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_trace_geteventinfo")]
        public object fn_trace_geteventinfo(int trace_id) => throw new InvalitContextException(nameof(fn_trace_geteventinfo));

        /// <summary>
        /// sys.fn_trace_getfilterinfo  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-trace-getfilterinfo-transact-sql
        /// </summary>
        /// <param name="trace_id">Is the ID of the trace.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_trace_getfilterinfo")]
        public object fn_trace_getfilterinfo(int trace_id) => throw new InvalitContextException(nameof(fn_trace_getfilterinfo));

        /// <summary>
        /// sys.fn_trace_getinfo  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-trace-getfilterinfo-transact-sql
        /// </summary>
        /// <param name="trace_id">Is the ID of the trace.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_trace_getinfo")]
        public object fn_trace_getinfo(object trace_id) => throw new InvalitContextException(nameof(fn_trace_getinfo));

        /// <summary>
        /// sys.fn_trace_gettable  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-trace-gettable-transact-sql
        /// </summary>
        /// <param name="filename">Specifies the initial trace file to be read.</param>
        /// <param name="number_files">Specifies the number of rollover files to be read.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_trace_gettable")]
        public object fn_trace_gettable(string filename, int? number_files) => throw new InvalitContextException(nameof(fn_trace_gettable));

        //--------------------------
        //Database Engine Stored Procedures
        //--------------------------
        /// <summary>
        /// sys.sp_flush_log  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-flush-log-transact-sql
        /// </summary>
        /// <returns>A return code of 1 indicates success. Any other value indicates failure</returns>
        [FuncStyleConverter(Name = "sys.sp_flush_log")]
        public int sp_flush_log() => throw new InvalitContextException(nameof(sp_flush_log));

        /// <summary>
        /// sys.sp_xtp_bind_db_resource_pool  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-xtp-bind-db-resource-pool-transact-sql
        /// </summary>
        /// <param name="database_name">The name of an existing In-Memory OLTP enabled database.</param>
        /// <param name="resource_pool_name">The name of an existing resource pool.</param>
        [FuncStyleConverter(Name = "sys.sp_xtp_bind_db_resource_pool")]
        public void sp_xtp_bind_db_resource_pool(string database_name, string resource_pool_name) => throw new InvalitContextException(nameof(sp_xtp_bind_db_resource_pool));

        /// <summary>
        /// sys.sp_xtp_checkpoint_force_garbage_collection  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-xtp-checkpoint-force-garbage-collection-transact-sql
        /// </summary>
        /// <returns>0 for success. Nonzero for failure.</returns>
        [FuncStyleConverter(Name = "sys.sp_xtp_checkpoint_force_garbage_collection")]
        public int sp_xtp_checkpoint_force_garbage_collection() => throw new InvalitContextException(nameof(sp_xtp_checkpoint_force_garbage_collection));

        /// <summary>
        /// sys.sp_xtp_checkpoint_force_garbage_collection  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-xtp-checkpoint-force-garbage-collection-transact-sql
        /// </summary>
        /// <param name="database_name">The database to run garbage collection on. The default is the current database.</param>
        /// <returns>0 for success. Nonzero for failure.</returns>
        [FuncStyleConverter(Name = "sys.sp_xtp_checkpoint_force_garbage_collection")]
        public int sp_xtp_checkpoint_force_garbage_collection(string database_name) => throw new InvalitContextException(nameof(sp_xtp_checkpoint_force_garbage_collection));

        /// <summary>
        /// sys.sp_xtp_control_proc_exec_stats  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-xtp-control-proc-exec-stats-transact-sql
        /// </summary>
        /// <param name="new_collection_value">Determines whether procedure-level statistics collection is on (1) or off (0).</param>
        /// <param name="old_collection_value">Returns the current status.</param>
        /// <returns>0 for success. Nonzero for failure.</returns>
        [FuncStyleConverter(Name = "sys.sp_xtp_control_proc_exec_stats")]
        public int sp_xtp_control_proc_exec_stats(int new_collection_value, string old_collection_value) => throw new InvalitContextException(nameof(sp_xtp_control_proc_exec_stats));

        /// <summary>
        /// sys.sp_xtp_control_query_exec_stats  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-xtp-control-query-exec-stats-transact-sql
        /// </summary>
        /// <returns>0 for success. Nonzero for failure.</returns>
        [FuncStyleConverter(Name = "sys.sp_xtp_control_query_exec_stats")]
        public int sp_xtp_control_query_exec_stats() => throw new InvalitContextException(nameof(sp_xtp_control_query_exec_stats));

        /// <summary>
        /// sys.sp_xtp_control_query_exec_stats  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-xtp-control-query-exec-stats-transact-sql
        /// </summary>
        /// <param name="new_collection_value">Determines whether procedure-level statistics collection is on (1) or off (0).</param>
        /// <returns>0 for success. Nonzero for failure.</returns>
        [FuncStyleConverter(Name = "sys.sp_xtp_control_query_exec_stats")]
        public int sp_xtp_control_query_exec_stats(int new_collection_value) => throw new InvalitContextException(nameof(sp_xtp_control_query_exec_stats));

        /// <summary>
        /// sys.sp_xtp_control_query_exec_stats  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-xtp-control-query-exec-stats-transact-sql
        /// </summary>
        /// <param name="new_collection_value">Determines whether procedure-level statistics collection is on (1) or off (0).</param>
        /// <param name="database_id">The database ID and object ID for the natively compiled stored procedure.</param>
        /// <returns>0 for success. Nonzero for failure.</returns>
        [FuncStyleConverter(Name = "sys.sp_xtp_control_query_exec_stats")]
        public int sp_xtp_control_query_exec_stats(int new_collection_value, int database_id) => throw new InvalitContextException(nameof(sp_xtp_control_query_exec_stats));

        /// <summary>
        /// sys.sp_xtp_control_query_exec_stats  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-xtp-control-query-exec-stats-transact-sql
        /// </summary>
        /// <param name="new_collection_value">Determines whether procedure-level statistics collection is on (1) or off (0).</param>
        /// <param name="database_id">The database ID and object ID for the natively compiled stored procedure.</param>
        /// <param name="xtp_object_id">The database ID and object ID for the natively compiled stored procedure.</param>
        /// <returns>0 for success. Nonzero for failure.</returns>
        [FuncStyleConverter(Name = "sys.sp_xtp_control_query_exec_stats")]
        public int sp_xtp_control_query_exec_stats(int new_collection_value, int database_id, int xtp_object_id) => throw new InvalitContextException(nameof(sp_xtp_control_query_exec_stats));

        /// <summary>
        /// sys.sp_xtp_control_query_exec_stats  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-xtp-control-query-exec-stats-transact-sql
        /// </summary>
        /// <param name="new_collection_value">Determines whether procedure-level statistics collection is on (1) or off (0).</param>
        /// <param name="database_id">The database ID and object ID for the natively compiled stored procedure.</param>
        /// <param name="xtp_object_id">The database ID and object ID for the natively compiled stored procedure.</param>
        /// <param name="old_collection_value">Returns the current status.</param>
        /// <returns>0 for success. Nonzero for failure.</returns>
        [FuncStyleConverter(Name = "sys.sp_xtp_control_query_exec_stats")]
        public int sp_xtp_control_query_exec_stats(int new_collection_value, int database_id, int xtp_object_id, string old_collection_value) => throw new InvalitContextException(nameof(sp_xtp_control_query_exec_stats));

        /// <summary>
        /// sys.sp_xtp_merge_checkpoint_files  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-xtp-merge-checkpoint-files-transact-sql
        /// </summary>
        /// <param name="database_name">The name of the database on which to invoke the merge. </param>
        /// <param name="lower_bound_Tid">The (bigint) lower bound of transactions for a data file as shown in sys.dm_db_xtp_checkpoint_files (Transact-SQL) corresponding to the start checkpoint file of the merge.</param>
        /// <param name="upper_bound_Tid">The (bigint) upper bound of transactions for a data file as shown in sys.dm_db_xtp_checkpoint_files (Transact-SQL). An error is generated for invalid transactonId value.</param>
        [FuncStyleConverter(Name = "sys.sp_xtp_merge_checkpoint_files")]
        public void sp_xtp_merge_checkpoint_files(string database_name, int lower_bound_Tid, int upper_bound_Tid) => throw new InvalitContextException(nameof(sp_xtp_merge_checkpoint_files));

        /// <summary>
        /// sys.sp_xtp_unbind_db_resource_pool  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-xtp-unbind-db-resource-pool-transact-sql
        /// </summary>
        /// <param name="database_name">The name of an existing In-Memory OLTP enabled database. </param>
        [FuncStyleConverter(Name = "sys.sp_xtp_unbind_db_resource_pool")]
        public void sp_xtp_unbind_db_resource_pool(string database_name) => throw new InvalitContextException(nameof(sp_xtp_unbind_db_resource_pool));
    }
}
