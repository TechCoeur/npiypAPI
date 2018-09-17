using System;

namespace npiypAPI.Models
{
    public class RawData
    {
        public string TestId{ get; set; }
        public string GrpType{ get; set; }
        public string DeviceType{ get; set; }
        public string SerialNumber{ get; set; }
        public string BRNumber{ get; set; }
        public string OperationInfo{ get; set; }
        public string PF{ get; set; }
        public string StatusInfo{ get; set; }
        public string ErrorCode{ get; set; }
        public string TestStatusCode{ get; set; }
        public string DocRevNo{ get; set; }
        public string TestScript{ get; set; }
        public string Item{ get; set; }
        public string FinishedGoodPN{ get; set; }
        public string TOSASerial{ get; set; }
        public string ROSASerial{ get; set; }
        public string Station{ get; set; }
        public string HydraVersion{ get; set; }
        public string StartTime{ get; set; }
        public string EndTime{ get; set; }
        public string CSTStart{ get; set; }
        public string CSTEnd{ get; set; }
        public string Created{ get; set; }
        public string NTHTest { get; set; }
        public string TotalTestTime { get; set; }
        public string PLCTime{ get; set; }
        public string OWTime{ get; set; }
        public string PureTestTime{ get; set; }
        public string isRework{ get; set; }
        public string ComponentReplaced{ get; set; }
        public string AgileRevision{ get; set; }
        public string TestType{ get; set; }
    }
}