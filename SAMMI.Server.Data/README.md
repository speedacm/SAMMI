# Data Interface
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

The Data Interface project uses Entity Framework Core to connect to the SAMMI database.  All interactions with the database *must* be performed by this library.  All classes which interact with the database directly via EF Core *must* have an accessibility level of `internal`.  As a rule of thumb, if you are using the `SammiContext`, the class in which you are working must be `internal`.  Data returned from public methods should consist only of external types, either from the System libraries or the [Models](..\SAMMI.Shared) project.
