﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BaseDataModel;

namespace Repository
{
    using System.Diagnostics.Contracts;

    using Repository.Contracts;

    /// <summary>
    /// Generic asynchronous repository reader interface
    /// </summary>
    /// <typeparam name="T">Type must be a class and inherited from IDataModel interface</typeparam>
    [ContractClass(typeof(RepositoryReaderAsyncContract<>))]
    public interface IRepositoryReaderAsync<T> where T : class, IDataModel, new()
    {
        /// <summary>
        /// Gets item by id asyncronously
        /// </summary>
        /// <param name="id">Id of item to get</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains default ( T ) if source is empty; otherwise, the found element in persistence storage</returns>
        Task<T> GetByIdAsync(Guid id);

        /// <summary>
        /// Gets all items in persistence storage asyncronously
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains all items of type T in persistence storage</returns>
        Task<IEnumerable<T>> GetAllAsync();
    }
}