﻿namespace IdentityModel.AspNetCore.OAuth2Introspection.Infrastructure
{
    public class IntrospectionClientOptions
    {
        public string Address { get; internal set; }
        public string ClientId { get; internal set; }
        public string ClientSecret { get; internal set; }
    }
}