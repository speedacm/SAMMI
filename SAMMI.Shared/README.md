# Models
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

The Models project is a library of models common to multiple components of SAMMI.  The Models project *may* contain `internal` and `static` classes, whose purpose is relevant to any `public` instantiable model within the project.  Any objects which are not referenced by more than one other project *should* be included in the relevant project and not in the shared library.
