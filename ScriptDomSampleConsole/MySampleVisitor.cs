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

        private string GetFragmentText(TSqlFragment node)
        {
            return _sql?.Substring(node.StartOffset, node.FragmentLength) ?? "(null)";
        }

        public override void Visit(AddAlterFullTextIndexAction node)
        {
            Console.WriteLine("AddAlterFullTextIndexAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AddFileSpec node)
        {
            Console.WriteLine("AddFileSpec Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AddMemberAlterRoleAction node)
        {
            Console.WriteLine("AddMemberAlterRoleAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AddSearchPropertyListAction node)
        {
            Console.WriteLine("AddSearchPropertyListAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AddSignatureStatement node)
        {
            Console.WriteLine("AddSignatureStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AdHocDataSource node)
        {
            Console.WriteLine("AdHocDataSource Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AdHocTableReference node)
        {
            Console.WriteLine("AdHocTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlgorithmKeyOption node)
        {
            Console.WriteLine("AlgorithmKeyOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterApplicationRoleStatement node)
        {
            Console.WriteLine("AlterApplicationRoleStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterAssemblyStatement node)
        {
            Console.WriteLine("AlterAssemblyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterAsymmetricKeyStatement node)
        {
            Console.WriteLine("AlterAsymmetricKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterAuthorizationStatement node)
        {
            Console.WriteLine("AlterAuthorizationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterAvailabilityGroupAction node)
        {
            Console.WriteLine("AlterAvailabilityGroupAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterAvailabilityGroupFailoverAction node)
        {
            Console.WriteLine("AlterAvailabilityGroupFailoverAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterAvailabilityGroupFailoverOption node)
        {
            Console.WriteLine("AlterAvailabilityGroupFailoverOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterAvailabilityGroupStatement node)
        {
            Console.WriteLine("AlterAvailabilityGroupStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterBrokerPriorityStatement node)
        {
            Console.WriteLine("AlterBrokerPriorityStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterCertificateStatement node)
        {
            Console.WriteLine("AlterCertificateStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterColumnAlterFullTextIndexAction node)
        {
            Console.WriteLine("AlterColumnAlterFullTextIndexAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterColumnEncryptionKeyStatement node)
        {
            Console.WriteLine("AlterColumnEncryptionKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterCreateEndpointStatementBase node)
        {
            Console.WriteLine("AlterCreateEndpointStatementBase Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterCreateServiceStatementBase node)
        {
            Console.WriteLine("AlterCreateServiceStatementBase Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterCredentialStatement node)
        {
            Console.WriteLine("AlterCredentialStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterCryptographicProviderStatement node)
        {
            Console.WriteLine("AlterCryptographicProviderStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterDatabaseAddFileGroupStatement node)
        {
            Console.WriteLine("AlterDatabaseAddFileGroupStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterDatabaseAddFileStatement node)
        {
            Console.WriteLine("AlterDatabaseAddFileStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterDatabaseAuditSpecificationStatement node)
        {
            Console.WriteLine("AlterDatabaseAuditSpecificationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterDatabaseCollateStatement node)
        {
            Console.WriteLine("AlterDatabaseCollateStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterDatabaseEncryptionKeyStatement node)
        {
            Console.WriteLine("AlterDatabaseEncryptionKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterDatabaseModifyFileGroupStatement node)
        {
            Console.WriteLine("AlterDatabaseModifyFileGroupStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterDatabaseModifyFileStatement node)
        {
            Console.WriteLine("AlterDatabaseModifyFileStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterDatabaseModifyNameStatement node)
        {
            Console.WriteLine("AlterDatabaseModifyNameStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterDatabaseRebuildLogStatement node)
        {
            Console.WriteLine("AlterDatabaseRebuildLogStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterDatabaseRemoveFileGroupStatement node)
        {
            Console.WriteLine("AlterDatabaseRemoveFileGroupStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterDatabaseRemoveFileStatement node)
        {
            Console.WriteLine("AlterDatabaseRemoveFileStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterDatabaseSetStatement node)
        {
            Console.WriteLine("AlterDatabaseSetStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterDatabaseStatement node)
        {
            Console.WriteLine("AlterDatabaseStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterDatabaseTermination node)
        {
            Console.WriteLine("AlterDatabaseTermination Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterEndpointStatement node)
        {
            Console.WriteLine("AlterEndpointStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterEventSessionStatement node)
        {
            Console.WriteLine("AlterEventSessionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterExternalDataSourceStatement node)
        {
            Console.WriteLine("AlterExternalDataSourceStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterFederationStatement node)
        {
            Console.WriteLine("AlterFederationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterFullTextCatalogStatement node)
        {
            Console.WriteLine("AlterFullTextCatalogStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterFullTextIndexAction node)
        {
            Console.WriteLine("AlterFullTextIndexAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterFullTextIndexStatement node)
        {
            Console.WriteLine("AlterFullTextIndexStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterFullTextStopListStatement node)
        {
            Console.WriteLine("AlterFullTextStopListStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterFunctionStatement node)
        {
            Console.WriteLine("AlterFunctionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterIndexStatement node)
        {
            Console.WriteLine("AlterIndexStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterLoginAddDropCredentialStatement node)
        {
            Console.WriteLine("AlterLoginAddDropCredentialStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterLoginEnableDisableStatement node)
        {
            Console.WriteLine("AlterLoginEnableDisableStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterLoginOptionsStatement node)
        {
            Console.WriteLine("AlterLoginOptionsStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterLoginStatement node)
        {
            Console.WriteLine("AlterLoginStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterMasterKeyStatement node)
        {
            Console.WriteLine("AlterMasterKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterMessageTypeStatement node)
        {
            Console.WriteLine("AlterMessageTypeStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterPartitionFunctionStatement node)
        {
            Console.WriteLine("AlterPartitionFunctionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterPartitionSchemeStatement node)
        {
            Console.WriteLine("AlterPartitionSchemeStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterProcedureStatement node)
        {
            Console.WriteLine("AlterProcedureStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterQueueStatement node)
        {
            Console.WriteLine("AlterQueueStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterRemoteServiceBindingStatement node)
        {
            Console.WriteLine("AlterRemoteServiceBindingStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterResourceGovernorStatement node)
        {
            Console.WriteLine("AlterResourceGovernorStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterResourcePoolStatement node)
        {
            Console.WriteLine("AlterResourcePoolStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterRoleAction node)
        {
            Console.WriteLine("AlterRoleAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterRoleStatement node)
        {
            Console.WriteLine("AlterRoleStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterRouteStatement node)
        {
            Console.WriteLine("AlterRouteStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterSchemaStatement node)
        {
            Console.WriteLine("AlterSchemaStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterSearchPropertyListStatement node)
        {
            Console.WriteLine("AlterSearchPropertyListStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterSecurityPolicyStatement node)
        {
            Console.WriteLine("AlterSecurityPolicyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterSequenceStatement node)
        {
            Console.WriteLine("AlterSequenceStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerAuditSpecificationStatement node)
        {
            Console.WriteLine("AlterServerAuditSpecificationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerAuditStatement node)
        {
            Console.WriteLine("AlterServerAuditStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerConfigurationBufferPoolExtensionContainerOption node)
        {
            Console.WriteLine("AlterServerConfigurationBufferPoolExtensionContainerOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerConfigurationBufferPoolExtensionOption node)
        {
            Console.WriteLine("AlterServerConfigurationBufferPoolExtensionOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerConfigurationBufferPoolExtensionSizeOption node)
        {
            Console.WriteLine("AlterServerConfigurationBufferPoolExtensionSizeOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerConfigurationDiagnosticsLogMaxSizeOption node)
        {
            Console.WriteLine("AlterServerConfigurationDiagnosticsLogMaxSizeOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerConfigurationDiagnosticsLogOption node)
        {
            Console.WriteLine("AlterServerConfigurationDiagnosticsLogOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerConfigurationFailoverClusterPropertyOption node)
        {
            Console.WriteLine("AlterServerConfigurationFailoverClusterPropertyOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerConfigurationHadrClusterOption node)
        {
            Console.WriteLine("AlterServerConfigurationHadrClusterOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerConfigurationSetBufferPoolExtensionStatement node)
        {
            Console.WriteLine("AlterServerConfigurationSetBufferPoolExtensionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerConfigurationSetDiagnosticsLogStatement node)
        {
            Console.WriteLine("AlterServerConfigurationSetDiagnosticsLogStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerConfigurationSetFailoverClusterPropertyStatement node)
        {
            Console.WriteLine("AlterServerConfigurationSetFailoverClusterPropertyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerConfigurationSetHadrClusterStatement node)
        {
            Console.WriteLine("AlterServerConfigurationSetHadrClusterStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerConfigurationSetSoftNumaStatement node)
        {
            Console.WriteLine("AlterServerConfigurationSetSoftNumaStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerConfigurationSoftNumaOption node)
        {
            Console.WriteLine("AlterServerConfigurationSoftNumaOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerConfigurationStatement node)
        {
            Console.WriteLine("AlterServerConfigurationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServerRoleStatement node)
        {
            Console.WriteLine("AlterServerRoleStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServiceMasterKeyStatement node)
        {
            Console.WriteLine("AlterServiceMasterKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterServiceStatement node)
        {
            Console.WriteLine("AlterServiceStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterSymmetricKeyStatement node)
        {
            Console.WriteLine("AlterSymmetricKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterTableAddTableElementStatement node)
        {
            Console.WriteLine("AlterTableAddTableElementStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterTableAlterColumnStatement node)
        {
            Console.WriteLine("AlterTableAlterColumnStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterTableAlterIndexStatement node)
        {
            Console.WriteLine("AlterTableAlterIndexStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterTableChangeTrackingModificationStatement node)
        {
            Console.WriteLine("AlterTableChangeTrackingModificationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterTableConstraintModificationStatement node)
        {
            Console.WriteLine("AlterTableConstraintModificationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterTableDropTableElement node)
        {
            Console.WriteLine("AlterTableDropTableElement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterTableDropTableElementStatement node)
        {
            Console.WriteLine("AlterTableDropTableElementStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterTableFileTableNamespaceStatement node)
        {
            Console.WriteLine("AlterTableFileTableNamespaceStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterTableRebuildStatement node)
        {
            Console.WriteLine("AlterTableRebuildStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterTableSetStatement node)
        {
            Console.WriteLine("AlterTableSetStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterTableStatement node)
        {
            Console.WriteLine("AlterTableStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterTableSwitchStatement node)
        {
            Console.WriteLine("AlterTableSwitchStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterTableTriggerModificationStatement node)
        {
            Console.WriteLine("AlterTableTriggerModificationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterTriggerStatement node)
        {
            Console.WriteLine("AlterTriggerStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterUserStatement node)
        {
            Console.WriteLine("AlterUserStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterViewStatement node)
        {
            Console.WriteLine("AlterViewStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterWorkloadGroupStatement node)
        {
            Console.WriteLine("AlterWorkloadGroupStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AlterXmlSchemaCollectionStatement node)
        {
            Console.WriteLine("AlterXmlSchemaCollectionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ApplicationRoleOption node)
        {
            Console.WriteLine("ApplicationRoleOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ApplicationRoleStatement node)
        {
            Console.WriteLine("ApplicationRoleStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AssemblyEncryptionSource node)
        {
            Console.WriteLine("AssemblyEncryptionSource Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AssemblyName node)
        {
            Console.WriteLine("AssemblyName Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AssemblyOption node)
        {
            Console.WriteLine("AssemblyOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AssemblyStatement node)
        {
            Console.WriteLine("AssemblyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AssignmentSetClause node)
        {
            Console.WriteLine("AssignmentSetClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AsymmetricKeyCreateLoginSource node)
        {
            Console.WriteLine("AsymmetricKeyCreateLoginSource Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AtomicBlockOption node)
        {
            Console.WriteLine("AtomicBlockOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AtTimeZoneCall node)
        {
            Console.WriteLine("AtTimeZoneCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AuditActionGroupReference node)
        {
            Console.WriteLine("AuditActionGroupReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AuditActionSpecification node)
        {
            Console.WriteLine("AuditActionSpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AuditGuidAuditOption node)
        {
            Console.WriteLine("AuditGuidAuditOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AuditOption node)
        {
            Console.WriteLine("AuditOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AuditSpecificationDetail node)
        {
            Console.WriteLine("AuditSpecificationDetail Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AuditSpecificationPart node)
        {
            Console.WriteLine("AuditSpecificationPart Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AuditSpecificationStatement node)
        {
            Console.WriteLine("AuditSpecificationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AuditTarget node)
        {
            Console.WriteLine("AuditTarget Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AuditTargetOption node)
        {
            Console.WriteLine("AuditTargetOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AuthenticationEndpointProtocolOption node)
        {
            Console.WriteLine("AuthenticationEndpointProtocolOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AuthenticationPayloadOption node)
        {
            Console.WriteLine("AuthenticationPayloadOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AutoCleanupChangeTrackingOptionDetail node)
        {
            Console.WriteLine("AutoCleanupChangeTrackingOptionDetail Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AutoCreateStatisticsDatabaseOption node)
        {
            Console.WriteLine("AutoCreateStatisticsDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AvailabilityGroupOption node)
        {
            Console.WriteLine("AvailabilityGroupOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AvailabilityGroupStatement node)
        {
            Console.WriteLine("AvailabilityGroupStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AvailabilityModeReplicaOption node)
        {
            Console.WriteLine("AvailabilityModeReplicaOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AvailabilityReplica node)
        {
            Console.WriteLine("AvailabilityReplica Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(AvailabilityReplicaOption node)
        {
            Console.WriteLine("AvailabilityReplicaOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BackupCertificateStatement node)
        {
            Console.WriteLine("BackupCertificateStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BackupDatabaseStatement node)
        {
            Console.WriteLine("BackupDatabaseStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BackupEncryptionOption node)
        {
            Console.WriteLine("BackupEncryptionOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BackupMasterKeyStatement node)
        {
            Console.WriteLine("BackupMasterKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BackupOption node)
        {
            Console.WriteLine("BackupOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BackupRestoreFileInfo node)
        {
            Console.WriteLine("BackupRestoreFileInfo Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BackupRestoreMasterKeyStatementBase node)
        {
            Console.WriteLine("BackupRestoreMasterKeyStatementBase Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BackupServiceMasterKeyStatement node)
        {
            Console.WriteLine("BackupServiceMasterKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BackupStatement node)
        {
            Console.WriteLine("BackupStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BackupTransactionLogStatement node)
        {
            Console.WriteLine("BackupTransactionLogStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BackwardsCompatibleDropIndexClause node)
        {
            Console.WriteLine("BackwardsCompatibleDropIndexClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BeginConversationTimerStatement node)
        {
            Console.WriteLine("BeginConversationTimerStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BeginDialogStatement node)
        {
            Console.WriteLine("BeginDialogStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BeginEndAtomicBlockStatement node)
        {
            Console.WriteLine("BeginEndAtomicBlockStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BeginEndBlockStatement node)
        {
            Console.WriteLine("BeginEndBlockStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BeginTransactionStatement node)
        {
            Console.WriteLine("BeginTransactionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BinaryExpression node)
        {
            Console.WriteLine("BinaryExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BinaryLiteral node)
        {
            Console.WriteLine("BinaryLiteral Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BinaryQueryExpression node)
        {
            Console.WriteLine("BinaryQueryExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BooleanBinaryExpression node)
        {
            Console.WriteLine("BooleanBinaryExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BooleanComparisonExpression node)
        {
            Console.WriteLine("BooleanComparisonExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BooleanExpression node)
        {
            Console.WriteLine("BooleanExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BooleanExpressionSnippet node)
        {
            Console.WriteLine("BooleanExpressionSnippet Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BooleanIsNullExpression node)
        {
            Console.WriteLine("BooleanIsNullExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BooleanNotExpression node)
        {
            Console.WriteLine("BooleanNotExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BooleanParenthesisExpression node)
        {
            Console.WriteLine("BooleanParenthesisExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BooleanTernaryExpression node)
        {
            Console.WriteLine("BooleanTernaryExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BoundingBoxParameter node)
        {
            Console.WriteLine("BoundingBoxParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BoundingBoxSpatialIndexOption node)
        {
            Console.WriteLine("BoundingBoxSpatialIndexOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BreakStatement node)
        {
            Console.WriteLine("BreakStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BrokerPriorityParameter node)
        {
            Console.WriteLine("BrokerPriorityParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BrokerPriorityStatement node)
        {
            Console.WriteLine("BrokerPriorityStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BrowseForClause node)
        {
            Console.WriteLine("BrowseForClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BuiltInFunctionTableReference node)
        {
            Console.WriteLine("BuiltInFunctionTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BulkInsertBase node)
        {
            Console.WriteLine("BulkInsertBase Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BulkInsertOption node)
        {
            Console.WriteLine("BulkInsertOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BulkInsertStatement node)
        {
            Console.WriteLine("BulkInsertStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(BulkOpenRowset node)
        {
            Console.WriteLine("BulkOpenRowset Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CallTarget node)
        {
            Console.WriteLine("CallTarget Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CaseExpression node)
        {
            Console.WriteLine("CaseExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CastCall node)
        {
            Console.WriteLine("CastCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CellsPerObjectSpatialIndexOption node)
        {
            Console.WriteLine("CellsPerObjectSpatialIndexOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CertificateCreateLoginSource node)
        {
            Console.WriteLine("CertificateCreateLoginSource Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CertificateOption node)
        {
            Console.WriteLine("CertificateOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CertificateStatementBase node)
        {
            Console.WriteLine("CertificateStatementBase Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ChangeRetentionChangeTrackingOptionDetail node)
        {
            Console.WriteLine("ChangeRetentionChangeTrackingOptionDetail Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ChangeTableChangesTableReference node)
        {
            Console.WriteLine("ChangeTableChangesTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ChangeTableVersionTableReference node)
        {
            Console.WriteLine("ChangeTableVersionTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ChangeTrackingDatabaseOption node)
        {
            Console.WriteLine("ChangeTrackingDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ChangeTrackingFullTextIndexOption node)
        {
            Console.WriteLine("ChangeTrackingFullTextIndexOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ChangeTrackingOptionDetail node)
        {
            Console.WriteLine("ChangeTrackingOptionDetail Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CharacterSetPayloadOption node)
        {
            Console.WriteLine("CharacterSetPayloadOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CheckConstraintDefinition node)
        {
            Console.WriteLine("CheckConstraintDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CheckpointStatement node)
        {
            Console.WriteLine("CheckpointStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ChildObjectName node)
        {
            Console.WriteLine("ChildObjectName Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CloseCursorStatement node)
        {
            Console.WriteLine("CloseCursorStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CloseMasterKeyStatement node)
        {
            Console.WriteLine("CloseMasterKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CloseSymmetricKeyStatement node)
        {
            Console.WriteLine("CloseSymmetricKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CoalesceExpression node)
        {
            Console.WriteLine("CoalesceExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnDefinition node)
        {
            Console.WriteLine("ColumnDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnDefinitionBase node)
        {
            Console.WriteLine("ColumnDefinitionBase Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnEncryptionAlgorithmNameParameter node)
        {
            Console.WriteLine("ColumnEncryptionAlgorithmNameParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnEncryptionAlgorithmParameter node)
        {
            Console.WriteLine("ColumnEncryptionAlgorithmParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnEncryptionDefinition node)
        {
            Console.WriteLine("ColumnEncryptionDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnEncryptionDefinitionParameter node)
        {
            Console.WriteLine("ColumnEncryptionDefinitionParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnEncryptionKeyNameParameter node)
        {
            Console.WriteLine("ColumnEncryptionKeyNameParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnEncryptionKeyStatement node)
        {
            Console.WriteLine("ColumnEncryptionKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnEncryptionKeyValue node)
        {
            Console.WriteLine("ColumnEncryptionKeyValue Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnEncryptionKeyValueParameter node)
        {
            Console.WriteLine("ColumnEncryptionKeyValueParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnEncryptionTypeParameter node)
        {
            Console.WriteLine("ColumnEncryptionTypeParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnMasterKeyNameParameter node)
        {
            Console.WriteLine("ColumnMasterKeyNameParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnMasterKeyParameter node)
        {
            Console.WriteLine("ColumnMasterKeyParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnMasterKeyPathParameter node)
        {
            Console.WriteLine("ColumnMasterKeyPathParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnMasterKeyStoreProviderNameParameter node)
        {
            Console.WriteLine("ColumnMasterKeyStoreProviderNameParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnReferenceExpression node)
        {
            Console.WriteLine("ColumnReferenceExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnStorageOptions node)
        {
            Console.WriteLine("ColumnStorageOptions Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ColumnWithSortOrder node)
        {
            Console.WriteLine("ColumnWithSortOrder Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CommandSecurityElement80 node)
        {
            Console.WriteLine("CommandSecurityElement80 Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CommitTransactionStatement node)
        {
            Console.WriteLine("CommitTransactionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CommonTableExpression node)
        {
            Console.WriteLine("CommonTableExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CompositeGroupingSpecification node)
        {
            Console.WriteLine("CompositeGroupingSpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CompressionDelayIndexOption node)
        {
            Console.WriteLine("CompressionDelayIndexOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CompressionEndpointProtocolOption node)
        {
            Console.WriteLine("CompressionEndpointProtocolOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CompressionPartitionRange node)
        {
            Console.WriteLine("CompressionPartitionRange Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ComputeClause node)
        {
            Console.WriteLine("ComputeClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ComputeFunction node)
        {
            Console.WriteLine("ComputeFunction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ConstraintDefinition node)
        {
            Console.WriteLine("ConstraintDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ContainmentDatabaseOption node)
        {
            Console.WriteLine("ContainmentDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ContinueStatement node)
        {
            Console.WriteLine("ContinueStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ContractMessage node)
        {
            Console.WriteLine("ContractMessage Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ConvertCall node)
        {
            Console.WriteLine("ConvertCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateAggregateStatement node)
        {
            Console.WriteLine("CreateAggregateStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateApplicationRoleStatement node)
        {
            Console.WriteLine("CreateApplicationRoleStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateAssemblyStatement node)
        {
            Console.WriteLine("CreateAssemblyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateAsymmetricKeyStatement node)
        {
            Console.WriteLine("CreateAsymmetricKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateAvailabilityGroupStatement node)
        {
            Console.WriteLine("CreateAvailabilityGroupStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateBrokerPriorityStatement node)
        {
            Console.WriteLine("CreateBrokerPriorityStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateCertificateStatement node)
        {
            Console.WriteLine("CreateCertificateStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateColumnEncryptionKeyStatement node)
        {
            Console.WriteLine("CreateColumnEncryptionKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateColumnMasterKeyStatement node)
        {
            Console.WriteLine("CreateColumnMasterKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateColumnStoreIndexStatement node)
        {
            Console.WriteLine("CreateColumnStoreIndexStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateContractStatement node)
        {
            Console.WriteLine("CreateContractStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateCredentialStatement node)
        {
            Console.WriteLine("CreateCredentialStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateCryptographicProviderStatement node)
        {
            Console.WriteLine("CreateCryptographicProviderStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateDatabaseAuditSpecificationStatement node)
        {
            Console.WriteLine("CreateDatabaseAuditSpecificationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateDatabaseEncryptionKeyStatement node)
        {
            Console.WriteLine("CreateDatabaseEncryptionKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateDatabaseStatement node)
        {
            Console.WriteLine("CreateDatabaseStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateDefaultStatement node)
        {
            Console.WriteLine("CreateDefaultStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateEndpointStatement node)
        {
            Console.WriteLine("CreateEndpointStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateEventNotificationStatement node)
        {
            Console.WriteLine("CreateEventNotificationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateEventSessionStatement node)
        {
            Console.WriteLine("CreateEventSessionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateExternalDataSourceStatement node)
        {
            Console.WriteLine("CreateExternalDataSourceStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateExternalFileFormatStatement node)
        {
            Console.WriteLine("CreateExternalFileFormatStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateExternalTableStatement node)
        {
            Console.WriteLine("CreateExternalTableStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateFederationStatement node)
        {
            Console.WriteLine("CreateFederationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateFullTextCatalogStatement node)
        {
            Console.WriteLine("CreateFullTextCatalogStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateFullTextIndexStatement node)
        {
            Console.WriteLine("CreateFullTextIndexStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateFullTextStopListStatement node)
        {
            Console.WriteLine("CreateFullTextStopListStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateFunctionStatement node)
        {
            Console.WriteLine("CreateFunctionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateIndexStatement node)
        {
            Console.WriteLine("CreateIndexStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateLoginSource node)
        {
            Console.WriteLine("CreateLoginSource Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateLoginStatement node)
        {
            Console.WriteLine("CreateLoginStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateMasterKeyStatement node)
        {
            Console.WriteLine("CreateMasterKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateMessageTypeStatement node)
        {
            Console.WriteLine("CreateMessageTypeStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreatePartitionFunctionStatement node)
        {
            Console.WriteLine("CreatePartitionFunctionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreatePartitionSchemeStatement node)
        {
            Console.WriteLine("CreatePartitionSchemeStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateProcedureStatement node)
        {
            Console.WriteLine("CreateProcedureStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateQueueStatement node)
        {
            Console.WriteLine("CreateQueueStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateRemoteServiceBindingStatement node)
        {
            Console.WriteLine("CreateRemoteServiceBindingStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateResourcePoolStatement node)
        {
            Console.WriteLine("CreateResourcePoolStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateRoleStatement node)
        {
            Console.WriteLine("CreateRoleStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateRouteStatement node)
        {
            Console.WriteLine("CreateRouteStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateRuleStatement node)
        {
            Console.WriteLine("CreateRuleStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateSchemaStatement node)
        {
            Console.WriteLine("CreateSchemaStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateSearchPropertyListStatement node)
        {
            Console.WriteLine("CreateSearchPropertyListStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateSecurityPolicyStatement node)
        {
            Console.WriteLine("CreateSecurityPolicyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateSelectiveXmlIndexStatement node)
        {
            Console.WriteLine("CreateSelectiveXmlIndexStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateSequenceStatement node)
        {
            Console.WriteLine("CreateSequenceStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateServerAuditSpecificationStatement node)
        {
            Console.WriteLine("CreateServerAuditSpecificationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateServerAuditStatement node)
        {
            Console.WriteLine("CreateServerAuditStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateServerRoleStatement node)
        {
            Console.WriteLine("CreateServerRoleStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateServiceStatement node)
        {
            Console.WriteLine("CreateServiceStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateSpatialIndexStatement node)
        {
            Console.WriteLine("CreateSpatialIndexStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateStatisticsStatement node)
        {
            Console.WriteLine("CreateStatisticsStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateSymmetricKeyStatement node)
        {
            Console.WriteLine("CreateSymmetricKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateSynonymStatement node)
        {
            Console.WriteLine("CreateSynonymStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateTableStatement node)
        {
            Console.WriteLine("CreateTableStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateTriggerStatement node)
        {
            Console.WriteLine("CreateTriggerStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateTypeStatement node)
        {
            Console.WriteLine("CreateTypeStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateTypeTableStatement node)
        {
            Console.WriteLine("CreateTypeTableStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateTypeUddtStatement node)
        {
            Console.WriteLine("CreateTypeUddtStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateTypeUdtStatement node)
        {
            Console.WriteLine("CreateTypeUdtStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateUserStatement node)
        {
            Console.WriteLine("CreateUserStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateViewStatement node)
        {
            Console.WriteLine("CreateViewStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateWorkloadGroupStatement node)
        {
            Console.WriteLine("CreateWorkloadGroupStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateXmlIndexStatement node)
        {
            Console.WriteLine("CreateXmlIndexStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreateXmlSchemaCollectionStatement node)
        {
            Console.WriteLine("CreateXmlSchemaCollectionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CreationDispositionKeyOption node)
        {
            Console.WriteLine("CreationDispositionKeyOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CredentialStatement node)
        {
            Console.WriteLine("CredentialStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CryptoMechanism node)
        {
            Console.WriteLine("CryptoMechanism Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CubeGroupingSpecification node)
        {
            Console.WriteLine("CubeGroupingSpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CursorDefaultDatabaseOption node)
        {
            Console.WriteLine("CursorDefaultDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CursorDefinition node)
        {
            Console.WriteLine("CursorDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CursorId node)
        {
            Console.WriteLine("CursorId Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CursorOption node)
        {
            Console.WriteLine("CursorOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(CursorStatement node)
        {
            Console.WriteLine("CursorStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DatabaseAuditAction node)
        {
            Console.WriteLine("DatabaseAuditAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DatabaseEncryptionKeyStatement node)
        {
            Console.WriteLine("DatabaseEncryptionKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DatabaseOption node)
        {
            Console.WriteLine("DatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DataCompressionOption node)
        {
            Console.WriteLine("DataCompressionOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DataModificationSpecification node)
        {
            Console.WriteLine("DataModificationSpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DataModificationStatement node)
        {
            Console.WriteLine("DataModificationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DataModificationTableReference node)
        {
            Console.WriteLine("DataModificationTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DataTypeReference node)
        {
            Console.WriteLine("DataTypeReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DataTypeSequenceOption node)
        {
            Console.WriteLine("DataTypeSequenceOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DbccNamedLiteral node)
        {
            Console.WriteLine("DbccNamedLiteral Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DbccOption node)
        {
            Console.WriteLine("DbccOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DbccStatement node)
        {
            Console.WriteLine("DbccStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DeallocateCursorStatement node)
        {
            Console.WriteLine("DeallocateCursorStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DeclareCursorStatement node)
        {
            Console.WriteLine("DeclareCursorStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DeclareTableVariableBody node)
        {
            Console.WriteLine("DeclareTableVariableBody Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DeclareTableVariableStatement node)
        {
            Console.WriteLine("DeclareTableVariableStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DeclareVariableElement node)
        {
            Console.WriteLine("DeclareVariableElement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DeclareVariableStatement node)
        {
            Console.WriteLine("DeclareVariableStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DefaultConstraintDefinition node)
        {
            Console.WriteLine("DefaultConstraintDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DefaultLiteral node)
        {
            Console.WriteLine("DefaultLiteral Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DelayedDurabilityDatabaseOption node)
        {
            Console.WriteLine("DelayedDurabilityDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DeleteMergeAction node)
        {
            Console.WriteLine("DeleteMergeAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DeleteSpecification node)
        {
            Console.WriteLine("DeleteSpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DeleteStatement node)
        {
            Console.WriteLine("DeleteStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DenyStatement node)
        {
            Console.WriteLine("DenyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DenyStatement80 node)
        {
            Console.WriteLine("DenyStatement80 Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DeviceInfo node)
        {
            Console.WriteLine("DeviceInfo Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DialogOption node)
        {
            Console.WriteLine("DialogOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DiskStatement node)
        {
            Console.WriteLine("DiskStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DiskStatementOption node)
        {
            Console.WriteLine("DiskStatementOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropAggregateStatement node)
        {
            Console.WriteLine("DropAggregateStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropAlterFullTextIndexAction node)
        {
            Console.WriteLine("DropAlterFullTextIndexAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropApplicationRoleStatement node)
        {
            Console.WriteLine("DropApplicationRoleStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropAssemblyStatement node)
        {
            Console.WriteLine("DropAssemblyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropAsymmetricKeyStatement node)
        {
            Console.WriteLine("DropAsymmetricKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropAvailabilityGroupStatement node)
        {
            Console.WriteLine("DropAvailabilityGroupStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropBrokerPriorityStatement node)
        {
            Console.WriteLine("DropBrokerPriorityStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropCertificateStatement node)
        {
            Console.WriteLine("DropCertificateStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropChildObjectsStatement node)
        {
            Console.WriteLine("DropChildObjectsStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropClusteredConstraintMoveOption node)
        {
            Console.WriteLine("DropClusteredConstraintMoveOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropClusteredConstraintOption node)
        {
            Console.WriteLine("DropClusteredConstraintOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropClusteredConstraintStateOption node)
        {
            Console.WriteLine("DropClusteredConstraintStateOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropClusteredConstraintValueOption node)
        {
            Console.WriteLine("DropClusteredConstraintValueOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropColumnEncryptionKeyStatement node)
        {
            Console.WriteLine("DropColumnEncryptionKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropColumnMasterKeyStatement node)
        {
            Console.WriteLine("DropColumnMasterKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropContractStatement node)
        {
            Console.WriteLine("DropContractStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropCredentialStatement node)
        {
            Console.WriteLine("DropCredentialStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropCryptographicProviderStatement node)
        {
            Console.WriteLine("DropCryptographicProviderStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropDatabaseAuditSpecificationStatement node)
        {
            Console.WriteLine("DropDatabaseAuditSpecificationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropDatabaseEncryptionKeyStatement node)
        {
            Console.WriteLine("DropDatabaseEncryptionKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropDatabaseStatement node)
        {
            Console.WriteLine("DropDatabaseStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropDefaultStatement node)
        {
            Console.WriteLine("DropDefaultStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropEndpointStatement node)
        {
            Console.WriteLine("DropEndpointStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropEventNotificationStatement node)
        {
            Console.WriteLine("DropEventNotificationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropEventSessionStatement node)
        {
            Console.WriteLine("DropEventSessionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropExternalDataSourceStatement node)
        {
            Console.WriteLine("DropExternalDataSourceStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropExternalFileFormatStatement node)
        {
            Console.WriteLine("DropExternalFileFormatStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropExternalTableStatement node)
        {
            Console.WriteLine("DropExternalTableStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropFederationStatement node)
        {
            Console.WriteLine("DropFederationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropFullTextCatalogStatement node)
        {
            Console.WriteLine("DropFullTextCatalogStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropFullTextIndexStatement node)
        {
            Console.WriteLine("DropFullTextIndexStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropFullTextStopListStatement node)
        {
            Console.WriteLine("DropFullTextStopListStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropFunctionStatement node)
        {
            Console.WriteLine("DropFunctionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropIndexClause node)
        {
            Console.WriteLine("DropIndexClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropIndexClauseBase node)
        {
            Console.WriteLine("DropIndexClauseBase Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropIndexStatement node)
        {
            Console.WriteLine("DropIndexStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropLoginStatement node)
        {
            Console.WriteLine("DropLoginStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropMasterKeyStatement node)
        {
            Console.WriteLine("DropMasterKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropMemberAlterRoleAction node)
        {
            Console.WriteLine("DropMemberAlterRoleAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropMessageTypeStatement node)
        {
            Console.WriteLine("DropMessageTypeStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropObjectsStatement node)
        {
            Console.WriteLine("DropObjectsStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropPartitionFunctionStatement node)
        {
            Console.WriteLine("DropPartitionFunctionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropPartitionSchemeStatement node)
        {
            Console.WriteLine("DropPartitionSchemeStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropProcedureStatement node)
        {
            Console.WriteLine("DropProcedureStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropQueueStatement node)
        {
            Console.WriteLine("DropQueueStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropRemoteServiceBindingStatement node)
        {
            Console.WriteLine("DropRemoteServiceBindingStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropResourcePoolStatement node)
        {
            Console.WriteLine("DropResourcePoolStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropRoleStatement node)
        {
            Console.WriteLine("DropRoleStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropRouteStatement node)
        {
            Console.WriteLine("DropRouteStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropRuleStatement node)
        {
            Console.WriteLine("DropRuleStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropSchemaStatement node)
        {
            Console.WriteLine("DropSchemaStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropSearchPropertyListAction node)
        {
            Console.WriteLine("DropSearchPropertyListAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropSearchPropertyListStatement node)
        {
            Console.WriteLine("DropSearchPropertyListStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropSecurityPolicyStatement node)
        {
            Console.WriteLine("DropSecurityPolicyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropSequenceStatement node)
        {
            Console.WriteLine("DropSequenceStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropServerAuditSpecificationStatement node)
        {
            Console.WriteLine("DropServerAuditSpecificationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropServerAuditStatement node)
        {
            Console.WriteLine("DropServerAuditStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropServerRoleStatement node)
        {
            Console.WriteLine("DropServerRoleStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropServiceStatement node)
        {
            Console.WriteLine("DropServiceStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropSignatureStatement node)
        {
            Console.WriteLine("DropSignatureStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropStatisticsStatement node)
        {
            Console.WriteLine("DropStatisticsStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropSymmetricKeyStatement node)
        {
            Console.WriteLine("DropSymmetricKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropSynonymStatement node)
        {
            Console.WriteLine("DropSynonymStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropTableStatement node)
        {
            Console.WriteLine("DropTableStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropTriggerStatement node)
        {
            Console.WriteLine("DropTriggerStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropTypeStatement node)
        {
            Console.WriteLine("DropTypeStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropUnownedObjectStatement node)
        {
            Console.WriteLine("DropUnownedObjectStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropUserStatement node)
        {
            Console.WriteLine("DropUserStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropViewStatement node)
        {
            Console.WriteLine("DropViewStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropWorkloadGroupStatement node)
        {
            Console.WriteLine("DropWorkloadGroupStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DropXmlSchemaCollectionStatement node)
        {
            Console.WriteLine("DropXmlSchemaCollectionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(DurabilityTableOption node)
        {
            Console.WriteLine("DurabilityTableOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EnabledDisabledPayloadOption node)
        {
            Console.WriteLine("EnabledDisabledPayloadOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EnableDisableTriggerStatement node)
        {
            Console.WriteLine("EnableDisableTriggerStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EncryptedValueParameter node)
        {
            Console.WriteLine("EncryptedValueParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EncryptionPayloadOption node)
        {
            Console.WriteLine("EncryptionPayloadOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EncryptionSource node)
        {
            Console.WriteLine("EncryptionSource Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EndConversationStatement node)
        {
            Console.WriteLine("EndConversationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EndpointAffinity node)
        {
            Console.WriteLine("EndpointAffinity Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EndpointProtocolOption node)
        {
            Console.WriteLine("EndpointProtocolOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EventDeclaration node)
        {
            Console.WriteLine("EventDeclaration Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EventDeclarationCompareFunctionParameter node)
        {
            Console.WriteLine("EventDeclarationCompareFunctionParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EventDeclarationSetParameter node)
        {
            Console.WriteLine("EventDeclarationSetParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EventGroupContainer node)
        {
            Console.WriteLine("EventGroupContainer Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EventNotificationObjectScope node)
        {
            Console.WriteLine("EventNotificationObjectScope Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EventRetentionSessionOption node)
        {
            Console.WriteLine("EventRetentionSessionOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EventSessionObjectName node)
        {
            Console.WriteLine("EventSessionObjectName Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EventSessionStatement node)
        {
            Console.WriteLine("EventSessionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EventTypeContainer node)
        {
            Console.WriteLine("EventTypeContainer Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(EventTypeGroupContainer node)
        {
            Console.WriteLine("EventTypeGroupContainer Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExecutableEntity node)
        {
            Console.WriteLine("ExecutableEntity Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExecutableProcedureReference node)
        {
            Console.WriteLine("ExecutableProcedureReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExecutableStringList node)
        {
            Console.WriteLine("ExecutableStringList Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExecuteAsClause node)
        {
            Console.WriteLine("ExecuteAsClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExecuteAsFunctionOption node)
        {
            Console.WriteLine("ExecuteAsFunctionOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExecuteAsProcedureOption node)
        {
            Console.WriteLine("ExecuteAsProcedureOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExecuteAsStatement node)
        {
            Console.WriteLine("ExecuteAsStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExecuteAsTriggerOption node)
        {
            Console.WriteLine("ExecuteAsTriggerOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExecuteContext node)
        {
            Console.WriteLine("ExecuteContext Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExecuteInsertSource node)
        {
            Console.WriteLine("ExecuteInsertSource Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExecuteOption node)
        {
            Console.WriteLine("ExecuteOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExecuteParameter node)
        {
            Console.WriteLine("ExecuteParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExecuteSpecification node)
        {
            Console.WriteLine("ExecuteSpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExecuteStatement node)
        {
            Console.WriteLine("ExecuteStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExistsPredicate node)
        {
            Console.WriteLine("ExistsPredicate Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExpressionCallTarget node)
        {
            Console.WriteLine("ExpressionCallTarget Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExpressionGroupingSpecification node)
        {
            Console.WriteLine("ExpressionGroupingSpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExpressionWithSortOrder node)
        {
            Console.WriteLine("ExpressionWithSortOrder Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalDataSourceLiteralOrIdentifierOption node)
        {
            Console.WriteLine("ExternalDataSourceLiteralOrIdentifierOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalDataSourceOption node)
        {
            Console.WriteLine("ExternalDataSourceOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalDataSourceStatement node)
        {
            Console.WriteLine("ExternalDataSourceStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalFileFormatContainerOption node)
        {
            Console.WriteLine("ExternalFileFormatContainerOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalFileFormatLiteralOption node)
        {
            Console.WriteLine("ExternalFileFormatLiteralOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalFileFormatOption node)
        {
            Console.WriteLine("ExternalFileFormatOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalFileFormatStatement node)
        {
            Console.WriteLine("ExternalFileFormatStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalFileFormatUseDefaultTypeOption node)
        {
            Console.WriteLine("ExternalFileFormatUseDefaultTypeOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalTableColumnDefinition node)
        {
            Console.WriteLine("ExternalTableColumnDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalTableDistributionOption node)
        {
            Console.WriteLine("ExternalTableDistributionOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalTableDistributionPolicy node)
        {
            Console.WriteLine("ExternalTableDistributionPolicy Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalTableLiteralOrIdentifierOption node)
        {
            Console.WriteLine("ExternalTableLiteralOrIdentifierOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalTableOption node)
        {
            Console.WriteLine("ExternalTableOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalTableRejectTypeOption node)
        {
            Console.WriteLine("ExternalTableRejectTypeOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalTableReplicatedDistributionPolicy node)
        {
            Console.WriteLine("ExternalTableReplicatedDistributionPolicy Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalTableRoundRobinDistributionPolicy node)
        {
            Console.WriteLine("ExternalTableRoundRobinDistributionPolicy Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalTableShardedDistributionPolicy node)
        {
            Console.WriteLine("ExternalTableShardedDistributionPolicy Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExternalTableStatement node)
        {
            Console.WriteLine("ExternalTableStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ExtractFromExpression node)
        {
            Console.WriteLine("ExtractFromExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FailoverModeReplicaOption node)
        {
            Console.WriteLine("FailoverModeReplicaOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FederationScheme node)
        {
            Console.WriteLine("FederationScheme Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FetchCursorStatement node)
        {
            Console.WriteLine("FetchCursorStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FetchType node)
        {
            Console.WriteLine("FetchType Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FileDeclaration node)
        {
            Console.WriteLine("FileDeclaration Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FileDeclarationOption node)
        {
            Console.WriteLine("FileDeclarationOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FileEncryptionSource node)
        {
            Console.WriteLine("FileEncryptionSource Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FileGroupDefinition node)
        {
            Console.WriteLine("FileGroupDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FileGroupOrPartitionScheme node)
        {
            Console.WriteLine("FileGroupOrPartitionScheme Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FileGrowthFileDeclarationOption node)
        {
            Console.WriteLine("FileGrowthFileDeclarationOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FileNameFileDeclarationOption node)
        {
            Console.WriteLine("FileNameFileDeclarationOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FileStreamDatabaseOption node)
        {
            Console.WriteLine("FileStreamDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FileStreamOnDropIndexOption node)
        {
            Console.WriteLine("FileStreamOnDropIndexOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FileStreamOnTableOption node)
        {
            Console.WriteLine("FileStreamOnTableOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FileStreamRestoreOption node)
        {
            Console.WriteLine("FileStreamRestoreOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FileTableCollateFileNameTableOption node)
        {
            Console.WriteLine("FileTableCollateFileNameTableOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FileTableConstraintNameTableOption node)
        {
            Console.WriteLine("FileTableConstraintNameTableOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FileTableDirectoryTableOption node)
        {
            Console.WriteLine("FileTableDirectoryTableOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ForceSeekTableHint node)
        {
            Console.WriteLine("ForceSeekTableHint Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ForClause node)
        {
            Console.WriteLine("ForClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ForeignKeyConstraintDefinition node)
        {
            Console.WriteLine("ForeignKeyConstraintDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FromClause node)
        {
            Console.WriteLine("FromClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FullTextCatalogAndFileGroup node)
        {
            Console.WriteLine("FullTextCatalogAndFileGroup Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FullTextCatalogOption node)
        {
            Console.WriteLine("FullTextCatalogOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FullTextCatalogStatement node)
        {
            Console.WriteLine("FullTextCatalogStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FullTextIndexColumn node)
        {
            Console.WriteLine("FullTextIndexColumn Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FullTextIndexOption node)
        {
            Console.WriteLine("FullTextIndexOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FullTextPredicate node)
        {
            Console.WriteLine("FullTextPredicate Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FullTextStopListAction node)
        {
            Console.WriteLine("FullTextStopListAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FullTextTableReference node)
        {
            Console.WriteLine("FullTextTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FunctionCall node)
        {
            Console.WriteLine("FunctionCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FunctionCallSetClause node)
        {
            Console.WriteLine("FunctionCallSetClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FunctionOption node)
        {
            Console.WriteLine("FunctionOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FunctionReturnType node)
        {
            Console.WriteLine("FunctionReturnType Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(FunctionStatementBody node)
        {
            Console.WriteLine("FunctionStatementBody Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(GeneralSetCommand node)
        {
            Console.WriteLine("GeneralSetCommand Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(GetConversationGroupStatement node)
        {
            Console.WriteLine("GetConversationGroupStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(GlobalVariableExpression node)
        {
            Console.WriteLine("GlobalVariableExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(GoToStatement node)
        {
            Console.WriteLine("GoToStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(GrandTotalGroupingSpecification node)
        {
            Console.WriteLine("GrandTotalGroupingSpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(GrantStatement node)
        {
            Console.WriteLine("GrantStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(GrantStatement80 node)
        {
            Console.WriteLine("GrantStatement80 Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(GridParameter node)
        {
            Console.WriteLine("GridParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(GridsSpatialIndexOption node)
        {
            Console.WriteLine("GridsSpatialIndexOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(GroupByClause node)
        {
            Console.WriteLine("GroupByClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(GroupingSetsGroupingSpecification node)
        {
            Console.WriteLine("GroupingSetsGroupingSpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(GroupingSpecification node)
        {
            Console.WriteLine("GroupingSpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(HadrAvailabilityGroupDatabaseOption node)
        {
            Console.WriteLine("HadrAvailabilityGroupDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(HadrDatabaseOption node)
        {
            Console.WriteLine("HadrDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(HavingClause node)
        {
            Console.WriteLine("HavingClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(Identifier node)
        {
            Console.WriteLine("Identifier Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IdentifierAtomicBlockOption node)
        {
            Console.WriteLine("IdentifierAtomicBlockOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IdentifierDatabaseOption node)
        {
            Console.WriteLine("IdentifierDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IdentifierLiteral node)
        {
            Console.WriteLine("IdentifierLiteral Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IdentifierOrValueExpression node)
        {
            Console.WriteLine("IdentifierOrValueExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IdentifierPrincipalOption node)
        {
            Console.WriteLine("IdentifierPrincipalOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IdentifierSnippet node)
        {
            Console.WriteLine("IdentifierSnippet Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IdentityFunctionCall node)
        {
            Console.WriteLine("IdentityFunctionCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IdentityOptions node)
        {
            Console.WriteLine("IdentityOptions Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IdentityValueKeyOption node)
        {
            Console.WriteLine("IdentityValueKeyOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IfStatement node)
        {
            Console.WriteLine("IfStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IIfCall node)
        {
            Console.WriteLine("IIfCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IndexDefinition node)
        {
            Console.WriteLine("IndexDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IndexExpressionOption node)
        {
            Console.WriteLine("IndexExpressionOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IndexOption node)
        {
            Console.WriteLine("IndexOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IndexStatement node)
        {
            Console.WriteLine("IndexStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IndexStateOption node)
        {
            Console.WriteLine("IndexStateOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IndexTableHint node)
        {
            Console.WriteLine("IndexTableHint Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IndexType node)
        {
            Console.WriteLine("IndexType Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(InlineDerivedTable node)
        {
            Console.WriteLine("InlineDerivedTable Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(InlineResultSetDefinition node)
        {
            Console.WriteLine("InlineResultSetDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(InPredicate node)
        {
            Console.WriteLine("InPredicate Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(InsertBulkColumnDefinition node)
        {
            Console.WriteLine("InsertBulkColumnDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(InsertBulkStatement node)
        {
            Console.WriteLine("InsertBulkStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(InsertMergeAction node)
        {
            Console.WriteLine("InsertMergeAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(InsertSource node)
        {
            Console.WriteLine("InsertSource Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(InsertSpecification node)
        {
            Console.WriteLine("InsertSpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(InsertStatement node)
        {
            Console.WriteLine("InsertStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IntegerLiteral node)
        {
            Console.WriteLine("IntegerLiteral Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(InternalOpenRowset node)
        {
            Console.WriteLine("InternalOpenRowset Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(IPv4 node)
        {
            Console.WriteLine("IPv4 Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(JoinParenthesisTableReference node)
        {
            Console.WriteLine("JoinParenthesisTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(JoinTableReference node)
        {
            Console.WriteLine("JoinTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(JsonForClause node)
        {
            Console.WriteLine("JsonForClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(JsonForClauseOption node)
        {
            Console.WriteLine("JsonForClauseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(KeyOption node)
        {
            Console.WriteLine("KeyOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(KeySourceKeyOption node)
        {
            Console.WriteLine("KeySourceKeyOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(KillQueryNotificationSubscriptionStatement node)
        {
            Console.WriteLine("KillQueryNotificationSubscriptionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(KillStatement node)
        {
            Console.WriteLine("KillStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(KillStatsJobStatement node)
        {
            Console.WriteLine("KillStatsJobStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LabelStatement node)
        {
            Console.WriteLine("LabelStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LeftFunctionCall node)
        {
            Console.WriteLine("LeftFunctionCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LikePredicate node)
        {
            Console.WriteLine("LikePredicate Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LineNoStatement node)
        {
            Console.WriteLine("LineNoStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ListenerIPEndpointProtocolOption node)
        {
            Console.WriteLine("ListenerIPEndpointProtocolOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(Literal node)
        {
            Console.WriteLine("Literal Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LiteralAtomicBlockOption node)
        {
            Console.WriteLine("LiteralAtomicBlockOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LiteralAuditTargetOption node)
        {
            Console.WriteLine("LiteralAuditTargetOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LiteralAvailabilityGroupOption node)
        {
            Console.WriteLine("LiteralAvailabilityGroupOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LiteralBulkInsertOption node)
        {
            Console.WriteLine("LiteralBulkInsertOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LiteralDatabaseOption node)
        {
            Console.WriteLine("LiteralDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LiteralEndpointProtocolOption node)
        {
            Console.WriteLine("LiteralEndpointProtocolOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LiteralOptimizerHint node)
        {
            Console.WriteLine("LiteralOptimizerHint Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LiteralOptionValue node)
        {
            Console.WriteLine("LiteralOptionValue Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LiteralPayloadOption node)
        {
            Console.WriteLine("LiteralPayloadOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LiteralPrincipalOption node)
        {
            Console.WriteLine("LiteralPrincipalOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LiteralRange node)
        {
            Console.WriteLine("LiteralRange Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LiteralReplicaOption node)
        {
            Console.WriteLine("LiteralReplicaOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LiteralSessionOption node)
        {
            Console.WriteLine("LiteralSessionOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LiteralStatisticsOption node)
        {
            Console.WriteLine("LiteralStatisticsOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LiteralTableHint node)
        {
            Console.WriteLine("LiteralTableHint Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LockEscalationTableOption node)
        {
            Console.WriteLine("LockEscalationTableOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LoginTypePayloadOption node)
        {
            Console.WriteLine("LoginTypePayloadOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LowPriorityLockWaitAbortAfterWaitOption node)
        {
            Console.WriteLine("LowPriorityLockWaitAbortAfterWaitOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LowPriorityLockWaitMaxDurationOption node)
        {
            Console.WriteLine("LowPriorityLockWaitMaxDurationOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LowPriorityLockWaitOption node)
        {
            Console.WriteLine("LowPriorityLockWaitOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(LowPriorityLockWaitTableSwitchOption node)
        {
            Console.WriteLine("LowPriorityLockWaitTableSwitchOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MasterKeyStatement node)
        {
            Console.WriteLine("MasterKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MaxDispatchLatencySessionOption node)
        {
            Console.WriteLine("MaxDispatchLatencySessionOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MaxLiteral node)
        {
            Console.WriteLine("MaxLiteral Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MaxRolloverFilesAuditTargetOption node)
        {
            Console.WriteLine("MaxRolloverFilesAuditTargetOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MaxSizeAuditTargetOption node)
        {
            Console.WriteLine("MaxSizeAuditTargetOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MaxSizeDatabaseOption node)
        {
            Console.WriteLine("MaxSizeDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MaxSizeFileDeclarationOption node)
        {
            Console.WriteLine("MaxSizeFileDeclarationOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MemoryOptimizedTableOption node)
        {
            Console.WriteLine("MemoryOptimizedTableOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MemoryPartitionSessionOption node)
        {
            Console.WriteLine("MemoryPartitionSessionOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MergeAction node)
        {
            Console.WriteLine("MergeAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MergeActionClause node)
        {
            Console.WriteLine("MergeActionClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MergeSpecification node)
        {
            Console.WriteLine("MergeSpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MergeStatement node)
        {
            Console.WriteLine("MergeStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MessageTypeStatementBase node)
        {
            Console.WriteLine("MessageTypeStatementBase Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MethodSpecifier node)
        {
            Console.WriteLine("MethodSpecifier Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MirrorToClause node)
        {
            Console.WriteLine("MirrorToClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MoneyLiteral node)
        {
            Console.WriteLine("MoneyLiteral Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MoveConversationStatement node)
        {
            Console.WriteLine("MoveConversationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MoveRestoreOption node)
        {
            Console.WriteLine("MoveRestoreOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MoveToDropIndexOption node)
        {
            Console.WriteLine("MoveToDropIndexOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MultiPartIdentifier node)
        {
            Console.WriteLine("MultiPartIdentifier Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(MultiPartIdentifierCallTarget node)
        {
            Console.WriteLine("MultiPartIdentifierCallTarget Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(NamedTableReference node)
        {
            Console.WriteLine("NamedTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(NameFileDeclarationOption node)
        {
            Console.WriteLine("NameFileDeclarationOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(NextValueForExpression node)
        {
            Console.WriteLine("NextValueForExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(NullableConstraintDefinition node)
        {
            Console.WriteLine("NullableConstraintDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(NullIfExpression node)
        {
            Console.WriteLine("NullIfExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(NullLiteral node)
        {
            Console.WriteLine("NullLiteral Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(NumericLiteral node)
        {
            Console.WriteLine("NumericLiteral Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OdbcConvertSpecification node)
        {
            Console.WriteLine("OdbcConvertSpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OdbcFunctionCall node)
        {
            Console.WriteLine("OdbcFunctionCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OdbcLiteral node)
        {
            Console.WriteLine("OdbcLiteral Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OdbcQualifiedJoinTableReference node)
        {
            Console.WriteLine("OdbcQualifiedJoinTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OffsetClause node)
        {
            Console.WriteLine("OffsetClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OnFailureAuditOption node)
        {
            Console.WriteLine("OnFailureAuditOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OnlineIndexLowPriorityLockWaitOption node)
        {
            Console.WriteLine("OnlineIndexLowPriorityLockWaitOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OnlineIndexOption node)
        {
            Console.WriteLine("OnlineIndexOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OnOffAssemblyOption node)
        {
            Console.WriteLine("OnOffAssemblyOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OnOffAtomicBlockOption node)
        {
            Console.WriteLine("OnOffAtomicBlockOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OnOffAuditTargetOption node)
        {
            Console.WriteLine("OnOffAuditTargetOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OnOffDatabaseOption node)
        {
            Console.WriteLine("OnOffDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OnOffDialogOption node)
        {
            Console.WriteLine("OnOffDialogOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OnOffFullTextCatalogOption node)
        {
            Console.WriteLine("OnOffFullTextCatalogOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OnOffOptionValue node)
        {
            Console.WriteLine("OnOffOptionValue Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OnOffPrincipalOption node)
        {
            Console.WriteLine("OnOffPrincipalOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OnOffRemoteServiceBindingOption node)
        {
            Console.WriteLine("OnOffRemoteServiceBindingOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OnOffSessionOption node)
        {
            Console.WriteLine("OnOffSessionOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OnOffStatisticsOption node)
        {
            Console.WriteLine("OnOffStatisticsOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OpenCursorStatement node)
        {
            Console.WriteLine("OpenCursorStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OpenJsonTableReference node)
        {
            Console.WriteLine("OpenJsonTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OpenMasterKeyStatement node)
        {
            Console.WriteLine("OpenMasterKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OpenQueryTableReference node)
        {
            Console.WriteLine("OpenQueryTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OpenRowsetTableReference node)
        {
            Console.WriteLine("OpenRowsetTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OpenSymmetricKeyStatement node)
        {
            Console.WriteLine("OpenSymmetricKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OpenXmlTableReference node)
        {
            Console.WriteLine("OpenXmlTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OptimizeForOptimizerHint node)
        {
            Console.WriteLine("OptimizeForOptimizerHint Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OptimizerHint node)
        {
            Console.WriteLine("OptimizerHint Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OptionValue node)
        {
            Console.WriteLine("OptionValue Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OrderBulkInsertOption node)
        {
            Console.WriteLine("OrderBulkInsertOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OrderByClause node)
        {
            Console.WriteLine("OrderByClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OrderIndexOption node)
        {
            Console.WriteLine("OrderIndexOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OutputClause node)
        {
            Console.WriteLine("OutputClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OutputIntoClause node)
        {
            Console.WriteLine("OutputIntoClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(OverClause node)
        {
            Console.WriteLine("OverClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PageVerifyDatabaseOption node)
        {
            Console.WriteLine("PageVerifyDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ParameterizationDatabaseOption node)
        {
            Console.WriteLine("ParameterizationDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ParameterizedDataTypeReference node)
        {
            Console.WriteLine("ParameterizedDataTypeReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ParameterlessCall node)
        {
            Console.WriteLine("ParameterlessCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ParenthesisExpression node)
        {
            Console.WriteLine("ParenthesisExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ParseCall node)
        {
            Console.WriteLine("ParseCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PartitionFunctionCall node)
        {
            Console.WriteLine("PartitionFunctionCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PartitionParameterType node)
        {
            Console.WriteLine("PartitionParameterType Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PartitionSpecifier node)
        {
            Console.WriteLine("PartitionSpecifier Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PartnerDatabaseOption node)
        {
            Console.WriteLine("PartnerDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PasswordAlterPrincipalOption node)
        {
            Console.WriteLine("PasswordAlterPrincipalOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PasswordCreateLoginSource node)
        {
            Console.WriteLine("PasswordCreateLoginSource Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PayloadOption node)
        {
            Console.WriteLine("PayloadOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(Permission node)
        {
            Console.WriteLine("Permission Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PermissionSetAssemblyOption node)
        {
            Console.WriteLine("PermissionSetAssemblyOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PivotedTableReference node)
        {
            Console.WriteLine("PivotedTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PortsEndpointProtocolOption node)
        {
            Console.WriteLine("PortsEndpointProtocolOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PredicateSetStatement node)
        {
            Console.WriteLine("PredicateSetStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PrimaryExpression node)
        {
            Console.WriteLine("PrimaryExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PrimaryRoleReplicaOption node)
        {
            Console.WriteLine("PrimaryRoleReplicaOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PrincipalOption node)
        {
            Console.WriteLine("PrincipalOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PrintStatement node)
        {
            Console.WriteLine("PrintStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(Privilege80 node)
        {
            Console.WriteLine("Privilege80 Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(PrivilegeSecurityElement80 node)
        {
            Console.WriteLine("PrivilegeSecurityElement80 Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ProcedureOption node)
        {
            Console.WriteLine("ProcedureOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ProcedureParameter node)
        {
            Console.WriteLine("ProcedureParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ProcedureReference node)
        {
            Console.WriteLine("ProcedureReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ProcedureReferenceName node)
        {
            Console.WriteLine("ProcedureReferenceName Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ProcedureStatementBody node)
        {
            Console.WriteLine("ProcedureStatementBody Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ProcedureStatementBodyBase node)
        {
            Console.WriteLine("ProcedureStatementBodyBase Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ProcessAffinityRange node)
        {
            Console.WriteLine("ProcessAffinityRange Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ProviderEncryptionSource node)
        {
            Console.WriteLine("ProviderEncryptionSource Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ProviderKeyNameKeyOption node)
        {
            Console.WriteLine("ProviderKeyNameKeyOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QualifiedJoin node)
        {
            Console.WriteLine("QualifiedJoin Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueryDerivedTable node)
        {
            Console.WriteLine("QueryDerivedTable Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueryExpression node)
        {
            Console.WriteLine("QueryExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueryParenthesisExpression node)
        {
            Console.WriteLine("QueryParenthesisExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QuerySpecification node)
        {
            Console.WriteLine("QuerySpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueryStoreCapturePolicyOption node)
        {
            Console.WriteLine("QueryStoreCapturePolicyOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueryStoreDatabaseOption node)
        {
            Console.WriteLine("QueryStoreDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueryStoreDataFlushIntervalOption node)
        {
            Console.WriteLine("QueryStoreDataFlushIntervalOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueryStoreDesiredStateOption node)
        {
            Console.WriteLine("QueryStoreDesiredStateOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueryStoreIntervalLengthOption node)
        {
            Console.WriteLine("QueryStoreIntervalLengthOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueryStoreMaxPlansPerQueryOption node)
        {
            Console.WriteLine("QueryStoreMaxPlansPerQueryOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueryStoreMaxStorageSizeOption node)
        {
            Console.WriteLine("QueryStoreMaxStorageSizeOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueryStoreOption node)
        {
            Console.WriteLine("QueryStoreOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueryStoreSizeCleanupPolicyOption node)
        {
            Console.WriteLine("QueryStoreSizeCleanupPolicyOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueryStoreTimeCleanupPolicyOption node)
        {
            Console.WriteLine("QueryStoreTimeCleanupPolicyOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueueDelayAuditOption node)
        {
            Console.WriteLine("QueueDelayAuditOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueueExecuteAsOption node)
        {
            Console.WriteLine("QueueExecuteAsOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueueOption node)
        {
            Console.WriteLine("QueueOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueueProcedureOption node)
        {
            Console.WriteLine("QueueProcedureOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueueStatement node)
        {
            Console.WriteLine("QueueStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueueStateOption node)
        {
            Console.WriteLine("QueueStateOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(QueueValueOption node)
        {
            Console.WriteLine("QueueValueOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RaiseErrorLegacyStatement node)
        {
            Console.WriteLine("RaiseErrorLegacyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RaiseErrorStatement node)
        {
            Console.WriteLine("RaiseErrorStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ReadOnlyForClause node)
        {
            Console.WriteLine("ReadOnlyForClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ReadTextStatement node)
        {
            Console.WriteLine("ReadTextStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RealLiteral node)
        {
            Console.WriteLine("RealLiteral Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ReceiveStatement node)
        {
            Console.WriteLine("ReceiveStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ReconfigureStatement node)
        {
            Console.WriteLine("ReconfigureStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RecoveryDatabaseOption node)
        {
            Console.WriteLine("RecoveryDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RemoteDataArchiveAlterTableOption node)
        {
            Console.WriteLine("RemoteDataArchiveAlterTableOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RemoteDataArchiveDatabaseOption node)
        {
            Console.WriteLine("RemoteDataArchiveDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RemoteDataArchiveDatabaseSetting node)
        {
            Console.WriteLine("RemoteDataArchiveDatabaseSetting Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RemoteDataArchiveDbCredentialSetting node)
        {
            Console.WriteLine("RemoteDataArchiveDbCredentialSetting Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RemoteDataArchiveDbFederatedServiceAccountSetting node)
        {
            Console.WriteLine("RemoteDataArchiveDbFederatedServiceAccountSetting Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RemoteDataArchiveDbServerSetting node)
        {
            Console.WriteLine("RemoteDataArchiveDbServerSetting Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RemoteDataArchiveTableOption node)
        {
            Console.WriteLine("RemoteDataArchiveTableOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RemoteServiceBindingOption node)
        {
            Console.WriteLine("RemoteServiceBindingOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RemoteServiceBindingStatementBase node)
        {
            Console.WriteLine("RemoteServiceBindingStatementBase Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RenameAlterRoleAction node)
        {
            Console.WriteLine("RenameAlterRoleAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ResampleStatisticsOption node)
        {
            Console.WriteLine("ResampleStatisticsOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ResourcePoolAffinitySpecification node)
        {
            Console.WriteLine("ResourcePoolAffinitySpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ResourcePoolParameter node)
        {
            Console.WriteLine("ResourcePoolParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ResourcePoolStatement node)
        {
            Console.WriteLine("ResourcePoolStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RestoreMasterKeyStatement node)
        {
            Console.WriteLine("RestoreMasterKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RestoreOption node)
        {
            Console.WriteLine("RestoreOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RestoreServiceMasterKeyStatement node)
        {
            Console.WriteLine("RestoreServiceMasterKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RestoreStatement node)
        {
            Console.WriteLine("RestoreStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ResultColumnDefinition node)
        {
            Console.WriteLine("ResultColumnDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ResultSetDefinition node)
        {
            Console.WriteLine("ResultSetDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ResultSetsExecuteOption node)
        {
            Console.WriteLine("ResultSetsExecuteOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ReturnStatement node)
        {
            Console.WriteLine("ReturnStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RevertStatement node)
        {
            Console.WriteLine("RevertStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RevokeStatement node)
        {
            Console.WriteLine("RevokeStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RevokeStatement80 node)
        {
            Console.WriteLine("RevokeStatement80 Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RightFunctionCall node)
        {
            Console.WriteLine("RightFunctionCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RolePayloadOption node)
        {
            Console.WriteLine("RolePayloadOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RoleStatement node)
        {
            Console.WriteLine("RoleStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RollbackTransactionStatement node)
        {
            Console.WriteLine("RollbackTransactionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RollupGroupingSpecification node)
        {
            Console.WriteLine("RollupGroupingSpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RouteOption node)
        {
            Console.WriteLine("RouteOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RouteStatement node)
        {
            Console.WriteLine("RouteStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(RowValue node)
        {
            Console.WriteLine("RowValue Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SaveTransactionStatement node)
        {
            Console.WriteLine("SaveTransactionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ScalarExpression node)
        {
            Console.WriteLine("ScalarExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ScalarExpressionDialogOption node)
        {
            Console.WriteLine("ScalarExpressionDialogOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ScalarExpressionRestoreOption node)
        {
            Console.WriteLine("ScalarExpressionRestoreOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ScalarExpressionSequenceOption node)
        {
            Console.WriteLine("ScalarExpressionSequenceOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ScalarExpressionSnippet node)
        {
            Console.WriteLine("ScalarExpressionSnippet Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ScalarFunctionReturnType node)
        {
            Console.WriteLine("ScalarFunctionReturnType Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ScalarSubquery node)
        {
            Console.WriteLine("ScalarSubquery Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SchemaDeclarationItem node)
        {
            Console.WriteLine("SchemaDeclarationItem Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SchemaObjectFunctionTableReference node)
        {
            Console.WriteLine("SchemaObjectFunctionTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SchemaObjectName node)
        {
            Console.WriteLine("SchemaObjectName Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SchemaObjectNameOrValueExpression node)
        {
            Console.WriteLine("SchemaObjectNameOrValueExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SchemaObjectNameSnippet node)
        {
            Console.WriteLine("SchemaObjectNameSnippet Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SchemaObjectResultSetDefinition node)
        {
            Console.WriteLine("SchemaObjectResultSetDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SchemaPayloadOption node)
        {
            Console.WriteLine("SchemaPayloadOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SearchedCaseExpression node)
        {
            Console.WriteLine("SearchedCaseExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SearchedWhenClause node)
        {
            Console.WriteLine("SearchedWhenClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SearchPropertyListAction node)
        {
            Console.WriteLine("SearchPropertyListAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SearchPropertyListFullTextIndexOption node)
        {
            Console.WriteLine("SearchPropertyListFullTextIndexOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SecondaryRoleReplicaOption node)
        {
            Console.WriteLine("SecondaryRoleReplicaOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SecurityElement80 node)
        {
            Console.WriteLine("SecurityElement80 Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SecurityPolicyOption node)
        {
            Console.WriteLine("SecurityPolicyOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SecurityPolicyStatement node)
        {
            Console.WriteLine("SecurityPolicyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SecurityPredicateAction node)
        {
            Console.WriteLine("SecurityPredicateAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SecurityPrincipal node)
        {
            Console.WriteLine("SecurityPrincipal Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SecurityStatement node)
        {
            Console.WriteLine("SecurityStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SecurityStatementBody80 node)
        {
            Console.WriteLine("SecurityStatementBody80 Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SecurityTargetObject node)
        {
            Console.WriteLine("SecurityTargetObject Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SecurityTargetObjectName node)
        {
            Console.WriteLine("SecurityTargetObjectName Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SecurityUserClause80 node)
        {
            Console.WriteLine("SecurityUserClause80 Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SelectElement node)
        {
            Console.WriteLine("SelectElement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SelectFunctionReturnType node)
        {
            Console.WriteLine("SelectFunctionReturnType Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SelectInsertSource node)
        {
            Console.WriteLine("SelectInsertSource Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SelectiveXmlIndexPromotedPath node)
        {
            Console.WriteLine("SelectiveXmlIndexPromotedPath Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SelectScalarExpression node)
        {
            Console.WriteLine("SelectScalarExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SelectSetVariable node)
        {
            Console.WriteLine("SelectSetVariable Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SelectStarExpression node)
        {
            Console.WriteLine("SelectStarExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SelectStatement node)
        {
            Console.WriteLine("SelectStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SelectStatementSnippet node)
        {
            Console.WriteLine("SelectStatementSnippet Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SemanticTableReference node)
        {
            Console.WriteLine("SemanticTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SendStatement node)
        {
            Console.WriteLine("SendStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SequenceOption node)
        {
            Console.WriteLine("SequenceOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SequenceStatement node)
        {
            Console.WriteLine("SequenceStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ServerAuditStatement node)
        {
            Console.WriteLine("ServerAuditStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ServiceContract node)
        {
            Console.WriteLine("ServiceContract Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SessionOption node)
        {
            Console.WriteLine("SessionOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SessionTimeoutPayloadOption node)
        {
            Console.WriteLine("SessionTimeoutPayloadOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetClause node)
        {
            Console.WriteLine("SetClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetCommand node)
        {
            Console.WriteLine("SetCommand Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetCommandStatement node)
        {
            Console.WriteLine("SetCommandStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetErrorLevelStatement node)
        {
            Console.WriteLine("SetErrorLevelStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetFipsFlaggerCommand node)
        {
            Console.WriteLine("SetFipsFlaggerCommand Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetIdentityInsertStatement node)
        {
            Console.WriteLine("SetIdentityInsertStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetOffsetsStatement node)
        {
            Console.WriteLine("SetOffsetsStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetOnOffStatement node)
        {
            Console.WriteLine("SetOnOffStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetRowCountStatement node)
        {
            Console.WriteLine("SetRowCountStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetSearchPropertyListAlterFullTextIndexAction node)
        {
            Console.WriteLine("SetSearchPropertyListAlterFullTextIndexAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetStatisticsStatement node)
        {
            Console.WriteLine("SetStatisticsStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetStopListAlterFullTextIndexAction node)
        {
            Console.WriteLine("SetStopListAlterFullTextIndexAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetTextSizeStatement node)
        {
            Console.WriteLine("SetTextSizeStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetTransactionIsolationLevelStatement node)
        {
            Console.WriteLine("SetTransactionIsolationLevelStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetUserStatement node)
        {
            Console.WriteLine("SetUserStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SetVariableStatement node)
        {
            Console.WriteLine("SetVariableStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ShutdownStatement node)
        {
            Console.WriteLine("ShutdownStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SignatureStatementBase node)
        {
            Console.WriteLine("SignatureStatementBase Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SimpleAlterFullTextIndexAction node)
        {
            Console.WriteLine("SimpleAlterFullTextIndexAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SimpleCaseExpression node)
        {
            Console.WriteLine("SimpleCaseExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SimpleWhenClause node)
        {
            Console.WriteLine("SimpleWhenClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SizeFileDeclarationOption node)
        {
            Console.WriteLine("SizeFileDeclarationOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SoapMethod node)
        {
            Console.WriteLine("SoapMethod Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SourceDeclaration node)
        {
            Console.WriteLine("SourceDeclaration Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SpatialIndexOption node)
        {
            Console.WriteLine("SpatialIndexOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SpatialIndexRegularOption node)
        {
            Console.WriteLine("SpatialIndexRegularOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SqlCommandIdentifier node)
        {
            Console.WriteLine("SqlCommandIdentifier Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SqlDataTypeReference node)
        {
            Console.WriteLine("SqlDataTypeReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(StateAuditOption node)
        {
            Console.WriteLine("StateAuditOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(StatementList node)
        {
            Console.WriteLine("StatementList Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(StatementListSnippet node)
        {
            Console.WriteLine("StatementListSnippet Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(StatementWithCtesAndXmlNamespaces node)
        {
            Console.WriteLine("StatementWithCtesAndXmlNamespaces Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(StatisticsOption node)
        {
            Console.WriteLine("StatisticsOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(StatisticsPartitionRange node)
        {
            Console.WriteLine("StatisticsPartitionRange Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(StopListFullTextIndexOption node)
        {
            Console.WriteLine("StopListFullTextIndexOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(StopRestoreOption node)
        {
            Console.WriteLine("StopRestoreOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(StringLiteral node)
        {
            Console.WriteLine("StringLiteral Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SubqueryComparisonPredicate node)
        {
            Console.WriteLine("SubqueryComparisonPredicate Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SymmetricKeyStatement node)
        {
            Console.WriteLine("SymmetricKeyStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SystemTimePeriodDefinition node)
        {
            Console.WriteLine("SystemTimePeriodDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(SystemVersioningTableOption node)
        {
            Console.WriteLine("SystemVersioningTableOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TableDataCompressionOption node)
        {
            Console.WriteLine("TableDataCompressionOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TableDefinition node)
        {
            Console.WriteLine("TableDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TableHint node)
        {
            Console.WriteLine("TableHint Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TableHintsOptimizerHint node)
        {
            Console.WriteLine("TableHintsOptimizerHint Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TableOption node)
        {
            Console.WriteLine("TableOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TableReference node)
        {
            Console.WriteLine("TableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TableReferenceWithAlias node)
        {
            Console.WriteLine("TableReferenceWithAlias Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TableReferenceWithAliasAndColumns node)
        {
            Console.WriteLine("TableReferenceWithAliasAndColumns Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TableSampleClause node)
        {
            Console.WriteLine("TableSampleClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TableSwitchOption node)
        {
            Console.WriteLine("TableSwitchOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TableValuedFunctionReturnType node)
        {
            Console.WriteLine("TableValuedFunctionReturnType Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TargetDeclaration node)
        {
            Console.WriteLine("TargetDeclaration Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TargetRecoveryTimeDatabaseOption node)
        {
            Console.WriteLine("TargetRecoveryTimeDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TemporalClause node)
        {
            Console.WriteLine("TemporalClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TextModificationStatement node)
        {
            Console.WriteLine("TextModificationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ThrowStatement node)
        {
            Console.WriteLine("ThrowStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TopRowFilter node)
        {
            Console.WriteLine("TopRowFilter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TransactionStatement node)
        {
            Console.WriteLine("TransactionStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TriggerAction node)
        {
            Console.WriteLine("TriggerAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TriggerObject node)
        {
            Console.WriteLine("TriggerObject Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TriggerOption node)
        {
            Console.WriteLine("TriggerOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TriggerStatementBody node)
        {
            Console.WriteLine("TriggerStatementBody Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TruncateTableStatement node)
        {
            Console.WriteLine("TruncateTableStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TryCastCall node)
        {
            Console.WriteLine("TryCastCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TryCatchStatement node)
        {
            Console.WriteLine("TryCatchStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TryConvertCall node)
        {
            Console.WriteLine("TryConvertCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TryParseCall node)
        {
            Console.WriteLine("TryParseCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TSEqualCall node)
        {
            Console.WriteLine("TSEqualCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TSqlBatch node)
        {
            Console.WriteLine("TSqlBatch Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TSqlFragment node)
        {
            Console.WriteLine("TSqlFragment Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TSqlFragmentSnippet node)
        {
            Console.WriteLine("TSqlFragmentSnippet Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TSqlScript node)
        {
            Console.WriteLine("TSqlScript Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TSqlStatement node)
        {
            Console.WriteLine("TSqlStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(TSqlStatementSnippet node)
        {
            Console.WriteLine("TSqlStatementSnippet Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UnaryExpression node)
        {
            Console.WriteLine("UnaryExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UniqueConstraintDefinition node)
        {
            Console.WriteLine("UniqueConstraintDefinition Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UnpivotedTableReference node)
        {
            Console.WriteLine("UnpivotedTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UnqualifiedJoin node)
        {
            Console.WriteLine("UnqualifiedJoin Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UpdateCall node)
        {
            Console.WriteLine("UpdateCall Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UpdateDeleteSpecificationBase node)
        {
            Console.WriteLine("UpdateDeleteSpecificationBase Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UpdateForClause node)
        {
            Console.WriteLine("UpdateForClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UpdateMergeAction node)
        {
            Console.WriteLine("UpdateMergeAction Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UpdateSpecification node)
        {
            Console.WriteLine("UpdateSpecification Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UpdateStatement node)
        {
            Console.WriteLine("UpdateStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UpdateStatisticsStatement node)
        {
            Console.WriteLine("UpdateStatisticsStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UpdateTextStatement node)
        {
            Console.WriteLine("UpdateTextStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UseFederationStatement node)
        {
            Console.WriteLine("UseFederationStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UserDataTypeReference node)
        {
            Console.WriteLine("UserDataTypeReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UserDefinedTypeCallTarget node)
        {
            Console.WriteLine("UserDefinedTypeCallTarget Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UserDefinedTypePropertyAccess node)
        {
            Console.WriteLine("UserDefinedTypePropertyAccess Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UserLoginOption node)
        {
            Console.WriteLine("UserLoginOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UserRemoteServiceBindingOption node)
        {
            Console.WriteLine("UserRemoteServiceBindingOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UserStatement node)
        {
            Console.WriteLine("UserStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(UseStatement node)
        {
            Console.WriteLine("UseStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ValueExpression node)
        {
            Console.WriteLine("ValueExpression Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ValuesInsertSource node)
        {
            Console.WriteLine("ValuesInsertSource Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(VariableMethodCallTableReference node)
        {
            Console.WriteLine("VariableMethodCallTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(VariableReference node)
        {
            Console.WriteLine("VariableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(VariableTableReference node)
        {
            Console.WriteLine("VariableTableReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(VariableValuePair node)
        {
            Console.WriteLine("VariableValuePair Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ViewOption node)
        {
            Console.WriteLine("ViewOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(ViewStatementBody node)
        {
            Console.WriteLine("ViewStatementBody Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WaitForStatement node)
        {
            Console.WriteLine("WaitForStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WaitForSupportedStatement node)
        {
            Console.WriteLine("WaitForSupportedStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WhenClause node)
        {
            Console.WriteLine("WhenClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WhereClause node)
        {
            Console.WriteLine("WhereClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WhileStatement node)
        {
            Console.WriteLine("WhileStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WindowDelimiter node)
        {
            Console.WriteLine("WindowDelimiter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WindowFrameClause node)
        {
            Console.WriteLine("WindowFrameClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WindowsCreateLoginSource node)
        {
            Console.WriteLine("WindowsCreateLoginSource Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WithCtesAndXmlNamespaces node)
        {
            Console.WriteLine("WithCtesAndXmlNamespaces Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WithinGroupClause node)
        {
            Console.WriteLine("WithinGroupClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WitnessDatabaseOption node)
        {
            Console.WriteLine("WitnessDatabaseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WorkloadGroupImportanceParameter node)
        {
            Console.WriteLine("WorkloadGroupImportanceParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WorkloadGroupParameter node)
        {
            Console.WriteLine("WorkloadGroupParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WorkloadGroupResourceParameter node)
        {
            Console.WriteLine("WorkloadGroupResourceParameter Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WorkloadGroupStatement node)
        {
            Console.WriteLine("WorkloadGroupStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WriteTextStatement node)
        {
            Console.WriteLine("WriteTextStatement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(WsdlPayloadOption node)
        {
            Console.WriteLine("WsdlPayloadOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(XmlDataTypeReference node)
        {
            Console.WriteLine("XmlDataTypeReference Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(XmlForClause node)
        {
            Console.WriteLine("XmlForClause Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(XmlForClauseOption node)
        {
            Console.WriteLine("XmlForClauseOption Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(XmlNamespaces node)
        {
            Console.WriteLine("XmlNamespaces Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(XmlNamespacesAliasElement node)
        {
            Console.WriteLine("XmlNamespacesAliasElement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(XmlNamespacesDefaultElement node)
        {
            Console.WriteLine("XmlNamespacesDefaultElement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }

        public override void Visit(XmlNamespacesElement node)
        {
            Console.WriteLine("XmlNamespacesElement Called: {0}", GetFragmentText(node));
            Console.WriteLine();
        }
    }
}
