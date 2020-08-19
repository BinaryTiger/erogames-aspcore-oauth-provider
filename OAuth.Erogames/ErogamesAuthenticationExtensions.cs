using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Authentication;
using OAuth.Erogames;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods to add Erogames authentication capabilities to an HTTP application pipeline.
    /// </summary>
    public static class ErogamesAuthenticationExtensions
    {
        /// <summary>
        /// Adds <see cref="ErogamesAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Erogames authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddErogames([NotNull] this AuthenticationBuilder builder)
        {
            return builder.AddErogames(ErogamesAuthenticationDefaults.AuthenticationScheme, options => { });
        }

        /// <summary>
        /// Adds <see cref="ErogamesAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Erogames authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="configuration">The delegate used to configure the OpenID 2.0 options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddErogames(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] Action<ErogamesAuthenticationOptions> configuration)
        {
            return builder.AddErogames(ErogamesAuthenticationDefaults.AuthenticationScheme, configuration);
        }

        /// <summary>
        /// Adds <see cref="ErogamesAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Erogames authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the Erogames options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddErogames(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] string scheme,
            [NotNull] Action<ErogamesAuthenticationOptions> configuration)
        {
            return builder.AddErogames(scheme, ErogamesAuthenticationDefaults.DisplayName, configuration);
        }

        /// <summary>
        /// Adds <see cref="ErogamesAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Erogames authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="caption">The optional display name associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the Erogames options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddErogames(
            [NotNull]this AuthenticationBuilder builder,
            [NotNull] string scheme,
            string caption,
            [NotNull] Action<ErogamesAuthenticationOptions> configuration)
        {
            return builder.AddOAuth<ErogamesAuthenticationOptions, ErogamesAuthenticationHandler>(scheme, caption, configuration);
        }

        
    }
}