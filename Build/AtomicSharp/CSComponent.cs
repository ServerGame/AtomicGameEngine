﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AtomicEngine
{
	public delegate void AtomicEventDelegate (VariantMap eventData);
	
	public class CSComponent : Component
	{
		public uint ManagedID;

		public CSComponent ()
		{	
			nativeInstance = NativeCore.RegisterNative (csb_Atomic_CSComponent_Constructor(), this);	
			ComponentCore.RegisterCSComponent (this);
		}

		virtual public void Start()
		{

		}

		virtual public void Update(float timeStep)
		{
			
		}
			
		public void SendEvent(string eventType, Dictionary<string, object> eventData = null)
		{

		}

		public void SubscribeToEvent(AObject sender, string eventType, AtomicEventDelegate function)
		{
			EventCore.SubscribeToEvent (this, sender, eventType, function);
		}

		public void SubscribeToEvent(string eventType, AtomicEventDelegate function)
		{
			EventCore.SubscribeToEvent (this, null, eventType, function);
		}

		void handleEvent(string eventType, Dictionary<uint, object> eventData)
		{

		}
			
		[DllImport (Constants.LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern IntPtr csb_Atomic_CSComponent_Constructor();

	}
}

