using System;
using Xunit;
using abstract_factory;

namespace abstract_factory_test
{
    public class FactoryTest
    {
        [Fact]
        public void carbonFactoryTest()
        {
            var carbonFactory = new CarbonFactory();
            Assert.Equal(typeof(CarbonProduct), carbonFactory.MakeProduct().GetType());
        }
        [Fact]
        public void ConcreteFactoryTest()
        {
            var concreteFactory = new ConcreteFactory();
            Assert.Equal(typeof(ConcreteProduct), concreteFactory.MakeProduct().GetType());
        }
        
    }
}
