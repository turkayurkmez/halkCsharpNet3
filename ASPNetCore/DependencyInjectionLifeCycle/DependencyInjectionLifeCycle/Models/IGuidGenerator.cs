namespace DependencyInjectionLifeCycle.Models
{
    public interface IGuidGenerator
    {
        public Guid Guid { get; set; }
    }

    public interface ISingletonGuidGenerator : IGuidGenerator { }
    public interface IScopedGuidGenerator : IGuidGenerator { }
    public interface ITransientGuidGenerator : IGuidGenerator { }

    public class SingletonGuidGenerator : ISingletonGuidGenerator
    {
        public SingletonGuidGenerator()
        {
            Guid = Guid.NewGuid();
        }
        public Guid Guid { get; set; }
    }

    public class ScopedGuidGenerator : IScopedGuidGenerator
    {
        public Guid Guid { get; set; }
        public ScopedGuidGenerator()
        {
            Guid = Guid.NewGuid();
        }
    }

    public class TransientGuidGenerator : ITransientGuidGenerator
    {
        public Guid Guid { get; set; }

        public TransientGuidGenerator()
        {
            Guid = Guid.NewGuid();
        }
    }

    public class GuidService
    {
        public ISingletonGuidGenerator SingletonGuid { get; set; }
        public IScopedGuidGenerator ScopedGuidGenerator { get; set; }
        public ITransientGuidGenerator TransientGuidGenerator { get; set; }

        public GuidService(ISingletonGuidGenerator singletonGuid, IScopedGuidGenerator scopedGuidGenerator, ITransientGuidGenerator transientGuidGenerator)
        {
            SingletonGuid = singletonGuid;
            ScopedGuidGenerator = scopedGuidGenerator;
            TransientGuidGenerator = transientGuidGenerator;
        }


    }

}
