﻿using System;
using System.Collections;

namespace Bytewizer.TinyCLR.Http.Mvc
{ 
    /// <summary>
    /// Describes an MVC action.
    /// </summary>
    public class ActionDescriptor
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ActionDescriptor"/>.
        /// </summary>
        public ActionDescriptor()
        {
            Id = DateTime.Now.Ticks.ToString();
            Properties = new Hashtable();
        }

        /// <summary>
        /// Gets an id which uniquely identifies the action.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// A friendly name for this action.
        /// </summary>
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Stores arbitrary metadata properties associated with the <see cref="ActionDescriptor"/>.
        /// </summary>
        public Hashtable Properties { get; set; }
    }
}
