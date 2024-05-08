// <auto-generated/>
#pragma warning disable
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;
using WolverineWebApi.Marten;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertInvoiceOperation1936131227
    public class UpsertInvoiceOperation1936131227 : Marten.Internal.Operations.StorageOperation<WolverineWebApi.Marten.Invoice, System.Guid>
    {
        private readonly WolverineWebApi.Marten.Invoice _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertInvoiceOperation1936131227(WolverineWebApi.Marten.Invoice document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }

        public const string COMMAND_TEXT = "select http.mt_upsert_invoice(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }

        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }

        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }

        public override string CommandText()
        {
            return COMMAND_TEXT;
        }

        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }

        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }
    }

    // END: UpsertInvoiceOperation1936131227
    
    
    // START: InsertInvoiceOperation1936131227
    public class InsertInvoiceOperation1936131227 : Marten.Internal.Operations.StorageOperation<WolverineWebApi.Marten.Invoice, System.Guid>
    {
        private readonly WolverineWebApi.Marten.Invoice _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertInvoiceOperation1936131227(WolverineWebApi.Marten.Invoice document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }

        public const string COMMAND_TEXT = "select http.mt_insert_invoice(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }

        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }

        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }

        public override string CommandText()
        {
            return COMMAND_TEXT;
        }

        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }

        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }
    }

    // END: InsertInvoiceOperation1936131227
    
    
    // START: UpdateInvoiceOperation1936131227
    public class UpdateInvoiceOperation1936131227 : Marten.Internal.Operations.StorageOperation<WolverineWebApi.Marten.Invoice, System.Guid>
    {
        private readonly WolverineWebApi.Marten.Invoice _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateInvoiceOperation1936131227(WolverineWebApi.Marten.Invoice document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }

        public const string COMMAND_TEXT = "select http.mt_update_invoice(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }

        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }

        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }

        public override string CommandText()
        {
            return COMMAND_TEXT;
        }

        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }

        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }
    }

    // END: UpdateInvoiceOperation1936131227
    
    
    // START: QueryOnlyInvoiceSelector1936131227
    public class QueryOnlyInvoiceSelector1936131227 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<WolverineWebApi.Marten.Invoice>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyInvoiceSelector1936131227(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }

        public WolverineWebApi.Marten.Invoice Resolve(System.Data.Common.DbDataReader reader)
        {

            WolverineWebApi.Marten.Invoice document;
            document = _serializer.FromJson<WolverineWebApi.Marten.Invoice>(reader, 0);
            return document;
        }

        public async System.Threading.Tasks.Task<WolverineWebApi.Marten.Invoice> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            WolverineWebApi.Marten.Invoice document;
            document = await _serializer.FromJsonAsync<WolverineWebApi.Marten.Invoice>(reader, 0, token).ConfigureAwait(false);
            return document;
        }
    }

    // END: QueryOnlyInvoiceSelector1936131227
    
    
    // START: LightweightInvoiceSelector1936131227
    public class LightweightInvoiceSelector1936131227 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<WolverineWebApi.Marten.Invoice, System.Guid>, Marten.Linq.Selectors.ISelector<WolverineWebApi.Marten.Invoice>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightInvoiceSelector1936131227(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }

        public WolverineWebApi.Marten.Invoice Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            WolverineWebApi.Marten.Invoice document;
            document = _serializer.FromJson<WolverineWebApi.Marten.Invoice>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

        public async System.Threading.Tasks.Task<WolverineWebApi.Marten.Invoice> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            WolverineWebApi.Marten.Invoice document;
            document = await _serializer.FromJsonAsync<WolverineWebApi.Marten.Invoice>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }
    }

    // END: LightweightInvoiceSelector1936131227
    
    
    // START: IdentityMapInvoiceSelector1936131227
    public class IdentityMapInvoiceSelector1936131227 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<WolverineWebApi.Marten.Invoice, System.Guid>, Marten.Linq.Selectors.ISelector<WolverineWebApi.Marten.Invoice>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapInvoiceSelector1936131227(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }

        public WolverineWebApi.Marten.Invoice Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            WolverineWebApi.Marten.Invoice document;
            document = _serializer.FromJson<WolverineWebApi.Marten.Invoice>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

        public async System.Threading.Tasks.Task<WolverineWebApi.Marten.Invoice> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            WolverineWebApi.Marten.Invoice document;
            document = await _serializer.FromJsonAsync<WolverineWebApi.Marten.Invoice>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }
    }

    // END: IdentityMapInvoiceSelector1936131227
    
    
    // START: DirtyTrackingInvoiceSelector1936131227
    public class DirtyTrackingInvoiceSelector1936131227 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<WolverineWebApi.Marten.Invoice, System.Guid>, Marten.Linq.Selectors.ISelector<WolverineWebApi.Marten.Invoice>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingInvoiceSelector1936131227(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }

        public WolverineWebApi.Marten.Invoice Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            WolverineWebApi.Marten.Invoice document;
            document = _serializer.FromJson<WolverineWebApi.Marten.Invoice>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

        public async System.Threading.Tasks.Task<WolverineWebApi.Marten.Invoice> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            WolverineWebApi.Marten.Invoice document;
            document = await _serializer.FromJsonAsync<WolverineWebApi.Marten.Invoice>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }
    }

    // END: DirtyTrackingInvoiceSelector1936131227
    
    
    // START: QueryOnlyInvoiceDocumentStorage1936131227
    public class QueryOnlyInvoiceDocumentStorage1936131227 : Marten.Internal.Storage.QueryOnlyDocumentStorage<WolverineWebApi.Marten.Invoice, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyInvoiceDocumentStorage1936131227(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }

        public override System.Guid AssignIdentity(WolverineWebApi.Marten.Invoice document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }

        public override Marten.Internal.Operations.IStorageOperation Update(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateInvoiceOperation1936131227
            (
                document, Identity(document),
                session.Versions.ForType<WolverineWebApi.Marten.Invoice, System.Guid>(),
                _document
                
            );
        }

        public override Marten.Internal.Operations.IStorageOperation Insert(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertInvoiceOperation1936131227
            (
                document, Identity(document),
                session.Versions.ForType<WolverineWebApi.Marten.Invoice, System.Guid>(),
                _document
                
            );
        }

        public override Marten.Internal.Operations.IStorageOperation Upsert(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertInvoiceOperation1936131227
            (
                document, Identity(document),
                session.Versions.ForType<WolverineWebApi.Marten.Invoice, System.Guid>(),
                _document
                
            );
        }

        public override Marten.Internal.Operations.IStorageOperation Overwrite(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }

        public override System.Guid Identity(WolverineWebApi.Marten.Invoice document)
        {
            return document.Id;
        }

        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyInvoiceSelector1936131227(session, _document);
        }
    }

    // END: QueryOnlyInvoiceDocumentStorage1936131227
    
    
    // START: LightweightInvoiceDocumentStorage1936131227
    public class LightweightInvoiceDocumentStorage1936131227 : Marten.Internal.Storage.LightweightDocumentStorage<WolverineWebApi.Marten.Invoice, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightInvoiceDocumentStorage1936131227(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }

        public override System.Guid AssignIdentity(WolverineWebApi.Marten.Invoice document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }

        public override Marten.Internal.Operations.IStorageOperation Update(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateInvoiceOperation1936131227
            (
                document, Identity(document),
                session.Versions.ForType<WolverineWebApi.Marten.Invoice, System.Guid>(),
                _document
                
            );
        }

        public override Marten.Internal.Operations.IStorageOperation Insert(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertInvoiceOperation1936131227
            (
                document, Identity(document),
                session.Versions.ForType<WolverineWebApi.Marten.Invoice, System.Guid>(),
                _document
                
            );
        }

        public override Marten.Internal.Operations.IStorageOperation Upsert(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertInvoiceOperation1936131227
            (
                document, Identity(document),
                session.Versions.ForType<WolverineWebApi.Marten.Invoice, System.Guid>(),
                _document
                
            );
        }

        public override Marten.Internal.Operations.IStorageOperation Overwrite(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }

        public override System.Guid Identity(WolverineWebApi.Marten.Invoice document)
        {
            return document.Id;
        }

        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightInvoiceSelector1936131227(session, _document);
        }
    }

    // END: LightweightInvoiceDocumentStorage1936131227
    
    
    // START: IdentityMapInvoiceDocumentStorage1936131227
    public class IdentityMapInvoiceDocumentStorage1936131227 : Marten.Internal.Storage.IdentityMapDocumentStorage<WolverineWebApi.Marten.Invoice, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapInvoiceDocumentStorage1936131227(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }

        public override System.Guid AssignIdentity(WolverineWebApi.Marten.Invoice document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }

        public override Marten.Internal.Operations.IStorageOperation Update(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateInvoiceOperation1936131227
            (
                document, Identity(document),
                session.Versions.ForType<WolverineWebApi.Marten.Invoice, System.Guid>(),
                _document
                
            );
        }

        public override Marten.Internal.Operations.IStorageOperation Insert(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertInvoiceOperation1936131227
            (
                document, Identity(document),
                session.Versions.ForType<WolverineWebApi.Marten.Invoice, System.Guid>(),
                _document
                
            );
        }

        public override Marten.Internal.Operations.IStorageOperation Upsert(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertInvoiceOperation1936131227
            (
                document, Identity(document),
                session.Versions.ForType<WolverineWebApi.Marten.Invoice, System.Guid>(),
                _document
                
            );
        }

        public override Marten.Internal.Operations.IStorageOperation Overwrite(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }

        public override System.Guid Identity(WolverineWebApi.Marten.Invoice document)
        {
            return document.Id;
        }

        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapInvoiceSelector1936131227(session, _document);
        }
    }

    // END: IdentityMapInvoiceDocumentStorage1936131227
    
    
    // START: DirtyTrackingInvoiceDocumentStorage1936131227
    public class DirtyTrackingInvoiceDocumentStorage1936131227 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<WolverineWebApi.Marten.Invoice, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingInvoiceDocumentStorage1936131227(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }

        public override System.Guid AssignIdentity(WolverineWebApi.Marten.Invoice document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }

        public override Marten.Internal.Operations.IStorageOperation Update(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateInvoiceOperation1936131227
            (
                document, Identity(document),
                session.Versions.ForType<WolverineWebApi.Marten.Invoice, System.Guid>(),
                _document
                
            );
        }

        public override Marten.Internal.Operations.IStorageOperation Insert(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertInvoiceOperation1936131227
            (
                document, Identity(document),
                session.Versions.ForType<WolverineWebApi.Marten.Invoice, System.Guid>(),
                _document
                
            );
        }

        public override Marten.Internal.Operations.IStorageOperation Upsert(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertInvoiceOperation1936131227
            (
                document, Identity(document),
                session.Versions.ForType<WolverineWebApi.Marten.Invoice, System.Guid>(),
                _document
                
            );
        }

        public override Marten.Internal.Operations.IStorageOperation Overwrite(WolverineWebApi.Marten.Invoice document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }

        public override System.Guid Identity(WolverineWebApi.Marten.Invoice document)
        {
            return document.Id;
        }

        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingInvoiceSelector1936131227(session, _document);
        }
    }

    // END: DirtyTrackingInvoiceDocumentStorage1936131227
    
    
    // START: InvoiceBulkLoader1936131227
    public class InvoiceBulkLoader1936131227 : Marten.Internal.CodeGeneration.BulkLoader<WolverineWebApi.Marten.Invoice, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<WolverineWebApi.Marten.Invoice, System.Guid> _storage;

        public InvoiceBulkLoader1936131227(Marten.Internal.Storage.IDocumentStorage<WolverineWebApi.Marten.Invoice, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }

        public const string MAIN_LOADER_SQL = "COPY http.mt_doc_invoice(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_invoice_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into http.mt_doc_invoice (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_invoice_temp.\"id\", mt_doc_invoice_temp.\"data\", mt_doc_invoice_temp.\"mt_version\", mt_doc_invoice_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_invoice_temp left join http.mt_doc_invoice on mt_doc_invoice_temp.id = http.mt_doc_invoice.id where http.mt_doc_invoice.id is null)";

        public const string OVERWRITE_SQL = "update http.mt_doc_invoice target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_invoice_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_invoice_temp as select * from http.mt_doc_invoice limit 0";


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }

        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }

        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }

        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, WolverineWebApi.Marten.Invoice document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }

        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, WolverineWebApi.Marten.Invoice document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }

        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }

        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }
    }

    // END: InvoiceBulkLoader1936131227
    
    
    // START: InvoiceProvider1936131227
    public class InvoiceProvider1936131227 : Marten.Internal.Storage.DocumentProvider<WolverineWebApi.Marten.Invoice>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InvoiceProvider1936131227(Marten.Schema.DocumentMapping mapping) : base(new InvoiceBulkLoader1936131227(new QueryOnlyInvoiceDocumentStorage1936131227(mapping)), new QueryOnlyInvoiceDocumentStorage1936131227(mapping), new LightweightInvoiceDocumentStorage1936131227(mapping), new IdentityMapInvoiceDocumentStorage1936131227(mapping), new DirtyTrackingInvoiceDocumentStorage1936131227(mapping))
        {
            _mapping = mapping;
        }
    }

    // END: InvoiceProvider1936131227
}