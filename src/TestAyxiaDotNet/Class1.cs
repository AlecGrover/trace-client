﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ayxia.Trace;

namespace TestAyxiaDotNet
{
  public class Class1
  {
		void Run()
		{
			foreach (var i in Enumerable.Range(0, 100))
			{
				Trace.Debug(this, "format {0:X}", i);
			}
		}
		public static void Main(string[] args)
    {
      var init = new ayxia_trace_initialize();
      init.RemoteHost = "localhost";
      init.ProcessName = "TestAyxiaDotNet";
      Trace.ayxia_tc_initialize(ref init);
			new Class1().Run();
			Trace.ayxia_tc_shutdown();
    }
  }
}
