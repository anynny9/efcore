// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#nullable enable

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore
{
    /// <summary>
    ///     Extension methods for <see cref="IConventionProperty" />.
    /// </summary>
    [Obsolete("Use IConventionProperty")]
    public static class ConventionPropertyExtensions
    {
        /// <summary>
        ///     Sets the custom <see cref="ValueComparer" /> for this property when performing key comparisons.
        /// </summary>
        /// <param name="property"> The property. </param>
        /// <param name="comparer"> The comparer, or <see langword="null" /> to remove any previously set comparer. </param>
        /// <param name="fromDataAnnotation"> Indicates whether the configuration was specified using a data annotation. </param>
        [Obsolete("Use SetValueComparer. Only a single value comparer is allowed for a given property.")]
        public static void SetKeyValueComparer(
            [NotNull] this IConventionProperty property,
            [CanBeNull] ValueComparer? comparer,
            bool fromDataAnnotation = false)
            => property.SetValueComparer(comparer);

        /// <summary>
        ///     Returns the configuration source for <see cref="IReadOnlyProperty.GetKeyValueComparer" />.
        /// </summary>
        /// <param name="property"> The property to find configuration source for. </param>
        /// <returns> The configuration source for <see cref="IReadOnlyProperty.GetKeyValueComparer" />. </returns>
        [Obsolete("Use GetValueComparerConfigurationSource. Only a single value comparer is allowed for a given property.")]
        public static ConfigurationSource? GetKeyValueComparerConfigurationSource([NotNull] this IConventionProperty property)
            => property.FindAnnotation(CoreAnnotationNames.KeyValueComparer)?.GetConfigurationSource();

        /// <summary>
        ///     Sets the custom <see cref="ValueComparer" /> for structural copies for this property.
        /// </summary>
        /// <param name="property"> The property. </param>
        /// <param name="comparer"> The comparer, or <see langword="null" /> to remove any previously set comparer. </param>
        /// <param name="fromDataAnnotation"> Indicates whether the configuration was specified using a data annotation. </param>
        [Obsolete("Use SetValueComparer. Only a single value comparer is allowed for a given property.")]
        public static void SetStructuralValueComparer(
            [NotNull] this IConventionProperty property,
            [CanBeNull] ValueComparer? comparer,
            bool fromDataAnnotation = false)
            => property.SetKeyValueComparer(comparer, fromDataAnnotation);

        /// <summary>
        ///     Returns the configuration source for <see cref="PropertyExtensions.GetStructuralValueComparer" />.
        /// </summary>
        /// <param name="property"> The property to find configuration source for. </param>
        /// <returns> The configuration source for <see cref="PropertyExtensions.GetStructuralValueComparer" />. </returns>
        [Obsolete("Use GetValueComparerConfigurationSource. Only a single value comparer is allowed for a given property.")]
        public static ConfigurationSource? GetStructuralValueComparerConfigurationSource([NotNull] this IConventionProperty property)
            => property.GetKeyValueComparerConfigurationSource();
    }
}
