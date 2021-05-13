using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AutoControlBuild
{
	public class HDevHelper
	{
		public List<ParamItem> LoadParamsFromHdevFile(string fileName)
		{
			List<ParamItem> returnParamItems = new List<ParamItem>();
			// Demo file
			fileName = @"E:\AutoProcedure01.hdvp";
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(fileName);

			// Load interface
			Dictionary<string, string> interfaceItems = new Dictionary<string, string>();
			XmlNodeList InterfaceItemsNoteList = xmlDoc.DocumentElement.SelectNodes("/hdevelop/procedure/interface/io/par");
			foreach (XmlNode item in InterfaceItemsNoteList)
			{
				interfaceItems.Add(item.Attributes["name"].Value, "IconicIn");
			}
			InterfaceItemsNoteList = xmlDoc.DocumentElement.SelectNodes("/hdevelop/procedure/interface/oo/par");
			foreach (XmlNode item in InterfaceItemsNoteList)
			{
				interfaceItems.Add(item.Attributes["name"].Value, "IconicOut");
			}
			InterfaceItemsNoteList = xmlDoc.DocumentElement.SelectNodes("/hdevelop/procedure/interface/ic/par");
			foreach (XmlNode item in InterfaceItemsNoteList)
			{
				interfaceItems.Add(item.Attributes["name"].Value, "CtrlIn");
			}
			InterfaceItemsNoteList = xmlDoc.DocumentElement.SelectNodes("/hdevelop/procedure/interface/oc/par");
			foreach (XmlNode item in InterfaceItemsNoteList)
			{
				interfaceItems.Add(item.Attributes["name"].Value, "CtrlOut");
			}

			XmlNodeList ProcedureNoteList = xmlDoc.DocumentElement.SelectNodes("/hdevelop/procedure/docu/parameters/parameter");
			foreach (XmlNode item in ProcedureNoteList)
			{
				string paramName = "";
				string paramType = "";
				try
				{
					paramName = item.Attributes["id"].Value;
					paramType = item.SelectSingleNode("sem_type").InnerText;
				}
				catch { }
				ParamItem tempItem = new ParamItem(paramName, paramType, interfaceItems[paramName]);
				returnParamItems.Add(tempItem);
			}
			return returnParamItems;
		}
	}
}
