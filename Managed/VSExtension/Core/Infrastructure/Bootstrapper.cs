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

using Autofac;
using System;

namespace VisualSOS.Core.Infrastructure {
    /// <summary>
    /// 
    /// </summary>
    public class Bootstrapper {
		/// <summary>
		/// Runs the specified container setter.
		/// </summary>
		/// <param name="containerSetter">The container setter.</param>
		public static void Run(Action<IContainer> containerSetter) {
			var builder = new ContainerBuilder();
			builder.RegisterModule<TypeRegistration>();
			var container = builder.Build();
			containerSetter(container);
		}
	}
}  