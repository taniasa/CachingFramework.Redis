﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CachingFramework.Redis.Contracts.RedisObjects
{
    /// <summary>
    /// Async implementation of a Managed dictionary using a Redis Hash
    /// </summary>
    public interface IRedisDictionaryAsync<TK, TV>
    {
        /// <summary>
        /// Adds a single element to the dictionary related to the given tag(s).
        /// </summary>
        /// <param name="key">The redis key.</param>
        /// <param name="value">The value.</param>
        /// <param name="tags">The tags to relate.</param>
        Task AddAsync(TK key, TV value, string[] tags);
        /// <summary>
        /// Adds multiple elements to the dictionary.
        /// </summary>
        /// <param name="collection">The collection.</param>
        Task AddRangeAsync(IEnumerable<KeyValuePair<TK, TV>> collection);
        /// <summary>
        /// Returns the number of elements in the hash.
        /// </summary>
        Task<long> GetCountAsync();
        /// <summary>
        /// Adds an element with the provided key and value to the redis hash.
        /// </summary>
        /// <param name="key">The object to use as the key of the element to add.</param>
        /// <param name="value">The object to use as the value of the element to add.</param>
        Task AddAsync(TK key, TV value);
        /// <summary>
        /// Determines whether the <see cref="T:System.Collections.Generic.IDictionary`2" /> contains an element with the specified key.
        /// </summary>
        /// <param name="key">The key to locate in the <see cref="T:System.Collections.Generic.IDictionary`2" />.</param>
        /// <returns>true if the <see cref="T:System.Collections.Generic.IDictionary`2" /> contains an element with the key; otherwise, false.</returns>
        Task<bool> ContainsKeyAsync(TK key);
        /// <summary>
        /// Determines whether the <see cref="T:System.Collections.Generic.ICollection`1" /> contains a specific value.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <returns>true if <paramref name="item" /> is found in the <see cref="T:System.Collections.Generic.ICollection`1" />; otherwise, false.</returns>
        Task<bool> ContainsAsync(KeyValuePair<TK, TV> item);
        /// <summary>
        /// Removes the element with the specified key from the <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </summary>
        /// <param name="key">The key of the element to remove.</param>
        /// <returns>true if the element is successfully removed; otherwise, false.  This method also returns false if <paramref name="key" /> was not found in the original <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
        Task<bool> RemoveAsync(TK key);
        /// <summary>
        /// Removes all items from the collection
        /// </summary>
        Task ClearAsync();
    }
}
