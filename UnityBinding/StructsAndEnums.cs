﻿using System.Runtime.InteropServices;
using Foundation;
using NativeLibrary;

static class CFunctions
{
	// extern void UnityRegisterLifeCycleListener (id<LifeCycleListener> obj);
	[DllImport("__Internal")]
	static extern void UnityRegisterLifeCycleListener(IUnityFrameworkListener obj);

	// extern void UnityUnregisterLifeCycleListener (id<LifeCycleListener> obj);
	[DllImport("__Internal")]
	static extern void UnityUnregisterLifeCycleListener(IUnityFrameworkListener obj);

	// extern UnityAppController * GetAppController ();
	[DllImport("__Internal")]
	static extern UnityAppController GetAppController();

	// extern void AppController_SendNotificationWithArg (NSString *name, id arg);
	[DllImport("__Internal")]
	static extern void AppController_SendNotificationWithArg(NSString name, NSObject arg);

	// extern void AppController_SendUnityViewControllerNotification (NSString *name);
	[DllImport("__Internal")]
	static extern void AppController_SendUnityViewControllerNotification(NSString name);

	[StructLayout(LayoutKind.Sequential)]
	public struct MachHeader
	{
		public uint magic;     /* mach magic number identifier */
		public int cputype; /* cpu specifier ; cpu_type_t*/
		public int cpusubtype;   /* machine specifier ; cpu_subtype_t */
		public uint filetype;  /* type of file */
		public uint ncmds;     /* number of load commands */
		public uint sizeofcmds;    /* the size of all the load commands */
		public uint flags;     /* flags */
		public uint reserved;  /* reserved */
	}

}
