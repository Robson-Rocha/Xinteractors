using System;

// ReSharper disable once CheckNamespace
namespace Xinteractors
{
    /// <summary>
    /// Represents a void return ou parameter for using within <see cref="IRequestHandler{TRequest,TResponse}"/>, <see cref="IRequestHandlerAsync{TRequest,TResponse}"/> and <see cref="IResponse{TResponseValue}"/>, since <see cref="System.Void"/> is not a valid assignable type. This is a singleton type, use <see cref="Message"/> property to get an instance.
    /// </summary>
    public sealed class VoidMessage : IEquatable<VoidMessage>, IComparable<VoidMessage>, IComparable
    {
        /// <summary>
        /// Gets the singleton instance of <see cref="VoidMessage"/>
        /// </summary>
        public static VoidMessage Message { get; } = new VoidMessage();

        private VoidMessage()
        {

        }

        #region IEquatable<VoidMessage>
        /// <inheritdoc />
        public bool Equals(VoidMessage other) => true;

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is VoidMessage;

        /// <inheritdoc />
        public override int GetHashCode() => 0;

        /// <summary>
        /// Determines whether the <paramref name="left"/> <see cref="VoidMessage"/> is equal to the <paramref name="right"/> <see cref="VoidMessage"/>. Always return <c>true</c>.
        /// </summary>
        /// <param name="left">The first, left to operator, <see cref="VoidMessage"/>.</param>
        /// <param name="right">The second, right to operator, <see cref="VoidMessage"/>.</param>
        /// Always return <c>true</c>.
        public static bool operator ==(VoidMessage left, VoidMessage right) => true;

        /// <summary>
        /// Determines whether the <paramref name="left"/> <see cref="VoidMessage"/> is not equal to the <paramref name="right"/> <see cref="VoidMessage"/>. Always return <c>false</c>.
        /// </summary>
        /// <param name="left">The first, left to operator, <see cref="VoidMessage"/>.</param>
        /// <param name="right">The second, right to operator, <see cref="VoidMessage"/>.</param>
        /// Always return <c>false</c>.
        public static bool operator !=(VoidMessage left, VoidMessage right) => false;
        #endregion

        #region IComparable<VoidMessage>

        /// <inheritdoc />
        public int CompareTo(VoidMessage other) => 0;

        /// <inheritdoc />
        public int CompareTo(object obj) => 0;

        /// <summary>
        /// Determines whether the <paramref name="left"/> <see cref="VoidMessage"/> is lesser than the <paramref name="right"/> <see cref="VoidMessage"/>. Always return <c>false</c>.
        /// </summary>
        /// <param name="left">The first, left to operator, <see cref="VoidMessage"/>.</param>
        /// <param name="right">The second, right to operator, <see cref="VoidMessage"/>.</param>
        /// Always return <c>false</c>.
        public static bool operator <(VoidMessage left, VoidMessage right) => false;

        /// <summary>
        /// Determines whether the <paramref name="left"/> <see cref="VoidMessage"/> is greater than the <paramref name="right"/> <see cref="VoidMessage"/>. Always return <c>false</c>.
        /// </summary>
        /// <param name="left">The first, left to operator, <see cref="VoidMessage"/>.</param>
        /// <param name="right">The second, right to operator, <see cref="VoidMessage"/>.</param>
        /// Always return <c>false</c>.
        public static bool operator >(VoidMessage left, VoidMessage right) => false;

        /// <summary>
        /// Determines whether the <paramref name="left"/> <see cref="VoidMessage"/> is lesser than or equal to the <paramref name="right"/> <see cref="VoidMessage"/>. Always return <c>true</c>.
        /// </summary>
        /// <param name="left">The first, left to operator, <see cref="VoidMessage"/>.</param>
        /// <param name="right">The second, right to operator, <see cref="VoidMessage"/>.</param>
        /// Always return <c>true</c>.
        public static bool operator <=(VoidMessage left, VoidMessage right) => true;

        /// <summary>
        /// Determines whether the <paramref name="left"/> <see cref="VoidMessage"/> is greater than or equal to the <paramref name="right"/> <see cref="VoidMessage"/>. Always return <c>true</c>.
        /// </summary>
        /// <param name="left">The first, left to operator, <see cref="VoidMessage"/>.</param>
        /// <param name="right">The second, right to operator, <see cref="VoidMessage"/>.</param>
        /// Always return <c>true</c>.
        public static bool operator >=(VoidMessage left, VoidMessage right) => true;
        #endregion

        /// <inheritdoc />
        public override string ToString() => "<void>";
    }
}
