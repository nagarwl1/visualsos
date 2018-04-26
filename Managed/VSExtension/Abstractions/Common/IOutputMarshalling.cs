﻿// Copyright (C) 2018 Angel Hernandez Matos
// You can redistribute this software and/or modify it under the terms of the 
// GNU General Public License  (GPL).  This program is distributed in the hope 
// that it will be useful, but WITHOUT ANY WARRANTY; without even the implied 
// warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  
// See License.txt for more details. 

/* Visual C# compiler   : Microsoft (R) Visual C# Compiler version 2.7.0.62707 (75dfc9b3)
Creation date           : 26/04/2018
Developer               : Angel Hernandez Matos
e-m@il                  : me@angelhernandezm.com
Website                 : http://www.angelhernandezm.com
*/

using System.Runtime.InteropServices;

namespace VisualSOS.Abstractions.Common {
    [Guid("3C0AEA79-8BF3-411C-A33C-722BC833282A")]

	public interface IOutputMarshalling {
		/// <summary>
		/// Redirects the output.
		/// </summary>
		/// <param name="message">The message.</param>
		void RedirectOutput(string message);
	}
}
