using Xinteractors;

namespace Venturus.Common.Abstractions.Interactors
{
    /// <summary>
    /// Provides methods for wrapping interactor failed responses.
    /// </summary>
    public static class RequestHandlerExtensions
    {
        /// <summary>
        /// Produces a failure response for the interactor.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="handler">The request handler for which the response will be produced.</param>
        /// <param name="statusCode">The status code datailing the response.</param>
        /// <param name="message">The message datailing the response.</param>
        /// <returns>The unsuccessful response.</returns>
        public static IResponse<TResponse> Failure<TRequest, TResponse>(this IRequestHandler<TRequest, TResponse> handler, int statusCode, string message = null)
            => Response.Failure<TResponse>(statusCode, message);

        /// <summary>
        /// Produces a failure response for the interactor.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="handler">The request handler for which the response will be produced.</param>
        /// <param name="message">The message datailing the response.</param>
        /// <returns>The unsuccessful response.</returns>
        public static IResponse<TResponse> Failure<TRequest, TResponse>(this IRequestHandler<TRequest, TResponse> handler, string message)
            => Response.Failure<TResponse>(message);

        /// <summary>
        /// Produces a failure response for the interactor.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="handler">The request handler for which the response will be produced.</param>
        /// <param name="statusCode">The status code datailing the response.</param>
        /// <param name="message">The message datailing the response.</param>
        /// <returns>The unsuccessful response.</returns>
        public static IResponse<TResponse> Failure<TRequest, TResponse>(this IRequestHandlerAsync<TRequest, TResponse> handler, int statusCode, string message = null)
            => Response.Failure<TResponse>(statusCode, message);

        /// <summary>
        /// Produces a failure response for the interactor.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="handler">The request handler for which the response will be produced.</param>
        /// <param name="message">The message datailing the response.</param>
        /// <returns>The unsuccessful response.</returns>
        public static IResponse<TResponse> Failure<TRequest, TResponse>(this IRequestHandlerAsync<TRequest, TResponse> handler, string message)
            => Response.Failure<TResponse>(message);

    }
}
