using System;
using NUnit.Framework;

namespace NUnit.HomeWork.RunOnlyOnce.Ble
{
	[TestFixture]
	public class SomeTestFixtureBle
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

