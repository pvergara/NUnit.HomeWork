using System;

namespace NUnit.HomeWork.RunOnlyOnce
{
	public static class Global
	{
		private static bool _isMoreThanFirstTime = false;
		public static bool IsMoreThanFirstTime { 
			get { 
				var aux = _isMoreThanFirstTime; 
				_isMoreThanFirstTime = true; 
				return aux ;
			} 
		}
	}
}

