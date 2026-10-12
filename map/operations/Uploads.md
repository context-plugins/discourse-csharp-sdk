<!-- Generated file — do not edit; regenerated with the SDK. -->

# Uploads — operations

Accessor: `client.Uploads` · Source: `src/Discourse/Api/Uploads.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AbortMultipart

- **Signature**: `AbortMultipart(AbortMultipartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UploadsAbortMultipartJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AbortMultipartRequest` | `src/Discourse/Requests/Uploads/AbortMultipartRequest.cs` |
| `UploadsAbortMultipartJsonRequest` | `src/Discourse/Models/UploadsAbortMultipartJsonRequest.cs` |
| `UploadsAbortMultipartJsonResponse` | `src/Discourse/Models/UploadsAbortMultipartJsonResponse.cs` |

### BatchPresignMultipartParts

- **Signature**: `BatchPresignMultipartParts(BatchPresignMultipartPartsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UploadsBatchPresignMultipartPartsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchPresignMultipartPartsRequest` | `src/Discourse/Requests/Uploads/BatchPresignMultipartPartsRequest.cs` |
| `UploadsBatchPresignMultipartPartsJsonRequest` | `src/Discourse/Models/UploadsBatchPresignMultipartPartsJsonRequest.cs` |
| `UploadsBatchPresignMultipartPartsJsonResponse` | `src/Discourse/Models/UploadsBatchPresignMultipartPartsJsonResponse.cs` |

### CompleteExternalUpload

- **Signature**: `CompleteExternalUpload(CompleteExternalUploadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UploadsCompleteExternalUploadJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CompleteExternalUploadRequest` | `src/Discourse/Requests/Uploads/CompleteExternalUploadRequest.cs` |
| `UploadsCompleteExternalUploadJsonRequest` | `src/Discourse/Models/UploadsCompleteExternalUploadJsonRequest.cs` |
| `UploadsCompleteExternalUploadJsonResponse` | `src/Discourse/Models/UploadsCompleteExternalUploadJsonResponse.cs` |

### CompleteMultipart

- **Signature**: `CompleteMultipart(CompleteMultipartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UploadsCompleteMultipartJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CompleteMultipartRequest` | `src/Discourse/Requests/Uploads/CompleteMultipartRequest.cs` |
| `UploadsCompleteMultipartJsonRequest` | `src/Discourse/Models/UploadsCompleteMultipartJsonRequest.cs` |
| `UploadsCompleteMultipartJsonResponse` | `src/Discourse/Models/UploadsCompleteMultipartJsonResponse.cs` |

### CreateMultipartUpload

- **Signature**: `CreateMultipartUpload(CreateMultipartUploadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UploadsCreateMultipartJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateMultipartUploadRequest` | `src/Discourse/Requests/Uploads/CreateMultipartUploadRequest.cs` |
| `UploadsCreateMultipartJsonRequest` | `src/Discourse/Models/UploadsCreateMultipartJsonRequest.cs` |
| `UploadsCreateMultipartJsonResponse` | `src/Discourse/Models/UploadsCreateMultipartJsonResponse.cs` |

### CreateUpload

- **Signature**: `CreateUpload(CreateUploadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `UploadType`
- **Returns**: `UploadsJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateUploadRequest` | `src/Discourse/Requests/Uploads/CreateUploadRequest.cs` |
| `UploadType` | `src/Discourse/Models/Enums/UploadType.cs` |
| `UploadsJsonResponse` | `src/Discourse/Models/UploadsJsonResponse.cs` |

### GeneratePresignedPut

- **Signature**: `GeneratePresignedPut(GeneratePresignedPutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UploadsGeneratePresignedPutJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GeneratePresignedPutRequest` | `src/Discourse/Requests/Uploads/GeneratePresignedPutRequest.cs` |
| `UploadsGeneratePresignedPutJsonRequest` | `src/Discourse/Models/UploadsGeneratePresignedPutJsonRequest.cs` |
| `UploadsGeneratePresignedPutJsonResponse` | `src/Discourse/Models/UploadsGeneratePresignedPutJsonResponse.cs` |

