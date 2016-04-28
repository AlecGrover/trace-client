#include <trace/trace.h>

int main()
{
  ayxia_trace_initialize init =
  {
    .process_name = "sample_c",
    .max_network_memory_kb = 1024 * 1024,
    .allow_dropped_frames = 0,
  };

  ayxia_tc_initialize(&init);
  TRACE_INFO("channel", "this is a test %d", 3);
  ayxia_tc_shutdown();
}
