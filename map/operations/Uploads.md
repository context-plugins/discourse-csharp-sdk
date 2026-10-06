<!-- Generated file — do not edit; regenerated with the SDK. -->

# Uploads — operations

Accessor: `client.Uploads` · Source: `Api/Uploads.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AbortMultipart

- **Signature**: `AbortMultipart(AbortMultipartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UploadsAbortMultipartJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AbortMultipartRequest` | `Requests/Uploads/AbortMultipartRequest.cs` |
| `UploadsAbortMultipartJsonRequest` | `Models/UploadsAbortMultipartJsonRequest.cs` |
| `UploadsAbortMultipartJsonResponse` | `Models/UploadsAbortMultipartJsonResponse.cs` |

### BatchPresignMultipartParts

- **Signature**: `BatchPresignMultipartParts(BatchPresignMultipartPartsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UploadsBatchPresignMultipartPartsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchPresignMultipartPartsRequest` | `Requests/Uploads/BatchPresignMultipartPartsRequest.cs` |
| `UploadsBatchPresignMultipartPartsJsonRequest` | `Models/UploadsBatchPresignMultipartPartsJsonRequest.cs` |
| `UploadsBatchPresignMultipartPartsJsonResponse` | `Models/UploadsBatchPresignMultipartPartsJsonResponse.cs` |

### CompleteExternalUpload

- **Signature**: `CompleteExternalUpload(CompleteExternalUploadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UploadsCompleteExternalUploadJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CompleteExternalUploadRequest` | `Requests/Uploads/CompleteExternalUploadRequest.cs` |
| `UploadsCompleteExternalUploadJsonRequest` | `Models/UploadsCompleteExternalUploadJsonRequest.cs` |
| `UploadsCompleteExternalUploadJsonResponse` | `Models/UploadsCompleteExternalUploadJsonResponse.cs` |

### CompleteMultipart

- **Signature**: `CompleteMultipart(CompleteMultipartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UploadsCompleteMultipartJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CompleteMultipartRequest` | `Requests/Uploads/CompleteMultipartRequest.cs` |
| `UploadsCompleteMultipartJsonRequest` | `Models/UploadsCompleteMultipartJsonRequest.cs` |
| `UploadsCompleteMultipartJsonResponse` | `Models/UploadsCompleteMultipartJsonResponse.cs` |

### CreateMultipartUpload

- **Signature**: `CreateMultipartUpload(CreateMultipartUploadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UploadsCreateMultipartJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateMultipartUploadRequest` | `Requests/Uploads/CreateMultipartUploadRequest.cs` |
| `UploadsCreateMultipartJsonRequest` | `Models/UploadsCreateMultipartJsonRequest.cs` |
| `UploadsCreateMultipartJsonResponse` | `Models/UploadsCreateMultipartJsonResponse.cs` |

### CreateUpload

- **Signature**: `CreateUpload(CreateUploadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `UploadType`
- **Returns**: `UploadsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateUploadRequest` | `Requests/Uploads/CreateUploadRequest.cs` |
| `UploadType` | `Models/Enums/UploadType.cs` |
| `UploadsJsonResponse` | `Models/UploadsJsonResponse.cs` |

### GeneratePresignedPut

- **Signature**: `GeneratePresignedPut(GeneratePresignedPutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UploadsGeneratePresignedPutJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GeneratePresignedPutRequest` | `Requests/Uploads/GeneratePresignedPutRequest.cs` |
| `UploadsGeneratePresignedPutJsonRequest` | `Models/UploadsGeneratePresignedPutJsonRequest.cs` |
| `UploadsGeneratePresignedPutJsonResponse` | `Models/UploadsGeneratePresignedPutJsonResponse.cs` |

