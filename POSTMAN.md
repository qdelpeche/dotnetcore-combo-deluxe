# Postman

These are the instructions to set up Postman in order to test this project. Because we are using bearer tokens in the project, you will need to follow these steps to set up Postman correctly.

## Setup

### Step 1: Register Your Application in Entra ID
1. Go to the Azure Portal.
1. Make sure you have a Microsoft Entra ID tenant or create one.
   * Take note of the **Tenant ID**.
   * Take note of the **Primary domain**.
1. Under App registrations, create a new registration for Postman.
   * Set the Supported account types to "Accounts in this organizational directory only."
   * Add a **Redirect URI** under the Web platform (use, ```https://oauth.pstmn.io/v1/callback```) and take note of it.
   * Take note of the **Client ID**.
1. Under API permissions, add necessary permissions. For this example, include openid, profile, and permissions to this project.
1. Grant admin consent for these permissions to ensure authorized access for all users in the organization.
1. Add a **Client Secret** and take note of it.

### Step 2: Update Permissions for this Project
1. Go back this project's app registration.
1. Go to "Expose an API".
1. Add a client application and use the **Client ID** from Step 1.
   * Ensure you check the "Authorized scopes" (e.g., api://dotnetcore-combo-deluxe/crud).

### Step 3: Configure Postman
1. Open Postman.
1. Create your request (e.g., http://localhost:4000/api/NoScope).
1. Set "Auth Type" to **OAuth 2.0**.
1. Fill in the details as follows:
   * TokenName: ```EntraIDToken``` or whatever you choose.
   * Grant Type: ```Authorization Code```
   * Callback URL: ```https://oauth.pstmn.io/v1/callback```
   * Auth URL: ```https://login.microsoftonline.com/<TENANT_ID>/oauth2/v2.0/authorize``` (replace ```<TENANT_ID>``` with your **Tenant ID** from above).
   * Access Token URL: ```https://login.microsoftonline.com/<TENANT_ID>/oauth2/v2.0/token``` (replace ```<TENANT_ID>``` with your **Tenant ID** from above).
   * Client ID: Enter the **Client ID** from above.
   * Client Secret: Enter the **Client Secret** from above.
   * Scope: Enter the scope of this project (e.g., api://dotnetcore-combo-deluxe/crud).

## Using
The process is quite simple:
1. Click "Get New Access Token".
1. Follow the steps to log in.
1. When the token is ready, click "Use Token".
1. Send your request to the server.

## Version
* Postman: 11.18