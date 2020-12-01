using Definux.Emeraude.Application.Mapping;
using System.Reflection;

namespace Emeraude.Template.Application.Mapping
{
    public class MainAssemblyMappingProfile : AssemblyMappingProfile
    {
        public MainAssemblyMappingProfile()
            : base(Assembly.GetExecutingAssembly())
        {

        }
    }
}
