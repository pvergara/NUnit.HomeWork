using NUnit.Framework;

namespace NUnit.HomeWork.RunOnlyOnce.Ble
{
	[TestFixture]
	public class SomeTestFixtureBle
	{
		[Test]
		public void BleOneTest ()
		{
			Assert.That (Global.IsMoreThanFirstTime,Is.True);
		}
		[Test]
        public void BleSecondTest()
		{
			Assert.That (Global.IsMoreThanFirstTime,Is.True);
		}
		[Test]
        public void BleThirdTest()
		{
			Assert.That (Global.IsMoreThanFirstTime,Is.True);
		}
		[Test]
        public void BleForthTest()
		{
			Assert.That (Global.IsMoreThanFirstTime,Is.True);
		}
	}
}

