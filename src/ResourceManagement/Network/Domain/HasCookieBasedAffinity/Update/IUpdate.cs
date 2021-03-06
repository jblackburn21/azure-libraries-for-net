// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent.HasCookieBasedAffinity.Update
{
    /// <summary>
    /// The stage of an update allowing to modify cookie based affinity.
    /// </summary>
    /// <typeparam name="ReturnT">The next stage of the update.</typeparam>
    public interface IWithCookieBasedAffinity<ReturnT> 
    {
        /// <summary>
        /// Disables cookie based affinity.
        /// </summary>
        /// <return>The next stage of the update.</return>
        ReturnT WithoutCookieBasedAffinity();

        /// <summary>
        /// Enables cookie based affinity.
        /// </summary>
        /// <return>The next stage of the update.</return>
        ReturnT WithCookieBasedAffinity();
    }
}