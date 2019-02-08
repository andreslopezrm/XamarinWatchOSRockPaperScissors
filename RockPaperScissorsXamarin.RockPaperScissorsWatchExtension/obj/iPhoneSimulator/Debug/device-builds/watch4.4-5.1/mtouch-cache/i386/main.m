#include "xamarin/xamarin.h"


void xamarin_register_modules_impl ()
{

}

void xamarin_register_assemblies_impl ()
{
	guint32 exception_gchandle = 0;

}

extern "C" void xamarin_create_classes_Xamarin_WatchOS();
void xamarin_setup_impl ()
{
	xamarin_create_classes_Xamarin_WatchOS();
	xamarin_gc_pump = FALSE;
	xamarin_init_mono_debug = TRUE;
	xamarin_executable_name = "RockPaperScissorsXamarinRockPaperScissorsWatchExtension.dll";
	mono_use_llvm = FALSE;
	xamarin_log_level = 0;
	xamarin_arch_name = "i386";
	xamarin_marshal_objectivec_exception_mode = MarshalObjectiveCExceptionModeThrowManagedException;
	xamarin_debug_mode = TRUE;
	setenv ("MONO_GC_PARAMS", "nursery-size=512k,soft-heap-limit=8m,major=marksweep", 1);
	xamarin_supports_dynamic_registration = TRUE;
}

int xamarin_watchextension_main (int argc, char **argv)
{
	NSAutoreleasePool *pool = [[NSAutoreleasePool alloc] init];
	argv [0] = (char *) "RockPaperScissorsXamarinRockPaperScissorsWatchExtension";
	int rv = xamarin_main (argc, argv, XamarinLaunchModeExtension);
	[pool drain];
	return rv;
}
void xamarin_initialize_callbacks () __attribute__ ((constructor));
void xamarin_initialize_callbacks ()
{
	xamarin_setup = xamarin_setup_impl;
	xamarin_register_assemblies = xamarin_register_assemblies_impl;
	xamarin_register_modules = xamarin_register_modules_impl;
}
