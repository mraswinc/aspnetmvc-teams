# ASP.NET MVC - Teams Tab
1. This project is showcasing how to integrate with Teams. At this current moment, only Auth is supported.

Steps:
1. Add jquery and Teams JS SDK into your project - https://docs.microsoft.com/en-us/javascript/api/overview/msteams-client?view=msteams-client-js-latest
2. Initialize the SDK
3. Use microsoftTeams.authentication.authenticate to create a popup dialog to allow the token to be passed from the browser to Teams
4. This authentication flow explains how the authentication works in Teams Tab. https://docs.microsoft.com/en-us/microsoftteams/platform/tabs/how-to/authentication/auth-flow-tab
