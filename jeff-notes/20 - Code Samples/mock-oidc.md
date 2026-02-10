# A Development OIDC/OAuth2 Server

[[notes/10 - Concepts/10.90 - Development Environment]]

#oidc #oauth2


## Hosting mock-oauth2-server in Aspire: 

In `apphost.cs`

```csharp
// Mock OAuth2 Server container - Pretends to be an identity provider, great for development.
var identity = builder.AddContainer("identity", "ghcr.io/navikt/mock-oauth2-server:3.0.1")
    .WithHttpEndpoint(9069, 8080) // Expose port 9069 on host to 8080 in container
    .WithLifetime(ContainerLifetime.Persistent) // Keep container and data between runs
    .WithEnvironment("JSON_CONFIG_PATH", "/app/resources/software/settings/config.json");
```

## Example `appsettings.development.json` for an API:

```json
  "Authentication": {
    "Schemes": {
      "Bearer": {
        "ClientId": "catalog-api",
        "ClientSecret": "oidc-pkce-confidential_secret",
        "RequireHttpsMetadata": false,
        "MapInboundClaims": false,
        "GetClaimsFromUserInfoEndpoint": true,
        "SaveTokens": true,
        "ValidateIssuer": false,
        "ValidateAudience": false,
        "ValidateIssuerSigningKey": false
      },
      "OpenIdConnect": {
        "ClientId": "catalog-api",
        "ClientSecret": "oidc-pkce-confidential_secret",
        "RequireHttpsMetadata": false,
        "GetClaimsFromUserInfoEndpoint": true,
        "SaveTokens": true,
        "MapInboundClaims": false
      }
    }
  }
```