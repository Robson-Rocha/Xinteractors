// ReSharper disable once CheckNamespace
namespace Xinteractors
{
    using System.Threading.Tasks;

    /// <summary>
    /// Defines a Asynchronous Handler to a Request, which can be used to process requests and execute commands. Used to implement Use Cases Interactors.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request being handled.</typeparam>
    /// <typeparam name="TResponse">The type of the handled response.</typeparam>
    public interface IRequestHandlerAsync<in TRequest, TResponse> : IInteractor
    {
        /// <summary>
        /// Handles a request asynchronously.
        /// </summary>
        /// <param name="request">The data for the request.</param>
        /// <returns>Task that should provide the Response from the request.</returns>
        Task<IResponse<TResponse>> HandleAsync(TRequest request);
    }
}