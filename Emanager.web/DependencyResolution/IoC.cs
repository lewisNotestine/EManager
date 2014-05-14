using StructureMap;
using EManager.Domain;
using EManager.web.Infrastructure;

namespace EManager.web {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            //This injects a DepartmentDb where an IDepartmentDatasource is needed.
                            x.For<IDepartmentDatasource>().Use<DepartmentDb>();
                        });
            return ObjectFactory.Container;
        }
    }
}