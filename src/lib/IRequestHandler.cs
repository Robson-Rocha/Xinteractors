// ReSharper disable once CheckNamespace
namespace Xinteractors
{
    /// <summary>
    /// Defines a Handler to a Request, which can be used to process requests and execute commands. Used to implement Use Cases Interactors.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request being handled.</typeparam>
    /// <typeparam name="TResponse">The type of the handled response.</typeparam>
    public interface IRequestHandler<in TRequest, out TResponse> : IInteractor
    {
        /// <summary>
        /// Handles a request.
        /// </summary>
        /// <param name="request">The data for the request.</param>
        /// <returns>Response from the request.</returns>
        IResponse<TResponse> Handle(TRequest request);
    }
}
