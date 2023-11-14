// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Configuration settings for the Azure App Service Authentication / Authorization feature. </summary>
    public partial class SiteAuthSettings : ResourceData
    {
        /// <summary> Initializes a new instance of SiteAuthSettings. </summary>
        public SiteAuthSettings()
        {
            AllowedExternalRedirectUrls = new ChangeTrackingList<string>();
            AllowedAudiences = new ChangeTrackingList<string>();
            AdditionalLoginParams = new ChangeTrackingList<string>();
            GoogleOAuthScopes = new ChangeTrackingList<string>();
            FacebookOAuthScopes = new ChangeTrackingList<string>();
            GitHubOAuthScopes = new ChangeTrackingList<string>();
            MicrosoftAccountOAuthScopes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SiteAuthSettings. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isEnabled"> &lt;code&gt;true&lt;/code&gt; if the Authentication / Authorization feature is enabled for the current app; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="runtimeVersion">
        /// The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
        /// The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
        /// </param>
        /// <param name="unauthenticatedClientAction"> The action to take when an unauthenticated client attempts to access the app. </param>
        /// <param name="isTokenStoreEnabled">
        /// &lt;code&gt;true&lt;/code&gt; to durably store platform-specific security tokens that are obtained during login flows; otherwise, &lt;code&gt;false&lt;/code&gt;.
        ///  The default is &lt;code&gt;false&lt;/code&gt;.
        /// </param>
        /// <param name="allowedExternalRedirectUrls">
        /// External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
        /// This is an advanced setting typically only needed by Windows Store application backends.
        /// Note that URLs within the current domain are always implicitly allowed.
        /// </param>
        /// <param name="defaultProvider">
        /// The default authentication provider to use when multiple providers are configured.
        /// This setting is only needed if multiple providers are configured and the unauthenticated client
        /// action is set to "RedirectToLoginPage".
        /// </param>
        /// <param name="tokenRefreshExtensionHours">
        /// The number of hours after session token expiration that a session token can be used to
        /// call the token refresh API. The default is 72 hours.
        /// </param>
        /// <param name="clientId">
        /// The Client ID of this relying party application, known as the client_id.
        /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </param>
        /// <param name="clientSecret">
        /// The Client Secret of this relying party application (in Azure Active Directory, this is also referred to as the Key).
        /// This setting is optional. If no client secret is configured, the OpenID Connect implicit auth flow is used to authenticate end users.
        /// Otherwise, the OpenID Connect Authorization Code Flow is used to authenticate end users.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </param>
        /// <param name="clientSecretSettingName"> The app setting name that contains the client secret of the relying party application. </param>
        /// <param name="clientSecretCertificateThumbprintString">
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret. It is also optional.
        /// </param>
        /// <param name="issuer">
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </param>
        /// <param name="validateIssuer"> Gets a value indicating whether the issuer should be a valid HTTPS url and be validated as such. </param>
        /// <param name="allowedAudiences">
        /// Allowed audience values to consider when validating JSON Web Tokens issued by
        /// Azure Active Directory. Note that the &lt;code&gt;ClientID&lt;/code&gt; value is always considered an
        /// allowed audience, regardless of this setting.
        /// </param>
        /// <param name="additionalLoginParams">
        /// Login parameters to send to the OpenID Connect authorization endpoint when
        /// a user logs in. Each parameter must be in the form "key=value".
        /// </param>
        /// <param name="aadClaimsAuthorization"> Gets a JSON string containing the Azure AD Acl settings. </param>
        /// <param name="googleClientId">
        /// The OpenID Connect Client ID for the Google web application.
        /// This setting is required for enabling Google Sign-In.
        /// Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        /// </param>
        /// <param name="googleClientSecret">
        /// The client secret associated with the Google web application.
        /// This setting is required for enabling Google Sign-In.
        /// Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        /// </param>
        /// <param name="googleClientSecretSettingName">
        /// The app setting name that contains the client secret associated with
        /// the Google web application.
        /// </param>
        /// <param name="googleOAuthScopes">
        /// The OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication.
        /// This setting is optional. If not specified, "openid", "profile", and "email" are used as default scopes.
        /// Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        /// </param>
        /// <param name="facebookAppId">
        /// The App ID of the Facebook app used for login.
        /// This setting is required for enabling Facebook Login.
        /// Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        /// </param>
        /// <param name="facebookAppSecret">
        /// The App Secret of the Facebook app used for Facebook Login.
        /// This setting is required for enabling Facebook Login.
        /// Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        /// </param>
        /// <param name="facebookAppSecretSettingName"> The app setting name that contains the app secret used for Facebook Login. </param>
        /// <param name="facebookOAuthScopes">
        /// The OAuth 2.0 scopes that will be requested as part of Facebook Login authentication.
        /// This setting is optional.
        /// Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        /// </param>
        /// <param name="gitHubClientId">
        /// The Client Id of the GitHub app used for login.
        /// This setting is required for enabling Github login
        /// </param>
        /// <param name="gitHubClientSecret">
        /// The Client Secret of the GitHub app used for Github Login.
        /// This setting is required for enabling Github login.
        /// </param>
        /// <param name="gitHubClientSecretSettingName">
        /// The app setting name that contains the client secret of the Github
        /// app used for GitHub Login.
        /// </param>
        /// <param name="gitHubOAuthScopes">
        /// The OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
        /// This setting is optional
        /// </param>
        /// <param name="twitterConsumerKey">
        /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        /// </param>
        /// <param name="twitterConsumerSecret">
        /// The OAuth 1.0a consumer secret of the Twitter application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        /// </param>
        /// <param name="twitterConsumerSecretSettingName">
        /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter
        /// application used for sign-in.
        /// </param>
        /// <param name="microsoftAccountClientId">
        /// The OAuth 2.0 client ID that was created for the app used for authentication.
        /// This setting is required for enabling Microsoft Account authentication.
        /// Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
        /// </param>
        /// <param name="microsoftAccountClientSecret">
        /// The OAuth 2.0 client secret that was created for the app used for authentication.
        /// This setting is required for enabling Microsoft Account authentication.
        /// Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
        /// </param>
        /// <param name="microsoftAccountClientSecretSettingName">
        /// The app setting name containing the OAuth 2.0 client secret that was created for the
        /// app used for authentication.
        /// </param>
        /// <param name="microsoftAccountOAuthScopes">
        /// The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication.
        /// This setting is optional. If not specified, "wl.basic" is used as the default scope.
        /// Microsoft Account Scopes and permissions documentation: https://msdn.microsoft.com/en-us/library/dn631845.aspx
        /// </param>
        /// <param name="isAuthFromFile">
        /// "true" if the auth config settings should be read from a file,
        /// "false" otherwise
        /// </param>
        /// <param name="authFilePath">
        /// The path of the config file containing auth settings.
        /// If the path is relative, base will the site's root directory.
        /// </param>
        /// <param name="configVersion">
        /// The ConfigVersion of the Authentication / Authorization feature in use for the current app.
        /// The setting in this value can control the behavior of the control plane for Authentication / Authorization.
        /// </param>
        /// <param name="kind"> Kind of resource. </param>
        internal SiteAuthSettings(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? isEnabled, string runtimeVersion, UnauthenticatedClientAction? unauthenticatedClientAction, bool? isTokenStoreEnabled, IList<string> allowedExternalRedirectUrls, BuiltInAuthenticationProvider? defaultProvider, double? tokenRefreshExtensionHours, string clientId, string clientSecret, string clientSecretSettingName, string clientSecretCertificateThumbprintString, string issuer, bool? validateIssuer, IList<string> allowedAudiences, IList<string> additionalLoginParams, string aadClaimsAuthorization, string googleClientId, string googleClientSecret, string googleClientSecretSettingName, IList<string> googleOAuthScopes, string facebookAppId, string facebookAppSecret, string facebookAppSecretSettingName, IList<string> facebookOAuthScopes, string gitHubClientId, string gitHubClientSecret, string gitHubClientSecretSettingName, IList<string> gitHubOAuthScopes, string twitterConsumerKey, string twitterConsumerSecret, string twitterConsumerSecretSettingName, string microsoftAccountClientId, string microsoftAccountClientSecret, string microsoftAccountClientSecretSettingName, IList<string> microsoftAccountOAuthScopes, string isAuthFromFile, string authFilePath, string configVersion, string kind) : base(id, name, resourceType, systemData)
        {
            IsEnabled = isEnabled;
            RuntimeVersion = runtimeVersion;
            UnauthenticatedClientAction = unauthenticatedClientAction;
            IsTokenStoreEnabled = isTokenStoreEnabled;
            AllowedExternalRedirectUrls = allowedExternalRedirectUrls;
            DefaultProvider = defaultProvider;
            TokenRefreshExtensionHours = tokenRefreshExtensionHours;
            ClientId = clientId;
            ClientSecret = clientSecret;
            ClientSecretSettingName = clientSecretSettingName;
            ClientSecretCertificateThumbprintString = clientSecretCertificateThumbprintString;
            Issuer = issuer;
            ValidateIssuer = validateIssuer;
            AllowedAudiences = allowedAudiences;
            AdditionalLoginParams = additionalLoginParams;
            AadClaimsAuthorization = aadClaimsAuthorization;
            GoogleClientId = googleClientId;
            GoogleClientSecret = googleClientSecret;
            GoogleClientSecretSettingName = googleClientSecretSettingName;
            GoogleOAuthScopes = googleOAuthScopes;
            FacebookAppId = facebookAppId;
            FacebookAppSecret = facebookAppSecret;
            FacebookAppSecretSettingName = facebookAppSecretSettingName;
            FacebookOAuthScopes = facebookOAuthScopes;
            GitHubClientId = gitHubClientId;
            GitHubClientSecret = gitHubClientSecret;
            GitHubClientSecretSettingName = gitHubClientSecretSettingName;
            GitHubOAuthScopes = gitHubOAuthScopes;
            TwitterConsumerKey = twitterConsumerKey;
            TwitterConsumerSecret = twitterConsumerSecret;
            TwitterConsumerSecretSettingName = twitterConsumerSecretSettingName;
            MicrosoftAccountClientId = microsoftAccountClientId;
            MicrosoftAccountClientSecret = microsoftAccountClientSecret;
            MicrosoftAccountClientSecretSettingName = microsoftAccountClientSecretSettingName;
            MicrosoftAccountOAuthScopes = microsoftAccountOAuthScopes;
            IsAuthFromFile = isAuthFromFile;
            AuthFilePath = authFilePath;
            ConfigVersion = configVersion;
            Kind = kind;
        }

        /// <summary> &lt;code&gt;true&lt;/code&gt; if the Authentication / Authorization feature is enabled for the current app; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
        /// The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
        /// </summary>
        public string RuntimeVersion { get; set; }
        /// <summary> The action to take when an unauthenticated client attempts to access the app. </summary>
        public UnauthenticatedClientAction? UnauthenticatedClientAction { get; set; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; to durably store platform-specific security tokens that are obtained during login flows; otherwise, &lt;code&gt;false&lt;/code&gt;.
        ///  The default is &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        public bool? IsTokenStoreEnabled { get; set; }
        /// <summary>
        /// External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
        /// This is an advanced setting typically only needed by Windows Store application backends.
        /// Note that URLs within the current domain are always implicitly allowed.
        /// </summary>
        public IList<string> AllowedExternalRedirectUrls { get; }
        /// <summary>
        /// The default authentication provider to use when multiple providers are configured.
        /// This setting is only needed if multiple providers are configured and the unauthenticated client
        /// action is set to "RedirectToLoginPage".
        /// </summary>
        public BuiltInAuthenticationProvider? DefaultProvider { get; set; }
        /// <summary>
        /// The number of hours after session token expiration that a session token can be used to
        /// call the token refresh API. The default is 72 hours.
        /// </summary>
        public double? TokenRefreshExtensionHours { get; set; }
        /// <summary>
        /// The Client ID of this relying party application, known as the client_id.
        /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        public string ClientId { get; set; }
        /// <summary>
        /// The Client Secret of this relying party application (in Azure Active Directory, this is also referred to as the Key).
        /// This setting is optional. If no client secret is configured, the OpenID Connect implicit auth flow is used to authenticate end users.
        /// Otherwise, the OpenID Connect Authorization Code Flow is used to authenticate end users.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        public string ClientSecret { get; set; }
        /// <summary> The app setting name that contains the client secret of the relying party application. </summary>
        public string ClientSecretSettingName { get; set; }
        /// <summary>
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret. It is also optional.
        /// </summary>
        public string ClientSecretCertificateThumbprintString { get; set; }
        /// <summary>
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </summary>
        public string Issuer { get; set; }
        /// <summary> Gets a value indicating whether the issuer should be a valid HTTPS url and be validated as such. </summary>
        public bool? ValidateIssuer { get; set; }
        /// <summary>
        /// Allowed audience values to consider when validating JSON Web Tokens issued by
        /// Azure Active Directory. Note that the &lt;code&gt;ClientID&lt;/code&gt; value is always considered an
        /// allowed audience, regardless of this setting.
        /// </summary>
        public IList<string> AllowedAudiences { get; }
        /// <summary>
        /// Login parameters to send to the OpenID Connect authorization endpoint when
        /// a user logs in. Each parameter must be in the form "key=value".
        /// </summary>
        public IList<string> AdditionalLoginParams { get; }
        /// <summary> Gets a JSON string containing the Azure AD Acl settings. </summary>
        public string AadClaimsAuthorization { get; set; }
        /// <summary>
        /// The OpenID Connect Client ID for the Google web application.
        /// This setting is required for enabling Google Sign-In.
        /// Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        /// </summary>
        public string GoogleClientId { get; set; }
        /// <summary>
        /// The client secret associated with the Google web application.
        /// This setting is required for enabling Google Sign-In.
        /// Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        /// </summary>
        public string GoogleClientSecret { get; set; }
        /// <summary>
        /// The app setting name that contains the client secret associated with
        /// the Google web application.
        /// </summary>
        public string GoogleClientSecretSettingName { get; set; }
        /// <summary>
        /// The OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication.
        /// This setting is optional. If not specified, "openid", "profile", and "email" are used as default scopes.
        /// Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        /// </summary>
        public IList<string> GoogleOAuthScopes { get; }
        /// <summary>
        /// The App ID of the Facebook app used for login.
        /// This setting is required for enabling Facebook Login.
        /// Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        /// </summary>
        public string FacebookAppId { get; set; }
        /// <summary>
        /// The App Secret of the Facebook app used for Facebook Login.
        /// This setting is required for enabling Facebook Login.
        /// Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        /// </summary>
        public string FacebookAppSecret { get; set; }
        /// <summary> The app setting name that contains the app secret used for Facebook Login. </summary>
        public string FacebookAppSecretSettingName { get; set; }
        /// <summary>
        /// The OAuth 2.0 scopes that will be requested as part of Facebook Login authentication.
        /// This setting is optional.
        /// Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        /// </summary>
        public IList<string> FacebookOAuthScopes { get; }
        /// <summary>
        /// The Client Id of the GitHub app used for login.
        /// This setting is required for enabling Github login
        /// </summary>
        public string GitHubClientId { get; set; }
        /// <summary>
        /// The Client Secret of the GitHub app used for Github Login.
        /// This setting is required for enabling Github login.
        /// </summary>
        public string GitHubClientSecret { get; set; }
        /// <summary>
        /// The app setting name that contains the client secret of the Github
        /// app used for GitHub Login.
        /// </summary>
        public string GitHubClientSecretSettingName { get; set; }
        /// <summary>
        /// The OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
        /// This setting is optional
        /// </summary>
        public IList<string> GitHubOAuthScopes { get; }
        /// <summary>
        /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        /// </summary>
        public string TwitterConsumerKey { get; set; }
        /// <summary>
        /// The OAuth 1.0a consumer secret of the Twitter application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        /// </summary>
        public string TwitterConsumerSecret { get; set; }
        /// <summary>
        /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter
        /// application used for sign-in.
        /// </summary>
        public string TwitterConsumerSecretSettingName { get; set; }
        /// <summary>
        /// The OAuth 2.0 client ID that was created for the app used for authentication.
        /// This setting is required for enabling Microsoft Account authentication.
        /// Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
        /// </summary>
        public string MicrosoftAccountClientId { get; set; }
        /// <summary>
        /// The OAuth 2.0 client secret that was created for the app used for authentication.
        /// This setting is required for enabling Microsoft Account authentication.
        /// Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
        /// </summary>
        public string MicrosoftAccountClientSecret { get; set; }
        /// <summary>
        /// The app setting name containing the OAuth 2.0 client secret that was created for the
        /// app used for authentication.
        /// </summary>
        public string MicrosoftAccountClientSecretSettingName { get; set; }
        /// <summary>
        /// The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication.
        /// This setting is optional. If not specified, "wl.basic" is used as the default scope.
        /// Microsoft Account Scopes and permissions documentation: https://msdn.microsoft.com/en-us/library/dn631845.aspx
        /// </summary>
        public IList<string> MicrosoftAccountOAuthScopes { get; }
        /// <summary>
        /// "true" if the auth config settings should be read from a file,
        /// "false" otherwise
        /// </summary>
        public string IsAuthFromFile { get; set; }
        /// <summary>
        /// The path of the config file containing auth settings.
        /// If the path is relative, base will the site's root directory.
        /// </summary>
        public string AuthFilePath { get; set; }
        /// <summary>
        /// The ConfigVersion of the Authentication / Authorization feature in use for the current app.
        /// The setting in this value can control the behavior of the control plane for Authentication / Authorization.
        /// </summary>
        public string ConfigVersion { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
