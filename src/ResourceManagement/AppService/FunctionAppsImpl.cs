// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.AppService.Fluent
{
    using Models;
    using ResourceManager.Fluent.Core;
    using Rest.Azure;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The implementation for FunctionApps.
    /// </summary>
    ///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LmFwcHNlcnZpY2UuaW1wbGVtZW50YXRpb24uV2ViQXBwc0ltcGw=
    internal partial class FunctionAppsImpl :
        TopLevelModifiableResources<
            IFunctionApp,
            FunctionAppImpl,
            Models.SiteInner,
            IWebAppsOperations,
            IAppServiceManager>,
        IFunctionApps
    {
        ///GENMHASH:8ACFB0E23F5F24AD384313679B65F404:AD7C28D26EC1F237B93E54AD31899691
        public FunctionAppImpl Define(string name)
        {
            return WrapModel(name);
        }

        ///GENMHASH:95834C6C7DA388E666B705A62A7D02BF:437A8ECA353AAE23242BFC82A5066CC3
        public override IEnumerable<IFunctionApp> ListByResourceGroup(string resourceGroupName)
        {
            Func<SiteInner, IFunctionApp> converter = inner =>
            {
                return Extensions.Synchronize(() => PopulateModelAsync(inner));
            };

            return Extensions.Synchronize(() => Inner.ListByResourceGroupAsync(resourceGroupName))
                        .AsContinuousCollection(link => Extensions.Synchronize(() => Inner.ListByResourceGroupNextAsync(link)))
                        .Select(inner => converter(inner));
        }

        public override async Task<IPagedCollection<IFunctionApp>> ListByResourceGroupAsync(string resourceGroupName, bool loadAllPages = true, CancellationToken cancellationToken = default(CancellationToken))
        {
            var collection = await PagedCollection<IFunctionApp, SiteInner>.LoadPageWithWrapModelAsync(
                async (cancellation) => await Inner.ListByResourceGroupAsync(resourceGroupName, cancellationToken: cancellation),
                Inner.ListByResourceGroupNextAsync,
                async (inner, cancellation) => await PopulateModelAsync(inner, cancellation),
                loadAllPages, cancellationToken);
            return PagedCollection<IFunctionApp, SiteInner>.CreateFromEnumerable(collection.Where(w => w.Inner.Kind == "app"));
        }

        public override async Task<IPagedCollection<IFunctionApp>> ListAsync(bool loadAllPages = true, CancellationToken cancellationToken = default(CancellationToken))
        {
            var collection = await PagedCollection<IFunctionApp, SiteInner>.LoadPageWithWrapModelAsync(
                async (cancellation) => await Inner.ListAsync(cancellation),
                Inner.ListNextAsync,
                async (inner, cancellation) => await PopulateModelAsync(inner, cancellation),
                loadAllPages, cancellationToken);
            return PagedCollection<IFunctionApp, SiteInner>.CreateFromEnumerable(collection.Where(w => w.Inner.Kind == "app"));
        }

        ///GENMHASH:0679DF8CA692D1AC80FC21655835E678:586E2B084878E8767487234B852D8D20
        protected async override Task DeleteInnerByGroupAsync(string groupName, string name, CancellationToken cancellationToken)
        {
            await Inner.DeleteAsync(groupName, name, cancellationToken: cancellationToken);
        }

        ///GENMHASH:AB63F782DA5B8D22523A284DAD664D17:F6B932DEEE4F4CBE27781F2323DD7232
        public async override Task<IFunctionApp> GetByResourceGroupAsync(string groupName, string name, CancellationToken cancellationToken = default(CancellationToken))
        {
            var inner = await GetInnerByGroupAsync(groupName, name, cancellationToken);
            var FunctionApp = await PopulateModelAsync(inner, cancellationToken);
            return FunctionApp;
        }

        private async Task<IFunctionApp> PopulateModelAsync(SiteInner inner, CancellationToken cancellationToken = default(CancellationToken))
        {
            var siteConfig = await Inner.GetConfigurationAsync(inner.ResourceGroup, inner.Name, cancellationToken);
            var FunctionApp = WrapModel(inner, siteConfig);
            await ((FunctionAppImpl)FunctionApp).CacheSiteProperties(cancellationToken);
            return FunctionApp;
        }

        ///GENMHASH:9CF36554B675F661BFEE8D1C53C27496:E373401BADB43C440BA3AAFA9214451D
        internal FunctionAppsImpl(AppServiceManager manager)
            : base(manager.Inner.WebApps, manager)
        {
        }

        ///GENMHASH:2FE8C4C2D5EAD7E37787838DE0B47D92:E49716A6377D1B0BC4969F4A89093ED9
        protected override FunctionAppImpl WrapModel(string name)
        {
            return new FunctionAppImpl(name, new SiteInner
            {
                Kind = "functionapp"
            }, null, Manager);
        }

        ///GENMHASH:64609469010BC4A501B1C3197AE4F243:BEC51BB7FA5CB1F04F04C62A207332AE
        protected override IFunctionApp WrapModel(SiteInner inner)
        {
            if (inner == null)
            {
                return null;
            }
            return new FunctionAppImpl(inner.Name, inner, null, Manager);
        }

        private IFunctionApp WrapModel(SiteInner inner, SiteConfigResourceInner siteConfigInner)
        {
            if (inner == null)
            {
                return null;
            }
            return new FunctionAppImpl(inner.Name, inner, siteConfigInner, Manager);
        }

        protected override async Task<IPage<SiteInner>> ListInnerAsync(CancellationToken cancellationToken)
        {
            return await Inner.ListAsync(cancellationToken);
        }

        protected override async Task<IPage<SiteInner>> ListInnerNextAsync(string link, CancellationToken cancellationToken)
        {
            return await Inner.ListNextAsync(link, cancellationToken);
        }

        protected override async Task<IPage<SiteInner>> ListInnerByGroupAsync(string resourceGroupName, CancellationToken cancellationToken)
        {
            return await Inner.ListByResourceGroupAsync(resourceGroupName, cancellationToken: cancellationToken);
        }

        protected override async Task<IPage<SiteInner>> ListInnerByGroupNextAsync(string link, CancellationToken cancellationToken)
        {
            return await Inner.ListByResourceGroupNextAsync(link, cancellationToken);
        }

        protected override async Task<SiteInner> GetInnerByGroupAsync(string groupName, string name, CancellationToken cancellationToken)
        {
            return await Inner.GetAsync(groupName, name, cancellationToken);
        }
    }
}
