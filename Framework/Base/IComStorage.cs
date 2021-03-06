﻿//**********************
//SwEx.AddIn - development tools for SOLIDWORKS add-ins
//Copyright(C) 2019 www.codestack.net
//License: https://github.com/codestackdev/swex-addin/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/swex/add-in/
//**********************

using CodeStack.SwEx.AddIn.Core;
using System;
using System.Collections.Generic;
using System.IO;

namespace CodeStack.SwEx.AddIn.Base
{
    /// <summary>
    /// Wrapper for <see cref="IStorage"/> interface for handling the operations with compound storage
    /// </summary>
    public interface IComStorage : IDisposable
    {
        /// <summary>
        /// Pointer to the underlying COM storage
        /// </summary>
        IStorage Storage { get; }

        /// <summary>
        /// Attempts to open sub storage
        /// </summary>
        /// <param name="storageName">Sub storage name</param>
        /// <param name="createIfNotExist">True to create storage if not exists</param>
        /// <returns>Pointer to sub storage or null</returns>
        IComStorage TryOpenStorage(string storageName, bool createIfNotExist);

        /// <summary>
        /// Attempts to open sub stream
        /// </summary>
        /// <param name="streamName">Stream name</param>
        /// <param name="createIfNotExist">Create stream if not exists</param>
        /// <returns>Pointer to stream or null</returns>
        Stream TryOpenStream(string streamName, bool createIfNotExist);

        /// <summary>
        /// Gets all children stream names
        /// </summary>
        /// <returns>Stream names</returns>
        string[] GetSubStreamNames();

        /// <summary>
        /// Gets all children storages names
        /// </summary>
        /// <returns>Storages names</returns>
        string[] GetSubStorageNames();

        /// <summary>
        /// Removes child stream or storage
        /// </summary>
        /// <param name="name">Stream or storage name</param>
        void RemoveSubElement(string name);
    }
}
