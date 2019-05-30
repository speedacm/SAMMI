# SAMMI
[![Website][logo]](https://speedacm.org/)  
The "Speed ACM Member Management Interface" (SAMMI) is a redevelopment of the "University of Louisville Student Chapter of the ACM" (ACM) public website.  This development is the primary focus of the "Web Apps Special Interest Group" (SIG).  The goals of the project are the following:
1. Increase maintainability of the website by allowing simpler, less-technical content management
1. Allow ACM members to register with their UofL e-mail accounts and pay dues online
1. Allow ACM officers to perform member-management duties online

## Contributing
In order to contribute you must participate in the SIG.  Discussion of contributions should take place on the [Speed ACM Discord](https://discord.speedacm.org) in the #web-apps channel.  ACM members in good standing may receive Write permissions for the repository upon request.  If granted, members are expected to commit all changes to their own personal development branch.  Contributions must be peer-reviewed and approved by the SIG Vice President.

## Components
SAMMI currently consists of four primary components.  More detailed information can be found in the README.md in each component project folder—linked in the Namespace property of the following tables.
### Client
<table>
  <tr>
    <td>Namespace</td>
    <td><a href="SAMMI.Client">SAMMI.Client</a></td>
  </tr>
  <tr>
    <td>Languages</td>
    <td>C#, HTML, SCSS</td>
  </tr>
  <tr>
    <td>Framework</td>
    <td><a href="https://github.com/aspnet/AspNetCore/tree/master/src/Components">Blazor</a></td>
  </tr>
  <tr>
    <td>Stack</td>
    <td>Front-end</td>
  </tr>
</table>

### Server
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

### Data Interface
<table>
  <tr>
    <td>Namespace</td>
    <td><a href="SAMMI.Server.Data">SAMMI.Server.Data</a></td>
  </tr>
  <tr>
    <td>Languages</td>
    <td>C#</td>
  </tr>
  <tr>
    <td>Framework</td>
    <td><a href="https://github.com/aspnet/EntityFrameworkCore">EF Core</a></td>
  </tr>
  <tr>
    <td>Stack</td>
    <td>Back-end</td>
  </tr>
</table>

### Models
<table>
  <tr>
    <td>Namespace</td>
    <td><a href="SAMMI.Shared">SAMMI.Shared</a></td>
  </tr>
  <tr>
    <td>Languages</td>
    <td>C#</td>
  </tr>
  <tr>
    <td>Framework</td>
    <td><a href="https://github.com/dotnet/core">.NET Core</a></td>
  </tr>
  <tr>
    <td>Stack</td>
    <td>Shared</td>
  </tr>
</table>

## Developement
SAMMI is built entirely on [.NET Core](https://github.com/dotnet/core)—an open-source, general purpose development platform.  The front-end of the application is built using [Blazor](https://github.com/aspnet/AspNetCore/tree/master/src/Components)—a .NET Core single page application framework which runs on WebAssembly.  The back-end of the application consists of an [ASP.NET Core](https://github.com/aspnet/AspNetCore) Server which serves the Client and exposes the SAMMI Web API and an [Entity Framework Core](https://github.com/aspnet/EntityFrameworkCore) Data Interface library.  All Models used by both the front-end and back-end components shall be built in a shared .NET Core library.

In order to contribute to the development of SAMMI, you will require the following:
### Using Visual Studio (Recommended)
- [Visual Studio 2019 Preview](https://visualstudio.microsoft.com/vs/preview/)  
  The following Workloads are required:  
  - ASP.NET and web development  
  - .NET Core cross-platform development
- [.NET Core SDK 3.0-preview5](https://dotnet.microsoft.com/download/dotnet-core/3.0)

### Using Command Line
- [.NET Core SDK 3.0-preview5](https://dotnet.microsoft.com/download/dotnet-core/3.0)


[logo]: https://i.imgur.com/rT98eOT.png "Speed ACM"
