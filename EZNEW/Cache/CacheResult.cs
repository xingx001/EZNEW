﻿using System.Collections.Generic;

namespace EZNEW.Cache.Command.Result
{
    /// <summary>
    /// Cache command result
    /// </summary>
    public class CacheResult<TResponse>
    {
        /// <summary>
        /// Gets or sets the responses
        /// </summary>
        public List<TResponse> Responses
        {
            get; set;
        }

        /// <summary>
        /// Add response
        /// </summary>
        /// <param name="responses">Cache responses</param>
        public void AddResponse(params TResponse[] responses)
        {
            if (responses == null || responses.Length < 1)
            {
                return;
            }
            Responses = Responses ?? new List<TResponse>();
            Responses.AddRange(responses);
        }

        /// <summary>
        /// Gets a empty result
        /// </summary>
        public static CacheResult<TResponse> EmptyResult()
        {
            return new CacheResult<TResponse>();
        }
    }
}
