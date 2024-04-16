﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace AntDesign.Select.Internal
{
#if NET5_0_OR_GREATER
    internal class ValueLabel<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TItemValue>
#else
 internal class ValueLabel<TItemValue>
#endif
    {
        [JsonPropertyName("value")]
        public TItemValue Value { get; set; }
        [JsonPropertyName("label")]
        public string Label { get; set; }
    }
}
