using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapDrive.Models
{
    class DeviceModel
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool Initialized { get; set; }
        public string? Status { get; set; }
        public bool? IsSyncing { get; set; }
        public int? SyncProgress { get; set; }
        public DateTime? InitializedDate { get; set; }
        public DateTime? LastSyncDate { get; set; }
        public String[]? BackupItems { get; set; }
    }
}
