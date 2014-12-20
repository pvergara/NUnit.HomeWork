using System;
using NUnit.Framework;

namespace NUnit.HomeWork.Bla
{
	[TestFixture]
	public class SomeTestFixture
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

