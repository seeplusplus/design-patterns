using System;

namespace abstract_factory
{
    public abstract class AbstractFactory { 
        public abstract AbstractProduct MakeProduct();
    }
    public class ConcreteFactory : AbstractFactory {
        public override AbstractProduct MakeProduct() => new ConcreteProduct();
    }
    public class CarbonFactory : AbstractFactory {
        public override AbstractProduct MakeProduct() => new CarbonProduct();
    }
}
