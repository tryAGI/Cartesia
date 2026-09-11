
#nullable enable

namespace Cartesia
{
    public partial class TtsClient
    {


        private static readonly global::Cartesia.EndPointSecurityRequirement s_TtsSseSecurityRequirement0 =
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

        private static readonly global::Cartesia.EndPointSecurityRequirement s_TtsSseSecurityRequirement1 =
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
        private static readonly global::Cartesia.EndPointSecurityRequirement[] s_TtsSseSecurityRequirements =
            new global::Cartesia.EndPointSecurityRequirement[]
            {                s_TtsSseSecurityRequirement0,
                s_TtsSseSecurityRequirement1,
            };
        partial void PrepareTtsSseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Cartesia.TtsSseCartesiaVersion cartesiaVersion,
            global::Cartesia.TTSSSERequest request);
        partial void PrepareTtsSseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Cartesia.TtsSseCartesiaVersion cartesiaVersion,
            global::Cartesia.TTSSSERequest request);
        partial void ProcessTtsSseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Text-to-Speech (SSE)<br/>
        /// Stream audio with extra metadata from a complete transcript
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Cartesia.TTSSSEEvent> TtsSseAsync(

            global::Cartesia.TTSSSERequest request,
            global::Cartesia.TtsSseCartesiaVersion cartesiaVersion = global::Cartesia.TtsSseCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTtsSseArguments(
                httpClient: HttpClient,
                cartesiaVersion: ref cartesiaVersion,
                request: request);


            var __authorizations = global::Cartesia.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TtsSseSecurityRequirements,
                operationName: "TtsSseAsync");

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
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Cartesia.PathBuilder(
                                path: "/tts/sse",
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

                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Cartesia.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareTtsSseRequest(
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
                                operationId: "TtsSse",
                                methodName: "TtsSseAsync",
                                pathTemplate: "\"/tts/sse\"",
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
                                operationId: "TtsSse",
                                methodName: "TtsSseAsync",
                                pathTemplate: "\"/tts/sse\"",
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
                                operationId: "TtsSse",
                                methodName: "TtsSseAsync",
                                pathTemplate: "\"/tts/sse\"",
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
                ProcessTtsSseResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Cartesia.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Cartesia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TtsSse",
                                methodName: "TtsSseAsync",
                                pathTemplate: "\"/tts/sse\"",
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
                                operationId: "TtsSse",
                                methodName: "TtsSseAsync",
                                pathTemplate: "\"/tts/sse\"",
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
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
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

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = global::Cartesia.TTSSSEEvent.FromJson(__content, JsonSerializerContext) ??
                                                       throw global::Cartesia.ApiException.Create(
                                                           statusCode: __response.StatusCode,
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           innerException: null,
                                                           responseBody: __content,
                                                           responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value));

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Text-to-Speech (SSE)<br/>
        /// Stream audio with extra metadata from a complete transcript
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="modelId">
        /// The ID of the model to use for the generation.<br/>
        /// See [Models](/build-with-cartesia/tts-models/latest) all options.<br/>
        /// Default Value: sonic-3.6<br/>
        /// Example: sonic-3.6
        /// </param>
        /// <param name="transcript">
        /// Default Value: Hi there, it's awesome to meet you.
        /// </param>
        /// <param name="voice">
        /// The voice to use for generation. Pass either a voice ID string or an object with a required `id` (additional object fields may be added in future API versions). Find a voice in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list). Embeddings are not accepted in this API version.
        /// </param>
        /// <param name="outputFormat"></param>
        /// <param name="language">
        /// The transcript's language or locale (for example `en` or `en-GB`). `language` and `locale` accept the same values. Set one or the other, never both; setting both returns a 400 error. See [supported codes](/build-with-cartesia/capability-guides/advanced-capabilities#which-locales-are-supported).
        /// </param>
        /// <param name="locale">
        /// The transcript's language or locale (for example `en` or `en-GB`). `locale` and `language` accept the same values. Set one or the other, never both; setting both returns a 400 error. See [supported codes](/build-with-cartesia/capability-guides/advanced-capabilities#which-locales-are-supported).
        /// </param>
        /// <param name="accent">
        /// Usually unnecessary: Cartesia picks the closest accent the voice supports for the requested `language` or `locale`. Set it only to make a [multilingual voice](/build-with-cartesia/capability-guides/multilingual-voices) sound accented (e.g. speak English with a French accent). Must come from the voice's [Get Voice `accents` field](/api-reference/voices/get#response-accents). Learn more [here](/build-with-cartesia/capability-guides/multilingual-voices#using-a-multilingual-voice).
        /// </param>
        /// <param name="normalization">
        /// Text normalization. `auto` (default) runs the locale-aware normalizer, `off` skips it, or pass a language or locale code (for example `en` or `en-IN`) to pin the normalizer independently of the generation language. See [Text Normalization](/build-with-cartesia/capability-guides/text-normalization).<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="addTimestamps">
        /// Whether to return word-level timestamps. If `false` (default), no word timestamps will be produced at all. If `true`, the server will return timestamp events containing word-level timing information.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="addPhonemeTimestamps">
        /// Whether to return phoneme-level timestamps. If `false` (default), no phoneme timestamps will be produced. If `true`, the server will return timestamp events containing phoneme-level timing information.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useNormalizedTimestamps">
        /// Whether to use normalized timestamps (True) or original timestamps (False).
        /// </param>
        /// <param name="pronunciationDictId">
        /// The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.
        /// </param>
        /// <param name="generationConfig">
        /// Configure the various attributes of the generated speech. Available on `sonic-3` and newer models; not available on earlier models.<br/>
        /// See [Volume, Speed, and Emotion](/build-with-cartesia/capability-guides/volume-speed-emotion) for a guide on this option.
        /// </param>
        /// <param name="contextId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Cartesia.TTSSSEEvent> TtsSseAsync(
            global::Cartesia.TTSRequestVoiceSpecifier voice,
            global::Cartesia.SSEOutputFormat outputFormat,
            global::Cartesia.TtsSseCartesiaVersion cartesiaVersion = global::Cartesia.TtsSseCartesiaVersion.x20260814,
            global::Cartesia.TTSModelID modelId = global::Cartesia.TTSModelID.Sonic36,
            string transcript = "Hi there, it's awesome to meet you.",
            string? language = default,
            string? locale = default,
            string? accent = default,
            string? normalization = default,
            bool? addTimestamps = default,
            bool? addPhonemeTimestamps = default,
            bool? useNormalizedTimestamps = default,
            string? pronunciationDictId = default,
            global::Cartesia.GenerationConfig? generationConfig = default,
            string? contextId = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Cartesia.TTSSSERequest
            {
                ModelId = modelId,
                Transcript = transcript,
                Voice = voice,
                OutputFormat = outputFormat,
                Language = language,
                Locale = locale,
                Accent = accent,
                Normalization = normalization,
                AddTimestamps = addTimestamps,
                AddPhonemeTimestamps = addPhonemeTimestamps,
                UseNormalizedTimestamps = useNormalizedTimestamps,
                PronunciationDictId = pronunciationDictId,
                GenerationConfig = generationConfig,
                ContextId = contextId,
            };

            var __enumerable = TtsSseAsync(
                cartesiaVersion: cartesiaVersion,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}