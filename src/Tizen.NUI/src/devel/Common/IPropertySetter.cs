/*
 * Copyright(c) 2025 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using System.ComponentModel;

namespace Tizen.NUI
{
    /// <summary>
    /// The interface for property setter.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IPropertySetter<TValue>
    {
        /// <summary>
        /// The name of the property.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Invokes property setter.
        /// </summary>
        void Invoke(object target, TValue value);
    }
}
