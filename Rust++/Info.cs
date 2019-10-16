using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeatherLoader.ModList;

namespace RustPP
{
	public class Info : IModInfo
	{
		public Info()
		{
			
		}
		
		public string GetModName()
		{
            return "Anti_Hacker";
		}
		
		public string GetModVersion()
		{
			return "1.0.0";
		}
		
		public string GetPrettyModName()
		{
            return "Anti_Hacker";
		}
		
		public string GetPrettyModVersion()
		{
			return "v1.0";
		}
		
		public bool CanAcceptModlessClients()
		{
			return true;
		}
		
		public bool CanConnectToModlessServers()
		{
			return true;
		}
		
		public string GetCreditString()
		{
			return "By HOHO www.hoho.im";
		}
	}
}
