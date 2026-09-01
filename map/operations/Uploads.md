<!-- Generated file — do not edit; regenerated with the SDK. -->

# Uploads — operations

Accessor: `client.Uploads` · Source: `Api/Uploads.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AbortMultipart

- **Signature**: `AbortMultipart(UploadsAbortMultipartJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `UploadsAbortMultipartJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UploadsAbortMultipartJsonRequest` | `Models/UploadsAbortMultipartJsonRequest.cs` |
| `UploadsAbortMultipartJsonResponse` | `Models/UploadsAbortMultipartJsonResponse.cs` |

### BatchPresignMultipartParts

- **Signature**: `BatchPresignMultipartParts(UploadsBatchPresignMultipartPartsJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `UploadsBatchPresignMultipartPartsJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UploadsBatchPresignMultipartPartsJsonRequest` | `Models/UploadsBatchPresignMultipartPartsJsonRequest.cs` |
| `UploadsBatchPresignMultipartPartsJsonResponse` | `Models/UploadsBatchPresignMultipartPartsJsonResponse.cs` |

### CompleteExternalUpload

- **Signature**: `CompleteExternalUpload(UploadsCompleteExternalUploadJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `UploadsCompleteExternalUploadJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UploadsCompleteExternalUploadJsonRequest` | `Models/UploadsCompleteExternalUploadJsonRequest.cs` |
| `UploadsCompleteExternalUploadJsonResponse` | `Models/UploadsCompleteExternalUploadJsonResponse.cs` |

### CompleteMultipart

- **Signature**: `CompleteMultipart(UploadsCompleteMultipartJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `UploadsCompleteMultipartJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UploadsCompleteMultipartJsonRequest` | `Models/UploadsCompleteMultipartJsonRequest.cs` |
| `UploadsCompleteMultipartJsonResponse` | `Models/UploadsCompleteMultipartJsonResponse.cs` |

### CreateMultipartUpload

- **Signature**: `CreateMultipartUpload(UploadsCreateMultipartJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `UploadsCreateMultipartJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UploadsCreateMultipartJsonRequest` | `Models/UploadsCreateMultipartJsonRequest.cs` |
| `UploadsCreateMultipartJsonResponse` | `Models/UploadsCreateMultipartJsonResponse.cs` |

### CreateUpload

- **Signature**: `CreateUpload(UploadType uploadType, int? userId, bool? synchronous, BinaryContent? file, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `userId` — nullable, no default → **must pass explicitly**
  - `synchronous` — nullable, no default → **must pass explicitly**
  - `file` — nullable, no default → **must pass explicitly**
- **Returns**: `UploadsJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UploadType` | `Models/Enums/UploadType.cs` |
| `UploadsJsonResponse` | `Models/UploadsJsonResponse.cs` |

### GeneratePresignedPut

- **Signature**: `GeneratePresignedPut(UploadsGeneratePresignedPutJsonRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `UploadsGeneratePresignedPutJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UploadsGeneratePresignedPutJsonRequest` | `Models/UploadsGeneratePresignedPutJsonRequest.cs` |
| `UploadsGeneratePresignedPutJsonResponse` | `Models/UploadsGeneratePresignedPutJsonResponse.cs` |

