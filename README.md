# .NET Core Combo Deluxe

This .NET Core Combo Deluxe uses OpenIdConnectDefaults for the web pages and JwtBearerDefaults for the REST endpoints. It will authenticate and authorize with Entra ID in Azure and works perfectly with the free tier. 

## Setup

### Step 1: Register Your Application in Entra ID
1. Go to the Azure Portal.
1. Make sure you have a Microsoft Entra ID tenant or create one.
   * Take note of the **Tenant ID**.
   * Take note of the **Primary domain**.
1. Under App registrations, create a new registration for this project.
   * Set the Supported account types to "Accounts in this organizational directory only."
   * Add a unique **Application ID URI** (e.g., api://dotnetcore-combo-deluxe) and take note of it.
1. Set the Redirect URI to https://localhost:5001/signin-oidc (or adjust the port to match your project).
1. Under Authentication, enable ID tokens since this application is a web app using OpenID Connect.
1. Under API permissions, add necessary permissions. For this example, include openid, profile, and a custom scope if needed (e.g., api://dotnetcore-combo-deluxe/crud).
1. Grant admin consent for these permissions to ensure authorized access for all users in the organization.

### Step 2: Configure API Permissions and Admin Consent
1. In the app registration settings, go to API Permissions.
1. Add Microsoft Graph API permissions (e.g., openid, profile, and User.Read) to enable basic user information access.
1. Click Grant admin consent to allow the application access to these permissions for all users.

### Step 3: Configure msalConfig
1. Open appsettings.json
1. Replace ``<PRIMARY_DOMAIN>`` with the **Primary domain** from the Microsoft Entra ID tenant.
1. Replace ``<TENANT_ID>`` with the **Tenant ID** from the Microsoft Entra ID tenant.
1. Replace ``<CLIENT_ID>`` with the **Client ID** from the app in Step 1.
1. Replace ``<CLIENT_SECRET>`` with the **Client Secret** for the app.
1. Replace ``<APPLICATION_ID_URI>`` with the **Application ID URI** from the app in Step 1.

## Tutorials
* [Microsoft Entra ID with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/azure-active-directory/?view=aspnetcore-8.0)

## Versions
* .NET: 8.0.10
