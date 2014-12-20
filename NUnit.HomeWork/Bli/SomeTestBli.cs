using System;
using NUnit.Framework;

namespace NUnit.HomeWork.RunOnlyOnce.Bli
{
	[TestFixture]
	public class SomeTestFixtureBli
	{
		[Test]
		public void OneTest ()
		{
			Assert.That (Global.IsMoreThanFirstTime,Is.True);
		}
		[Test]
		public void SecondTest ()
		{
			Assert.That (Global.IsMoreThanFirstTime,Is.True);
		}
		[Test]
		public void ThirdTest ()
		{
			Assert.That (Global.IsMoreThanFirstTime,Is.True);
		}
		[Test]
		public void ForthTest ()
		{
			Assert.That (Global.IsMoreThanFirstTime,Is.True);
		}
	}
}

