// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// VNETInfo contract. This contract is public and is a stripped down
    /// version of VNETInfoInternal
    /// </summary>
    [JsonTransformation]
    public partial class VnetInfo : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VnetInfo class.
        /// </summary>
        public VnetInfo() { }

        /// <summary>
        /// Initializes a new instance of the VnetInfo class.
        /// </summary>
        public VnetInfo(string name, string location, string id = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string vnetResourceId = default(string), string certThumbprint = default(string), string certBlob = default(string), IList<VnetRoute> routes = default(IList<VnetRoute>), bool? resyncRequired = default(bool?), string dnsServers = default(string))
            : base(name, location, id, kind, type, tags)
        {
            VnetResourceId = vnetResourceId;
            CertThumbprint = certThumbprint;
            CertBlob = certBlob;
            Routes = routes;
            ResyncRequired = resyncRequired;
            DnsServers = dnsServers;
        }

        /// <summary>
        /// The vnet resource id
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetResourceId")]
        public string VnetResourceId { get; set; }

        /// <summary>
        /// The client certificate thumbprint
        /// </summary>
        [JsonProperty(PropertyName = "properties.certThumbprint")]
        public string CertThumbprint { get; set; }

        /// <summary>
        /// A certificate file (.cer) blob containing the public key of the
        /// private key used to authenticate a
        /// Point-To-Site VPN connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.certBlob")]
        public string CertBlob { get; set; }

        /// <summary>
        /// The routes that this virtual network connection uses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routes")]
        public IList<VnetRoute> Routes { get; set; }

        /// <summary>
        /// Flag to determine if a resync is required
        /// </summary>
        [JsonProperty(PropertyName = "properties.resyncRequired")]
        public bool? ResyncRequired { get; set; }

        /// <summary>
        /// Dns servers to be used by this VNET. This should be a
        /// comma-separated list of IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsServers")]
        public string DnsServers { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.Routes != null)
            {
                foreach (var element in this.Routes)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
