// <auto-generated/>
using KiotaSamples.PetStoreSdk.Models;
using KiotaSamples.PetStoreSdk.Store.Order.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaSamples.PetStoreSdk.Store.Order {
    /// <summary>
    /// Builds and executes requests for operations under \store\order
    /// </summary>
    public class OrderRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the KiotaSamples.PetStoreSdk.store.order.item collection</summary>
        /// <param name="position">ID of pet that needs to be fetched</param>
        public WithOrderItemRequestBuilder this[long position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("orderId", position);
            return new WithOrderItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the KiotaSamples.PetStoreSdk.store.order.item collection</summary>
        /// <param name="position">ID of pet that needs to be fetched</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithOrderItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("orderId", position);
            return new WithOrderItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new OrderRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrderRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/store/order", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new OrderRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrderRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/store/order", rawUrl) {
        }
        /// <summary>
        /// Place an order for a pet
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaSamples.PetStoreSdk.Models.Order?> PostAsync(KiotaSamples.PetStoreSdk.Models.Order body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<KiotaSamples.PetStoreSdk.Models.Order> PostAsync(KiotaSamples.PetStoreSdk.Models.Order body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<KiotaSamples.PetStoreSdk.Models.Order>(requestInfo, KiotaSamples.PetStoreSdk.Models.Order.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(KiotaSamples.PetStoreSdk.Models.Order body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(KiotaSamples.PetStoreSdk.Models.Order body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public OrderRequestBuilder WithUrl(string rawUrl) {
            return new OrderRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class OrderRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
