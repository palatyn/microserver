﻿using System;

using Bytewizer.TinyCLR.Pipeline;
using Bytewizer.TinyCLR.Http.Features;
using Bytewizer.TinyCLR.Sockets.Channel;

namespace Bytewizer.TinyCLR.Http
{
    /// <summary>
    /// Encapsulates all HTTP-specific information about an individual HTTP request.
    /// </summary>
    public class HttpContext : IContext
    {

        /// <summary>
        /// Initializes an instance of the <see cref="HttpContext" /> class.
        /// </summary>
        public HttpContext() 
        {
            Features = new FeatureCollection();
            Request = new HttpRequest();
            Response = new HttpResponse();
        }

        /// <summary>
        /// Gets the collection of HTTP features provided by the server 
        /// and middleware available on this request.
        /// </summary>
        public IFeatureCollection Features { get; }

        /// <summary>
        /// Gets the <see cref="HttpRequest"/> object for this request.
        /// </summary>
        public HttpRequest Request { get; private set; }

        /// <summary>
        /// Gets the <see cref="HttpResponse"/> object for this request.
        /// </summary>
        public HttpResponse Response { get; private set; }

        /// <summary>
        /// Gets information about the underlying connection for this request.
        /// </summary>
        public ConnectionInfo Connection => Channel.Connection;

        /// <summary>
        /// Gets or sets the object used to manage user session data for this request.
        /// </summary>
        public SocketChannel Channel { get; set; } = new SocketChannel();

        /// <summary>
        /// Gets or sets security information for the current HTTP request.
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Gets or sets a key/value collection that can be used to share data within the scope of this request.
        /// </summary>
        public ItemsDictionary Items { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="IServiceProvider"/> that provides access to the request's service container.
        /// </summary>
        public IServiceProvider RequestServices { get; set; }

        /// <summary>
        /// Aborts the connection underlying this request.
        /// </summary>
        public void Abort()
        {
            Channel?.Clear();
        }
    }
}