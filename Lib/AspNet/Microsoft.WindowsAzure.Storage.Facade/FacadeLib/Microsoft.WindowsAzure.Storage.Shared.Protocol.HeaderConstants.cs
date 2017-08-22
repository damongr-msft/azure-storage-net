using System;
namespace Microsoft.WindowsAzure.Storage.Shared.Protocol
{

public static class HeaderConstants
{
    public static readonly string UserAgent = "Azure-Storage/8.4.0 ";
    public const string UserAgentProductName = "Azure-Storage";
    public const string UserAgentProductVersion = "8.4.0";
    public const string PrefixForStorageHeader = "x-ms-";
    public const string TrueHeader = "true";
    public const string FalseHeader = "false";
    public const string PrefixForStorageProperties = "x-ms-prop-";
    public const string PrefixForStorageMetadata = "x-ms-meta-";
    public const string ContentDispositionResponseHeader = "Content-Disposition";
    public const string ContentLengthHeader = "Content-Length";
    public const string ContentLanguageHeader = "Content-Language";
    public const string EtagHeader = "ETag";
    public const string ServerEncrypted = "x-ms-server-encrypted";
    public const string ServerRequestEncrypted = "x-ms-request-server-encrypted";
    public const string RangeHeader = "x-ms-range";
    public const string RangeContentMD5Header = "x-ms-range-get-content-md5";
    public const string StorageVersionHeader = "x-ms-version";
    public const string CopySourceHeader = "x-ms-copy-source";
    public const string SourceIfMatchHeader = "x-ms-source-if-match";
    public const string SourceIfModifiedSinceHeader = "x-ms-source-if-modified-since";
    public const string SourceIfNoneMatchHeader = "x-ms-source-if-none-match";
    public const string SourceIfUnmodifiedSinceHeader = "x-ms-source-if-unmodified-since";
    public const string FileType = "x-ms-type";
    public const string FileCacheControlHeader = "x-ms-cache-control";
    public const string FileContentDispositionRequestHeader = "x-ms-content-disposition";
    public const string FileContentEncodingHeader = "x-ms-content-encoding";
    public const string FileContentLanguageHeader = "x-ms-content-language";
    public const string FileContentMD5Header = "x-ms-content-md5";
    public const string FileContentTypeHeader = "x-ms-content-type";
    public const string FileContentLengthHeader = "x-ms-content-length";
    public const string FileRangeWrite = "x-ms-write";
    public const string BlobType = "x-ms-blob-type";
    public const string SnapshotHeader = "x-ms-snapshot";
    public const string DeleteSnapshotHeader = "x-ms-delete-snapshots";
    public const string AccessTierHeader = "x-ms-access-tier";
    public const string ArchiveStatusHeader = "x-ms-archive-status";
    public const string AccessTierInferredHeader = "x-ms-access-tier-inferred";
    public const string BlobCacheControlHeader = "x-ms-blob-cache-control";
    public const string BlobContentDispositionRequestHeader = "x-ms-blob-content-disposition";
    public const string BlobContentEncodingHeader = "x-ms-blob-content-encoding";
    public const string BlobContentLanguageHeader = "x-ms-blob-content-language";
    public const string BlobContentMD5Header = "x-ms-blob-content-md5";
    public const string BlobContentTypeHeader = "x-ms-blob-content-type";
    public const string BlobContentLengthHeader = "x-ms-blob-content-length";
    public const string BlobSequenceNumber = "x-ms-blob-sequence-number";
    public const string SequenceNumberAction = "x-ms-sequence-number-action";
    public const string BlobCommittedBlockCount = "x-ms-blob-committed-block-count";
    public const string BlobAppendOffset = "x-ms-blob-append-offset";
    public const string IfSequenceNumberLEHeader = "x-ms-if-sequence-number-le";
    public const string IfSequenceNumberLTHeader = "x-ms-if-sequence-number-lt";
    public const string IfSequenceNumberEqHeader = "x-ms-if-sequence-number-eq";
    public const string IfMaxSizeLessThanOrEqualHeader = "x-ms-blob-condition-maxsize";
    public const string IfAppendPositionEqualHeader = "x-ms-blob-condition-appendpos";
    public const string LeaseIdHeader = "x-ms-lease-id";
    public const string LeaseStatus = "x-ms-lease-status";
    public const string LeaseState = "x-ms-lease-state";
    public const string PageWrite = "x-ms-page-write";
    public const string ApproximateMessagesCount = "x-ms-approximate-messages-count";
    public const string Date = "x-ms-date";
    public const string RequestIdHeader = "x-ms-request-id";
    public const string ClientRequestIdHeader = "x-ms-client-request-id";
    public const string BlobPublicAccess = "x-ms-blob-public-access";
    public const string RangeHeaderFormat = "bytes={0}-{1}";
    public const string TargetStorageVersion = "2017-04-17";
    public const string File = "File";
    public const string PageBlob = "PageBlob";
    public const string BlockBlob = "BlockBlob";
    public const string AppendBlob = "AppendBlob";
    public const string SnapshotsOnlyValue = "only";
    public const string IncludeSnapshotsValue = "include";
    public const string PopReceipt = "x-ms-popreceipt";
    public const string NextVisibleTime = "x-ms-time-next-visible";
    public const string PeekOnly = "peekonly";
    public const string ContainerPublicAccessType = "x-ms-blob-public-access";
    public const string LeaseActionHeader = "x-ms-lease-action";
    public const string ProposedLeaseIdHeader = "x-ms-proposed-lease-id";
    public const string LeaseDurationHeader = "x-ms-lease-duration";
    public const string LeaseBreakPeriodHeader = "x-ms-lease-break-period";
    public const string LeaseTimeHeader = "x-ms-lease-time";
    public const string KeyNameHeader = "x-ms-key-name";
    public const string CopyIdHeader = "x-ms-copy-id";
    public const string CopyCompletionTimeHeader = "x-ms-copy-completion-time";
    public const string CopyStatusHeader = "x-ms-copy-status";
    public const string CopyProgressHeader = "x-ms-copy-progress";
    public const string CopyDescriptionHeader = "x-ms-copy-status-description";
    public const string CopyActionHeader = "x-ms-copy-action";
    public const string CopyTypeHeader = "x-ms-copy-type";
    public const string CopyActionAbort = "abort";
    public const string IncrementalCopyHeader = "x-ms-incremental-copy";
    public const string CopyDestinationSnapshotHeader = "x-ms-copy-destination-snapshot";
    public const string ShareSize = "x-ms-share-size";
    public const string ShareQuota = "x-ms-share-quota";
    internal const string PayloadAcceptHeader = "Accept";
    internal const string PayloadContentTypeHeader = "Content-Type";
}

}