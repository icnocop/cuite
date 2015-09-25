param($installPath, $toolsPath, $package, $project)

# Find the app.config file
$config = $project.ProjectItems | where {$_.Name -eq "app.config"}

# Find its path on the file system
$localPath = $config.Properties | where {$_.Name -eq "LocalPath"}

# Load 'app.config' as XML
$xml = New-Object xml
$xml.Load($localPath.Value)

# Configure namespaces
$ns = New-Object System.Xml.XmlNamespaceManager($xml.NameTable)
$ns.AddNamespace("asmv1", "urn:schemas-microsoft-com:asm.v1")

# Select the binding redirects
$bindingRedirects = $xml.SelectNodes("configuration/runtime/asmv1:assemblyBinding/asmv1:dependentAssembly/asmv1:bindingRedirect[@newVersion='[Placeholder]']", $ns)

# change the 'newVersion' values to match the current running instance of Visual Studio
foreach ($bindingRedirect in $bindingRedirects)
{
	$bindingRedirect.SetAttribute("newVersion", "${env:VisualStudioVersion}.0.0")
}

# Save changes to 'app.config'
$xml.Save($localPath.Value)