// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Dashboard.Models
{
    /// <summary> The properties parameters for a PATCH request to a grafana resource. </summary>
    public partial class ManagedGrafanaPropertiesUpdateParameters
    {
        /// <summary> Initializes a new instance of ManagedGrafanaPropertiesUpdateParameters. </summary>
        public ManagedGrafanaPropertiesUpdateParameters()
        {
            GrafanaPlugins = new ChangeTrackingDictionary<string, GrafanaPlugin>();
        }

        /// <summary> The zone redundancy setting of the Grafana instance. </summary>
        public ZoneRedundancy? ZoneRedundancy { get; set; }
        /// <summary> The api key setting of the Grafana instance. </summary>
        public ApiKey? ApiKey { get; set; }
        /// <summary> Whether a Grafana instance uses deterministic outbound IPs. </summary>
        public DeterministicOutboundIP? DeterministicOutboundIP { get; set; }
        /// <summary> Indicate the state for enable or disable traffic over the public interface. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> GrafanaIntegrations is a bundled observability experience (e.g. pre-configured data source, tailored Grafana dashboards, alerting defaults) for common monitoring scenarios. </summary>
        internal GrafanaIntegrations GrafanaIntegrations { get; set; }
        /// <summary> Gets the azure monitor workspace integrations. </summary>
        public IList<AzureMonitorWorkspaceIntegration> AzureMonitorWorkspaceIntegrations
        {
            get
            {
                if (GrafanaIntegrations is null)
                    GrafanaIntegrations = new GrafanaIntegrations();
                return GrafanaIntegrations.AzureMonitorWorkspaceIntegrations;
            }
        }

        /// <summary> Enterprise settings of a Grafana instance. </summary>
        public EnterpriseConfigurations EnterpriseConfigurations { get; set; }
        /// <summary> Server configurations of a Grafana instance. </summary>
        internal GrafanaConfigurations GrafanaConfigurations { get; set; }
        /// <summary>
        /// Email server settings.
        /// https://grafana.com/docs/grafana/v9.0/setup-grafana/configure-grafana/#smtp
        /// </summary>
        public Smtp GrafanaConfigurationsSmtp
        {
            get => GrafanaConfigurations is null ? default : GrafanaConfigurations.Smtp;
            set
            {
                if (GrafanaConfigurations is null)
                    GrafanaConfigurations = new GrafanaConfigurations();
                GrafanaConfigurations.Smtp = value;
            }
        }

        /// <summary> Update of Grafana plugin. Key is plugin id, value is plugin definition. If plugin definition is null, plugin with given plugin id will be removed. Otherwise, given plugin will be installed. </summary>
        public IDictionary<string, GrafanaPlugin> GrafanaPlugins { get; }
        /// <summary> The major Grafana software version to target. </summary>
        public string GrafanaMajorVersion { get; set; }
    }
}
