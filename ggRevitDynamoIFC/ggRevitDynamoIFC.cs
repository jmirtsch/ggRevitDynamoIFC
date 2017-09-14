using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using RevitServices.Persistence;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB.Structure;

using Autodesk.DesignScript.Runtime;
using Autodesk.DesignScript.Interfaces;

using GGYM;

namespace ggDynamoIFC
{
	public static class ggDynamoIFC
	{
		[MultiReturn(new[] { "Result", "Log" })]
		public static Dictionary<string,object> ConvertFile(string IfcFileName, string RevitFileName, string TemplateFileName = "")
		{
			string log = "";
			UIApplication uiapp = DocumentManager.Instance.CurrentUIApplication;
			bool result = ggRevitIFC.ConvertFile(uiapp, IfcFileName, RevitFileName, TemplateFileName, out log);
			return new Dictionary<string, object>
			{
				{ "Result", result },
				{ "Log", log }
			};
		}
	}
}
