// ReSharper disable once CheckNamespace
namespace Xinteractors
{
    /// <summary>
    /// Represents a response wrapper from an interactor containing additional about a response.
    /// </summary>
    /// <typeparam name="TResponseValue">The response itsel from the interactor.</typeparam>
    public interface IResponse<out TResponseValue>
    {
        /// <summary>
        /// Gets a message detailing the response.
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Gets a status code about the response.
        /// </summary>
        int StatusCode { get; }

        /// <summary>
        /// Gets a value indicating if the interactor succeeded.
        /// </summary>
        bool Succeeded { get; }

        /// <summary>
        /// Gets the response value from the interactor.
        /// </summary>
        TResponseValue Value { get; }
    }
}
