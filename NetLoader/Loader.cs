using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGiesecke.DllExport;
using System.Runtime.InteropServices;

namespace NetLoader {
	static class Native {
		[DllImport("NetScript.exe", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void PrintString(string Str);

	}

	static class Loader {
		[DllExport(ExportName = "Load", CallingConvention = CallingConvention.Cdecl)]
		public static void Load() {
			Native.PrintString("Loaded .NET scripts!");
		}

		[DllExport(ExportName = "Unload", CallingConvention = CallingConvention.Cdecl)]
		public static void Unload() {
			Native.PrintString("Unloaded .NET scripts!");
		}
	}
}