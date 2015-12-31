using NUnit.Framework;

namespace LocationSlugger.Tests
{
    [TestFixture]
    public class LocationSluggerTests
    {
        protected LocationSlugger LocationSlugger;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            LocationSlugger = new LocationSlugger();
        }

        public class SlugTests : LocationSluggerTests
        {
            [Test]
            public void returns_string_with_comma_and_space_replaced_by_double_hyphen()
            {
                var result = LocationSlugger.Slug("Camberley, Surrey");

                Assert.That(result, Is.EqualTo("Camberley--Surrey"));
            }

            [Test]
            public void returns_string_with_space_and_a_comma_and_space_replaced_by_double_hyphen()
            {
                var result = LocationSlugger.Slug("Blackfriars Road, London");

                Assert.That(result, Is.EqualTo("Blackfriars-Road--London"));
            }

            [Test]
            public void returns_string_with_hyphens_replaced_by_tilde()
            {
                var result = LocationSlugger.Slug("Stoke-on-Trent");

                Assert.That(result, Is.EqualTo("Stoke~on~Trent"));
            }

            [Test]
            public void returns_string_with_special_characters_remaining()
            {
                var result = LocationSlugger.Slug("Côte d'Ivoire");

                Assert.That(result, Is.EqualTo("Côte-d'Ivoire"));
            }
        }

        public class UnSlugTests : LocationSluggerTests
        {
            [Test]
            public void returns_string_with_double_hyphen_replace_by_comma_and_space()
            {
                var result = LocationSlugger.UnSlug("Camberley--Surrey");

                Assert.That(result, Is.EqualTo("Camberley, Surrey"));
            }

            [Test]
            public void returns_string_with_double_hyphen_replaced_by_space_and_a_comma()
            {
                var result = LocationSlugger.UnSlug("Blackfriars-Road--London");

                Assert.That(result, Is.EqualTo("Blackfriars Road, London"));
            }

            [Test]
            public void returns_string_with_tilde_replaced_by_hyphens()
            {
                var result = LocationSlugger.UnSlug("Stoke~on~Trent");

                Assert.That(result, Is.EqualTo("Stoke-on-Trent"));
            }
        }
    }
}