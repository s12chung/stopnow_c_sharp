//http://www.codeproject.com/csharp/GetIdleTimeWithCS.asp

using System;
using System.Runtime.InteropServices;

namespace Win32_API
{
	internal struct LASTINPUTINFO 
	{
		public uint cbSize;

		public uint dwTime;
	}

	public class Win32
	{
		[DllImport("User32.dll")]
		public static extern bool LockWorkStation();

		[DllImport("User32.dll")]
		private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);		

		[DllImport("Kernel32.dll")]
		private static extern uint GetLastError();
	
		public static uint GetIdleTime()
		{
			LASTINPUTINFO lastInPut = new LASTINPUTINFO();
			lastInPut.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(lastInPut);
			GetLastInputInfo(ref lastInPut);

			return ((uint)Environment.TickCount - lastInPut.dwTime)/(1000);
		}
	}
}
