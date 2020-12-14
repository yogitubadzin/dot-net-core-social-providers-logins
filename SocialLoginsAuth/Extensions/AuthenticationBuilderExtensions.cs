using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SocialLoginsAuth.Extensions
{
    public static class AuthenticationBuilderExtensions
    {
        public static AuthenticationBuilder AddFacebookAuth(
            this AuthenticationBuilder serviceCollection,
            IConfiguration configuration)
        {
            var id = configuration["ExternalProviders:Facebook:Id"];
            var secret = configuration["ExternalProviders:Facebook:secret"];

            if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(secret))
            {
                serviceCollection.AddFacebook(options =>
                {
                    options.AppId = id;
                    options.AppSecret = secret;
                });
            }

            return serviceCollection;
        }

        public static AuthenticationBuilder AddTwitterAuth(
            this AuthenticationBuilder serviceCollection,
            IConfiguration configuration)
        {
            var id = configuration["ExternalProviders:Twitter:Id"];
            var secret = configuration["ExternalProviders:Twitter:secret"];

            if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(secret))
            {
                serviceCollection.AddTwitter(options =>
                {
                    options.ConsumerKey = id;
                    options.ConsumerSecret = secret;
                });
            }

            return serviceCollection;
        }

        public static AuthenticationBuilder AddGitHubAuth(
            this AuthenticationBuilder serviceCollection,
            IConfiguration configuration)
        {
            var id = configuration["ExternalProviders:GitHub:Id"];
            var secret = configuration["ExternalProviders:GitHub:secret"];

            if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(secret))
            {
                serviceCollection.AddGitHub(options =>
                {
                    options.ClientId = id;
                    options.ClientSecret = secret;
                });
            }

            return serviceCollection;
        }

        public static AuthenticationBuilder AddGoogleAuth(
            this AuthenticationBuilder serviceCollection,
            IConfiguration configuration)
        {
            var id = configuration["ExternalProviders:Google:Id"];
            var secret = configuration["ExternalProviders:Google:secret"];

            if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(secret))
            {
                serviceCollection.AddGoogle(options =>
                {
                    options.ClientId = id;
                    options.ClientSecret = secret;
                });
            }

            return serviceCollection;
        }
    }
}