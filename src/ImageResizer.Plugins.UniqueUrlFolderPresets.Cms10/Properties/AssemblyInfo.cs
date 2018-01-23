using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using EPiServer.PlugIn;

[assembly: AssemblyTitle("Unique Url Folder Presets for CMS 10")]
[assembly: AssemblyDescription("Unique, cachable, URLs for media in EPiServer CMS 10 using ImageResizing.NET presets.")]
[assembly: AssemblyCompany("@defsteph")]
[assembly: AssemblyCopyright("Copyright 2018")]
[assembly: AssemblyProduct("ImageResizer.Plugins.UniqueUrlFolderPresets.Cms10")]
[assembly: ComVisible(false)]
[assembly: Guid("deae71af-3b0b-435d-92de-0756da29ea51")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: InternalsVisibleTo("ImageResizer.Plugins.UniqueUrlFolderPresets.Cms10.Tests")]
[assembly: PlugInSummary(MoreInfoUrl = "<A href='https://github.com/defsteph/UniqueUrlFolderPresets.Cms10'>GitHub Repository</A>", License = LicensingMode.Freeware)]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif