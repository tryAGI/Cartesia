
#nullable enable

namespace Cartesia
{
    public partial class InfillClient
    {


        private static readonly global::Cartesia.EndPointSecurityRequirement s_InfillBytesSecurityRequirement0 =
            new global::Cartesia.EndPointSecurityRequirement
            {
                Authorizations = new global::Cartesia.EndPointAuthorizationRequirement[]
                {                    new global::Cartesia.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "APIKeyAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Cartesia.EndPointSecurityRequirement[] s_InfillBytesSecurityRequirements =
            new global::Cartesia.EndPointSecurityRequirement[]
            {                s_InfillBytesSecurityRequirement0,
            };
        partial void PrepareInfillBytesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Cartesia.InfillBytesCartesiaVersion cartesiaVersion,
            global::Cartesia.InfillBytesRequest request);
        partial void PrepareInfillBytesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Cartesia.InfillBytesCartesiaVersion cartesiaVersion,
            global::Cartesia.InfillBytesRequest request);
        partial void ProcessInfillBytesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInfillBytesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Infill (Bytes)<br/>
        /// Generate audio that smoothly connects two existing audio segments
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> InfillBytesAsync(

            global::Cartesia.InfillBytesRequest request,
            global::Cartesia.InfillBytesCartesiaVersion cartesiaVersion = global::Cartesia.InfillBytesCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await InfillBytesAsResponseAsync(

                request: request,
                cartesiaVersion: cartesiaVersion,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Infill (Bytes)<br/>
        /// Generate audio that smoothly connects two existing audio segments
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.IO.Stream> InfillBytesAsStreamAsync(

            global::Cartesia.InfillBytesRequest request,
            global::Cartesia.InfillBytesCartesiaVersion cartesiaVersion = global::Cartesia.InfillBytesCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareInfillBytesArguments(
                httpClient: HttpClient,
                cartesiaVersion: ref cartesiaVersion,
                request: request);


            var __authorizations = global::Cartesia.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_InfillBytesSecurityRequirements,
                operationName: "InfillBytesAsync");

            using var __timeoutCancellationTokenSource = global::Cartesia.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Cartesia.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Cartesia.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Cartesia.PathBuilder(
                                path: "/infill/bytes",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Cartesia.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

                __httpRequest.Headers.TryAddWithoutValidation("Cartesia-Version", cartesiaVersion.ToValueString());


                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.LeftAudio != default)
                            {

                                var __contentLeftAudio = new global::System.Net.Http.ByteArrayContent(request.LeftAudio ?? global::System.Array.Empty<byte>());
                                __contentLeftAudio.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.LeftAudioname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.LeftAudioname) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentLeftAudio,
                                    name: "\"left_audio\"",
                                    fileName: request.LeftAudioname != null ? $"\"{request.LeftAudioname}\"" : string.Empty);
                                if (__contentLeftAudio.Headers.ContentDisposition != null)
                                {
                                    __contentLeftAudio.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.RightAudio != default)
                            {

                                var __contentRightAudio = new global::System.Net.Http.ByteArrayContent(request.RightAudio ?? global::System.Array.Empty<byte>());
                                __contentRightAudio.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.RightAudioname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.RightAudioname) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentRightAudio,
                                    name: "\"right_audio\"",
                                    fileName: request.RightAudioname != null ? $"\"{request.RightAudioname}\"" : string.Empty);
                                if (__contentRightAudio.Headers.ContentDisposition != null)
                                {
                                    __contentRightAudio.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.ModelId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.ModelId).HasValue ? (request.ModelId).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"model_id\"");

                            }
                            if (request.Language != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Language).HasValue ? (request.Language).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"language\"");

                            }
                            if (request.Transcript != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Transcript ?? string.Empty),
                                    name: "\"transcript\"");

                            }
                            if (request.VoiceId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.VoiceId ?? string.Empty),
                                    name: "\"voice_id\"");

                            }
                            if (request.OutputFormatContainer != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.OutputFormatContainer).HasValue ? (request.OutputFormatContainer).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"output_format[container]\"");

                            }
                            if (request.OutputFormatSampleRate != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.OutputFormatSampleRate, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"output_format[sample_rate]\"");

                            }
                            if (request.OutputFormatEncoding != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.OutputFormatEncoding).HasValue ? (request.OutputFormatEncoding).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"output_format[encoding]\"");

                            }
                            if (request.OutputFormatBitRate != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.OutputFormatBitRate, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"output_format[bit_rate]\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::Cartesia.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareInfillBytesRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    cartesiaVersion: cartesiaVersion!,
                    request: request);

                global::Cartesia.AutoSDKHttpRequestOptions.StampAuthorizationOverride(__httpRequest);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Cartesia.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Cartesia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InfillBytes",
                                methodName: "InfillBytesAsync",
                                pathTemplate: "\"/infill/bytes\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Cartesia.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Cartesia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Cartesia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InfillBytes",
                                methodName: "InfillBytesAsync",
                                pathTemplate: "\"/infill/bytes\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Cartesia.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Cartesia.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Cartesia.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Cartesia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Cartesia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InfillBytes",
                                methodName: "InfillBytesAsync",
                                pathTemplate: "\"/infill/bytes\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Cartesia.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                try
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessInfillBytesResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Cartesia.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Cartesia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InfillBytes",
                                methodName: "InfillBytesAsync",
                                pathTemplate: "\"/infill/bytes\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Cartesia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Cartesia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InfillBytes",
                                methodName: "InfillBytesAsync",
                                pathTemplate: "\"/infill/bytes\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            try
                            {
                                __response.EnsureSuccessStatusCode();

                                var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                return new global::Cartesia.ResponseStream(__response, __content);
                            }
                            catch (global::System.Exception __ex)
                            {
                                string? __content = null;
                                try
                                {
                                    __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);
                                }
                                catch (global::System.Exception)
                                {
                                }

                                throw global::Cartesia.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __ex,
                                    responseBody: __content,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                }
                catch
                {
                    __response.Dispose();
                    throw;
                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Infill (Bytes)<br/>
        /// Generate audio that smoothly connects two existing audio segments
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<byte[]>> InfillBytesAsResponseAsync(

            global::Cartesia.InfillBytesRequest request,
            global::Cartesia.InfillBytesCartesiaVersion cartesiaVersion = global::Cartesia.InfillBytesCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareInfillBytesArguments(
                httpClient: HttpClient,
                cartesiaVersion: ref cartesiaVersion,
                request: request);


            var __authorizations = global::Cartesia.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_InfillBytesSecurityRequirements,
                operationName: "InfillBytesAsync");

            using var __timeoutCancellationTokenSource = global::Cartesia.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Cartesia.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Cartesia.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Cartesia.PathBuilder(
                                path: "/infill/bytes",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Cartesia.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

                __httpRequest.Headers.TryAddWithoutValidation("Cartesia-Version", cartesiaVersion.ToValueString());


                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.LeftAudio != default)
                            {

                                var __contentLeftAudio = new global::System.Net.Http.ByteArrayContent(request.LeftAudio ?? global::System.Array.Empty<byte>());
                                __contentLeftAudio.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.LeftAudioname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.LeftAudioname) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentLeftAudio,
                                    name: "\"left_audio\"",
                                    fileName: request.LeftAudioname != null ? $"\"{request.LeftAudioname}\"" : string.Empty);
                                if (__contentLeftAudio.Headers.ContentDisposition != null)
                                {
                                    __contentLeftAudio.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.RightAudio != default)
                            {

                                var __contentRightAudio = new global::System.Net.Http.ByteArrayContent(request.RightAudio ?? global::System.Array.Empty<byte>());
                                __contentRightAudio.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.RightAudioname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.RightAudioname) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentRightAudio,
                                    name: "\"right_audio\"",
                                    fileName: request.RightAudioname != null ? $"\"{request.RightAudioname}\"" : string.Empty);
                                if (__contentRightAudio.Headers.ContentDisposition != null)
                                {
                                    __contentRightAudio.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.ModelId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.ModelId).HasValue ? (request.ModelId).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"model_id\"");

                            }
                            if (request.Language != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Language).HasValue ? (request.Language).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"language\"");

                            }
                            if (request.Transcript != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Transcript ?? string.Empty),
                                    name: "\"transcript\"");

                            }
                            if (request.VoiceId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.VoiceId ?? string.Empty),
                                    name: "\"voice_id\"");

                            }
                            if (request.OutputFormatContainer != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.OutputFormatContainer).HasValue ? (request.OutputFormatContainer).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"output_format[container]\"");

                            }
                            if (request.OutputFormatSampleRate != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.OutputFormatSampleRate, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"output_format[sample_rate]\"");

                            }
                            if (request.OutputFormatEncoding != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.OutputFormatEncoding).HasValue ? (request.OutputFormatEncoding).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"output_format[encoding]\"");

                            }
                            if (request.OutputFormatBitRate != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.OutputFormatBitRate, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"output_format[bit_rate]\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::Cartesia.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareInfillBytesRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    cartesiaVersion: cartesiaVersion!,
                    request: request);

                global::Cartesia.AutoSDKHttpRequestOptions.StampAuthorizationOverride(__httpRequest);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Cartesia.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Cartesia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InfillBytes",
                                methodName: "InfillBytesAsync",
                                pathTemplate: "\"/infill/bytes\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Cartesia.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Cartesia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Cartesia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InfillBytes",
                                methodName: "InfillBytesAsync",
                                pathTemplate: "\"/infill/bytes\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Cartesia.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Cartesia.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Cartesia.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Cartesia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Cartesia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InfillBytes",
                                methodName: "InfillBytesAsync",
                                pathTemplate: "\"/infill/bytes\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Cartesia.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessInfillBytesResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Cartesia.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Cartesia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InfillBytes",
                                methodName: "InfillBytesAsync",
                                pathTemplate: "\"/infill/bytes\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Cartesia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Cartesia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InfillBytes",
                                methodName: "InfillBytesAsync",
                                pathTemplate: "\"/infill/bytes\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsByteArrayAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessInfillBytesResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return new global::Cartesia.AutoSDKHttpResponse<byte[]>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Cartesia.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Cartesia.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: null,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    var __content = await __response.Content.ReadAsByteArrayAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return new global::Cartesia.AutoSDKHttpResponse<byte[]>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Cartesia.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Cartesia.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Infill (Bytes)<br/>
        /// Generate audio that smoothly connects two existing audio segments
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="leftAudio">
        /// Audio clip that comes before the infill transcript:<br/>
        /// `left_audio` -&gt; `transcript` -&gt; `right_audio`<br/>
        /// For best results, target natural pauses in the audio and clip tightly.<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="leftAudioname">
        /// Audio clip that comes before the infill transcript:<br/>
        /// `left_audio` -&gt; `transcript` -&gt; `right_audio`<br/>
        /// For best results, target natural pauses in the audio and clip tightly.<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="rightAudio">
        /// Audio clip that comes after the infill transcript:<br/>
        /// `left_audio` -&gt; `transcript` -&gt; `right_audio`<br/>
        /// For best results, target natural pauses in the audio and clip tightly.<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="rightAudioname">
        /// Audio clip that comes after the infill transcript:<br/>
        /// `left_audio` -&gt; `transcript` -&gt; `right_audio`<br/>
        /// For best results, target natural pauses in the audio and clip tightly.<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="modelId">
        /// The ID of the model to use for generating audio
        /// </param>
        /// <param name="language">
        /// The language that the given voice should speak the transcript in. This may depend on the model you're using. See [Models](/build-with-cartesia/tts-models/latest) for details.
        /// </param>
        /// <param name="transcript">
        /// The infill text to generate.<br/>
        /// For best results, use longer transcripts to give the model more flexibility to adapt to the rest of the audio.
        /// </param>
        /// <param name="voiceId">
        /// The ID of the voice to use for generating audio
        /// </param>
        /// <param name="outputFormatContainer"></param>
        /// <param name="outputFormatSampleRate">
        /// The sample rate of the output audio
        /// </param>
        /// <param name="outputFormatEncoding">
        /// The encoding format for output audio. See [TTS Output Audio Format](/build-with-cartesia/capability-guides/tts-output-audio-format) if you're unsure what to use.
        /// </param>
        /// <param name="outputFormatBitRate">
        /// Required for `mp3` containers.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> InfillBytesAsync(
            global::Cartesia.InfillBytesCartesiaVersion cartesiaVersion = global::Cartesia.InfillBytesCartesiaVersion.x20260814,
            byte[]? leftAudio = default,
            string? leftAudioname = default,
            byte[]? rightAudio = default,
            string? rightAudioname = default,
            global::Cartesia.InfillBytesRequestModelId? modelId = default,
            global::Cartesia.SupportedLanguage? language = default,
            string? transcript = default,
            string? voiceId = default,
            global::Cartesia.OutputFormatContainer? outputFormatContainer = default,
            int? outputFormatSampleRate = default,
            global::Cartesia.RawEncoding? outputFormatEncoding = default,
            int? outputFormatBitRate = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Cartesia.InfillBytesRequest
            {
                LeftAudio = leftAudio,
                LeftAudioname = leftAudioname,
                RightAudio = rightAudio,
                RightAudioname = rightAudioname,
                ModelId = modelId,
                Language = language,
                Transcript = transcript,
                VoiceId = voiceId,
                OutputFormatContainer = outputFormatContainer,
                OutputFormatSampleRate = outputFormatSampleRate,
                OutputFormatEncoding = outputFormatEncoding,
                OutputFormatBitRate = outputFormatBitRate,
            };

            return await InfillBytesAsync(
                cartesiaVersion: cartesiaVersion,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}