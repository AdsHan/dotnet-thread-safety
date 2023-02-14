using ThreadSafety.UnitTests.Types;

namespace ThreadSafety.UnitTests
{
    public class ThreadSafetyTest
    {

        [Fact(DisplayName = "Test - No Thread-Safety")]
        [Trait("Layer", "Thread-Safety")]
        public void NoThreadSafetyTest()
        {
            Parallel.For(0, 10, x =>
            {
                NoThreadSafetyType.Populate();
            });

            Assert.Equal(10000, NoThreadSafetyType.Count());
        }

        [Fact(DisplayName = "Test - Lock Thread-Safety")]
        [Trait("Layer", "Thread-Safety")]
        public void LockThreadSafetyTest()
        {
            Parallel.For(0, 10, x =>
            {
                LockThreadSafetyType.Populate();
            });

            Assert.Equal(10000, LockThreadSafetyType.Count());
        }

        [Fact(DisplayName = "Test - Lazy Thread-Safety")]
        [Trait("Layer", "Thread-Safety")]
        public void LazyThreadSafetyTest()
        {
            Parallel.For(0, 10, x =>
            {
                LazyThreadSafetyType.Populate();
            });

            Assert.Equal(10000, LazyThreadSafetyType.Count());
        }
    }
}