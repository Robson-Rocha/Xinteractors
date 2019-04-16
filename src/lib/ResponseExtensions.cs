// ReSharper disable once CheckNamespace
namespace Xinteractors
{
    /// <summary>
    /// Provides methods for wrapping interactor responses.
    /// </summary>
    public static class ResponseExtensions
    {
        /// <summary>
        /// Indicates that the interaction was successful, adding additional information.
        /// </summary>
        /// <typeparam name="TResponseValue">The type of interactor response.</typeparam>
        /// <param name="responseValue">The value of the interaction response.</param>
        /// <param name="statusCode">The status code of the response.</param>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> ToSuccessResponse<TResponseValue>(this TResponseValue responseValue, int statusCode, string message = null)
            => Response.Success(responseValue, statusCode, message);

        /// <summary>
        /// Indicates that the interaction was successful, adding additional information.
        /// </summary>
        /// <typeparam name="TResponseValue">The type of interactor response.</typeparam>
        /// <param name="responseValue">The value of the interaction response.</param>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> ToSuccessResponse<TResponseValue>(this TResponseValue responseValue, string message)
            => Response.Success(responseValue, message);

        /// <summary>
        /// Indicates that the interaction was successful, adding additional information.
        /// </summary>
        /// <typeparam name="TResponseValue">The type of interactor response.</typeparam>
        /// <param name="responseValue">The value of the interaction response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> ToSuccessResponse<TResponseValue>(this TResponseValue responseValue)
            => Response.Success(responseValue);

        /// <summary>
        /// Indicates that the interaction was unsuccessful, adding additional information.
        /// </summary>
        /// <typeparam name="TResponseValue">The type of interactor response.</typeparam>
        /// <param name="responseValue">The value of the interaction response.</param>
        /// <param name="statusCode">The status code of the response.</param>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> ToFailureResponse<TResponseValue>(this TResponseValue responseValue, int statusCode, string message = null)
            => Response.Failure(responseValue, statusCode, message);

        /// <summary>
        /// Indicates that the interaction was unsuccessful, adding additional information.
        /// </summary>
        /// <typeparam name="TResponseValue">The type of interactor response.</typeparam>
        /// <param name="responseValue">The value of the interaction response.</param>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> ToFailureResponse<TResponseValue>(this TResponseValue responseValue, string message)
            => Response.Failure(responseValue, message);

    }
}
