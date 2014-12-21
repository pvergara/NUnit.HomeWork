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

        private static bool _isFirstTime = true;
        public static bool IsFirstTime
        {
            get
            {
                var aux = _isFirstTime;
                _isFirstTime = false;
                return aux;
            }
        }
	}
}

