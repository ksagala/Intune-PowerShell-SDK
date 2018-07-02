// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; objects.</para>
    ///     <para type="description">GET ~/me/events/{eventId}/instances/{instanceId}/calendar/singleValueExtendedProperties</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; objects in the &quot;singleValueExtendedProperties&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Events_Instances_Calendar_SingleValueExtendedProperties", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
    [ResourceIdPropertyName("singleValueExtendedPropertyId")]
    [ResourceReference]
    public class Get_Me_Events_Instances_Calendar_SingleValueExtendedProperties : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.")]
        public System.String instanceId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.")]
        public System.String eventId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; object in the &quot;singleValueExtendedProperties&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; object in the &quot;singleValueExtendedProperties&quot; collection.")]
        public System.String singleValueExtendedPropertyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String value { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/events/{eventId}/instances/{instanceId}/calendar/singleValueExtendedProperties/{singleValueExtendedPropertyId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; object.</para>
    ///     <para type="description">POST ~/me/events/{eventId}/instances/{instanceId}/calendar/singleValueExtendedProperties</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; object to the &quot;singleValueExtendedProperties&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Events_Instances_Calendar_SingleValueExtendedProperties", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.singleValueLegacyExtendedProperty")]
    [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
    [ResourceReference]
    public class New_Me_Events_Instances_Calendar_SingleValueExtendedProperties : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.")]
        public System.String instanceId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.")]
        public System.String eventId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.singleValueLegacyExtendedProperty", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String value { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/events/{eventId}/instances/{instanceId}/calendar/singleValueExtendedProperties";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
    ///     <para type="description">PATCH ~/me/events/{eventId}/instances/{instanceId}/calendar/singleValueExtendedProperties</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; object in the &quot;singleValueExtendedProperties&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Events_Instances_Calendar_SingleValueExtendedProperties", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.singleValueLegacyExtendedProperty")]
    [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
    [ResourceIdPropertyName("singleValueExtendedPropertyId")]
    public class Update_Me_Events_Instances_Calendar_SingleValueExtendedProperties : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; object in the &quot;singleValueExtendedProperties&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; object in the &quot;singleValueExtendedProperties&quot; collection.")]
        public System.String singleValueExtendedPropertyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.")]
        public System.String instanceId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.")]
        public System.String eventId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.singleValueLegacyExtendedProperty", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String value { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/events/{eventId}/instances/{instanceId}/calendar/singleValueExtendedProperties/{singleValueExtendedPropertyId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; object.</para>
    ///     <para type="description">DELETE ~/me/events/{eventId}/instances/{instanceId}/calendar/singleValueExtendedProperties/singleValueExtendedPropertyId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; object from the &quot;singleValueExtendedProperties&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Events_Instances_Calendar_SingleValueExtendedProperties", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
    [ResourceIdPropertyName("singleValueExtendedPropertyId")]
    public class Remove_Me_Events_Instances_Calendar_SingleValueExtendedProperties : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; object in the &quot;singleValueExtendedProperties&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; object in the &quot;singleValueExtendedProperties&quot; collection.")]
        public System.String singleValueExtendedPropertyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.")]
        public System.String instanceId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.")]
        public System.String eventId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/events/{eventId}/instances/{instanceId}/calendar/singleValueExtendedProperties/{singleValueExtendedPropertyId}";
        }
    }
}