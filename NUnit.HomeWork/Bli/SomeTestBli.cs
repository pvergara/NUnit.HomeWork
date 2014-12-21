using NUnit.Framework;

namespace NUnit.HomeWork.RunOnlyOnce.Bli
{
	[TestFixture]
	public class SomeTestFixtureBli
	{
		[Test]
		public void BliOneTest ()
		{
            Assert.That(Global.IsFirstTime, Is.False);
		}
		[Test]
        public void BliSecondTest()
		{
            Assert.That(Global.IsFirstTime, Is.False);
        }
		[Test]
        public void BliThirdTest()
		{
            Assert.That(Global.IsFirstTime, Is.False);
        }
		[Test]
        public void BliForthTest()
		{
            Assert.That(Global.IsFirstTime, Is.False);
        }
	}
}

