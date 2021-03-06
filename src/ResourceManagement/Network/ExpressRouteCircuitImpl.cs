// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.Network.Fluent.ExpressRouteCircuit.Definition;
    using Microsoft.Azure.Management.Network.Fluent.ExpressRouteCircuit.Update;
    using Microsoft.Azure.Management.Network.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using System.Collections.Generic;

///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50Lm5ldHdvcmsuaW1wbGVtZW50YXRpb24uRXhwcmVzc1JvdXRlQ2lyY3VpdEltcGw=
    internal partial class ExpressRouteCircuitImpl  :
        GroupableParentResource<
            IExpressRouteCircuit,
            ExpressRouteCircuitInner,
            ExpressRouteCircuitImpl,
            INetworkManager,
            IWithGroup,
            ExpressRouteCircuit.Definition.IWithServiceProvider,
            IWithCreate,
            IUpdate>,
        IExpressRouteCircuit,
        IDefinition,
        IUpdate
    {
        private ExpressRouteCircuitPeeringsImpl peerings;
        private Dictionary<string, IExpressRouteCircuitPeering> expressRouteCircuitPeerings;
        ///GENMHASH:359B78C1848B4A526D723F29D8C8C558:61D79376AC9D01EA7059F6BD84206AB4
        protected override async Task<Models.ExpressRouteCircuitInner> CreateInnerAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return await Manager.Inner.ExpressRouteCircuits.CreateOrUpdateAsync(ResourceGroupName, Name, Inner);
        }

        ///GENMHASH:AC21A10EE2E745A89E94E447800452C1:4A8A08F876EE1B1D8B0D8521C4C08D8D
        protected override void BeforeCreating()
        {
        }

        ///GENMHASH:1DD11B743EA080DABF3911449A2D097A:B60D86AC1332DA7EE3D07D731C97EDBC
        public bool IsAllowClassicOperations()
        {
            return Inner.AllowClassicOperations.HasValue ? Inner.AllowClassicOperations.Value : false;
        }

        ///GENMHASH:F04E137633EC331554E748A2DF9F1C63:E5F6F8BB59C66FDE984B44E1C54B5DD4
        public ExpressRouteCircuitImpl EnableClassicOperations()
        {
            Inner.AllowClassicOperations = true;
            return this;
        }

        ///GENMHASH:FCCC6282D4C0CBC779DE9E45F79406A3:6949147503205A9E73F5615BB1589DCC
        public ExpressRouteCircuitImpl WithBandwidthInMbps(int bandwidthInMbps)
        {
            EnsureServiceProviderProperties().BandwidthInMbps = bandwidthInMbps;
            return this;
        }

        ///GENMHASH:85C0B0BDE138F3DA3DA30727277F9168:07F188A54813492D83103B14B8C862DE
        public IUpdate DisableClassicOperations()
        {
            Inner.AllowClassicOperations = false;
            return this;
        }

        ///GENMHASH:F91F57741BB7E185BF012523964DEED0:27E486AB74A10242FF421C0798DDC450
        protected override void AfterCreating()
        {
        }

        ///GENMHASH:6D9F740D6D73C56877B02D9F1C96F6E7:3DFA04748ECE6D9F0E55BD6015449BA8
        protected override void InitializeChildrenFromInner()
        {
            expressRouteCircuitPeerings = new Dictionary<string, IExpressRouteCircuitPeering>();
            if (Inner.Peerings != null) {
                foreach(var peering in Inner.Peerings) {
                    expressRouteCircuitPeerings[peering.Name] = new ExpressRouteCircuitPeeringImpl(this, peering, Manager.Inner.ExpressRouteCircuitPeerings, ExpressRouteCircuitPeeringType.Parse(peering.PeeringType));
                }
            }

        }

        public override async Task<IExpressRouteCircuit> RefreshAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await base.RefreshAsync(cancellationToken);
            InitializeChildrenFromInner();
            return this;
        }

        ///GENMHASH:2DA41BC231DAB49CE5C371D81589EE4C:33F0C10B83F076BDC2D44F79C1C586E1
        public string ServiceProviderNotes()
        {
            return Inner.ServiceProviderNotes;
        }

        ///GENMHASH:D8FCD961D6BE6B83CB9C046D9F26E057:59190BD3B464A70A33E345C37A98560E
        public ServiceProviderProvisioningState ServiceProviderProvisioningState()
        {
            return Models.ServiceProviderProvisioningState.Parse(Inner.ServiceProviderProvisioningState);
        }

        ///GENMHASH:99D5BF64EA8AA0E287C9B6F77AAD6FC4:3DB04077E6BABC0FB5A5ACDA19D11309
        public string ProvisioningState()
        {
            return Inner.ProvisioningState;
        }

        ///GENMHASH:EBF5D7FCB8A0369CDDB6CE536441686B:B1BC50C86FFB2C345FDD74FE115FF7EB
        internal  ExpressRouteCircuitImpl(string name, ExpressRouteCircuitInner innerObject, INetworkManager manager)
            : base(name, innerObject, manager)
        {
        }

        ///GENMHASH:5AD91481A0966B059A478CD4E9DD9466:94AB303D28E23177449985C742EA7495
        protected override async Task<Models.ExpressRouteCircuitInner> GetInnerAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return await this.Manager.Inner.ExpressRouteCircuits.GetAsync(ResourceGroupName, this.Name);
        }

        ///GENMHASH:7C102FC888A44580A6E10E7FF69A5CC6:65FBF79C40CABC2B89EEE9134C216675
        public ExpressRouteCircuitImpl WithSku(ExpressRouteCircuitSkuType sku)
        {
            Inner.Sku = sku.Sku();
            return this;
        }

        ///GENMHASH:6156CBBE562DB102D30D00D0F72FF564:CC801AA6C2F51CD8A1E0CA4F52068A83
        private ExpressRouteCircuitServiceProviderProperties EnsureServiceProviderProperties()
        {
            if (Inner.ServiceProviderProperties == null) {
                Inner.ServiceProviderProperties = new ExpressRouteCircuitServiceProviderProperties();
            }
            return Inner.ServiceProviderProperties;
        }

        ///GENMHASH:C1218CB3CF7425636BEAE9124D60FA31:AA92E7FF458AF1B7C292C536F653D5DE
        public ExpressRouteCircuitImpl WithServiceProvider(string serviceProviderName)
        {
            EnsureServiceProviderProperties().ServiceProviderName = serviceProviderName;
            return this;
        }

        ///GENMHASH:F643E35681DDE3BAB4A2AD17B92AC438:5F1DD36DE2F88BA9BD8A7B9E6E0F9A90
        public string CircuitProvisioningState()
        {
            return Inner.CircuitProvisioningState;
        }

        ///GENMHASH:66F5A03D7EB9E3E5BA184EFDB0178FFD:52BBC11095CBE139DC9FCE45CA978969
        public IReadOnlyDictionary<string,Microsoft.Azure.Management.Network.Fluent.IExpressRouteCircuitPeering> PeeringsMap()
        {
            return expressRouteCircuitPeerings;
        }

        ///GENMHASH:DAC0ADBD485D3FA7934FDCF3DF6AFB33:89CD7B3F148D44874EE77529B14FD49A
        public IExpressRouteCircuitPeerings Peerings()
        {
            if (peerings == null) {
                peerings = new ExpressRouteCircuitPeeringsImpl(this);
            }
            return peerings;
        }

        ///GENMHASH:61C73FB217F7A9A923B7B628B601872E:31A1C8230C69B8AF9BB1B31FAAAB7CB6
        public string ServiceKey()
        {
            return Inner.ServiceKey;
        }

        ///GENMHASH:F792F6C8C594AA68FA7A0FCA92F55B55:A944DB494D8304965DA88AD60DC67F18
        public ExpressRouteCircuitSkuType Sku()
        {
            return ExpressRouteCircuitSkuType.FromSku(Inner.Sku);
        }

        ///GENMHASH:EAEB821EE6A7057687C263BA59743170:84EDF5CF16690E7BECA4C96DB170FE06
        public ExpressRouteCircuitImpl WithPeeringLocation(string location)
        {
            EnsureServiceProviderProperties().PeeringLocation = location;
            return this;
        }

        ///GENMHASH:8DDC9D7A46BBD05C8777C27CFE8EA6E7:13D89199398BD8696BA24577F7FB0955
        public ExpressRouteCircuitServiceProviderProperties ServiceProviderProperties()
        {
            return Inner.ServiceProviderProperties;
        }
    }
}