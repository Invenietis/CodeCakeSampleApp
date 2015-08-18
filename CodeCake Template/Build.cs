using Cake.Common;
using Cake.Core;
using Cake.Common.Diagnostics;
using Code.Cake;

namespace $safeprojectname$
{
    public class Build : CodeCakeHost
    {
        public Build()
        {
            var configuration = Cake.Argument( "configuration", "Release" );

            Task( "Build" )
                .Does( () =>
                {
                    Cake.Information( "Building with '{0}' configuration.", configuration );
                } );

            Task( "Default" ).IsDependentOn( "Build" );
        }
    }
}
