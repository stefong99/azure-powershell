﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Management.Automation;

namespace Microsoft.Azure.Commands.ContainerRegistry.Commands
{
    [Cmdlet("Remove", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ContainerRegistryManifest", DefaultParameterSetName = ByManifestParameterSet, SupportsShouldProcess = true)]
    [OutputType(typeof(bool))]
    public class RemoveAzureContainerRegistryManifest : ContainerRegistryDataPlaneCmdletBase
    {
        [Parameter(Mandatory = true, ParameterSetName = ByManifestParameterSet, ValueFromPipelineByPropertyName = true, HelpMessage = "Repository Name.")]
        [Parameter(Mandatory = true, ParameterSetName = ByTagParameterSet, ValueFromPipelineByPropertyName = true, HelpMessage = "Repository Name.")]
        [ValidateNotNullOrEmpty]
        public string RepositoryName { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = ByManifestParameterSet, ValueFromPipelineByPropertyName = true, HelpMessage = "Manifest reference.")]
        [ValidateNotNullOrEmpty]
        public string Manifest { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = ByTagParameterSet, ValueFromPipelineByPropertyName = true, HelpMessage = "Tag.")]
        [ValidateNotNullOrEmpty]
        public string Tag { get; set; }

        public override void ExecuteChildCmdlet()
        {
            if (ParameterSetName.Equals(ByManifestParameterSet))
            {
                if (this.ShouldProcess(string.Format("Delete manifest {0}@{1} under {2}", this.RepositoryName, this.Manifest, this.RegistryName)))
                {
                    WriteObject(this.RegistryDataPlaneClient.RemoveManifest(this.RepositoryName, this.Manifest));
                }  
            }
            else if (ParameterSetName.Equals(ByTagParameterSet))
            {
                if (this.ShouldProcess(string.Format("Delete manifest for {0}：{1} under {2}", this.RepositoryName, this.Tag, this.RegistryName)))
                {
                    WriteObject(this.RegistryDataPlaneClient.RemoveManifestByTag(this.RepositoryName, this.Tag));
                }
            }
            else
            {
                throw new PSArgumentException("Invalid parameter set");
            }
        }
    }
}
