// ReSharper disable once CheckNamespace
namespace Xinteractors
{
    using System;

    /// <summary>
    /// Provides methods for wrapping interactor responses.
    /// </summary>
    public static class Response
    {
        /// <summary>
        /// Indicates that the interaction was successful, adding additional information.
        /// </summary>
        /// <typeparam name="TResponseValue">The type of interactor response.</typeparam>
        /// <param name="responseValue">The value of the interaction response.</param>
        /// <param name="statusCode">The status code of the response.</param>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> Success<TResponseValue>(TResponseValue responseValue, int statusCode, string message = null)
            => Response<TResponseValue>.Success(responseValue, statusCode, message);

        /// <summary>
        /// Indicates that the interaction was successful, adding additional information.
        /// </summary>
        /// <typeparam name="TResponseValue">The type of interactor response.</typeparam>
        /// <param name="responseValue">The value of the interaction response.</param>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> Success<TResponseValue>(TResponseValue responseValue, string message)
            => Response<TResponseValue>.Success(responseValue, message);

        /// <summary>
        /// Indicates that the interaction was successful, adding additional information.
        /// </summary>
        /// <typeparam name="TResponseValue">The type of interactor response.</typeparam>
        /// <param name="responseValue">The value of the interaction response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> Success<TResponseValue>(TResponseValue responseValue)
            => Response<TResponseValue>.Success(responseValue);

        /// <summary>
        /// Indicates that the interaction was unsuccessful, adding additional information.
        /// </summary>
        /// <typeparam name="TResponseValue">The type of interactor response.</typeparam>
        /// <param name="responseValue">The value of the interaction response.</param>
        /// <param name="statusCode">The status code of the response.</param>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> Failure<TResponseValue>(TResponseValue responseValue, int statusCode, string message = null)
            => Response<TResponseValue>.Failure(responseValue, statusCode, message);

        /// <summary>
        /// Indicates that the interaction was unsuccessful, adding additional information.
        /// </summary>
        /// <typeparam name="TResponseValue">The type of interactor response.</typeparam>
        /// <param name="responseValue">The value of the interaction response.</param>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> Failure<TResponseValue>(TResponseValue responseValue, string message)
            => Response<TResponseValue>.Failure(responseValue, message);

        /// <summary>
        /// Indicates that the interaction was unsuccessful, adding additional information.
        /// </summary>
        /// <typeparam name="TResponseValue">The type of interactor response.</typeparam>
        /// <param name="statusCode">The status code of the response.</param>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> Failure<TResponseValue>(int statusCode, string message = null)
            => Response<TResponseValue>.Failure(statusCode, message);

        /// <summary>
        /// Indicates that the interaction was unsuccessful, adding additional information.
        /// </summary>
        /// <typeparam name="TResponseValue">The type of interactor response.</typeparam>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> Failure<TResponseValue>(string message)
            => Response<TResponseValue>.Failure(message);
    }

    /// <summary>
    /// Represents a response wrapper that adds information about an interactor response
    /// </summary>
    /// <typeparam name="TResponseValue">The type of interactor response.</typeparam>
    public class Response<TResponseValue> : IResponse<TResponseValue>
    {
        private const string DefaultSuccessResponse = "The operation has succeeded";

        /// <summary>
        /// Gets the value of the response
        /// </summary>
        public TResponseValue Value { get; }

        /// <summary>
        /// Gets a value indicating if the interaction was successful
        /// </summary>
        public bool Succeeded { get; }

        /// <summary>
        /// Gets a vakue indicating the status code of the response
        /// </summary>
        public int StatusCode { get; }

        /// <summary>
        /// Gets a message about the response
        /// </summary>
        public string Message { get; }

        internal Response(TResponseValue value, bool succeeded, int statusCode, string message)
        {
            Value = value;
            Succeeded = succeeded;
            StatusCode = statusCode;
            Message = message;
        }

        /// <summary>
        /// Indicates that the interaction was successful, adding additional information.
        /// </summary>
        /// <param name="responseValue">The value of the interaction response.</param>
        /// <param name="statusCode">The status code of the response.</param>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> Success(TResponseValue responseValue, int statusCode, string message = null) 
            => new Response<TResponseValue>(responseValue, true, statusCode, message ?? DefaultSuccessResponse);

        /// <summary>
        /// Indicates that the interaction was successful, adding additional information.
        /// </summary>
        /// <param name="responseValue">The value of the interaction response.</param>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> Success(TResponseValue responseValue, string message)
            => Success(responseValue, 0, message);

        /// <summary>
        /// Indicates that the interaction was successful, adding additional information.
        /// </summary>
        /// <param name="responseValue">The value of the interaction response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> Success(TResponseValue responseValue)
            => Success(responseValue, 0);

        /// <summary>
        /// Indicates that the interaction was unsuccessful, adding additional information.
        /// </summary>
        /// <param name="responseValue">The value of the interaction response.</param>
        /// <param name="statusCode">The status code of the response.</param>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> Failure(TResponseValue responseValue, int statusCode, string message = null)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));
            return new Response<TResponseValue>(responseValue, false, statusCode, message);
        }

        /// <summary>
        /// Indicates that the interaction was unsuccessful, adding additional information.
        /// </summary>
        /// <param name="responseValue">The value of the interaction response.</param>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> Failure(TResponseValue responseValue, string message)
            => Failure(responseValue, -1, message);

        /// <summary>
        /// Indicates that the interaction was unsuccessful, adding additional information.
        /// </summary>
        /// <param name="statusCode">The status code of the response.</param>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> Failure(int statusCode, string message = null)
            => Failure(default(TResponseValue), statusCode, message);

        /// <summary>
        /// Indicates that the interaction was unsuccessful, adding additional information.
        /// </summary>
        /// <param name="message">A message about the response.</param>
        /// <returns>The wrapped response.</returns>
        public static Response<TResponseValue> Failure(string message)
            => Failure(default(TResponseValue), -1, message);

    }
}
