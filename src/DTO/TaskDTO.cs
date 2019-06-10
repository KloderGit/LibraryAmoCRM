using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.DTO
{
    public class TaskDTO : IntentDTO
    {
        public int responsible_user_id { get; set; }
        public int created_by { get; set; }
        public uint created_at { get; set; }
        public uint updated_at { get; set; }
        public int account_id { get; set; }
        public int group_id { get; set; }
        public int element_id { get; set; }
        public int element_type { get; set; }
        public bool is_completed { get; set; }
        public uint complete_till_at { get; set; }
        public int duration { get; set; }
        public IntentDTO Result { get; set; }
        public int task_type { get; set; }
    }
}
