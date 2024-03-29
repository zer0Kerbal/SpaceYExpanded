﻿#region CC-BY-NC-SA-4.0+
/* SpaceY Expanded ModularManagement Support
	This file is part of SpaceY.Expanded, and is
		©2023 LisiasT : http://lisias.net <support@lisias.net>

	SpaceY.Expanded is
		© 2022-2023 zer0Kerbal
		© 2014-2022 Necrobones

	and licensed as follows:
		* CC-BY-NC-SA-4.0 : https://creativecommons.org/licenses/by-nc-sa/4.0/

	SpaceY.Expanded is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
*/
#endregion

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("SpaceY Expanded Module Manager Support")]
[assembly: AssemblyDescription("SpaceY Expanded")]
[assembly: AssemblyCompany("SpaceY")]
[assembly: AssemblyProduct("SpaceY Expanded")]
[assembly: AssemblyCopyright("© 2022-2023 zer0Kerbal, © 2014-2022 Necrobones")]
[assembly: AssemblyTrademark("™ 2022-2023 zer0Kerbal, ™ 2014-2022 Necrobones")]
[assembly: AssemblyCulture("")]

#if DEBUG 
  [assembly: AssemblyConfiguration("Debug")]
#else
   [assembly: AssemblyConfiguration("Release")]
#endif