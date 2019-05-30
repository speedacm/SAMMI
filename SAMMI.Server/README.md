# Server
<table>
  <tr>
    <td>Namespace</td>
    <td><a href="SAMMI.Server">SAMMI.Server</a></td>
  </tr>
  <tr>
    <td>Languages</td>
    <td>C#</td>
  </tr>
  <tr>
    <td>Framework</td>
    <td><a href="https://github.com/aspnet/AspNetCore">ASP.NET Core</a></td>
  </tr>
  <tr>
    <td>Stack</td>
    <td>Back-end</td>
  </tr>
</table>

The Server project is an ASP.NET Core HTTP server which serves the [Client](..\SAMMI.Client) project as well as exposes a public web API.  The web API should return only types from the System libraries or the [Models](..\SAMMI.Shared) project.  Data from the SAMMI database *must* be acquired via the [Data Interface](..\SAMMI.Server.Data) project.
