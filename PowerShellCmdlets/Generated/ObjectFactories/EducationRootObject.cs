// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.educationRoot&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.educationRoot&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "EducationRootObject", DefaultParameterSetName = @"microsoft.graph.educationRoot")]
    [ODataType("microsoft.graph.educationRoot")]
    public class New_EducationRootObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;classes&quot; property, of type &quot;microsoft.graph.educationClass&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationRoot&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.educationClass")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.educationRoot", HelpMessage = @"The &quot;classes&quot; property, of type &quot;microsoft.graph.educationClass&quot;.")]
        public System.Object[] classes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;schools&quot; property, of type &quot;microsoft.graph.educationSchool&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationRoot&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.educationSchool")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.educationRoot", HelpMessage = @"The &quot;schools&quot; property, of type &quot;microsoft.graph.educationSchool&quot;.")]
        public System.Object[] schools { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;users&quot; property, of type &quot;microsoft.graph.educationUser&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationRoot&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.educationUser")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.educationRoot", HelpMessage = @"The &quot;users&quot; property, of type &quot;microsoft.graph.educationUser&quot;.")]
        public System.Object[] users { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;me&quot; property, of type &quot;microsoft.graph.educationUser&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationRoot&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.educationUser")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationRoot", HelpMessage = @"The &quot;me&quot; property, of type &quot;microsoft.graph.educationUser&quot;.")]
        public System.Object me { get; set; }
    }
}