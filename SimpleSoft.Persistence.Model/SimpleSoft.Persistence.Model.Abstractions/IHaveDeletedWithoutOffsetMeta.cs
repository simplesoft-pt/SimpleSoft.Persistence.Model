﻿#region License
// The MIT License (MIT)
// 
// Copyright (c) 2018 Simplesoft.pt
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

using System;

namespace SimpleSoft.Persistence.Model
{
    /// <summary>
    /// Metadata information about the entity soft deleted
    /// </summary>
    /// <typeparam name="TDeletedBy">The identifier or entity type</typeparam>
    public interface IHaveDeletedWithoutOffsetMeta<TDeletedBy>
    {
        /// <summary>
        /// The <see cref="DateTime"/> when it was soft deleted
        /// </summary>
        DateTime? DeletedOn { get; set; }

        /// <summary>
        /// The identifier (or entity) which soft deleted this entity
        /// </summary>
        TDeletedBy DeletedBy { get; set; }
    }

    /// <summary>
    /// Metadata information about the entity deletition, using a <see cref="string"/>
    /// as an identifier for the <see cref="IHaveDeletedWithoutOffsetMeta{T}.DeletedBy"/>
    /// </summary>
    public interface IHaveDeletedWithoutOffsetMeta : IHaveDeletedWithoutOffsetMeta<string>
    {

    }
}
